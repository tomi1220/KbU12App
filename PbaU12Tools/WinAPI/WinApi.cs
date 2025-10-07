using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PbaU12Tools.WinAPI
{
    public static class WinApi
    {
        [DllImport("shell32.dll", CharSet = CharSet.Auto)]
        public static extern int ShellExecute(IntPtr hwnd, string lpOperation, string lpFile, string? lpParameters, string? lpDirectory, int nShowCmd);

        [DllImport("shell32.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
        public static extern int SHOpenFolderAndSelectItems(
            IntPtr pidlFolder,
            uint cidl,
            [MarshalAs(UnmanagedType.LPArray)] IntPtr[] apidl,
            uint dwFlags);

        [DllImport("shell32.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
        public static extern int SHParseDisplayName(
            [MarshalAs(UnmanagedType.LPWStr)] string pszName,
            IntPtr pbc,
            out IntPtr ppidl,
            uint sfgaoIn,
            out uint psfgaoOut);

        [DllImport("ole32.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
        public static extern void CoTaskMemFree(IntPtr pv);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int SendMessage(IntPtr hWnd, int wMsg, IntPtr wParam, IntPtr lParam);
        public const int WM_VSCROLL = 277; // Vertical scroll
        public const int SB_LINEUP = 0; // Scrolls one line up
        public const int SB_LINEDOWN = 1; // Scrolls one line down
    }
}
