using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;
using System.Runtime.InteropServices;

namespace SimpleAlarm
{
    public partial class SmartAlarm : Form
    {
        private string targetDateTime;
        private string currentDateTime;
        private string chosenWavFileName = "Default";
        private bool alarmStarted = false;
        private bool isSoundPlaying = false;
        private SoundPlayer soundPlayer;
        private CancellationTokenSource cancellationTokenSource;
        private CustomMessageBox myMessageBox;
        private AboutMe myAboutCard;
        private AboutApp appAboutCard;
        private Point currentFormCoordinate;
        private int alarmProcessCounter = 0;
        private int soundDuration = 29023;
        private const int
            HTLEFT = 10,
            HTRIGHT = 11,
            HTTOP = 12,
            HTTOPLEFT = 13,
            HTTOPRIGHT = 14,
            HTBOTTOM = 15,
            HTBOTTOMLEFT = 16,
            HTBOTTOMRIGHT = 17;

        Button[] buttons;


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
                    this.Location = currentFormCoordinate;
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
            string message = "It is time to get up mate, you'll be late!";
            myMessageBox = new CustomMessageBox();
            myMessageBox.button_stop.Click += MessageBoxButtonStop_Click;
            myMessageBox.button_snooze.Click += MessageBoxButtonSnooze_Click;
            myMessageBox.setTitle(title);
            myMessageBox.setMessage(message);
        }



        private void simple_alarm_Load(object sender, EventArgs e)
        {
            soundPlayer = new SoundPlayer("Default.wav");
            string time_now = DateTime.Now.ToLongTimeString();
            string date_now = DateTime.Now.ToLongDateString();
            target_time.Text = time_now;
            target_date.Text = date_now;
            timer_current_time.Start();

            radioButton_specify_time.Checked = true;
            targetDateTime = $"{target_date.Text} {target_time.Text}";
            this.MinimumSize = new Size(650, 400);
            this.Size = new Size(750, 400);
            list_music.SelectedIndex = 0;
           buttons =  new Button[]
                    {button_minimize,button_about,
                    button_minimize_maximize,button_close};
            currentFormCoordinate = this.Location;
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

        private void StopProcess() 
        {
            StopAlarm();
            CloseMessageBox();
            ResetAlarmProcessCounter();
            RestoreComponents();
        }

        private void MessageBoxButtonStop_Click(object sender, EventArgs e)
        {
            StopProcess();
        }

        bool ReachedCallCount => alarmProcessCounter == int.Parse(textBox_times.Text);
        private bool FormMinimized => WindowState == FormWindowState.Minimized;
        private bool FullSized => this.Size == Screen.PrimaryScreen.WorkingArea.Size;

        private bool IsFormOnZeroZeroCoordinate => this.Location == new Point(0, 0);

        private void MessageBoxButtonSnooze_Click(object sender, EventArgs e)
        {
            alarmProcessCounter++;
            if (ReachedCallCount)
            {
                StopProcess();
            }
            else
            {
                CloseMessageBox();
                StopAlarmMusic();
                targetDateTime = DateTime.Now.AddMinutes(double.Parse(textBox_snooze.Text)).ToString();
                StartTargetTimer();
            }
        }

        private void DisableInputComponents()
        {
            DisableAdditionalComponents();
            DisableTestAlarmMusicComponents();
            DisableFromNowComponents();
            DisableSpecifyTimeComponents();
            radioButton_from_now.Enabled = false;
            radioButton_specify_time.Enabled = false;
        }
        private void EnableInputComponents()
        {
            EnableTestAlarmMusicComponents();
            EnableAdditionalComponents();
            EnableFromNowComponents();
            EnableSpecifyTimeComponents();
            radioButton_from_now.Enabled = true;
            radioButton_specify_time.Enabled = true;
        }
        private void ChangeStatusTestAlarmMusicComponents(bool value)
        {
            list_music.Enabled = value;
            button_play.Enabled = value;
            button_stop.Enabled = value;
        }
        private void DisableTestAlarmMusicComponents()
        {
            ChangeStatusTestAlarmMusicComponents(false);
        }
        private void EnableTestAlarmMusicComponents()
        {
            ChangeStatusTestAlarmMusicComponents(true);
        }

        private void ChangeStatusAdditionalComponents(bool value)
        {
            label_call.Enabled = value;
            label_snooze.Enabled = value;
            textBox_times.Enabled = value;
            textBox_snooze.Enabled = value;
            label_call_time.Enabled = value;
            label_call_minute.Enabled = value;
        }

        private void DisableAdditionalComponents()
        {
            ChangeStatusAdditionalComponents(false); 
        }
        private void EnableAdditionalComponents()
        {
            ChangeStatusAdditionalComponents(true);
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

        private void ChangeStyleAlarmButton(string text, Color color)
        {
            button_start_alarm.BackColor = color;
            button_start_alarm.Text = text;
        }

        private void StartProcess()
        {
            alarmStarted = true;

            ChooseAlarmMusic();
            DisableInputComponents();
            ChangeStyleAlarmButton("Stop alarm",Color.Red);
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
            alarmStarted = false;
            EnableInputComponents();

            ChangeStyleAlarmButton("Start alarm", Color.FromArgb(98, 133, 138));
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
                        Thread.Sleep(soundDuration);
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
            if(cancellationTokenSource != null)
            {
                cancellationTokenSource.Cancel();
                cancellationTokenSource.Dispose();
            }
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
                myMessageBox.ShowDialog();
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
                label_header_hour.Visible = false;
                label_header_minute.Visible = false;
                label_header_message_minute.Visible = false;
                label_header_message_left.Text = "The alarm will go off at ";
            }
        }

        private void radioButton_from_now_CheckedChanged(object sender, EventArgs e)
        {
            radioButton_from_now.Text = $"From now ({DateTime.Now})";
            EnableFromNowComponents();
            DisableSpecifyTimeComponents();
            label_header_hour.Visible = true;
            label_header_minute.Visible = true;
            label_header_message_minute.Visible = true;
            label_header_message_left.Text = "The alarm will go off in ";
            label_header_message_right.Text = from_now_hour.Text;
            label_header_message_minute.Text = from_now_minute.Text;
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


        const int recSize = 10; 

        Rectangle _Top { get { return new Rectangle(0, 0, this.ClientSize.Width, recSize); } }
        Rectangle _Left { get { return new Rectangle(0, 0, recSize, this.ClientSize.Height); } }
        Rectangle _Bottom { get { return new Rectangle(0, this.ClientSize.Height - recSize, this.ClientSize.Width, recSize); } }
        Rectangle _Right { get { return new Rectangle(this.ClientSize.Width - recSize, 0, recSize, this.ClientSize.Height); } }

        Rectangle _TopLeft { get { return new Rectangle(0, 0, recSize, recSize); } }
        Rectangle _TopRight { get { return new Rectangle(this.ClientSize.Width - recSize, 0, recSize, recSize); } }
        Rectangle _BottomLeft { get { return new Rectangle(0, this.ClientSize.Height - recSize, recSize, recSize); } }
        Rectangle _BottomRight { get { return new Rectangle(this.ClientSize.Width - recSize, this.ClientSize.Height - recSize, recSize, recSize); } }


        private void InitializeSoundPlayer(string wavFileName)
        {
            soundPlayer = new SoundPlayer($"{wavFileName}.wav");
            this.soundDuration = SoundInfo.GetSoundLength($"{wavFileName}.wav");
        }

        private void ChooseAlarmMusic()
        {
            string name = list_music.Text;
            chosenWavFileName = name;
            InitializeSoundPlayer(name);
        }
        private void button_play_Click(object sender, EventArgs e)
        {
            soundPlayer.Stop();
            if(!chosenWavFileName.Equals(list_music.Text))
                ChooseAlarmMusic();
            soundPlayer.Play();
        }

        private void button_stop_Click(object sender, EventArgs e)
        {
            soundPlayer.Stop();
        }

        private void SmartAlarm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && e.Clicks == 1 && !FullSized)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }

