using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Tarsier.WinEnvVariable.Editor.Helpers;

namespace Tarsier.WinEnvVariable.Editor {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if(UserPrivileges.IsUserAdministrator()) {
                Application.Run(new MainWindow());
            }else {
                MessageBox.Show(@"You need to start this application in administrator mode in order to edit environment variables.\n
                    Please Run as Administrator", "Admin Rights Required", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
