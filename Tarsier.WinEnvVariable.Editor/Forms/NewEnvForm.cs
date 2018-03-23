using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Tarsier.WinEnvVariable.Editor.Constants;
using Tarsier.WinEnvVariable.Editor.Enums;

namespace Tarsier.WinEnvVariable.Editor.Forms {
    public partial class NewEnvForm : Form {
        public string EnvName {
            get { return txtName.Text.Trim(); }
        }
        public string EnvValue {
            get { return txtValue.Text.Trim(); }
        }
        public NewEnvForm() {
            InitializeComponent();
        }

        private void txtName_KeyDown(object sender, KeyEventArgs e) {
            if(e.KeyCode.Equals(Keys.Enter)) {
                btnAdd.PerformClick();
            }
        }

        private void tmrCheck_Tick(object sender, EventArgs e) {
            btnAdd.Enabled = (txtName.Text.Trim().Length > 0 && txtValue.Text.Trim().Length > 0);
        }

        private void Buttons_Click(object sender, EventArgs e) {
            Button btn = sender as Button;
            if(btn != null) {
                if(btn.Tag != null) {
                    if(btn.Tag.ToString().Equals("FILE")) {
                        using(OpenFileDialog opd = new OpenFileDialog()) {
                            opd.Filter = Dialogs.GetFilters(Filters.ALL);
                            if(opd.ShowDialog().Equals(DialogResult.OK)) {
                                txtValue.Text = opd.FileName;
                            }
                        }
                    } else {
                        using(FolderBrowserDialog fbd = new FolderBrowserDialog()) {
                            fbd.Description = Titles.FOLDER_ENV;
                            if(fbd.ShowDialog().Equals(DialogResult.OK)) {
                                txtValue.Text = fbd.SelectedPath;
                            }
                        }
                    }
                }
            }
        }
        
    }
}
