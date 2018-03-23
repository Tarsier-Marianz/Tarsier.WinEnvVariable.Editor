using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace Tarsier.WinEnvVariable.Editor.API {
    public class NativeMethods {
        // Import the kernel32 dll.
        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        // The declaration is similar to the SDK function
        public static extern bool SetEnvironmentVariable(string lpName, string lpValue);



       public const int HWND_BROADCAST = 0xffff;
       public const uint WM_SETTINGCHANGE = 0x001a;

        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        public static extern bool SendNotifyMessage(IntPtr hWnd, uint Msg,UIntPtr wParam, string lParam);
    }
}
