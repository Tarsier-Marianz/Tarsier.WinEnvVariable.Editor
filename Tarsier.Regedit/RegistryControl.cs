using Microsoft.Win32;
namespace Tarsier.Regedit {
    public class RegistryControl {
        private string appKey = "SOFTWARE\\Marianz\\Tarsier.WinEnvVariable.Editor";
        public string AppKey {
            get { return appKey; }
            set { appKey = value; }
        }
        private RegistryKey subRegistryKey = null;
        private RegistryKey rootRegistryKey = Registry.LocalMachine;

        public RegistryKey RootRegistryKey {
            get { return rootRegistryKey; }
            set { rootRegistryKey = value; }
        }

        public string Read(string KeyName) {
            if(string.IsNullOrEmpty(KeyName)) {
                return string.Empty;
            }
            subRegistryKey = rootRegistryKey.OpenSubKey(appKey);
            if(subRegistryKey == null) {
                return null;
            } else {
                try {
                    return (string)subRegistryKey.GetValue(KeyName);
                } catch {
                    return null;
                }
            }
        }

        public bool Write(string KeyName, object Value) {
            if(string.IsNullOrEmpty(KeyName)) {
                return false;
            }
            try {
                subRegistryKey = rootRegistryKey.CreateSubKey(appKey);
                subRegistryKey.SetValue(KeyName, Value);
                return true;
            } catch {
                return false;
            }
        }

        public bool Delete(string KeyName) {
            try {
                subRegistryKey = rootRegistryKey.CreateSubKey(appKey);
                if(subRegistryKey == null)
                    return true;

                subRegistryKey.DeleteValue(KeyName);
                return true;
            } catch {
                return false;
            }
        }

        public bool Reset() {
            try {
                if(rootRegistryKey.OpenSubKey(appKey) != null)
                    rootRegistryKey.DeleteSubKeyTree(appKey);
                return true;
            } catch {
                return false;
            }
        }
    }
}
