using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
namespace SimpleAlarm
{
    static class Program
    {
        [DllImport("user32.dll")]
        static extern bool AnimateWindow(IntPtr hwnd, int dwTime, int dwFlags);

        private const int AW_VER_POSITIVE = 0x00000004;
        private const int AW_VER_NEGATIVE = 0x00000008;
        private const int AW_SLIDE = 0x00040000;
        private const int AW_HIDE = 0x00010000;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SmartAlarm());
            //Application.Run(new CustomMessageBox());
        }
    }
}

