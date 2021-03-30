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
    public partial class SmartAlarm : Form
    {
        private string targetDateTime;
        private string currentDateTime;
        private SoundPlayer soundPlayer;
        private bool alarmStarted = false;
        private bool isSoundPlaying = false;
        private CancellationTokenSource cancellationTokenSource;
        private CustomMessageBox myMessageBox;
        private int alarmProcessCounter = 0;
        private const int
            HTLEFT = 10,
            HTRIGHT = 11,
            HTTOP = 12,
            HTTOPLEFT = 13,
            HTTOPRIGHT = 14,
            HTBOTTOM = 15,
            HTBOTTOMLEFT = 16,
            HTBOTTOMRIGHT = 17;


        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public SmartAlarm()
        {
            InitializeComponent();
            //this.SetStyle(ControlStyles.ResizeRedraw, true);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left && e.Clicks == 1)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }

            else if(e.Button == MouseButtons.Left && e.Clicks == 2)
            {
                if (this.Size == Screen.PrimaryScreen.WorkingArea.Size)
                {
                    this.Size = new Size(700, 440);
                    this.CenterToScreen();
                }
                else
                {
                    this.Size = Screen.PrimaryScreen.WorkingArea.Size;
                    this.Location = new Point(0, 0);
                }
            }
        }


        private void InitializeCustomMessageBox()
        {
            string title = "Get up!";
            string message = "It is time to get up mate, come on!";
            myMessageBox = new CustomMessageBox();
            myMessageBox.button_stop.Click += MessageBoxButtonStop_Click;
            myMessageBox.button_snooze.Click += MessageBoxButtonSnooze_Click;
            myMessageBox.setTitle(title);
            myMessageBox.setMessage(message);
        }



        private void simple_alarm_Load(object sender, EventArgs e)
        {
            soundPlayer = new SoundPlayer("default_alarm.wav");
            string time_now = DateTime.Now.ToLongTimeString();
            string date_now = DateTime.Now.ToLongDateString();
            target_time.Text = time_now;
            target_date.Text = date_now;
            timer_current_time.Start();

            radioButton_specify_time.Checked = true;
            targetDateTime = $"{target_date.Text} {target_time.Text}";
            this.MinimumSize = new Size(650, 310);
            this.Size = new Size(750, 400);

        }

        private void CloseMessageBox()
        {
            this.myMessageBox.Close();
        }

        private void EnableForm()
        {
            this.Enabled = true;
        }
        private void DisableForm()
        {
            this.Enabled = false;
        }

        private void ResetAlarmProcessCounter()
        {
            this.alarmProcessCounter = 0;
        }

        private void StopAlarm()
        {
            StopAlarmMusic();
        }

        private void StopTargetTimer()
        {
            timer_target_time.Stop();
        }
        private void StartTargetTimer()
        {
            timer_target_time.Start();
        }

        private void MessageBoxButtonStop_Click(object sender, EventArgs e)
        {
            StopAlarm();
        }

        bool ReachedCallCount => alarmProcessCounter == int.Parse(textBox_times.Text);

        private void MessageBoxButtonSnooze_Click(object sender, EventArgs e)
        {
            alarmProcessCounter++;
            if (ReachedCallCount)
            {
                StopAlarm();
                CloseMessageBox();
                EnableForm();
                ResetAlarmProcessCounter();
                RestoreComponents();
            }
            else
            {
                CloseMessageBox();
                StopAlarmMusic();
                targetDateTime = DateTime.Now.AddMinutes(double.Parse(textBox_snooze.Text)).ToString();
                StartTargetTimer();
                EnableForm();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InitializeCustomMessageBox();
            this.Enabled = false;
            myMessageBox.Show();
        }
        private void InitializeInputComponents()
        {
            EnableFromNowComponents();
            EnableSpecifyTimeComponents();
            radioButton_from_now.Enabled = true;
            radioButton_specify_time.Enabled = true;
        }
        private void ResetInputComponents()
        {
            DisableFromNowComponents();
            DisableSpecifyTimeComponents();
            radioButton_from_now.Enabled = false;
            radioButton_specify_time.Enabled = false;
        }

        private void AlarmWithSpecifiedTime()
        {
            targetDateTime = $"{target_date.Text} {target_time.Text}";
            StartTargetTimer();
        }

        private void AlarmWithFromNow()
        {
            double hour = from_now_hour.Value.Hour;
            double minute = from_now_minute.Value.Minute;
            
            targetDateTime = DateTime.Now.AddHours(hour).AddMinutes(minute).ToString();
            StartTargetTimer();
        }

        private void ChangeColorAndTextStartAlarmButton()
        {
            button_start_alarm.BackColor = Color.Red;
            button_start_alarm.Text = "Stop alarm";
        }

        private void StartProcess()
        {
            alarmStarted = true;
            
            ResetInputComponents();
            ChangeColorAndTextStartAlarmButton();
            if (radioButton_specify_time.Checked)
            {
                AlarmWithSpecifiedTime();
            }
            else
            {
                AlarmWithFromNow();
            }
        }
        private void RestoreComponents()
        {
            StopAlarm();
            alarmStarted = false;
            InitializeInputComponents();
            button_start_alarm.BackColor = Color.FromArgb(98, 133, 138);
            button_start_alarm.Text = "Start alarm";
            StopTargetTimer();
        }


        private void timer_current_time_Tick(object sender, EventArgs e)
        {
            label_current_time.Text = DateTime.Now.ToString();
            currentDateTime = DateTime.Now.ToString();
        }

        private async  Task PlayAlarmMusicAsynchronously(int loopCount, CancellationToken cancellationToken)
        {
                isSoundPlaying = true;
               await Task.Run(() =>
                {
                    for (int i = 0; i < loopCount; i++)
                    {
                        soundPlayer.Play();
                        Thread.Sleep(23000);
                        if (cancellationToken.IsCancellationRequested)
                            break;
                        if (!isSoundPlaying)
                            break;
                    }
                });

        }
        private async void PlayAlarmMusic(int times)
        {
            cancellationTokenSource = new CancellationTokenSource();
            await PlayAlarmMusicAsynchronously(times, cancellationTokenSource.Token);
        }

        private void StopAlarmMusic()
        {
            cancellationTokenSource.Cancel();
            cancellationTokenSource.Dispose();
            soundPlayer.Stop();
            isSoundPlaying = false;
        }

        private void timer_target_time_Tick(object sender, EventArgs e)
        {
            if (this.currentDateTime.Equals(this.targetDateTime) && alarmStarted)
            {
                StopTargetTimer();
                PlayAlarmMusic(int.MaxValue);

                InitializeCustomMessageBox();
                myMessageBox.Show();
                DisableForm();
            }

        }

        private void ChangeStatusSpecifyTimeComponents(bool value)
        {
            target_date.Enabled = value;
            target_time.Enabled = value;
        }
        private void EnableSpecifyTimeComponents()
        {
            ChangeStatusSpecifyTimeComponents(true);
        }
        private void DisableSpecifyTimeComponents()
        {
            ChangeStatusSpecifyTimeComponents(false);
        }


        private void ChangeFromNowComponents(bool value)
        {
            from_now_hour.Enabled = value;
            from_now_minute.Enabled = value;
            label_hour.Enabled = value;
            label_minute.Enabled = value;            
        }
        private void EnableFromNowComponents()
        {
            ChangeFromNowComponents(true);
        }
        private void DisableFromNowComponents()
        {
            ChangeFromNowComponents(false);
        }

        private void radioButton_specify_time_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton_specify_time.Checked)
            {
                label_header_message_right.Text = $"{target_time.Text}  {target_date.Text}";
                radioButton_from_now.Text = "From now";
                EnableSpecifyTimeComponents();
                DisableFromNowComponents();
            }
        }

        private void radioButton_from_now_CheckedChanged(object sender, EventArgs e)
        {
            radioButton_from_now.Text = $"From now ({DateTime.Now})";
            EnableFromNowComponents();
            DisableSpecifyTimeComponents();
        }

        private void radioButton_specify_time_MouseEnter(object sender, EventArgs e)
        {
            radioButton_specify_time.ForeColor = Color.FromArgb(18, 204, 123);
        }

        private void radioButton_specify_time_MouseLeave(object sender, EventArgs e)
        {
            radioButton_specify_time.ForeColor = Color.Black;
        }

        private void radioButton_from_now_MouseEnter(object sender, EventArgs e)
        {
            radioButton_from_now.ForeColor = Color.FromArgb(18, 204, 123);
        }

        private void radioButton_from_now_MouseLeave(object sender, EventArgs e)
        {
            radioButton_from_now.ForeColor = Color.Black;
        }

        private void target_time_ValueChanged(object sender, EventArgs e)
        {
            label_header_message_right.Text = $"{target_time.Text}  {target_date.Text}";
        }

        private void target_date_ValueChanged(object sender, EventArgs e)
        {
            label_header_message_right.Text = $"{target_time.Text}  {target_date.Text}";
        }

        private void button_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        const int _ = 10; 

        Rectangle _Top { get { return new Rectangle(0, 0, this.ClientSize.Width, _); } }
        Rectangle _Left { get { return new Rectangle(0, 0, _, this.ClientSize.Height); } }
        Rectangle _Bottom { get { return new Rectangle(0, this.ClientSize.Height - _, this.ClientSize.Width, _); } }
        Rectangle _Right { get { return new Rectangle(this.ClientSize.Width - _, 0, _, this.ClientSize.Height); } }

        Rectangle _TopLeft { get { return new Rectangle(0, 0, _, _); } }
        Rectangle _TopRight { get { return new Rectangle(this.ClientSize.Width - _, 0, _, _); } }
        Rectangle _BottomLeft { get { return new Rectangle(0, this.ClientSize.Height - _, _, _); } }
        Rectangle _BottomRight { get { return new Rectangle(this.ClientSize.Width - _, this.ClientSize.Height - _, _, _); } }

        private void button_minimize_maximize_Click(object sender, EventArgs e)
        {
            if (this.Size == Screen.PrimaryScreen.WorkingArea.Size && this.Location == new Point(0, 0))
            {
                this.Size = new Size(700, 440);
                this.CenterToScreen();
            }
            else
            {
                this.Size = Screen.PrimaryScreen.WorkingArea.Size;
                this.Location = new Point(0, 0);
                button_minimize_maximize.Image = SimpleAlarm.Properties.Resources.restore_down;
            }
        }

        private void simple_alarm_Resize(object sender, EventArgs e)
        {
            if (this.Size == Screen.PrimaryScreen.WorkingArea.Size)
            {
                button_minimize_maximize.Image = SimpleAlarm.Properties.Resources.restore_down;
            }
            else if(this.Location == new Point(0,0))
            {
                button_minimize_maximize.Image = SimpleAlarm.Properties.Resources.maximize;
            }
        }

        private void simple_alarm_Move(object sender, EventArgs e)
        {
            if (this.Size == Screen.PrimaryScreen.WorkingArea.Size && this.Location != new Point(0,0))
            {
                button_minimize_maximize.Image = SimpleAlarm.Properties.Resources.maximize;
            }
        }

        private void button_start_alarm_Click(object sender, EventArgs e)
        {
            if (!alarmStarted)
            {
                StartProcess();
            }
            else
            {
                RestoreComponents();
            }
        }

        protected override void WndProc(ref Message message)
        {
            base.WndProc(ref message);
            if (message.Msg == 0x84) // WM_NCHITTEST
            {
                var cursor = this.PointToClient(Cursor.Position);

                if (_TopLeft.Contains(cursor)) message.Result = (IntPtr)HTTOPLEFT;
                else if (_TopRight.Contains(cursor)) message.Result = (IntPtr)HTTOPRIGHT;
                else if (_BottomLeft.Contains(cursor)) message.Result = (IntPtr)HTBOTTOMLEFT;
                else if (_BottomRight.Contains(cursor)) message.Result = (IntPtr)HTBOTTOMRIGHT;

                else if (_Top.Contains(cursor)) message.Result = (IntPtr)HTTOP;
                else if (_Left.Contains(cursor)) message.Result = (IntPtr)HTLEFT;
                else if (_Right.Contains(cursor)) message.Result = (IntPtr)HTRIGHT;
                else if (_Bottom.Contains(cursor)) message.Result = (IntPtr)HTBOTTOM;
            }
        }

        private void CursorInBorder(MouseEventArgs e)
        {
            if ((e.X <= 2 && e.Y <= 2) || (e.X + 2 >= this.Width && e.Y + 2 >= this.Height))
            {
                this.Cursor = Cursors.SizeNWSE;
            }
            else if ((e.X + 2 >= this.Width && e.Y <= 2) || (e.X <= 2 && e.Y + 2 >= this.Height))
            {
                this.Cursor = Cursors.SizeNESW;
            }
            else if (e.X <= 2 || e.X + 2 >= this.Width)
            {
                this.Cursor = Cursors.SizeWE;
            }
            else if (e.Y <= 2 || e.Y + 2 >= this.Height)
            {
                this.Cursor = Cursors.SizeNS;
            }
            else
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void simple_alarm_MouseMove(object sender, MouseEventArgs e)
        {
            CursorInBorder(e);
        }

    }

}

