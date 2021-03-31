using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleAlarm
{
    public partial class CustomMessageBox : Form
    {
        Random random = new Random();
        int answer;
        public CustomMessageBox()
        {
            InitializeComponent();
        }

        public void setTitle(String title)
        {
            this.label_title.Text = title;
        }
        public void setMessage(String message)
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
            label_num1.Text = random.Next(20, 50).ToString();
            label_num2.Text = random.Next(20, 50).ToString();
        }

        private void CustomMessageBox_Load(object sender, EventArgs e)
        {
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