            //else if (e.Button == MouseButtons.Left && e.Clicks == 2)
            //{
            //    if (this.Size == Screen.PrimaryScreen.WorkingArea.Size)
            //    {
            //        this.Size = new Size(700, 440);
            //        //this.CenterToScreen();
            //        this.Location = currentFormCoordinate;
            //    }
            //    else
            //    {
            //        this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            //        this.Location = new Point(0, 0);
            //    }
            //}
        }

        private void CreateAboutMeCard()
        {
            myAboutCard = new AboutMe();
            myAboutCard.setMainFrame(this);
        }
        private void CreateAboutAppCard()
        {
            appAboutCard = new AboutApp();
            appAboutCard.setMainFrame(this);
        }


        private void button_about_Click(object sender, EventArgs e)
        {
            CreateAboutMeCard();
            myAboutCard.ShowDialog();
        }


        private void from_now_hour_ValueChanged(object sender, EventArgs e)
        {
            label_header_message_right.Text = from_now_hour.Text;
            label_header_message_minute.Text = from_now_minute.Text;
        }

        private void from_now_minute_ValueChanged(object sender, EventArgs e)
        {
            label_header_message_right.Text = from_now_hour.Text;
            label_header_message_minute.Text = from_now_minute.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateAboutAppCard();
            appAboutCard.ShowDialog();
        }

        private void ChangeButtonsLocation(Button[] buttons, int xPos, int yPos)
        {
            for(int i = 0; i < buttons.Length; i++)
            {
                int currX = buttons[i].Location.X;
                int currY = buttons[i].Location.Y;
                buttons[i].Location = new Point(currX + xPos, currY + yPos);
            }
        }

        private void button_minimize_maximize_Click(object sender, EventArgs e)
        {

            if (FullSized && IsFormOnZeroZeroCoordinate)
            {
                this.Size = new Size(700, 440);
                this.Location = currentFormCoordinate;
                ChangeButtonsLocation(buttons, -5, 3);
            }
            else
            {
                this.Size = Screen.PrimaryScreen.WorkingArea.Size;
                this.Location = new Point(0, 0);
                ChangeButtonsLocation(buttons, 5, -3);
                Console.WriteLine(button_close.Location);
            }
        }


        private void simple_alarm_Resize(object sender, EventArgs e)
        {
            if (FullSized)
            {
                Console.WriteLine("boyuldu");
                button_minimize_maximize.Image = SimpleAlarm.Properties.Resources.restore_down;
            }
            else if (IsFormOnZeroZeroCoordinate)
            {
                Console.WriteLine("kicildi");
                button_minimize_maximize.Image = SimpleAlarm.Properties.Resources.maximize;
            }
        }

        private void simple_alarm_Move(object sender, EventArgs e)
        {
            if (FullSized && !IsFormOnZeroZeroCoordinate)
            {
                button_minimize_maximize.Image = SimpleAlarm.Properties.Resources.maximize;
                if(button_close.Location == new Point(1318,0))
                    ChangeButtonsLocation(buttons, -5, 3);
            }
            else if(!FullSized && IsFormOnZeroZeroCoordinate && !FormMinimized|| 
                    !FullSized && !IsFormOnZeroZeroCoordinate && !FormMinimized)
            {
                currentFormCoordinate = this.Location;
            }
        }

        private void button_start_alarm_Click(object sender, EventArgs e)
        {
            soundPlayer.Stop();
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
            if (message.Msg == 0x84 && !FullSized)
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

    }

}