using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Tarsier.WinEnvVariable.Editor.Forms {
    public partial class NewArchive : Form {
        public NewArchive() {
            InitializeComponent();
        }

        private void tmr_Tick(object sender, EventArgs e) {
            btnAdd.Enabled = txtName.Text.Trim().Length > 0 && txtValue.Text.Trim().Length > 5;
        }

        private void chkAppend_CheckedChanged(object sender, EventArgs e) {
            string name = txtName.Text.Trim();
            if(!string.IsNullOrEmpty(name)) {
                if(chkAppend.Checked) {
                    txtName.Text = string.Format("{0}_{1}", name, DateTime.Now.ToString("yyyy-MM-dd"));
                }else {
                    string[] snames = name.Split('_');
                    List<string> joins = new List<string>();
                    for(int i=0; i< snames.Length; i++) {
                        if(!IsDate(snames[i])) {
                            joins.Add(snames[i]);
                        }
                    }
                    txtName.Text = string.Join("_", joins);
                }
            }
        }

        private bool IsDate(string date) {
            DateTime temp;
            return DateTime.TryParse(date, out temp);
        }

        private void btnAdd_Click(object sender, EventArgs e) {

        }
    }
}