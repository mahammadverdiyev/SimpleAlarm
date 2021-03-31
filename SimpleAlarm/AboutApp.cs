using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace SimpleAlarm
{
    public partial class AboutApp : Form
    {
        Form mainFrame;

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public AboutApp()
        {
            InitializeComponent();
        }


        public void setMainFrame(Form mainFrame)
        {
            this.mainFrame = mainFrame;
        }

        private void AboutApp_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && e.Clicks == 1)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
