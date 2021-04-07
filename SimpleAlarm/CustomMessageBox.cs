using System;
using System.Drawing;
using System.Windows.Forms;

namespace SimpleAlarm
{
	public partial class AlarmRingScreen : Form
	{
		private Random random = new Random();
		private int minValue;
		private int maxValue;
		private int answer;
		private string expressionDifficultyLevel;

		private SmartAlarm smartAlarm;

		public AlarmRingScreen(SmartAlarm smartAlarm)
		{
			this.smartAlarm = smartAlarm;
			InitializeComponent();
		}

		public void Initialize()
		{
			label_title.Text = "Alarm";

			string message = smartAlarm.MessageTextBox.Text;
			if (message.Trim().Length == 0)
				message = "It is time to get up mate, you'll be late!";

			label_message.Text = message;
			expressionDifficultyLevel = smartAlarm.DifficultyComboBox.SelectedItem.ToString();
		}
		private void StopButton_Click(object sender, EventArgs e)
		{
			smartAlarm.AlarmStarted = false;
			smartAlarm.SoundManager.StopMusic();
			CloseMessageBox();
			ResetAlarmProcessCounter();
			smartAlarm.RestoreComponents();
		}

		private void CloseMessageBox()
		{
			Close();
		}

		private void ResetAlarmProcessCounter()
		{
			smartAlarm.AlarmProcessCounter = 0;
		}

		private void SnoozeButton_Click(object sender, EventArgs e)
		{
			smartAlarm.Snooze();
		}

		private void CalculateAnswer()
		{
			answer = int.Parse(label_num1.Text) + int.Parse(label_num2.Text);
		}

		private void GenerateNumbers()
		{
			label_num1.Text = random.Next(minValue, maxValue).ToString();
			label_num2.Text = random.Next(minValue, maxValue).ToString();
		}

		private void CustomMessageBox_Load(object sender, EventArgs e)
		{
			int x = smartAlarm.Location.X + (smartAlarm.Width / 5);
			int y = smartAlarm.Location.Y + (smartAlarm.Height / 3);
			this.Location = new Point(x, y);
			switch (this.expressionDifficultyLevel)
			{
				case "Easy":
					Console.WriteLine("easy");
					minValue = 1;
					maxValue = 9;
					break;

				case "Medium":
					minValue = 20;
					maxValue = 70;
					break;

				case "Hard":
					minValue = 200;
					maxValue = 700;
					break;
				default:
					break;
			}
			GenerateNumbers();
			CalculateAnswer();
			stopAlarmButton.Enabled = false;
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			textBox_answer.Text = textBox_answer.Text.Trim();
			int userAnswer;
			bool parsable = int.TryParse(textBox_answer.Text, out userAnswer);
			if (parsable)
				if (userAnswer == this.answer)
					stopAlarmButton.Enabled = true;
				else
					stopAlarmButton.Enabled = false;
		}
	}
}
