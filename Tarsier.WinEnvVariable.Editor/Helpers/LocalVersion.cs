using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Tarsier.WinEnvVariable.Editor.Helpers {
   public class LocalVersion {
        public static string GetVersion(string path) {
            string lv = string.Empty;

            if(string.IsNullOrEmpty(path)
                || Path.GetInvalidPathChars().Intersect(path.ToCharArray()).Count() != 0
                || !new FileInfo(path).Exists) {
                lv = null;
            } else if(new FileInfo(path).Exists) {
                string s = File.ReadAllText(path);
                lv = ValidateFile(s) ? s : string.Empty;
            }
            return lv;
        }

        public static bool ValidateFile(string contents) {
            bool val = false;
            if(!string.IsNullOrEmpty(contents)) {
                string pattern = "^([0-9]*\\.){3}[0-9]*$";
                System.Text.RegularExpressions.Regex re = new System.Text.RegularExpressions.Regex(pattern);
                val = re.IsMatch(contents);
            }
            return val;
        }
        public static string CreateLocalVersionFile(string folderPath, string version) {
            if(!new DirectoryInfo(folderPath).Exists) {
                Directory.CreateDirectory(folderPath);
            }
            string versionFile = Path.Combine(folderPath, "latestVersion.txt");
            if(File.Exists(versionFile)) {
                File.Delete(versionFile);
            }

            if(!File.Exists(versionFile)) {
                File.WriteAllText(versionFile, version);
            }
            return versionFile;
        }

    }
}
