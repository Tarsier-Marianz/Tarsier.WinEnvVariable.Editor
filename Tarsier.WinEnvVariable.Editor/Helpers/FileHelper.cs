using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Tarsier.Association;
using Tarsier.Regedit;

namespace Tarsier.WinEnvVariable.Editor.Helpers {
   public class FileHelper {
        public static void CheckAssociation() {
            string ext = "auudb";
            string logExt = RegConfig.Get<string>(ext);
            if(string.IsNullOrEmpty(logExt)) {
                string logIcon = Path.Combine(Application.StartupPath, "Uploader.Database.ico");
                RegConfig.Set<string>(ext, logIcon);
                FileAssociation fa = new FileAssociation();
                fa.Extension = ext;
                fa.ContentType = "";
                fa.Description = "App Updates Database ";
                fa.ProgramId = Application.ProductName + "." + ext;
                fa.IconPath = logIcon;

                fa.AddCommand("open", Application.ExecutablePath + " %1");
                fa.Create();
            }
        }
    }
}
