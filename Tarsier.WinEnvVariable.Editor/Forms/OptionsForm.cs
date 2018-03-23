using Tarsier.WinEnvVariable.Editor.Helpers;
using Tarsier.WinEnvVariable.Editor.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Tarsier.Regedit;
using Tarsier.Security;

namespace Tarsier.WinEnvVariable.Editor {
    public partial class ConfigServerForm : Form {
        public ConfigServerForm(int tabIndex=0) {
            InitializeComponent();
            InitConfig(tabIndex);
        }
        private void InitConfig(int tabIndex) {
            tabControlConfig.SelectedIndex = tabIndex;
            chkTruncatePath.Checked =RegConfig.Get<bool>("TruncatePath");
            chkAppDataTempFolder.Checked = RegConfig.Get<bool>("AppDataTempFolder");
            chkNewProfile.Checked = RegConfig.Get<bool>("ExecuteNewProfile");
            chkEnableIncludeFile.Checked = RegConfig.Get<bool>("EnableIncludeFile");
            chkAutoUnbind.Checked = RegConfig.Get<bool>("AutoUnbind");
            chkAutoSaveProfile.Checked = RegConfig.Get<bool>("AutoSaveProfile");
        }

        private void Checkboxes_CheckedChanged(object sender, EventArgs e) {
            CheckBox chk = sender as CheckBox;
            if(chk != null) {
                if(chk.Tag != null) {
                    RegConfig.Set<bool>(chk.Tag.ToString(), chk.Checked);
                }
            }
        }
        
        private void ConfigServerForm_Load(object sender, EventArgs e) {
            btnApply.Focus();
        }
    }
}
