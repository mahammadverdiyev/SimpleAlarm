
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_minimize_maximize = new System.Windows.Forms.Button();
            this.button_minimize = new System.Windows.Forms.Button();
            this.button_close = new System.Windows.Forms.Button();
            this.label_header_message_right = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
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
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_times = new System.Windows.Forms.DateTimePicker();
            this.textBox_snooze = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
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
            this.radioButton_specify_time.Location = new System.Drawing.Point(25, 129);
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
            this.radioButton_from_now.Location = new System.Drawing.Point(24, 215);
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
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(89)))), ((int)(((byte)(71)))));
            this.panel1.Controls.Add(this.button_minimize_maximize);
            this.panel1.Controls.Add(this.button_minimize);
            this.panel1.Controls.Add(this.button_close);
            this.panel1.Controls.Add(this.label_header_message_right);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label_header_message_left);
            this.panel1.Controls.Add(this.label_header);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(701, 88);
            this.panel1.TabIndex = 6;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
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
            this.button_minimize_maximize.Location = new System.Drawing.Point(601, 3);
            this.button_minimize_maximize.Name = "button_minimize_maximize";
            this.button_minimize_maximize.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button_minimize_maximize.Size = new System.Drawing.Size(48, 36);
            this.button_minimize_maximize.TabIndex = 15;
            this.button_minimize_maximize.UseVisualStyleBackColor = false;
            this.button_minimize_maximize.Click += new System.EventHandler(this.button_minimize_maximize_Click);
            // 
            // button_minimize
            // 
            this.button_minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_minimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(89)))), ((int)(((byte)(71)))));
            this.button_minimize.FlatAppearance.BorderSize = 0;
            this.button_minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_minimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_minimize.ForeColor = System.Drawing.Color.White;
            this.button_minimize.Location = new System.Drawing.Point(552, 3);
            this.button_minimize.Name = "button_minimize";
            this.button_minimize.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button_minimize.Size = new System.Drawing.Size(48, 36);
            this.button_minimize.TabIndex = 14;
            this.button_minimize.Text = "−";
            this.button_minimize.UseVisualStyleBackColor = false;
            this.button_minimize.Click += new System.EventHandler(this.button_minimize_Click);
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
            this.button_close.Location = new System.Drawing.Point(650, 3);
            this.button_close.Name = "button_close";
            this.button_close.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button_close.Size = new System.Drawing.Size(48, 36);
            this.button_close.TabIndex = 13;
            this.button_close.UseVisualStyleBackColor = false;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // label_header_message_right
            // 
            this.label_header_message_right.AutoSize = true;
            this.label_header_message_right.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_header_message_right.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(204)))), ((int)(((byte)(123)))));
            this.label_header_message_right.Location = new System.Drawing.Point(178, 52);
            this.label_header_message_right.Name = "label_header_message_right";
            this.label_header_message_right.Size = new System.Drawing.Size(19, 24);
            this.label_header_message_right.TabIndex = 12;
            this.label_header_message_right.Text = "s";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(15, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(23, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // label_header_message_left
            // 
            this.label_header_message_left.AutoSize = true;
            this.label_header_message_left.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_header_message_left.ForeColor = System.Drawing.Color.White;
            this.label_header_message_left.Location = new System.Drawing.Point(12, 56);
            this.label_header_message_left.Name = "label_header_message_left";
            this.label_header_message_left.Size = new System.Drawing.Size(160, 18);
            this.label_header_message_left.TabIndex = 9;
            this.label_header_message_left.Text = "The alarm will go off at ";
            // 
            // label_header
            // 
            this.label_header.AutoSize = true;
            this.label_header.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_header.ForeColor = System.Drawing.Color.White;
            this.label_header.Location = new System.Drawing.Point(44, 13);
            this.label_header.Name = "label_header";
            this.label_header.Size = new System.Drawing.Size(103, 20);
            this.label_header.TabIndex = 8;
            this.label_header.Text = "Smart Alarm";
            // 
            // target_date
            // 
            this.target_date.CustomFormat = "mm:dd:yyyy";
            this.target_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.target_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.target_date.Location = new System.Drawing.Point(43, 155);
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
            this.target_time.Location = new System.Drawing.Point(175, 155);
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
            this.from_now_hour.Location = new System.Drawing.Point(43, 241);
            this.from_now_hour.Name = "from_now_hour";
            this.from_now_hour.ShowUpDown = true;
            this.from_now_hour.Size = new System.Drawing.Size(65, 24);
            this.from_now_hour.TabIndex = 10;
            this.from_now_hour.Value = new System.DateTime(2021, 3, 28, 2, 0, 0, 0);
            // 
            // from_now_minute
            // 
            this.from_now_minute.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.from_now_minute.CustomFormat = "m";
            this.from_now_minute.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.from_now_minute.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.from_now_minute.Location = new System.Drawing.Point(175, 241);
            this.from_now_minute.MaxDate = new System.DateTime(2021, 3, 28, 12, 59, 0, 0);
            this.from_now_minute.Name = "from_now_minute";
            this.from_now_minute.ShowUpDown = true;
            this.from_now_minute.Size = new System.Drawing.Size(53, 24);
            this.from_now_minute.TabIndex = 11;
            this.from_now_minute.Value = new System.DateTime(2021, 3, 28, 0, 0, 0, 0);
            // 
            // label_hour
            // 
            this.label_hour.AutoSize = true;
            this.label_hour.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_hour.Location = new System.Drawing.Point(114, 247);
            this.label_hour.Name = "label_hour";
            this.label_hour.Size = new System.Drawing.Size(52, 16);
            this.label_hour.TabIndex = 12;
            this.label_hour.Text = "Hour(s)";
            // 
            // label_minute
            // 
            this.label_minute.AutoSize = true;
            this.label_minute.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_minute.Location = new System.Drawing.Point(234, 248);
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
            this.button_start_alarm.Location = new System.Drawing.Point(586, 388);
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
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label_current_time);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(0, 88);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(701, 27);
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
            this.label3.Location = new System.Drawing.Point(302, 0);
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
            this.label_current_time.Location = new System.Drawing.Point(557, 3);
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
            this.label5.Location = new System.Drawing.Point(302, 115);
            this.label5.Margin = new System.Windows.Forms.Padding(0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(1, 2000);
            this.label5.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(309, 131);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 18);
            this.label7.TabIndex = 17;
            this.label7.Text = "Call";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(407, 160);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 18);
            this.label8.TabIndex = 18;
            this.label8.Text = "Time(s)";
            // 
            // textBox_times
            // 
            this.textBox_times.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_times.CustomFormat = "m";
            this.textBox_times.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_times.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.textBox_times.Location = new System.Drawing.Point(348, 155);
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
            this.textBox_snooze.Location = new System.Drawing.Point(348, 235);
            this.textBox_snooze.MaxDate = new System.DateTime(2021, 3, 28, 12, 59, 0, 0);
            this.textBox_snooze.Name = "textBox_snooze";
            this.textBox_snooze.ShowUpDown = true;
            this.textBox_snooze.Size = new System.Drawing.Size(53, 24);
            this.textBox_snooze.TabIndex = 20;
            this.textBox_snooze.Value = new System.DateTime(2021, 3, 28, 12, 5, 0, 0);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(407, 240);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 18);
            this.label9.TabIndex = 21;
            this.label9.Text = "Minute(s)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(306, 208);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 18);
            this.label10.TabIndex = 22;
            this.label10.Text = "Snooze";
            // 
            // SmartAlarm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(700, 440);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox_snooze);
            this.Controls.Add(this.textBox_times);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label_minute);
            this.Controls.Add(this.label_hour);
            this.Controls.Add(this.from_now_minute);
            this.Controls.Add(this.from_now_hour);
            this.Controls.Add(this.target_time);
            this.Controls.Add(this.target_date);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.radioButton_from_now);
            this.Controls.Add(this.radioButton_specify_time);
            this.Controls.Add(this.button_start_alarm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(16, 310);
            this.Name = "SmartAlarm";
            this.Text = "Wise Alarm";
            this.Load += new System.EventHandler(this.simple_alarm_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.simple_alarm_MouseMove);
            this.Move += new System.EventHandler(this.simple_alarm_Move);
            this.Resize += new System.EventHandler(this.simple_alarm_Resize);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_start_alarm;
        private System.Windows.Forms.Timer timer_current_time;
        private System.Windows.Forms.Timer timer_target_time;
        private System.Windows.Forms.RadioButton radioButton_specify_time;
        private System.Windows.Forms.RadioButton radioButton_from_now;
        private System.Windows.Forms.Panel panel1;
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
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker textBox_times;
        private System.Windows.Forms.DateTimePicker textBox_snooze;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}

