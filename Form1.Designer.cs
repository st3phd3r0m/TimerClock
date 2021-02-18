
namespace TimerClock
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.soundFileOpenerTimer = new System.Windows.Forms.Button();
            this.StartTimerButton = new System.Windows.Forms.Button();
            this.timerHourTextBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.timerSoundLabel = new System.Windows.Forms.Label();
            this.timerLabel = new System.Windows.Forms.Label();
            this.timerFeatureNameLabel = new System.Windows.Forms.Label();
            this.mLabel = new System.Windows.Forms.Label();
            this.hLabel = new System.Windows.Forms.Label();
            this.timerSecTextBox = new System.Windows.Forms.TextBox();
            this.timerMinTextBox = new System.Windows.Forms.TextBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.openFileDialogTimer = new System.Windows.Forms.OpenFileDialog();
            this.panel3 = new System.Windows.Forms.Panel();
            this.alarmSoundLabel = new System.Windows.Forms.Label();
            this.soundFileOpenerAlarm = new System.Windows.Forms.Button();
            this.startAlarmButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.alarmMinTextBox = new System.Windows.Forms.TextBox();
            this.alarmHourTextBox = new System.Windows.Forms.TextBox();
            this.alarmFeatureNameLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(303, 77);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(35, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(229, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(35, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // soundFileOpenerTimer
            // 
            this.soundFileOpenerTimer.Location = new System.Drawing.Point(149, 90);
            this.soundFileOpenerTimer.Name = "soundFileOpenerTimer";
            this.soundFileOpenerTimer.Size = new System.Drawing.Size(114, 23);
            this.soundFileOpenerTimer.TabIndex = 2;
            this.soundFileOpenerTimer.Text = "Choose a sound";
            this.soundFileOpenerTimer.UseVisualStyleBackColor = true;
            this.soundFileOpenerTimer.Click += new System.EventHandler(this.SoundFileOpenerTimer_Click);
            // 
            // StartTimerButton
            // 
            this.StartTimerButton.Location = new System.Drawing.Point(44, 90);
            this.StartTimerButton.Name = "StartTimerButton";
            this.StartTimerButton.Size = new System.Drawing.Size(93, 23);
            this.StartTimerButton.TabIndex = 1;
            this.StartTimerButton.Text = "Start the timer";
            this.StartTimerButton.UseVisualStyleBackColor = true;
            this.StartTimerButton.Click += new System.EventHandler(this.StartTimerButton_Click);
            // 
            // timerHourTextBox
            // 
            this.timerHourTextBox.Location = new System.Drawing.Point(34, 51);
            this.timerHourTextBox.MaxLength = 2;
            this.timerHourTextBox.Name = "timerHourTextBox";
            this.timerHourTextBox.Size = new System.Drawing.Size(35, 23);
            this.timerHourTextBox.TabIndex = 2;
            this.timerHourTextBox.Text = "00";
            this.timerHourTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.timerHourTextBox.TextChanged += new System.EventHandler(this.TimerHourTextBox_TextChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.timerSoundLabel);
            this.panel2.Controls.Add(this.soundFileOpenerTimer);
            this.panel2.Controls.Add(this.timerLabel);
            this.panel2.Controls.Add(this.StartTimerButton);
            this.panel2.Controls.Add(this.timerFeatureNameLabel);
            this.panel2.Controls.Add(this.mLabel);
            this.panel2.Controls.Add(this.hLabel);
            this.panel2.Controls.Add(this.timerSecTextBox);
            this.panel2.Controls.Add(this.timerMinTextBox);
            this.panel2.Controls.Add(this.timerHourTextBox);
            this.panel2.Location = new System.Drawing.Point(13, 95);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(302, 147);
            this.panel2.TabIndex = 3;
            // 
            // timerSoundLabel
            // 
            this.timerSoundLabel.Location = new System.Drawing.Point(9, 116);
            this.timerSoundLabel.Name = "timerSoundLabel";
            this.timerSoundLabel.Size = new System.Drawing.Size(287, 20);
            this.timerSoundLabel.TabIndex = 9;
            // 
            // timerLabel
            // 
            this.timerLabel.Location = new System.Drawing.Point(33, 51);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(229, 23);
            this.timerLabel.TabIndex = 7;
            this.timerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timerFeatureNameLabel
            // 
            this.timerFeatureNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.timerFeatureNameLabel.Location = new System.Drawing.Point(10, 10);
            this.timerFeatureNameLabel.Name = "timerFeatureNameLabel";
            this.timerFeatureNameLabel.Size = new System.Drawing.Size(287, 23);
            this.timerFeatureNameLabel.TabIndex = 8;
            this.timerFeatureNameLabel.Text = "Timer";
            this.timerFeatureNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mLabel
            // 
            this.mLabel.Location = new System.Drawing.Point(161, 51);
            this.mLabel.Name = "mLabel";
            this.mLabel.Size = new System.Drawing.Size(52, 23);
            this.mLabel.TabIndex = 6;
            this.mLabel.Text = "minutes";
            this.mLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hLabel
            // 
            this.hLabel.Location = new System.Drawing.Point(75, 51);
            this.hLabel.Name = "hLabel";
            this.hLabel.Size = new System.Drawing.Size(39, 23);
            this.hLabel.TabIndex = 5;
            this.hLabel.Text = "hours";
            this.hLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timerSecTextBox
            // 
            this.timerSecTextBox.Location = new System.Drawing.Point(219, 51);
            this.timerSecTextBox.MaxLength = 2;
            this.timerSecTextBox.Name = "timerSecTextBox";
            this.timerSecTextBox.Size = new System.Drawing.Size(35, 23);
            this.timerSecTextBox.TabIndex = 4;
            this.timerSecTextBox.Tag = "";
            this.timerSecTextBox.Text = "00";
            this.timerSecTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.timerSecTextBox.TextChanged += new System.EventHandler(this.TimerSecTextBox_TextChanged);
            // 
            // timerMinTextBox
            // 
            this.timerMinTextBox.Location = new System.Drawing.Point(120, 51);
            this.timerMinTextBox.MaxLength = 2;
            this.timerMinTextBox.Name = "timerMinTextBox";
            this.timerMinTextBox.Size = new System.Drawing.Size(35, 23);
            this.timerMinTextBox.TabIndex = 3;
            this.timerMinTextBox.Text = "00";
            this.timerMinTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.timerMinTextBox.TextChanged += new System.EventHandler(this.TimerMinTextBox_TextChanged);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.Timer2_Tick);
            // 
            // openFileDialogTimer
            // 
            this.openFileDialogTimer.FileName = "openFileDialogTimer";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.alarmSoundLabel);
            this.panel3.Controls.Add(this.soundFileOpenerAlarm);
            this.panel3.Controls.Add(this.startAlarmButton);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.alarmMinTextBox);
            this.panel3.Controls.Add(this.alarmHourTextBox);
            this.panel3.Controls.Add(this.alarmFeatureNameLabel);
            this.panel3.Location = new System.Drawing.Point(12, 248);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(302, 176);
            this.panel3.TabIndex = 4;
            // 
            // alarmSoundLabel
            // 
            this.alarmSoundLabel.Location = new System.Drawing.Point(10, 146);
            this.alarmSoundLabel.Name = "alarmSoundLabel";
            this.alarmSoundLabel.Size = new System.Drawing.Size(287, 20);
            this.alarmSoundLabel.TabIndex = 14;
            // 
            // soundFileOpenerAlarm
            // 
            this.soundFileOpenerAlarm.Location = new System.Drawing.Point(149, 116);
            this.soundFileOpenerAlarm.Name = "soundFileOpenerAlarm";
            this.soundFileOpenerAlarm.Size = new System.Drawing.Size(114, 23);
            this.soundFileOpenerAlarm.TabIndex = 13;
            this.soundFileOpenerAlarm.Text = "Choose a sound";
            this.soundFileOpenerAlarm.UseVisualStyleBackColor = true;
            this.soundFileOpenerAlarm.Click += new System.EventHandler(this.SoundFileOpenerTimer_Click);
            // 
            // startAlarmButton
            // 
            this.startAlarmButton.Location = new System.Drawing.Point(44, 116);
            this.startAlarmButton.Name = "startAlarmButton";
            this.startAlarmButton.Size = new System.Drawing.Size(93, 23);
            this.startAlarmButton.TabIndex = 12;
            this.startAlarmButton.Text = "Start the alarm";
            this.startAlarmButton.UseVisualStyleBackColor = true;
            this.startAlarmButton.Click += new System.EventHandler(this.StartAlarmButton_Click);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(140, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 23);
            this.label4.TabIndex = 10;
            this.label4.Text = ":";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // alarmMinTextBox
            // 
            this.alarmMinTextBox.Location = new System.Drawing.Point(164, 62);
            this.alarmMinTextBox.MaxLength = 2;
            this.alarmMinTextBox.Name = "alarmMinTextBox";
            this.alarmMinTextBox.Size = new System.Drawing.Size(35, 23);
            this.alarmMinTextBox.TabIndex = 8;
            this.alarmMinTextBox.Text = "00";
            this.alarmMinTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.alarmMinTextBox.TextChanged += new System.EventHandler(this.AlarmMinTextBox_TextChanged);
            // 
            // alarmHourTextBox
            // 
            this.alarmHourTextBox.Location = new System.Drawing.Point(99, 62);
            this.alarmHourTextBox.MaxLength = 2;
            this.alarmHourTextBox.Name = "alarmHourTextBox";
            this.alarmHourTextBox.Size = new System.Drawing.Size(35, 23);
            this.alarmHourTextBox.TabIndex = 7;
            this.alarmHourTextBox.Text = "08";
            this.alarmHourTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.alarmHourTextBox.TextChanged += new System.EventHandler(this.AlarmHourTextBox_TextChanged);
            // 
            // alarmFeatureNameLabel
            // 
            this.alarmFeatureNameLabel.Location = new System.Drawing.Point(10, 9);
            this.alarmFeatureNameLabel.Name = "alarmFeatureNameLabel";
            this.alarmFeatureNameLabel.Size = new System.Drawing.Size(287, 23);
            this.alarmFeatureNameLabel.TabIndex = 0;
            this.alarmFeatureNameLabel.Text = "Alarm";
            this.alarmFeatureNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(322, 436);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(338, 475);
            this.MinimumSize = new System.Drawing.Size(338, 475);
            this.Name = "Form1";
            this.Text = "TimerClock";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button StartTimerButton;
        private System.Windows.Forms.TextBox timerHourTextBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label mLabel;
        private System.Windows.Forms.Label hLabel;
        private System.Windows.Forms.TextBox timerSecTextBox;
        private System.Windows.Forms.TextBox timerMinTextBox;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label timerLabel;
        private System.Windows.Forms.Label timerFeatureNameLabel;
        private System.Windows.Forms.Button soundFileOpenerTimer;
        private System.Windows.Forms.OpenFileDialog openFileDialogTimer;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label alarmFeatureNameLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox alarmMinTextBox;
        private System.Windows.Forms.TextBox alarmHourTextBox;
        private System.Windows.Forms.Button startAlarmButton;
        private System.Windows.Forms.Button soundFileOpenerAlarm;
        private System.Windows.Forms.Label timerSoundLabel;
        private System.Windows.Forms.Label alarmSoundLabel;
    }
}

