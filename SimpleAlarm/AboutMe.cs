using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace SimpleAlarm
{
	public partial class AboutMe : Form
	{
		private Form mainForm;

		public const int WM_NCLBUTTONDOWN = 0xA1;
		public const int HT_CAPTION = 0x2;

		[DllImport("user32.dll")]
		public static extern int SendMessage(IntPtr hWnd,
						 int Msg, int wParam, int lParam);
		[DllImport("user32.dll")]
		public static extern bool ReleaseCapture();

		public AboutMe(Form mainForm)
		{
			InitializeComponent();
			this.mainForm = mainForm;
		}

		private void AboutCard_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left && e.Clicks == 1)
			{
				ReleaseCapture();
				SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
			}
		}

		private void ProjectGithubPagePicture_Click(object sender, EventArgs e)
		{
			Process.Start("https://github.com/mahammadverdiyev/SimpleAlarm");
		}

		private void MediumProfilePicture_Click(object sender, EventArgs e)
		{
			Process.Start("https://verdiyevmahammad.medium.com/");
		}

		private void FacebookProfilePicture_Click(object sender, EventArgs e)
		{
			Process.Start("https://www.facebook.com/muhammedverdiyevrovshan");
		}

		private void StarGazersMediumPicture_Click(object sender, EventArgs e)
		{
			Process.Start("https://medium.com/star-gazers");
		}

		private void AboutCard_FormClosed(object sender, FormClosedEventArgs e)
		{
			mainForm.Show();
		}

		private void StarGazersFacebookPicture_Click(object sender, EventArgs e)
		{
			Process.Start("https://www.facebook.com/groups/stargazersmedium");
		}

		private void GithubProfilePicture_Click(object sender, EventArgs e)
		{
			Process.Start("https://github.com/mahammadverdiyev");
		}

		private void CloseButton_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
