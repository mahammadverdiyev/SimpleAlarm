
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
			this.currentTimeTimer = new System.Windows.Forms.Timer(this.components);
			this.targetTimeTimer = new System.Windows.Forms.Timer(this.components);
			this.specifyTimeRadioButton = new System.Windows.Forms.RadioButton();
			this.fromNowRadioButton = new System.Windows.Forms.RadioButton();
			this.minimizeButton = new System.Windows.Forms.Button();
			this.headerMessageRightLabel = new System.Windows.Forms.Label();
			this.headerMessageLefPartLabel = new System.Windows.Forms.Label();
			this.label_header = new System.Windows.Forms.Label();
			this.targetDateTimePicker = new System.Windows.Forms.DateTimePicker();
			this.targetTimeDateTimePicker = new System.Windows.Forms.DateTimePicker();
			this.fromNowHourLabel = new System.Windows.Forms.Label();
			this.fromNowMinuteLabel = new System.Windows.Forms.Label();
			this.startAlarmButton_alarm = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label6 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.currentTimeLabel = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.callLabel = new System.Windows.Forms.Label();
			this.callTimesLabel = new System.Windows.Forms.Label();
			this.alarmAmountToCallNumericUpDown = new System.Windows.Forms.DateTimePicker();
			this.snoozeTextBox = new System.Windows.Forms.DateTimePicker();
			this.callMinuteLabel = new System.Windows.Forms.Label();
			this.snoozeLabel = new System.Windows.Forms.Label();
			this.musicListComboBox = new System.Windows.Forms.ComboBox();
			this.playMusicButton = new System.Windows.Forms.Button();
			this.stopMusicButton = new System.Windows.Forms.Button();
			this.panel3 = new System.Windows.Forms.Panel();
			this.cancelAlarmButton = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label_message = new System.Windows.Forms.Label();
			this.messageTextBox = new System.Windows.Forms.TextBox();
			this.difficultyComboBox = new System.Windows.Forms.ComboBox();
			this.label_difficulty = new System.Windows.Forms.Label();
			this.label_duration_value = new System.Windows.Forms.Label();
			this.label_duration = new System.Windows.Forms.Label();
			this.button_about = new System.Windows.Forms.Button();
			this.minimizeMaximizeButton = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.closeButton = new System.Windows.Forms.Button();
			this.displayInformationButton = new System.Windows.Forms.Button();
			this.headerMinuteMessageLabel = new System.Windows.Forms.Label();
			this.headerHourLabel = new System.Windows.Forms.Label();
			this.headerMinuteLabel = new System.Windows.Forms.Label();
			this.fromNowHourNumericUpDown = new System.Windows.Forms.DateTimePicker();
			this.fromNowMinuteNumericUpDown = new System.Windows.Forms.DateTimePicker();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// currentTimeTimer
			// 
			this.currentTimeTimer.Interval = 500;
			this.currentTimeTimer.Tick += new System.EventHandler(this.CurrentTimeTimer_Tick);
			// 
			// targetTimeTimer
			// 
			this.targetTimeTimer.Interval = 500;
			this.targetTimeTimer.Tick += new System.EventHandler(this.TargetTimeTimer_Tick);
			// 
			// specifyTimeRadioButton
			// 
			this.specifyTimeRadioButton.AutoSize = true;
			this.specifyTimeRadioButton.Checked = true;
			this.specifyTimeRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.specifyTimeRadioButton.ForeColor = System.Drawing.Color.Black;
			this.specifyTimeRadioButton.Location = new System.Drawing.Point(24, 15);
			this.specifyTimeRadioButton.Name = "specifyTimeRadioButton";
			this.specifyTimeRadioButton.Size = new System.Drawing.Size(99, 20);
			this.specifyTimeRadioButton.TabIndex = 4;
			this.specifyTimeRadioButton.TabStop = true;
			this.specifyTimeRadioButton.Text = "Specify time";
			this.specifyTimeRadioButton.UseVisualStyleBackColor = true;
			this.specifyTimeRadioButton.CheckedChanged += new System.EventHandler(this.SpecifyTimeRadioButton_CheckedChanged);
			this.specifyTimeRadioButton.MouseEnter += new System.EventHandler(this.SpecifyTimeRadioButton_MouseEnter);
			this.specifyTimeRadioButton.MouseLeave += new System.EventHandler(this.SpecifyTimeRadioButton_MouseLeave);
			// 
			// radioButton_from_now
			// 
			this.fromNowRadioButton.AutoSize = true;
			this.fromNowRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.fromNowRadioButton.ForeColor = System.Drawing.Color.Black;
			this.fromNowRadioButton.Location = new System.Drawing.Point(23, 86);
			this.fromNowRadioButton.Name = "radioButton_from_now";
			this.fromNowRadioButton.Size = new System.Drawing.Size(84, 20);
			this.fromNowRadioButton.TabIndex = 5;
			this.fromNowRadioButton.Text = "From now";
			this.fromNowRadioButton.UseVisualStyleBackColor = true;
			this.fromNowRadioButton.CheckedChanged += new System.EventHandler(this.FromNowRadioButton_CheckedChanged);
			this.fromNowRadioButton.MouseEnter += new System.EventHandler(this.FromNowRadioButton_MouseEnter);
			this.fromNowRadioButton.MouseLeave += new System.EventHandler(this.FromNowRadioButton_MouseLeave);
			// 
			// minimizeButton
			// 
			this.minimizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.minimizeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(89)))), ((int)(((byte)(71)))));
			this.minimizeButton.FlatAppearance.BorderSize = 0;
			this.minimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.minimizeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.minimizeButton.ForeColor = System.Drawing.Color.White;
			this.minimizeButton.Location = new System.Drawing.Point(539, 3);
			this.minimizeButton.Name = "minimizeButton";
			this.minimizeButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.minimizeButton.Size = new System.Drawing.Size(48, 36);
			this.minimizeButton.TabIndex = 14;
			this.minimizeButton.Text = "−";
			this.minimizeButton.UseVisualStyleBackColor = false;
			this.minimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
			// 
			// headerMessageRightLabel
			// 
			this.headerMessageRightLabel.AutoSize = true;
			this.headerMessageRightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.headerMessageRightLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(204)))), ((int)(((byte)(123)))));
			this.headerMessageRightLabel.Location = new System.Drawing.Point(164, 51);
			this.headerMessageRightLabel.Name = "headerMessageRightLabel";
			this.headerMessageRightLabel.Size = new System.Drawing.Size(19, 24);
			this.headerMessageRightLabel.TabIndex = 12;
			this.headerMessageRightLabel.Text = "s";
			// 
			// label_header_message_left
			// 
			this.headerMessageLefPartLabel.AutoSize = true;
			this.headerMessageLefPartLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.headerMessageLefPartLabel.ForeColor = System.Drawing.Color.White;
			this.headerMessageLefPartLabel.Location = new System.Drawing.Point(9, 55);
			this.headerMessageLefPartLabel.Name = "label_header_message_left";
			this.headerMessageLefPartLabel.Size = new System.Drawing.Size(160, 18);
			this.headerMessageLefPartLabel.TabIndex = 9;
			this.headerMessageLefPartLabel.Text = "The alarm will go off at ";
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
			// targetDateTimePicker
			// 
			this.targetDateTimePicker.CustomFormat = "mm:dd:yyyy";
			this.targetDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.targetDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.targetDateTimePicker.Location = new System.Drawing.Point(42, 41);
			this.targetDateTimePicker.Name = "targetDateTimePicker";
			this.targetDateTimePicker.Size = new System.Drawing.Size(126, 24);
			this.targetDateTimePicker.TabIndex = 8;
			this.targetDateTimePicker.Value = new System.DateTime(2021, 3, 4, 0, 0, 0, 0);
			this.targetDateTimePicker.ValueChanged += new System.EventHandler(this.TargetTimeOrDateNumericUpDown_ValueChanged);
			// 
			// targetTimeDateTimePicker
			// 
			this.targetTimeDateTimePicker.CustomFormat = "hh:mm:ss";
			this.targetTimeDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.targetTimeDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.targetTimeDateTimePicker.Location = new System.Drawing.Point(174, 41);
			this.targetTimeDateTimePicker.Name = "targetTimeDateTimePicker";
			this.targetTimeDateTimePicker.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.targetTimeDateTimePicker.ShowUpDown = true;
			this.targetTimeDateTimePicker.Size = new System.Drawing.Size(101, 24);
			this.targetTimeDateTimePicker.TabIndex = 9;
			this.targetTimeDateTimePicker.Value = new System.DateTime(2021, 3, 28, 12, 34, 0, 0);
			this.targetTimeDateTimePicker.ValueChanged += new System.EventHandler(this.TargetTimeOrDateNumericUpDown_ValueChanged);
			// 
			// label_hour
			// 
			this.fromNowHourLabel.AutoSize = true;
			this.fromNowHourLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.fromNowHourLabel.Location = new System.Drawing.Point(113, 118);
			this.fromNowHourLabel.Name = "label_hour";
			this.fromNowHourLabel.Size = new System.Drawing.Size(52, 16);
			this.fromNowHourLabel.TabIndex = 12;
			this.fromNowHourLabel.Text = "Hour(s)";
			// 
			// label_minute
			// 
			this.fromNowMinuteLabel.AutoSize = true;
			this.fromNowMinuteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.fromNowMinuteLabel.Location = new System.Drawing.Point(233, 119);
			this.fromNowMinuteLabel.Name = "label_minute";
			this.fromNowMinuteLabel.Size = new System.Drawing.Size(62, 16);
			this.fromNowMinuteLabel.TabIndex = 13;
			this.fromNowMinuteLabel.Text = "Minute(s)";
			// 
			// startAlarmButton_alarm
			// 
			this.startAlarmButton_alarm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.startAlarmButton_alarm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(166)))), ((int)(((byte)(133)))));
			this.startAlarmButton_alarm.FlatAppearance.BorderSize = 0;
			this.startAlarmButton_alarm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.startAlarmButton_alarm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.startAlarmButton_alarm.ForeColor = System.Drawing.Color.White;
			this.startAlarmButton_alarm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.startAlarmButton_alarm.Location = new System.Drawing.Point(312, 283);
			this.startAlarmButton_alarm.Name = "startAlarmButton_alarm";
			this.startAlarmButton_alarm.Size = new System.Drawing.Size(102, 40);
			this.startAlarmButton_alarm.TabIndex = 3;
			this.startAlarmButton_alarm.Text = "Start Alarm";
			this.startAlarmButton_alarm.UseVisualStyleBackColor = false;
			this.startAlarmButton_alarm.Click += new System.EventHandler(this.StartAlarmButton_Click);
			// 
			// panel2
			// 
			this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel2.BackColor = System.Drawing.Color.Gainsboro;
			this.panel2.Controls.Add(this.label6);
			this.panel2.Controls.Add(this.label3);
			this.panel2.Controls.Add(this.currentTimeLabel);
			this.panel2.Controls.Add(this.label4);
			this.panel2.Location = new System.Drawing.Point(5, 88);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(681, 27);
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
			// currentTimeLabel
			// 
			this.currentTimeLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.currentTimeLabel.AutoSize = true;
			this.currentTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.currentTimeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(89)))), ((int)(((byte)(71)))));
			this.currentTimeLabel.Location = new System.Drawing.Point(537, 3);
			this.currentTimeLabel.Name = "currentTimeLabel";
			this.currentTimeLabel.Size = new System.Drawing.Size(24, 18);
			this.currentTimeLabel.TabIndex = 1;
			this.currentTimeLabel.Text = "ss";
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
			this.label5.Location = new System.Drawing.Point(301, -13);
			this.label5.Margin = new System.Windows.Forms.Padding(0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(1, 2000);
			this.label5.TabIndex = 16;
			// 
			// label_call
			// 
			this.callLabel.AutoSize = true;
			this.callLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.callLabel.Location = new System.Drawing.Point(309, 15);
			this.callLabel.Name = "label_call";
			this.callLabel.Size = new System.Drawing.Size(33, 18);
			this.callLabel.TabIndex = 17;
			this.callLabel.Text = "Call";
			// 
			// label_call_time
			// 
			this.callTimesLabel.AutoSize = true;
			this.callTimesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.callTimesLabel.Location = new System.Drawing.Point(371, 47);
			this.callTimesLabel.Name = "label_call_time";
			this.callTimesLabel.Size = new System.Drawing.Size(59, 18);
			this.callTimesLabel.TabIndex = 18;
			this.callTimesLabel.Text = "Time(s)";
			// 
			// alarmAmountToCallNumericUpDown
			// 
			this.alarmAmountToCallNumericUpDown.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.alarmAmountToCallNumericUpDown.CustomFormat = "m";
			this.alarmAmountToCallNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.alarmAmountToCallNumericUpDown.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.alarmAmountToCallNumericUpDown.Location = new System.Drawing.Point(311, 41);
			this.alarmAmountToCallNumericUpDown.MaxDate = new System.DateTime(2021, 3, 28, 12, 59, 0, 0);
			this.alarmAmountToCallNumericUpDown.Name = "alarmAmountToCallNumericUpDown";
			this.alarmAmountToCallNumericUpDown.ShowUpDown = true;
			this.alarmAmountToCallNumericUpDown.Size = new System.Drawing.Size(53, 24);
			this.alarmAmountToCallNumericUpDown.TabIndex = 19;
			this.alarmAmountToCallNumericUpDown.Value = new System.DateTime(2021, 3, 28, 12, 1, 0, 0);
			// 
			// snoozeTextBox
			// 
			this.snoozeTextBox.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.snoozeTextBox.CustomFormat = "m";
			this.snoozeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.snoozeTextBox.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.snoozeTextBox.Location = new System.Drawing.Point(312, 110);
			this.snoozeTextBox.MaxDate = new System.DateTime(2021, 3, 28, 12, 59, 0, 0);
			this.snoozeTextBox.Name = "snoozeTextBox";
			this.snoozeTextBox.ShowUpDown = true;
			this.snoozeTextBox.Size = new System.Drawing.Size(53, 24);
			this.snoozeTextBox.TabIndex = 20;
			this.snoozeTextBox.Value = new System.DateTime(2021, 3, 28, 12, 5, 0, 0);
			// 
			// label_call_minute
			// 
			this.callMinuteLabel.AutoSize = true;
			this.callMinuteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.callMinuteLabel.Location = new System.Drawing.Point(371, 117);
			this.callMinuteLabel.Name = "label_call_minute";
			this.callMinuteLabel.Size = new System.Drawing.Size(70, 18);
			this.callMinuteLabel.TabIndex = 21;
			this.callMinuteLabel.Text = "Minute(s)";
			// 
			// label_snooze
			// 
			this.snoozeLabel.AutoSize = true;
			this.snoozeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.snoozeLabel.Location = new System.Drawing.Point(308, 86);
			this.snoozeLabel.Name = "label_snooze";
			this.snoozeLabel.Size = new System.Drawing.Size(60, 18);
			this.snoozeLabel.TabIndex = 22;
			this.snoozeLabel.Text = "Snooze";
			// 
			// musicListComboBox
			// 
			this.musicListComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.musicListComboBox.FormattingEnabled = true;
			this.musicListComboBox.Items.AddRange(new object[] {
            "Default",
            "Soft Alarm 1",
            "Soft Alarm 2",
            "Soft Alarm 3"});
			this.musicListComboBox.Location = new System.Drawing.Point(40, 176);
			this.musicListComboBox.Name = "musicListComboBox";
			this.musicListComboBox.Size = new System.Drawing.Size(151, 26);
			this.musicListComboBox.TabIndex = 23;
			this.musicListComboBox.SelectedIndexChanged += new System.EventHandler(this.MusicList_SelectedIndexChanged);
			// 
			// playMusicButton
			// 
			this.playMusicButton.Location = new System.Drawing.Point(40, 240);
			this.playMusicButton.Name = "playMusicButton";
			this.playMusicButton.Size = new System.Drawing.Size(83, 26);
			this.playMusicButton.TabIndex = 24;
			this.playMusicButton.Text = "Play";
			this.playMusicButton.UseVisualStyleBackColor = true;
			this.playMusicButton.Click += new System.EventHandler(this.PlayMusicButton_Click);
			// 
			// stopMusicButton
			// 
			this.stopMusicButton.Location = new System.Drawing.Point(152, 240);
			this.stopMusicButton.Name = "stopMusicButton";
			this.stopMusicButton.Size = new System.Drawing.Size(83, 26);
			this.stopMusicButton.TabIndex = 25;
			this.stopMusicButton.Text = "Stop";
			this.stopMusicButton.UseVisualStyleBackColor = true;
			this.stopMusicButton.Click += new System.EventHandler(this.StopMusic_Click);
			// 
			// panel3
			// 
			this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
			this.panel3.Controls.Add(this.fromNowMinuteNumericUpDown);
			this.panel3.Controls.Add(this.fromNowHourNumericUpDown);
			this.panel3.Controls.Add(this.cancelAlarmButton);
			this.panel3.Controls.Add(this.label1);
			this.panel3.Controls.Add(this.label_message);
			this.panel3.Controls.Add(this.messageTextBox);
			this.panel3.Controls.Add(this.difficultyComboBox);
			this.panel3.Controls.Add(this.label_difficulty);
			this.panel3.Controls.Add(this.label_duration_value);
			this.panel3.Controls.Add(this.label_duration);
			this.panel3.Controls.Add(this.playMusicButton);
			this.panel3.Controls.Add(this.specifyTimeRadioButton);
			this.panel3.Controls.Add(this.stopMusicButton);
			this.panel3.Controls.Add(this.startAlarmButton_alarm);
			this.panel3.Controls.Add(this.fromNowRadioButton);
			this.panel3.Controls.Add(this.targetDateTimePicker);
			this.panel3.Controls.Add(this.musicListComboBox);
			this.panel3.Controls.Add(this.targetTimeDateTimePicker);
			this.panel3.Controls.Add(this.snoozeLabel);
			this.panel3.Controls.Add(this.callMinuteLabel);
			this.panel3.Controls.Add(this.snoozeTextBox);
			this.panel3.Controls.Add(this.fromNowHourLabel);
			this.panel3.Controls.Add(this.alarmAmountToCallNumericUpDown);
			this.panel3.Controls.Add(this.fromNowMinuteLabel);
			this.panel3.Controls.Add(this.callTimesLabel);
			this.panel3.Controls.Add(this.label5);
			this.panel3.Controls.Add(this.callLabel);
			this.panel3.Location = new System.Drawing.Point(5, 115);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(681, 330);
			this.panel3.TabIndex = 27;
			// 
			// cancelAlarmButton
			// 
			this.cancelAlarmButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.cancelAlarmButton.BackColor = System.Drawing.Color.Red;
			this.cancelAlarmButton.FlatAppearance.BorderSize = 0;
			this.cancelAlarmButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cancelAlarmButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cancelAlarmButton.ForeColor = System.Drawing.Color.White;
			this.cancelAlarmButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.cancelAlarmButton.Location = new System.Drawing.Point(571, 283);
			this.cancelAlarmButton.Name = "cancelAlarmButton";
			this.cancelAlarmButton.Size = new System.Drawing.Size(102, 40);
			this.cancelAlarmButton.TabIndex = 33;
			this.cancelAlarmButton.Text = "Cancel Alarm";
			this.cancelAlarmButton.UseVisualStyleBackColor = false;
			this.cancelAlarmButton.Click += new System.EventHandler(this.CancelAlarmButton_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(39, 149);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(48, 18);
			this.label1.TabIndex = 32;
			this.label1.Text = "Music";
			// 
			// label_message
			// 
			this.label_message.AutoSize = true;
			this.label_message.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_message.Location = new System.Drawing.Point(308, 217);
			this.label_message.Name = "label_message";
			this.label_message.Size = new System.Drawing.Size(135, 18);
			this.label_message.TabIndex = 31;
			this.label_message.Text = "Message (optional)";
			// 
			// messageTextBox
			// 
			this.messageTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.messageTextBox.Location = new System.Drawing.Point(311, 242);
			this.messageTextBox.Name = "messageTextBox";
			this.messageTextBox.Size = new System.Drawing.Size(251, 24);
			this.messageTextBox.TabIndex = 30;
			// 
			// difficultyComboBox
			// 
			this.difficultyComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.difficultyComboBox.FormattingEnabled = true;
			this.difficultyComboBox.Items.AddRange(new object[] {
            "Easy",
            "Medium",
            "Hard"});
			this.difficultyComboBox.Location = new System.Drawing.Point(312, 176);
			this.difficultyComboBox.Name = "difficultyComboBox";
			this.difficultyComboBox.Size = new System.Drawing.Size(87, 26);
			this.difficultyComboBox.TabIndex = 29;
			this.difficultyComboBox.Text = "Easy";
			// 
			// label_difficulty
			// 
			this.label_difficulty.AutoSize = true;
			this.label_difficulty.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_difficulty.Location = new System.Drawing.Point(308, 149);
			this.label_difficulty.Name = "label_difficulty";
			this.label_difficulty.Size = new System.Drawing.Size(156, 18);
			this.label_difficulty.TabIndex = 28;
			this.label_difficulty.Text = "Difficulty of expression";
			// 
			// label_duration_value
			// 
			this.label_duration_value.AutoSize = true;
			this.label_duration_value.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_duration_value.Location = new System.Drawing.Point(96, 205);
			this.label_duration_value.Name = "label_duration_value";
			this.label_duration_value.Size = new System.Drawing.Size(27, 13);
			this.label_duration_value.TabIndex = 27;
			this.label_duration_value.Text = "29 s";
			// 
			// label_duration
			// 
			this.label_duration.AutoSize = true;
			this.label_duration.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_duration.Location = new System.Drawing.Point(40, 205);
			this.label_duration.Name = "label_duration";
			this.label_duration.Size = new System.Drawing.Size(50, 13);
			this.label_duration.TabIndex = 26;
			this.label_duration.Text = "Duration:";
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
			this.button_about.Location = new System.Drawing.Point(490, 3);
			this.button_about.Name = "button_about";
			this.button_about.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.button_about.Size = new System.Drawing.Size(48, 36);
			this.button_about.TabIndex = 17;
			this.button_about.UseVisualStyleBackColor = false;
			this.button_about.Click += new System.EventHandler(this.AboutButton_Click);
			// 
			// minimizeMaximizeButton
			// 
			this.minimizeMaximizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.minimizeMaximizeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(89)))), ((int)(((byte)(71)))));
			this.minimizeMaximizeButton.FlatAppearance.BorderSize = 0;
			this.minimizeMaximizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.minimizeMaximizeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.minimizeMaximizeButton.ForeColor = System.Drawing.Color.White;
			this.minimizeMaximizeButton.Image = ((System.Drawing.Image)(resources.GetObject("minimizeMaximizeButton.Image")));
			this.minimizeMaximizeButton.Location = new System.Drawing.Point(588, 3);
			this.minimizeMaximizeButton.Name = "minimizeMaximizeButton";
			this.minimizeMaximizeButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.minimizeMaximizeButton.Size = new System.Drawing.Size(48, 36);
			this.minimizeMaximizeButton.TabIndex = 15;
			this.minimizeMaximizeButton.UseVisualStyleBackColor = false;
			this.minimizeMaximizeButton.Click += new System.EventHandler(this.MinimizeMaximizeButton_Click);
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
			// closeButton
			// 
			this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.closeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(89)))), ((int)(((byte)(71)))));
			this.closeButton.FlatAppearance.BorderSize = 0;
			this.closeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
			this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.closeButton.ForeColor = System.Drawing.Color.White;
			this.closeButton.Image = global::SimpleAlarm.Properties.Resources.close;
			this.closeButton.Location = new System.Drawing.Point(637, 3);
			this.closeButton.Name = "closeButton";
			this.closeButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.closeButton.Size = new System.Drawing.Size(48, 36);
			this.closeButton.TabIndex = 13;
			this.closeButton.UseVisualStyleBackColor = false;
			this.closeButton.Click += new System.EventHandler(this.CloseButton_Click);
			// 
			// displayInformationButton
			// 
			this.displayInformationButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.displayInformationButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(89)))), ((int)(((byte)(71)))));
			this.displayInformationButton.FlatAppearance.BorderSize = 0;
			this.displayInformationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.displayInformationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.displayInformationButton.ForeColor = System.Drawing.Color.White;
			this.displayInformationButton.Image = global::SimpleAlarm.Properties.Resources.info;
			this.displayInformationButton.Location = new System.Drawing.Point(441, 3);
			this.displayInformationButton.Name = "displayInformationButton";
			this.displayInformationButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.displayInformationButton.Size = new System.Drawing.Size(48, 36);
			this.displayInformationButton.TabIndex = 28;
			this.displayInformationButton.UseVisualStyleBackColor = false;
			this.displayInformationButton.Click += new System.EventHandler(this.DisplayInformationButton_Click);
			// 
			// headerMinuteMessageLabel
			// 
			this.headerMinuteMessageLabel.AutoSize = true;
			this.headerMinuteMessageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.headerMinuteMessageLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(204)))), ((int)(((byte)(123)))));
			this.headerMinuteMessageLabel.Location = new System.Drawing.Point(273, 51);
			this.headerMinuteMessageLabel.Name = "headerMinuteMessageLabel";
			this.headerMinuteMessageLabel.Size = new System.Drawing.Size(19, 24);
			this.headerMinuteMessageLabel.TabIndex = 29;
			this.headerMinuteMessageLabel.Text = "s";
			this.headerMinuteMessageLabel.Visible = false;
			// 
			// label_header_hour
			// 
			this.headerHourLabel.AutoSize = true;
			this.headerHourLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.headerHourLabel.ForeColor = System.Drawing.Color.White;
			this.headerHourLabel.Location = new System.Drawing.Point(189, 57);
			this.headerHourLabel.Name = "label_header_hour";
			this.headerHourLabel.Size = new System.Drawing.Size(78, 16);
			this.headerHourLabel.TabIndex = 30;
			this.headerHourLabel.Text = "hour(s) and ";
			this.headerHourLabel.Visible = false;
			// 
			// label_header_minute
			// 
			this.headerMinuteLabel.AutoSize = true;
			this.headerMinuteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.headerMinuteLabel.ForeColor = System.Drawing.Color.White;
			this.headerMinuteLabel.Location = new System.Drawing.Point(305, 57);
			this.headerMinuteLabel.Name = "label_header_minute";
			this.headerMinuteLabel.Size = new System.Drawing.Size(65, 16);
			this.headerMinuteLabel.TabIndex = 31;
			this.headerMinuteLabel.Text = "minute(s).";
			this.headerMinuteLabel.Visible = false;
			// 
			// fromNowHourNumericUpDown
			// 
			this.fromNowHourNumericUpDown.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.fromNowHourNumericUpDown.CustomFormat = "m";
			this.fromNowHourNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.fromNowHourNumericUpDown.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.fromNowHourNumericUpDown.Location = new System.Drawing.Point(42, 112);
			this.fromNowHourNumericUpDown.MaxDate = new System.DateTime(2021, 3, 28, 12, 59, 0, 0);
			this.fromNowHourNumericUpDown.Name = "fromNowHourNumericUpDown";
			this.fromNowHourNumericUpDown.ShowUpDown = true;
			this.fromNowHourNumericUpDown.Size = new System.Drawing.Size(53, 24);
			this.fromNowHourNumericUpDown.TabIndex = 34;
			this.fromNowHourNumericUpDown.Value = new System.DateTime(2021, 3, 28, 12, 1, 0, 0);
			// 
			// from_now_minute
			// 
			this.fromNowMinuteNumericUpDown.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.fromNowMinuteNumericUpDown.CustomFormat = "m";
			this.fromNowMinuteNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.fromNowMinuteNumericUpDown.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.fromNowMinuteNumericUpDown.Location = new System.Drawing.Point(171, 112);
			this.fromNowMinuteNumericUpDown.MaxDate = new System.DateTime(2021, 3, 28, 12, 59, 0, 0);
			this.fromNowMinuteNumericUpDown.Name = "from_now_minute";
			this.fromNowMinuteNumericUpDown.ShowUpDown = true;
			this.fromNowMinuteNumericUpDown.Size = new System.Drawing.Size(53, 24);
			this.fromNowMinuteNumericUpDown.TabIndex = 35;
			this.fromNowMinuteNumericUpDown.Value = new System.DateTime(2021, 3, 28, 12, 1, 0, 0);
			// 
			// SmartAlarm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(89)))), ((int)(((byte)(71)))));
			this.ClientSize = new System.Drawing.Size(690, 450);
			this.Controls.Add(this.headerMinuteLabel);
			this.Controls.Add(this.headerHourLabel);
			this.Controls.Add(this.headerMinuteMessageLabel);
			this.Controls.Add(this.displayInformationButton);
			this.Controls.Add(this.button_about);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.minimizeMaximizeButton);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.headerMessageLefPartLabel);
			this.Controls.Add(this.label_header);
			this.Controls.Add(this.headerMessageRightLabel);
			this.Controls.Add(this.minimizeButton);
			this.Controls.Add(this.closeButton);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimumSize = new System.Drawing.Size(16, 310);
			this.Name = "SmartAlarm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Wise Alarm";
			this.Load += new System.EventHandler(this.SmartAlarm_Load);
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SmartAlarm_MouseDown);
			this.Move += new System.EventHandler(this.SmartAlarm_Move);
			this.Resize += new System.EventHandler(this.SmartAlarm_Resize);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button startAlarmButton_alarm;
		private System.Windows.Forms.Timer currentTimeTimer;
		private System.Windows.Forms.Timer targetTimeTimer;
		private System.Windows.Forms.RadioButton specifyTimeRadioButton;
		private System.Windows.Forms.RadioButton fromNowRadioButton;
		private System.Windows.Forms.Label label_header;
		private System.Windows.Forms.Label headerMessageLefPartLabel;
		private System.Windows.Forms.DateTimePicker targetDateTimePicker;
		private System.Windows.Forms.DateTimePicker targetTimeDateTimePicker;
		private System.Windows.Forms.Label fromNowHourLabel;
		private System.Windows.Forms.Label fromNowMinuteLabel;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label headerMessageRightLabel;
		private System.Windows.Forms.Label currentTimeLabel;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button closeButton;
		private System.Windows.Forms.Button minimizeButton;
		private System.Windows.Forms.Button minimizeMaximizeButton;
		private System.Windows.Forms.Label callLabel;
		private System.Windows.Forms.Label callTimesLabel;
		private System.Windows.Forms.DateTimePicker alarmAmountToCallNumericUpDown;
		private System.Windows.Forms.DateTimePicker snoozeTextBox;
		private System.Windows.Forms.Label callMinuteLabel;
		private System.Windows.Forms.Label snoozeLabel;
		private System.Windows.Forms.ComboBox musicListComboBox;
		private System.Windows.Forms.Button playMusicButton;
		private System.Windows.Forms.Button stopMusicButton;
		private System.Windows.Forms.Button button_about;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Button displayInformationButton;
		private System.Windows.Forms.Label headerMinuteMessageLabel;
		private System.Windows.Forms.Label headerHourLabel;
		private System.Windows.Forms.Label headerMinuteLabel;
		private System.Windows.Forms.Label label_duration;
		private System.Windows.Forms.Label label_duration_value;
		private System.Windows.Forms.Label label_difficulty;
		private System.Windows.Forms.ComboBox difficultyComboBox;
		private System.Windows.Forms.Label label_message;
		private System.Windows.Forms.TextBox messageTextBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button cancelAlarmButton;
		private System.Windows.Forms.DateTimePicker fromNowHourNumericUpDown;
		private System.Windows.Forms.DateTimePicker fromNowMinuteNumericUpDown;
	}
}

