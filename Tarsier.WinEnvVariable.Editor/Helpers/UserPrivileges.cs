using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;

namespace Tarsier.WinEnvVariable.Editor.Helpers {
    public class UserPrivileges {
        public static bool IsUserAdministrator() {
            bool isAdmin;
            try {
                //get the currently logged in user
                WindowsIdentity user = WindowsIdentity.GetCurrent();
                WindowsPrincipal principal = new WindowsPrincipal(user);
                isAdmin = principal.IsInRole(WindowsBuiltInRole.Administrator);
            } catch(UnauthorizedAccessException) {
                isAdmin = false;
            } catch(Exception) {
                isAdmin = false;
            }
            return isAdmin;
        }

    }
}
