using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace SimpleAlarm
{
	public partial class SmartAlarm : Form
	{
		private bool alarmStarted = false;
		public bool AlarmStarted { set => alarmStarted = value; }

		private AlarmRingScreen alarmRingScreen;

		private int alarmProcessCounter = 0;
		public int AlarmProcessCounter
		{
			get => alarmProcessCounter;
			set => alarmProcessCounter = value;
		}
		public bool AlarmCalledSpecifiedTimes => alarmProcessCounter == int.Parse(alarmAmountToCallNumericUpDown.Text);

		public const int WM_NCLBUTTONDOWN = 0xA1;
		public const int HT_CAPTION = 0x2;

		[DllImport("user32.dll")]
		public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
		[DllImport("user32.dll")]
		public static extern bool ReleaseCapture();

		public TextBox MessageTextBox => messageTextBox;
		public ComboBox DifficultyComboBox => difficultyComboBox;

		private string selectedMusic = "Default";

		private SoundManager soundManager;
		public SoundManager SoundManager => soundManager;

		private IAlarm alarm;

		private FormWindowController formWindowController;

		public Button MinimizeMaximizeButton => minimizeMaximizeButton;
		public Button CloseButton => closeButton;

		private bool FullSized => Size == Screen.PrimaryScreen.WorkingArea.Size;

		public SmartAlarm()
		{
			InitializeComponent();
			soundManager = new SoundManager();
			formWindowController = new FormWindowController(this);
			formWindowController.SetButtonArray(new Button[]
				{
					minimizeButton,
					button_about,
					minimizeMaximizeButton,
					closeButton,
				}
			);
		}

		private void SmartAlarm_Load(object sender, EventArgs e)
		{
			soundManager.Set("Default.wav");

			SetCurrentDateAndTime();

			currentTimeTimer.Start();

			MinimumSize = new Size(690, 450);
			musicListComboBox.SelectedIndex = 0;
		}

		private void SetCurrentDateAndTime()
		{
			string currentTimeInString = DateTime.Now.ToLongTimeString();
			string currentDateInString = DateTime.Now.ToLongDateString();
			targetTimeDateTimePicker.Text = currentTimeInString;
			targetDateTimePicker.Text = currentDateInString;
		}

		private void StartAlarmButton_Click(object sender, EventArgs e)
		{
			alarmStarted = true;

			ToggleComponents(false);

			SetAlarmDependingOnUserChoice();
		}

		private void SetAlarmDependingOnUserChoice()
		{
			switch (specifyTimeRadioButton.Checked)
			{
				case true:
					SetSpecifiedDateAlarm();
					break;
				case false:
					SetFromNowAlarm();
					break;
			}
		}

		private void SetSpecifiedDateAlarm()
		{
			Time specifiedTime = GetUserSpecifiedAlarmTime();

			alarm = new SpecifiedDateAlarm();
			alarm.Set(specifiedTime, targetDateTimePicker.Value);

			StartTargetTimer();
		}

		private Time GetUserSpecifiedAlarmTime()
		{
			int hour = targetTimeDateTimePicker.Value.Hour;
			int minute = targetTimeDateTimePicker.Value.Minute;
			return new Time(hour, minute);
		}

		private void SetFromNowAlarm()
		{
			int hoursFromNow = fromNowHourNumericUpDown.Value.Hour;
			int minutesFromNow = fromNowMinuteNumericUpDown.Value.Minute;

			alarm = new FromNowAlarm();
			alarm.Set(new Time(hoursFromNow, minutesFromNow), DateTime.Now);

			StartTargetTimer();
		}

		private void CancelAlarmButton_Click(object sender, EventArgs e) => RestoreComponents();

		public void RestoreComponents()
		{
			alarmStarted = false;
			ToggleComponents(true);
			ResetAlarmProcessCounter();
			StopTargetTimer();
		}

		private void PopAlarmRingingScreenUp()
		{
			alarmRingScreen = new AlarmRingScreen(this);
			alarmRingScreen.Initialize();
		}

		private void CloseAlarmRingingScreen() => alarmRingScreen.Close();

		private void ResetAlarmProcessCounter() => alarmProcessCounter = 0;

		private void StartTargetTimer() => targetTimeTimer.Start();

		private void StopTargetTimer() => targetTimeTimer.Stop();

		private void TargetTimeTimer_Tick(object sender, EventArgs e)
		{
			if (GetCurrentTime() == alarm.GetTime() && alarmStarted)
			{
				StopTargetTimer();
				PlayAlarmMusicLooping();
				PopAlarmRingingScreenUp();
				alarmRingScreen.ShowDialog();
			}
		}

		private Time GetCurrentTime() => new Time(DateTime.Now.Day, DateTime.Now.Minute);

		private void CurrentTimeTimer_Tick(object sender, EventArgs e) => currentTimeLabel.Text = DateTime.Now.ToString();

		private void RefreshHeaderMessage()
		{
			if (specifyTimeRadioButton.Checked)
			{
				string time = DateTime.Now.AddMinutes(double.Parse(snoozeTextBox.Text)).ToLongTimeString();
				headerMessageRightLabel.Text = $"{time} {targetDateTimePicker.Text}";
			}
			else
			{
				headerMinuteMessageLabel.Text = snoozeTextBox.Text;
			}
		}

		public void Snooze()
		{
			alarmProcessCounter++;

			if (AlarmCalledSpecifiedTimes)
			{
				StopProcess();
			}
			else
			{
				CloseAlarmRingingScreen();
				soundManager.StopMusic();

				int snoozeMinute = int.Parse(snoozeTextBox.Text);
				alarm.SnoozeFor(snoozeMinute);

				RefreshHeaderMessage();
				StartTargetTimer();
			}
		}

		private void StopProcess()
		{
			alarmStarted = false;
			soundManager.StopMusic();
			alarmRingScreen.Close();
			RestoreComponents();
		}

		private void ToggleComponents(bool value)
		{
			musicListComboBox.Enabled = value;
			playMusicButton.Enabled = value;
			stopMusicButton.Enabled = value;

			callLabel.Enabled = value;
			snoozeLabel.Enabled = value;
			alarmAmountToCallNumericUpDown.Enabled = value;
			snoozeTextBox.Enabled = value;
			callTimesLabel.Enabled = value;
			callMinuteLabel.Enabled = value;

			ToggleFromNowAlarmComponents(value);

			targetDateTimePicker.Enabled = value;
			targetTimeDateTimePicker.Enabled = value;

			fromNowRadioButton.Enabled = value;
			specifyTimeRadioButton.Enabled = value;
		}

		private void SpecifyTimeRadioButton_CheckedChanged(object sender, EventArgs e)
		{
			if (specifyTimeRadioButton.Checked)
			{
				headerMessageRightLabel.Text = $"{targetTimeDateTimePicker.Text}  {targetDateTimePicker.Text}";
				fromNowRadioButton.Text = "From now";

				ToggleFromNowAlarmComponents(false);
				ToggleHeaderComponents(false);

				headerMessageLefPartLabel.Text = "The alarm will go off at ";
			}
		}

		private void FromNowRadioButton_CheckedChanged(object sender, EventArgs e)
		{
			fromNowRadioButton.Text = $"From now ({DateTime.Now})";

			ToggleFromNowAlarmComponents(true);

			targetDateTimePicker.Enabled = false;
			targetTimeDateTimePicker.Enabled = false;

			ToggleHeaderComponents(true);

			UpdateAlarmTimeInHeader();
		}

		private void UpdateAlarmTimeInHeader()
		{
			headerMessageLefPartLabel.Text = "The alarm will go off in ";
			headerMessageRightLabel.Text = fromNowHourNumericUpDown.Text;
			headerMinuteMessageLabel.Text = fromNowMinuteNumericUpDown.Text;
		}

		private void ToggleFromNowAlarmComponents(bool value)
		{
			fromNowHourNumericUpDown.Enabled = value;
			fromNowMinuteNumericUpDown.Enabled = value;
			fromNowHourLabel.Enabled = value;
			fromNowMinuteLabel.Enabled = value;
		}

		private void ToggleHeaderComponents(bool value)
		{
			headerHourLabel.Visible = value;
			headerMinuteLabel.Visible = value;
			headerMinuteMessageLabel.Visible = value;
		}

		private void TargetTimeOrDateNumericUpDown_ValueChanged(object sender, EventArgs e)
		{
			headerMessageRightLabel.Text = $"{targetTimeDateTimePicker.Text} {targetDateTimePicker.Text}";
		}

		private void PlayMusicButton_Click(object sender, EventArgs e) => soundManager.PlayMusic();

		private void StopMusic_Click(object sender, EventArgs e) => soundManager.StopMusic();

		private void PlayAlarmMusicLooping() => soundManager.PlayLooping();

		private void SmartAlarm_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left && e.Clicks == 1 && !FullSized)
			{
				ReleaseCapture();
				SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
			}
		}

		private void FromNowHourOrMinuteNumericUPDown_ValueChanged(object sender, EventArgs e)
		{
			headerMessageRightLabel.Text = fromNowHourNumericUpDown.Text;
			headerMinuteMessageLabel.Text = fromNowMinuteNumericUpDown.Text;
		}

		private void MusicList_SelectedIndexChanged(object sender, EventArgs e)
		{
			selectedMusic = musicListComboBox.SelectedItem.ToString();
			soundManager.Set($"{selectedMusic}.wav");
			int duration = SoundInfo.GetSoundLength($"{selectedMusic}.wav") / 1000;
			label_duration_value.Text = $"{duration}s";
		}

		private void AboutButton_Click(object sender, EventArgs e)
		{
			AboutMe aboutMe = new AboutMe(this);
			aboutMe.Show();
		}

		private void DisplayInformationButton_Click(object sender, EventArgs e)
		{
			AboutApp aboutApp = new AboutApp(this);
			aboutApp.ShowDialog();
		}

		private void MinimizeMaximizeButton_Click(object sender, EventArgs e) => formWindowController.MinimizeOrMaximize();

		private void MinimizeButton_Click(object sender, EventArgs e) => WindowState = FormWindowState.Minimized;

		private void SmartAlarm_Resize(object sender, EventArgs e) => formWindowController.ChangeMinimizeMaximizeButtonIcon();

		private void CloseButton_Click(object sender, EventArgs e) => Application.Exit();

		private void SmartAlarm_Move(object sender, EventArgs e) => formWindowController.MoveForm();

		private void SpecifyTimeRadioButton_MouseEnter(object sender, EventArgs e) => specifyTimeRadioButton.ForeColor = Color.FromArgb(18, 204, 123);

		private void SpecifyTimeRadioButton_MouseLeave(object sender, EventArgs e) => specifyTimeRadioButton.ForeColor = Color.Black;

		private void FromNowRadioButton_MouseEnter(object sender, EventArgs e) => fromNowRadioButton.ForeColor = Color.FromArgb(18, 204, 123);

		private void FromNowRadioButton_MouseLeave(object sender, EventArgs e) => fromNowRadioButton.ForeColor = Color.Black;
	}
}