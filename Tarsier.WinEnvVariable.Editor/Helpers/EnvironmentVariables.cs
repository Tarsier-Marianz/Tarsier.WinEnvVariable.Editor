using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using Tarsier.WinEnvVariable.Editor.API;

namespace Tarsier.WinEnvVariable.Editor.Helpers {
    public class EnvironmentVariables {
        public void NotifyUserEnvironmentVariableChanged() {
            NativeMethods.SendNotifyMessage((IntPtr)NativeMethods.HWND_BROADCAST, NativeMethods.WM_SETTINGCHANGE, (UIntPtr)0, "Environment");
        }

        private string REG_ENVPATH = @"SYSTEM\CurrentControlSet\Control\Session Manager\Environment";
        public bool SetEnvironmentVariable(string name, string value) {
            try {
                using(var envKey = Registry.LocalMachine.OpenSubKey(REG_ENVPATH, true)) {
                    Contract.Assert(envKey != null, @"registry key is missing!");
                    envKey.SetValue(name, value);
                    NotifyUserEnvironmentVariableChanged();
                }
            } catch {
                return false;
            }
            return true;
        }

        public bool DeleteEnvironmentVariable(string name) {
            return SetEnvironmentVariable(name, string.Empty);
        }
    }
}
