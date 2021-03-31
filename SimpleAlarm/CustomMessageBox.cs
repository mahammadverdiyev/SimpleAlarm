using System;
using System.Drawing;
using System.Windows.Forms;

namespace SimpleAlarm
{
    public partial class CustomMessageBox : Form
    {
        Form mainForm;
        Random random = new Random();
        int minValue;
        int maxValue;
        int answer;
        string expressionDifficultyLevel;
        
        
        public CustomMessageBox()
        {
            InitializeComponent();
        }

        public void SetMainForm(Form mainForm)
        {
            this.mainForm = mainForm;
        }

        public void SetExpressionDifficulty(string difficultyLevel)
        {
            this.expressionDifficultyLevel = difficultyLevel;
        }

        public void SetTitle(String title)
        {
            this.label_title.Text = title;
        }
        public void SetMessage(String message)
        {
            this.label_message.Text = message;
        }


        private void CalculateAnswer()
        {
            this.answer = int.Parse(label_num1.Text) +
                                            int.Parse(label_num2.Text);
        }


        private void GenerateNumbers()
        {
            label_num1.Text = random.Next(minValue, maxValue).ToString();
            label_num2.Text = random.Next(minValue, maxValue).ToString();
        }

        private void CustomMessageBox_Load(object sender, EventArgs e)
        {
            int x = mainForm.Location.X + (mainForm.Width / 5);
            int y = mainForm.Location.Y + (mainForm.Height / 3);
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
            button_stop.Enabled = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox_answer.Text = textBox_answer.Text.Trim();
            int userAnswer;
            bool parsable = int.TryParse(textBox_answer.Text, out userAnswer);
            if (parsable)
                if(userAnswer == this.answer)
                    button_stop.Enabled = true;
            else
                button_stop.Enabled = false;
        }
    }
}
