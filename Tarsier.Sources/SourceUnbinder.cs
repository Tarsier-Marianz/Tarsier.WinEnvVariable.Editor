using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Tarsier.Sources.Events;

namespace Tarsier.Sources {
    public class SourceUnbinder {

        private SourceSummary _sourceSumm = new SourceSummary();
        public SourceSummary SourceSummary {
            get { return _sourceSumm; }
            
        }

        public event EventHandler<UnbindProgressEvents> UnbindProgress;
        /// <summary>
        /// Processes a list of files based on the porcessing method.
        /// </summary>
        /// <param name="processMethod">The method for processing the files.</param>
        /// <param name="files">The list of files.</param>
        private bool ProcessFile(Action<string> processMethod, IEnumerable<string> files) {
            foreach(var file in files) {
                try {
                    processMethod(file);
                } catch(Exception e) {
                    string message = String.Format("Unable to process {0}: {1}", file, e.Message);
                    return false;
                }
            }
            return true;
        }


        public bool UnbindEntry(FileEntry entry) {
            if(entry == null) {
                throw new ArgumentException("Internal Error: UnbindEntry called with a file that is not a project");
            }
            bool success = false;
            if(entry.Type == Enumeration.FileType.Solution) {
                _sourceSumm.Solution++;
                success = ModifySolutionFile(entry);
            } else if(entry.Type == Enumeration.FileType.CsProj || entry.Type == Enumeration.FileType.VbProj) {
              
                success = ModifyProjectFile(entry);
                if(entry.Type == Enumeration.FileType.CsProj) {
                    _sourceSumm.CsProj++;
                } else {
                    _sourceSumm.VbProj++;
                }
            } else if(entry.Type == Enumeration.FileType.VsSource) {
                _sourceSumm.VsSource++;
                success = DeleteSourceFile(entry);
            } else {
                _sourceSumm.Unknown++;
                success = false;
            }
            return success;
        }
        public bool ModifySolutionFile(FileEntry entry) {
            bool success = true;
            try {
                if(entry == null) {
                    throw new ArgumentException("Internal Error: ModifyProjectFile called with a file that is not a solution");
                }
                string filename = entry.Info.FullName;

                // Remove the read-only flag
                var original_attr = File.GetAttributes(filename);
                File.SetAttributes(filename, FileAttributes.Normal);

                var output_lines = new List<string>();

                bool in_sourcecontrol_section = false;

                Encoding encoding;
                var lines = ReadAllLines(filename, out encoding);

                foreach(string line in lines) {
                    var line_trimmed = line.Trim();

                    // lines can contain separators which interferes with the regex
                    // escape them to prevent regex from having problems
                    line_trimmed = Uri.EscapeDataString(line_trimmed);


                    if(line_trimmed.StartsWith("GlobalSection(SourceCodeControl)")
                        || line_trimmed.StartsWith("GlobalSection(TeamFoundationVersionControl)")
                        || System.Text.RegularExpressions.Regex.IsMatch(line_trimmed, @"GlobalSection\(.*Version.*Control", System.Text.RegularExpressions.RegexOptions.IgnoreCase)) {
                        // this means we are starting a Source Control Section
                        // do not copy the line to output
                        in_sourcecontrol_section = true;
                    } else if(in_sourcecontrol_section && line_trimmed.StartsWith("EndGlobalSection")) {
                        // This means we were Source Control section and now see the ending marker
                        // do not copy the line containing the ending marker 
                        in_sourcecontrol_section = false;
                    } else if(line_trimmed.StartsWith("Scc")) {
                        // These lines should be ignored completely no matter where they are seen
                    } else {
                        // No handle every other line
                        // Basically as long as we are not in a source control section
                        // then that line can be copied to output
                        if(!in_sourcecontrol_section) {
                            output_lines.Add(line);
                        }
                    }
                }

                // Write the file back out
                File.WriteAllLines(filename, output_lines, encoding);
                // Restore the original file attributes
                File.SetAttributes(filename, original_attr);
            } catch {
                success = false;
            }
            if(UnbindProgress != null) {
                UnbindProgressEvents fec = new UnbindProgressEvents(success, entry);
                UnbindProgress(this, fec);
            }
            return success;
        }

