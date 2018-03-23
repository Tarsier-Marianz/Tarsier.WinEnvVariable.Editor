using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Tarsier.WinEnvVariable.Editor.Forms {
    public partial class RestartForm : Form {
        public RestartForm(string envName, string type) {
            InitializeComponent();
            if(type.Equals("ENV_UPDATE")) {
                lblInfo.Text = string.Format("{0} name in environment variable was successfully updated. Please restart computer to takes effect.", envName);
            } else if(type.Equals("ENV_DELETE")) {
                lblInfo.Text = string.Format("{0} name in environment variable was successfully deleted. Please restart computer to takes effect.", envName);
            } else {
                lblInfo.Text = string.Format("The environment variable {0} was successfully saved. Please restart computer to takes effect.", envName);
            }
        }
    }
}
