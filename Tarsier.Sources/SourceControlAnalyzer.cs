using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Tarsier.Sources.Enumeration;

namespace Tarsier.Sources {
    public class SourceControlAnalyzer {
        public SourceControlAnalyzer() { }
        
        public FileEntry ValidateSource(FileInfo info) {
            FileType type = FileType.Unknown;
            string normalizedFilename = info.Name.ToLower();
            if(normalizedFilename.Contains(".") &&
                normalizedFilename.EndsWith("proj")) {
                if(normalizedFilename.EndsWith(".csproj")) {
                    type = FileType.CsProj;
                } else if(normalizedFilename.EndsWith(".vdproj")) {
                    type = FileType.VbProj;
                } else {
                    type = FileType.Unknown;
                }
            } else if(normalizedFilename.EndsWith(".sln")) {
                type = FileType.Solution;
            } else if(normalizedFilename.EndsWith(".vssscc") ||
                normalizedFilename.EndsWith(".vspscc")) {
                type = FileType.VsSource;
            } else {
                type = FileType.Unknown;
            }
            if(type != FileType.Unknown) {
                return new FileEntry() {
                    Name = info.Name,
                    Info = info,
                    Type = type
                };
               
            }
            return null;
        }
    }
}