        public bool ModifyProjectFile(FileEntry entry) {
            bool success = true;
            try {
                if(entry == null) {
                    throw new ArgumentException("Internal Error: ModifyProjectFile called with a file that is not a project");
                }
                string filename = entry.Info.FullName;
                // Load the Project file
                XDocument doc = null;
                Encoding encoding = new UTF8Encoding(false);
                using(StreamReader reader = new StreamReader(filename, encoding)) {
                    doc = XDocument.Load(reader);
                    encoding = reader.CurrentEncoding;
                }

                // Modify the Source Control Elements
                RemoveSCCElementsAttributes(doc.Root);

                // Remove the read-only flag
                var original_attr = File.GetAttributes(filename);
                File.SetAttributes(filename, FileAttributes.Normal);

                //if the original document doesn't include the encoding attribute 
                //in the declaration then do not write it to the outpu file.
                if(doc.Declaration == null || String.IsNullOrEmpty(doc.Declaration.Encoding))
                    encoding = null;

                //else if its not utf (i.e. utf-8, utf-16, utf32) format which use a BOM
                //then use the encoding identified in the XML file.
                else if(!doc.Declaration.Encoding.StartsWith("utf", StringComparison.OrdinalIgnoreCase))
                    encoding = Encoding.GetEncoding(doc.Declaration.Encoding);

                // Write out the XML
                using(var writer = new System.Xml.XmlTextWriter(filename, encoding)) {
                    writer.Formatting = System.Xml.Formatting.Indented;
                    doc.Save(writer);
                    writer.Close();
                }

                // Restore the original file attributes
                File.SetAttributes(filename, original_attr);
            } catch {
                success = false;
            }
            if(UnbindProgress != null) {
                UnbindProgressEvents fec = new UnbindProgressEvents(success, entry);
                UnbindProgress(this, fec);
            }
            return success;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="el"></param>
        private void RemoveSCCElementsAttributes(XElement el) {
            el.Elements().Where(x => x.Name.LocalName.StartsWith("Scc")).Remove();
            el.Attributes().Where(x => x.Name.LocalName.StartsWith("Scc")).Remove();

            foreach(var child in el.Elements()) {
                RemoveSCCElementsAttributes(child);
            }
        }

        /// <summary>
        /// Delete source control file
        /// </summary>
        /// <param name="entry"></param>
        public bool DeleteSourceFile(FileEntry entry) {
            bool success = true;
            try {
                if(entry == null) {
                    throw new ArgumentException("Internal Error: DeleteSourceFile called with a file that is not a source control");
                }
                string filename = entry.Info.FullName;
                File.SetAttributes(filename, FileAttributes.Normal);
                File.Delete(filename);
            } catch {
                success = false;
            }
            if(UnbindProgress != null) {
                UnbindProgressEvents fec = new UnbindProgressEvents(success, entry);
                UnbindProgress(this, fec);
            }
            return success;
        }

        /// <summary>
        /// Reads all the lines from a test file into an array.
        /// </summary>
        /// <param name="path">The file to open for reading.</param>
        /// <param name="encoding">The file encoding.</param>
        /// <returns>A string array containing all the lines from the file</returns>
        /// <remarks>UTF-8 encoded files optionally include a byte order mark (BOM) at the beginning of the file.
        /// If the mark is detected by the StreamReader class, it will modify it's encoding property so that it
        /// reflects that file was written with a BOM. However, if no BOM is detected the StreamReader will not
        /// modify it encoding property. The determined UTF-8 encoding (UTF-8 with BOM or UTF-8 without BOM) is
        /// returned as an output parameter.
        /// </remarks>
        private string[] ReadAllLines(string path, out Encoding encoding) {
            List<string> lines = new List<string>();

            Encoding encodingNoBom = new UTF8Encoding(false);
            using(StreamReader reader = new StreamReader(path, encodingNoBom)) {
                while(!reader.EndOfStream) {
                    lines.Add(reader.ReadLine());
                }
                encoding = reader.CurrentEncoding;
            }
            return lines.ToArray();
        }
    }
}