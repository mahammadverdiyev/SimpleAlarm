using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace SimpleAlarm
{
    public partial class AboutMe : Form
    {
        Form mainFrame;

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public AboutMe()
        {
            InitializeComponent();
        }

        public void setMainFrame(Form mainFrame)
        {
            this.mainFrame = mainFrame;
        }
        private void AboutCard_Load(object sender, EventArgs e)
        {
        }

        private void AboutCard_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && e.Clicks == 1)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/mahammadverdiyev/SimpleAlarm");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Process.Start("https://verdiyevmahammad.medium.com/");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.facebook.com/muhammedverdiyevrovshan");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Process.Start("https://medium.com/star-gazers");
        }

        private void AboutCard_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.mainFrame.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.facebook.com/groups/stargazersmedium");
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/mahammadverdiyev");
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
