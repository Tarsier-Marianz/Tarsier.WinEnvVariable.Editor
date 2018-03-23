using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Tarsier.Extensions;

namespace Tarsier.WinEnvVariable.Editor.Helpers {
   public class Elements {
        public static void ClearProfileDetails(Control parent) {
            foreach(Control ctrl in parent.Controls) {
                if(ctrl is Label) {
                    Label lbl = ((Label)ctrl);
                    if(lbl.Tag.ToSafeString().Equals("CLEAR")) {
                        lbl.Text = string.Empty;
                        lbl.Image = null;
                    }
                }
            }
        }

        public static string TrimRemotePath(string url) {
            if(!string.IsNullOrEmpty(url)) {
                List<string> trimUrl = new List<string>();
                string[] chunks = url.Split(new char[] { '/','\\'});
                for(int i=0; i< chunks.Length; i++) {
                    string chunkUrl = chunks[i].RemoveNonAlphaNumeric();
                    if(!string.IsNullOrEmpty(chunkUrl)) {
                        trimUrl.Add(chunkUrl);
                    }
                }
                if(trimUrl.Count > 0) {
                    return "/" + string.Join("/", trimUrl.ToArray());
                }
            }
            return string.Empty;
        }
    }
}
