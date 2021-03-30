using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Reflection;
using System.IO;
using System.Resources;
using System.Media;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Drawing.Drawing2D;

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
            // TODO: add github repo
            Process.Start("https://www.youtube.com/");
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
