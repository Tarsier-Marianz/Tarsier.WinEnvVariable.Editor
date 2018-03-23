
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using Tarsier.Association;
using Tarsier.Config;
using Tarsier.Extensions;
using Tarsier.Regedit;
using Tarsier.Security;
using Tarsier.UI;

namespace Tarsier.WinEnvVariable.Editor.Forms {
    public partial class AboutForm : Form {
        private AppInfo _info = new AppInfo();
        public AboutForm() {
            InitializeComponent();
            lblTitle.Text = _info.AssemblyTitle;
            lblVersion.Text = string.Format("Version {0} (Release Build {1})", _info.AssemblyFileVersion, _info.AssemblyVersion);
            lblCopyright.Text = _info.AssemblyCopyright;
            lblDescription.Text = _info.AssemblyDescription;
            DisplayLibraries();

        }
        void DisplayLibraries() {
            // list of libraries used
            var asms = new List<Assembly>();
            asms.Add(typeof(JsonConvert).Assembly);
            asms.Add(typeof(SQLiteConnection).Assembly);

            foreach(var asm in asms) {
                var item = new ListViewItem(asm.GetName().Name);
                item.ForeColor = Color.FromArgb(11, 128, 246);
                item.SubItems.Add(asm.GetName().Version.ToString());
                LibsListView.Items.Add(item);
            }
            var projectsAsm = new List<Assembly>();
            projectsAsm.Add(typeof(SQLiteHelper).Assembly);
            projectsAsm.Add(typeof(MessageListBox).Assembly);
            projectsAsm.Add(typeof(StringUtils).Assembly);
            projectsAsm.Add(typeof(FileAssociation).Assembly);
            projectsAsm.Add(typeof(SimpleEncryption).Assembly);
            projectsAsm.Add(typeof(Objects).Assembly);
            foreach(var asm in projectsAsm) {
                var item = new ListViewItem(asm.GetName().Name);
                item.ForeColor = Color.Gray;
                item.SubItems.Add(asm.GetName().Version.ToString());
                LibsListView.Items.Add(item);
            }
        }

        private void Link_Click(object sender, EventArgs e) {
            PictureBox p = sender as PictureBox;
            if(p != null) {
                Process.Start(p.Tag.ToSafeString());
            }
        }
        
    }
}
