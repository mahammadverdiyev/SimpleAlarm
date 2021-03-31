
namespace SimpleAlarm
{
    partial class SmartAlarm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SmartAlarm));
            this.timer_current_time = new System.Windows.Forms.Timer(this.components);
            this.timer_target_time = new System.Windows.Forms.Timer(this.components);
            this.radioButton_specify_time = new System.Windows.Forms.RadioButton();
            this.radioButton_from_now = new System.Windows.Forms.RadioButton();
            this.button_minimize = new System.Windows.Forms.Button();
            this.label_header_message_right = new System.Windows.Forms.Label();
            this.label_header_message_left = new System.Windows.Forms.Label();
            this.label_header = new System.Windows.Forms.Label();
            this.target_date = new System.Windows.Forms.DateTimePicker();
            this.target_time = new System.Windows.Forms.DateTimePicker();
            this.from_now_hour = new System.Windows.Forms.DateTimePicker();
            this.from_now_minute = new System.Windows.Forms.DateTimePicker();
            this.label_hour = new System.Windows.Forms.Label();
            this.label_minute = new System.Windows.Forms.Label();
            this.button_start_alarm = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_current_time = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label_call = new System.Windows.Forms.Label();
            this.label_call_time = new System.Windows.Forms.Label();
            this.textBox_times = new System.Windows.Forms.DateTimePicker();
            this.textBox_snooze = new System.Windows.Forms.DateTimePicker();
            this.label_call_minute = new System.Windows.Forms.Label();
            this.label_snooze = new System.Windows.Forms.Label();
            this.list_music = new System.Windows.Forms.ComboBox();
            this.button_play = new System.Windows.Forms.Button();
            this.button_stop = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button_about = new System.Windows.Forms.Button();
            this.button_minimize_maximize = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_close = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label_header_message_minute = new System.Windows.Forms.Label();
            this.label_header_hour = new System.Windows.Forms.Label();
            this.label_header_minute = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer_current_time
            // 
            this.timer_current_time.Interval = 500;
            this.timer_current_time.Tick += new System.EventHandler(this.timer_current_time_Tick);
            // 
            // timer_target_time
            // 
            this.timer_target_time.Interval = 500;
            this.timer_target_time.Tick += new System.EventHandler(this.timer_target_time_Tick);
            // 
            // radioButton_specify_time
            // 
            this.radioButton_specify_time.AutoSize = true;
            this.radioButton_specify_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_specify_time.ForeColor = System.Drawing.Color.Black;
            this.radioButton_specify_time.Location = new System.Drawing.Point(24, 12);
            this.radioButton_specify_time.Name = "radioButton_specify_time";
            this.radioButton_specify_time.Size = new System.Drawing.Size(99, 20);
            this.radioButton_specify_time.TabIndex = 4;
            this.radioButton_specify_time.TabStop = true;
            this.radioButton_specify_time.Text = "Specify time";
            this.radioButton_specify_time.UseVisualStyleBackColor = true;
            this.radioButton_specify_time.CheckedChanged += new System.EventHandler(this.radioButton_specify_time_CheckedChanged);
            this.radioButton_specify_time.MouseEnter += new System.EventHandler(this.radioButton_specify_time_MouseEnter);
            this.radioButton_specify_time.MouseLeave += new System.EventHandler(this.radioButton_specify_time_MouseLeave);
            // 
            // radioButton_from_now
            // 
            this.radioButton_from_now.AutoSize = true;
            this.radioButton_from_now.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_from_now.ForeColor = System.Drawing.Color.Black;
            this.radioButton_from_now.Location = new System.Drawing.Point(23, 98);
            this.radioButton_from_now.Name = "radioButton_from_now";
            this.radioButton_from_now.Size = new System.Drawing.Size(84, 20);
            this.radioButton_from_now.TabIndex = 5;
            this.radioButton_from_now.TabStop = true;
            this.radioButton_from_now.Text = "From now";
            this.radioButton_from_now.UseVisualStyleBackColor = true;
            this.radioButton_from_now.CheckedChanged += new System.EventHandler(this.radioButton_from_now_CheckedChanged);
            this.radioButton_from_now.MouseEnter += new System.EventHandler(this.radioButton_from_now_MouseEnter);
            this.radioButton_from_now.MouseLeave += new System.EventHandler(this.radioButton_from_now_MouseLeave);
            // 
            // button_minimize
            // 
            this.button_minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_minimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(89)))), ((int)(((byte)(71)))));
            this.button_minimize.FlatAppearance.BorderSize = 0;
            this.button_minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_minimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_minimize.ForeColor = System.Drawing.Color.White;
            this.button_minimize.Location = new System.Drawing.Point(499, 3);
            this.button_minimize.Name = "button_minimize";
            this.button_minimize.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button_minimize.Size = new System.Drawing.Size(48, 36);
            this.button_minimize.TabIndex = 14;
            this.button_minimize.Text = "−";
            this.button_minimize.UseVisualStyleBackColor = false;
            this.button_minimize.Click += new System.EventHandler(this.button_minimize_Click);
            // 
            // label_header_message_right
            // 
            this.label_header_message_right.AutoSize = true;
            this.label_header_message_right.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_header_message_right.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(204)))), ((int)(((byte)(123)))));
            this.label_header_message_right.Location = new System.Drawing.Point(164, 51);
            this.label_header_message_right.Name = "label_header_message_right";
            this.label_header_message_right.Size = new System.Drawing.Size(19, 24);
            this.label_header_message_right.TabIndex = 12;
            this.label_header_message_right.Text = "s";
            // 
            // label_header_message_left
            // 
            this.label_header_message_left.AutoSize = true;
            this.label_header_message_left.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_header_message_left.ForeColor = System.Drawing.Color.White;
            this.label_header_message_left.Location = new System.Drawing.Point(9, 55);
            this.label_header_message_left.Name = "label_header_message_left";
            this.label_header_message_left.Size = new System.Drawing.Size(160, 18);
            this.label_header_message_left.TabIndex = 9;
            this.label_header_message_left.Text = "The alarm will go off at ";
            // 
            // label_header
            // 
            this.label_header.AutoSize = true;
            this.label_header.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_header.ForeColor = System.Drawing.Color.White;
            this.label_header.Location = new System.Drawing.Point(41, 8);
            this.label_header.Name = "label_header";
            this.label_header.Size = new System.Drawing.Size(112, 24);
            this.label_header.TabIndex = 8;
            this.label_header.Text = "Smart Alarm";
            // 
            // target_date
            // 
            this.target_date.CustomFormat = "mm:dd:yyyy";
            this.target_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.target_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.target_date.Location = new System.Drawing.Point(42, 38);
            this.target_date.Name = "target_date";
            this.target_date.Size = new System.Drawing.Size(126, 24);
            this.target_date.TabIndex = 8;
            this.target_date.Value = new System.DateTime(2021, 3, 4, 0, 0, 0, 0);
            this.target_date.ValueChanged += new System.EventHandler(this.target_date_ValueChanged);
            // 
            // target_time
            // 
            this.target_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.target_time.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.target_time.Location = new System.Drawing.Point(174, 38);
            this.target_time.Name = "target_time";
            this.target_time.ShowUpDown = true;
            this.target_time.Size = new System.Drawing.Size(101, 24);
            this.target_time.TabIndex = 9;
            this.target_time.Value = new System.DateTime(2021, 3, 28, 12, 34, 0, 0);
            this.target_time.ValueChanged += new System.EventHandler(this.target_time_ValueChanged);
            // 
            // from_now_hour
            // 
            this.from_now_hour.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.from_now_hour.CustomFormat = "H";
            this.from_now_hour.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.from_now_hour.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.from_now_hour.Location = new System.Drawing.Point(42, 124);
            this.from_now_hour.Name = "from_now_hour";
            this.from_now_hour.ShowUpDown = true;
            this.from_now_hour.Size = new System.Drawing.Size(65, 24);
            this.from_now_hour.TabIndex = 10;
            this.from_now_hour.Value = new System.DateTime(2021, 3, 28, 2, 0, 0, 0);
            this.from_now_hour.ValueChanged += new System.EventHandler(this.from_now_hour_ValueChanged);
            // 
            // from_now_minute
            // 
            this.from_now_minute.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.from_now_minute.CustomFormat = "m";
            this.from_now_minute.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.from_now_minute.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.from_now_minute.Location = new System.Drawing.Point(174, 124);
            this.from_now_minute.MaxDate = new System.DateTime(2021, 3, 28, 12, 59, 0, 0);
            this.from_now_minute.Name = "from_now_minute";
            this.from_now_minute.ShowUpDown = true;
            this.from_now_minute.Size = new System.Drawing.Size(53, 24);
            this.from_now_minute.TabIndex = 11;
            this.from_now_minute.Value = new System.DateTime(2021, 3, 28, 0, 0, 0, 0);
            this.from_now_minute.ValueChanged += new System.EventHandler(this.from_now_minute_ValueChanged);
            // 
            // label_hour
            // 
            this.label_hour.AutoSize = true;
            this.label_hour.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_hour.Location = new System.Drawing.Point(113, 130);
            this.label_hour.Name = "label_hour";
            this.label_hour.Size = new System.Drawing.Size(52, 16);
            this.label_hour.TabIndex = 12;
            this.label_hour.Text = "Hour(s)";
            // 
            // label_minute
            // 
            this.label_minute.AutoSize = true;
            this.label_minute.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_minute.Location = new System.Drawing.Point(233, 131);
            this.label_minute.Name = "label_minute";
            this.label_minute.Size = new System.Drawing.Size(62, 16);
            this.label_minute.TabIndex = 13;
            this.label_minute.Text = "Minute(s)";
            // 
            // button_start_alarm
            // 
            this.button_start_alarm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_start_alarm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(166)))), ((int)(((byte)(133)))));
            this.button_start_alarm.FlatAppearance.BorderSize = 0;
            this.button_start_alarm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_start_alarm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_start_alarm.ForeColor = System.Drawing.Color.White;
            this.button_start_alarm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_start_alarm.Location = new System.Drawing.Point(526, 229);
            this.button_start_alarm.Name = "button_start_alarm";
            this.button_start_alarm.Size = new System.Drawing.Size(102, 40);
            this.button_start_alarm.TabIndex = 3;
            this.button_start_alarm.Text = "Start alarm";
            this.button_start_alarm.UseVisualStyleBackColor = false;
            this.button_start_alarm.Click += new System.EventHandler(this.button_start_alarm_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label_current_time);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(5, 88);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(641, 27);
            this.panel2.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(309, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 18);
            this.label6.TabIndex = 17;
            this.label6.Text = "Additional";
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(301, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1, 457);
            this.label3.TabIndex = 16;
            // 
            // label_current_time
            // 
            this.label_current_time.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label_current_time.AutoSize = true;
            this.label_current_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_current_time.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(89)))), ((int)(((byte)(71)))));
            this.label_current_time.Location = new System.Drawing.Point(497, 3);
            this.label_current_time.Name = "label_current_time";
            this.label_current_time.Size = new System.Drawing.Size(24, 18);
            this.label_current_time.TabIndex = 1;
            this.label_current_time.Text = "ss";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Time";
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(301, -2);
            this.label5.Margin = new System.Windows.Forms.Padding(0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(1, 2000);
            this.label5.TabIndex = 16;
            // 
            // label_call
            // 
            this.label_call.AutoSize = true;
            this.label_call.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_call.Location = new System.Drawing.Point(308, 14);
            this.label_call.Name = "label_call";
            this.label_call.Size = new System.Drawing.Size(33, 18);
            this.label_call.TabIndex = 17;
            this.label_call.Text = "Call";
            // 
            // label_call_time
            // 
            this.label_call_time.AutoSize = true;
            this.label_call_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_call_time.Location = new System.Drawing.Point(406, 43);
            this.label_call_time.Name = "label_call_time";
            this.label_call_time.Size = new System.Drawing.Size(59, 18);
            this.label_call_time.TabIndex = 18;
            this.label_call_time.Text = "Time(s)";
            // 
            // textBox_times
            // 
            this.textBox_times.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_times.CustomFormat = "m";
            this.textBox_times.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_times.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.textBox_times.Location = new System.Drawing.Point(347, 38);
            this.textBox_times.MaxDate = new System.DateTime(2021, 3, 28, 12, 59, 0, 0);
            this.textBox_times.Name = "textBox_times";
            this.textBox_times.ShowUpDown = true;
            this.textBox_times.Size = new System.Drawing.Size(53, 24);
            this.textBox_times.TabIndex = 19;
            this.textBox_times.Value = new System.DateTime(2021, 3, 28, 12, 1, 0, 0);
            // 
            // textBox_snooze
            // 
            this.textBox_snooze.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_snooze.CustomFormat = "m";
            this.textBox_snooze.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_snooze.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.textBox_snooze.Location = new System.Drawing.Point(347, 118);
            this.textBox_snooze.MaxDate = new System.DateTime(2021, 3, 28, 12, 59, 0, 0);
            this.textBox_snooze.Name = "textBox_snooze";
            this.textBox_snooze.ShowUpDown = true;
            this.textBox_snooze.Size = new System.Drawing.Size(53, 24);
            this.textBox_snooze.TabIndex = 20;
            this.textBox_snooze.Value = new System.DateTime(2021, 3, 28, 12, 5, 0, 0);
            // 
            // label_call_minute
            // 
            this.label_call_minute.AutoSize = true;
            this.label_call_minute.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_call_minute.Location = new System.Drawing.Point(406, 123);
            this.label_call_minute.Name = "label_call_minute";
            this.label_call_minute.Size = new System.Drawing.Size(70, 18);
            this.label_call_minute.TabIndex = 21;
            this.label_call_minute.Text = "Minute(s)";
            // 
            // label_snooze
            // 
            this.label_snooze.AutoSize = true;
            this.label_snooze.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_snooze.Location = new System.Drawing.Point(305, 91);
            this.label_snooze.Name = "label_snooze";
            this.label_snooze.Size = new System.Drawing.Size(60, 18);
            this.label_snooze.TabIndex = 22;
            this.label_snooze.Text = "Snooze";
            // 
            // list_music
            // 
            this.list_music.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_music.FormattingEnabled = true;
            this.list_music.Items.AddRange(new object[] {
            "Default",
            "Soft Alarm 1",
            "Soft Alarm 2",
            "Soft Alarm 3"});
            this.list_music.Location = new System.Drawing.Point(24, 188);
            this.list_music.Name = "list_music";
            this.list_music.Size = new System.Drawing.Size(130, 26);
            this.list_music.TabIndex = 23;
            // 
            // button_play
            // 
            this.button_play.Location = new System.Drawing.Point(192, 169);
            this.button_play.Name = "button_play";
            this.button_play.Size = new System.Drawing.Size(83, 26);
            this.button_play.TabIndex = 24;
            this.button_play.Text = "Play";
            this.button_play.UseVisualStyleBackColor = true;
            this.button_play.Click += new System.EventHandler(this.button_play_Click);
            // 
            // button_stop
            // 
            this.button_stop.Location = new System.Drawing.Point(192, 212);
            this.button_stop.Name = "button_stop";
            this.button_stop.Size = new System.Drawing.Size(83, 26);
            this.button_stop.TabIndex = 25;
            this.button_stop.Text = "Stop";
            this.button_stop.UseVisualStyleBackColor = true;
            this.button_stop.Click += new System.EventHandler(this.button_stop_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.Controls.Add(this.button_play);
            this.panel3.Controls.Add(this.radioButton_specify_time);
            this.panel3.Controls.Add(this.button_stop);
            this.panel3.Controls.Add(this.button_start_alarm);
            this.panel3.Controls.Add(this.radioButton_from_now);
            this.panel3.Controls.Add(this.target_date);
            this.panel3.Controls.Add(this.list_music);
            this.panel3.Controls.Add(this.target_time);
            this.panel3.Controls.Add(this.label_snooze);
            this.panel3.Controls.Add(this.from_now_hour);
            this.panel3.Controls.Add(this.label_call_minute);
            this.panel3.Controls.Add(this.from_now_minute);
            this.panel3.Controls.Add(this.textBox_snooze);
            this.panel3.Controls.Add(this.label_hour);
            this.panel3.Controls.Add(this.textBox_times);
            this.panel3.Controls.Add(this.label_minute);
            this.panel3.Controls.Add(this.label_call_time);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label_call);
            this.panel3.Location = new System.Drawing.Point(5, 115);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(641, 280);
            this.panel3.TabIndex = 27;
            // 
            // button_about
            // 
            this.button_about.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_about.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(89)))), ((int)(((byte)(71)))));
            this.button_about.FlatAppearance.BorderSize = 0;
            this.button_about.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_about.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_about.ForeColor = System.Drawing.Color.White;
            this.button_about.Image = ((System.Drawing.Image)(resources.GetObject("button_about.Image")));
            this.button_about.Location = new System.Drawing.Point(450, 3);
            this.button_about.Name = "button_about";
            this.button_about.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button_about.Size = new System.Drawing.Size(48, 36);
            this.button_about.TabIndex = 17;
            this.button_about.UseVisualStyleBackColor = false;
            this.button_about.Click += new System.EventHandler(this.button_about_Click);
            // 
            // button_minimize_maximize
            // 
            this.button_minimize_maximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_minimize_maximize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(89)))), ((int)(((byte)(71)))));
            this.button_minimize_maximize.FlatAppearance.BorderSize = 0;
            this.button_minimize_maximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_minimize_maximize.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_minimize_maximize.ForeColor = System.Drawing.Color.White;
            this.button_minimize_maximize.Image = ((System.Drawing.Image)(resources.GetObject("button_minimize_maximize.Image")));
            this.button_minimize_maximize.Location = new System.Drawing.Point(548, 3);
            this.button_minimize_maximize.Name = "button_minimize_maximize";
            this.button_minimize_maximize.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button_minimize_maximize.Size = new System.Drawing.Size(48, 36);
            this.button_minimize_maximize.TabIndex = 15;
            this.button_minimize_maximize.UseVisualStyleBackColor = false;
            this.button_minimize_maximize.Click += new System.EventHandler(this.button_minimize_maximize_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(23, 23);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // button_close
            // 
            this.button_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(89)))), ((int)(((byte)(71)))));
            this.button_close.FlatAppearance.BorderSize = 0;
            this.button_close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.button_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_close.ForeColor = System.Drawing.Color.White;
            this.button_close.Image = global::SimpleAlarm.Properties.Resources.close;
            this.button_close.Location = new System.Drawing.Point(597, 3);
            this.button_close.Name = "button_close";
            this.button_close.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button_close.Size = new System.Drawing.Size(48, 36);
            this.button_close.TabIndex = 13;
            this.button_close.UseVisualStyleBackColor = false;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(89)))), ((int)(((byte)(71)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::SimpleAlarm.Properties.Resources.info;
            this.button1.Location = new System.Drawing.Point(401, 3);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button1.Size = new System.Drawing.Size(48, 36);
            this.button1.TabIndex = 28;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label_header_message_minute
            // 
            this.label_header_message_minute.AutoSize = true;
            this.label_header_message_minute.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_header_message_minute.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(204)))), ((int)(((byte)(123)))));
            this.label_header_message_minute.Location = new System.Drawing.Point(273, 51);
            this.label_header_message_minute.Name = "label_header_message_minute";
            this.label_header_message_minute.Size = new System.Drawing.Size(19, 24);
            this.label_header_message_minute.TabIndex = 29;
            this.label_header_message_minute.Text = "s";
            this.label_header_message_minute.Visible = false;
            // 
            // label_header_hour
            // 
            this.label_header_hour.AutoSize = true;
            this.label_header_hour.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_header_hour.ForeColor = System.Drawing.Color.White;
            this.label_header_hour.Location = new System.Drawing.Point(189, 57);
            this.label_header_hour.Name = "label_header_hour";
            this.label_header_hour.Size = new System.Drawing.Size(78, 16);
            this.label_header_hour.TabIndex = 30;
            this.label_header_hour.Text = "hour(s) and ";
            this.label_header_hour.Visible = false;
            // 
            // label_header_minute
            // 
            this.label_header_minute.AutoSize = true;
            this.label_header_minute.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_header_minute.ForeColor = System.Drawing.Color.White;
            this.label_header_minute.Location = new System.Drawing.Point(305, 57);
            this.label_header_minute.Name = "label_header_minute";
            this.label_header_minute.Size = new System.Drawing.Size(65, 16);
            this.label_header_minute.TabIndex = 31;
            this.label_header_minute.Text = "minute(s).";
            this.label_header_minute.Visible = false;
            // 
            // SmartAlarm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(89)))), ((int)(((byte)(71)))));
            this.ClientSize = new System.Drawing.Size(650, 400);
            this.Controls.Add(this.label_header_minute);
            this.Controls.Add(this.label_header_hour);
            this.Controls.Add(this.label_header_message_minute);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_about);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button_minimize_maximize);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label_header_message_left);
            this.Controls.Add(this.label_header);
            this.Controls.Add(this.label_header_message_right);
            this.Controls.Add(this.button_minimize);
            this.Controls.Add(this.button_close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(16, 310);
            this.Name = "SmartAlarm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wise Alarm";
            this.Load += new System.EventHandler(this.simple_alarm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SmartAlarm_MouseDown);
            this.Move += new System.EventHandler(this.simple_alarm_Move);
            this.Resize += new System.EventHandler(this.simple_alarm_Resize);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_start_alarm;
        private System.Windows.Forms.Timer timer_current_time;
        private System.Windows.Forms.Timer timer_target_time;
        private System.Windows.Forms.RadioButton radioButton_specify_time;
        private System.Windows.Forms.RadioButton radioButton_from_now;
        private System.Windows.Forms.Label label_header;
        private System.Windows.Forms.Label label_header_message_left;
        private System.Windows.Forms.DateTimePicker target_date;
        private System.Windows.Forms.DateTimePicker target_time;
        private System.Windows.Forms.DateTimePicker from_now_hour;
        private System.Windows.Forms.DateTimePicker from_now_minute;
        private System.Windows.Forms.Label label_hour;
        private System.Windows.Forms.Label label_minute;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_header_message_right;
        private System.Windows.Forms.Label label_current_time;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.Button button_minimize;
        private System.Windows.Forms.Button button_minimize_maximize;
        private System.Windows.Forms.Label label_call;
        private System.Windows.Forms.Label label_call_time;
        private System.Windows.Forms.DateTimePicker textBox_times;
        private System.Windows.Forms.DateTimePicker textBox_snooze;
        private System.Windows.Forms.Label label_call_minute;
        private System.Windows.Forms.Label label_snooze;
        private System.Windows.Forms.ComboBox list_music;
        private System.Windows.Forms.Button button_play;
        private System.Windows.Forms.Button button_stop;
        private System.Windows.Forms.Button button_about;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label_header_message_minute;
        private System.Windows.Forms.Label label_header_hour;
        private System.Windows.Forms.Label label_header_minute;
    }
}

