namespace WPCExampleCSharp
{
    partial class FormMain
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
            this.Panel1 = new System.Windows.Forms.Panel();
            this.LabelTop = new System.Windows.Forms.Label();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.LabelResultNote = new System.Windows.Forms.Label();
            this.TextBoxResult = new System.Windows.Forms.TextBox();
            this.GroupBoxLock = new System.Windows.Forms.GroupBox();
            this.ButtonLock = new System.Windows.Forms.Button();
            this.GroupBoxSuspend = new System.Windows.Forms.GroupBox();
            this.LabelHibernateInfo = new System.Windows.Forms.Label();
            this.LabelSleepInfo = new System.Windows.Forms.Label();
            this.ButtonCheckSupport = new System.Windows.Forms.Button();
            this.CheckBoxForceSuspend = new System.Windows.Forms.CheckBox();
            this.ButtonHibernate = new System.Windows.Forms.Button();
            this.ButtonSleep = new System.Windows.Forms.Button();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.ComboBoxForceOption = new System.Windows.Forms.ComboBox();
            this.LabelForceOption = new System.Windows.Forms.Label();
            this.ButtonShutdown = new System.Windows.Forms.Button();
            this.ButtonPowerOff = new System.Windows.Forms.Button();
            this.ButtonRestart = new System.Windows.Forms.Button();
            this.ButtonLogOff = new System.Windows.Forms.Button();
            this.Panel1.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            this.GroupBoxLock.SuspendLayout();
            this.GroupBoxSuspend.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.White;
            this.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel1.Controls.Add(this.LabelTop);
            this.Panel1.Location = new System.Drawing.Point(-2, -1);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(604, 76);
            this.Panel1.TabIndex = 18;
            // 
            // LabelTop
            // 
            this.LabelTop.AutoSize = true;
            this.LabelTop.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LabelTop.ForeColor = System.Drawing.Color.DodgerBlue;
            this.LabelTop.Location = new System.Drawing.Point(25, 24);
            this.LabelTop.Name = "LabelTop";
            this.LabelTop.Size = new System.Drawing.Size(329, 25);
            this.LabelTop.TabIndex = 0;
            this.LabelTop.Text = "WPC Example - Visual C#.Net";
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.LabelResultNote);
            this.GroupBox2.Controls.Add(this.TextBoxResult);
            this.GroupBox2.Location = new System.Drawing.Point(19, 449);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(558, 90);
            this.GroupBox2.TabIndex = 17;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Result";
            // 
            // LabelResultNote
            // 
            this.LabelResultNote.AutoSize = true;
            this.LabelResultNote.Location = new System.Drawing.Point(6, 67);
            this.LabelResultNote.Name = "LabelResultNote";
            this.LabelResultNote.Size = new System.Drawing.Size(545, 14);
            this.LabelResultNote.TabIndex = 7;
            this.LabelResultNote.Text = "Note: You may not see return result if the system immediately enters shutdown or " +
    "suspend state";
            // 
            // TextBoxResult
            // 
            this.TextBoxResult.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TextBoxResult.Location = new System.Drawing.Point(20, 27);
            this.TextBoxResult.Name = "TextBoxResult";
            this.TextBoxResult.ReadOnly = true;
            this.TextBoxResult.Size = new System.Drawing.Size(101, 27);
            this.TextBoxResult.TabIndex = 0;
            this.TextBoxResult.TabStop = false;
            this.TextBoxResult.Text = "-";
            // 
            // GroupBoxLock
            // 
            this.GroupBoxLock.Controls.Add(this.ButtonLock);
            this.GroupBoxLock.Location = new System.Drawing.Point(19, 372);
            this.GroupBoxLock.Name = "GroupBoxLock";
            this.GroupBoxLock.Size = new System.Drawing.Size(558, 61);
            this.GroupBoxLock.TabIndex = 16;
            this.GroupBoxLock.TabStop = false;
            this.GroupBoxLock.Text = "Lock Function";
            // 
            // ButtonLock
            // 
            this.ButtonLock.Location = new System.Drawing.Point(19, 21);
            this.ButtonLock.Name = "ButtonLock";
            this.ButtonLock.Size = new System.Drawing.Size(101, 27);
            this.ButtonLock.TabIndex = 0;
            this.ButtonLock.Text = "Lock";
            this.ButtonLock.UseVisualStyleBackColor = true;
            this.ButtonLock.Click += new System.EventHandler(this.ButtonLock_Click);
            // 
            // GroupBoxSuspend
            // 
            this.GroupBoxSuspend.Controls.Add(this.LabelHibernateInfo);
            this.GroupBoxSuspend.Controls.Add(this.LabelSleepInfo);
            this.GroupBoxSuspend.Controls.Add(this.ButtonCheckSupport);
            this.GroupBoxSuspend.Controls.Add(this.CheckBoxForceSuspend);
            this.GroupBoxSuspend.Controls.Add(this.ButtonHibernate);
            this.GroupBoxSuspend.Controls.Add(this.ButtonSleep);
            this.GroupBoxSuspend.Location = new System.Drawing.Point(19, 224);
            this.GroupBoxSuspend.Name = "GroupBoxSuspend";
            this.GroupBoxSuspend.Size = new System.Drawing.Size(558, 134);
            this.GroupBoxSuspend.TabIndex = 15;
            this.GroupBoxSuspend.TabStop = false;
            this.GroupBoxSuspend.Text = "Suspend Functions";
            // 
            // LabelHibernateInfo
            // 
            this.LabelHibernateInfo.AutoSize = true;
            this.LabelHibernateInfo.Location = new System.Drawing.Point(138, 96);
            this.LabelHibernateInfo.Name = "LabelHibernateInfo";
            this.LabelHibernateInfo.Size = new System.Drawing.Size(140, 14);
            this.LabelHibernateInfo.TabIndex = 6;
            this.LabelHibernateInfo.Text = "Check System Support !";
            // 
            // LabelSleepInfo
            // 
            this.LabelSleepInfo.AutoSize = true;
            this.LabelSleepInfo.Location = new System.Drawing.Point(138, 62);
            this.LabelSleepInfo.Name = "LabelSleepInfo";
            this.LabelSleepInfo.Size = new System.Drawing.Size(140, 14);
            this.LabelSleepInfo.TabIndex = 5;
            this.LabelSleepInfo.Text = "Check System Support !";
            // 
            // ButtonCheckSupport
            // 
            this.ButtonCheckSupport.Location = new System.Drawing.Point(388, 74);
            this.ButtonCheckSupport.Name = "ButtonCheckSupport";
            this.ButtonCheckSupport.Size = new System.Drawing.Size(152, 27);
            this.ButtonCheckSupport.TabIndex = 3;
            this.ButtonCheckSupport.Text = "Check System Support";
            this.ButtonCheckSupport.UseVisualStyleBackColor = true;
            this.ButtonCheckSupport.Click += new System.EventHandler(this.ButtonCheckSupport_Click);
            // 
            // CheckBoxForceSuspend
            // 
            this.CheckBoxForceSuspend.AutoSize = true;
            this.CheckBoxForceSuspend.Location = new System.Drawing.Point(20, 26);
            this.CheckBoxForceSuspend.Name = "CheckBoxForceSuspend";
            this.CheckBoxForceSuspend.Size = new System.Drawing.Size(56, 18);
            this.CheckBoxForceSuspend.TabIndex = 0;
            this.CheckBoxForceSuspend.Text = "Force";
            this.CheckBoxForceSuspend.UseVisualStyleBackColor = true;
            // 
            // ButtonHibernate
            // 
            this.ButtonHibernate.Enabled = false;
            this.ButtonHibernate.Location = new System.Drawing.Point(19, 90);
            this.ButtonHibernate.Name = "ButtonHibernate";
            this.ButtonHibernate.Size = new System.Drawing.Size(101, 27);
            this.ButtonHibernate.TabIndex = 2;
            this.ButtonHibernate.Text = "Hibernate";
            this.ButtonHibernate.UseVisualStyleBackColor = true;
            this.ButtonHibernate.Click += new System.EventHandler(this.ButtonHibernate_Click);
            // 
            // ButtonSleep
            // 
            this.ButtonSleep.Enabled = false;
            this.ButtonSleep.Location = new System.Drawing.Point(19, 56);
            this.ButtonSleep.Name = "ButtonSleep";
            this.ButtonSleep.Size = new System.Drawing.Size(101, 27);
            this.ButtonSleep.TabIndex = 1;
            this.ButtonSleep.Text = "Sleep";
            this.ButtonSleep.UseVisualStyleBackColor = true;
            this.ButtonSleep.Click += new System.EventHandler(this.ButtonSleep_Click);
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.ComboBoxForceOption);
            this.GroupBox1.Controls.Add(this.LabelForceOption);
            this.GroupBox1.Controls.Add(this.ButtonShutdown);
            this.GroupBox1.Controls.Add(this.ButtonPowerOff);
            this.GroupBox1.Controls.Add(this.ButtonRestart);
            this.GroupBox1.Controls.Add(this.ButtonLogOff);
            this.GroupBox1.Location = new System.Drawing.Point(19, 89);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(558, 121);
            this.GroupBox1.TabIndex = 14;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Shutdown Functions";
            // 
            // ComboBoxForceOption
            // 
            this.ComboBoxForceOption.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxForceOption.FormattingEnabled = true;
            this.ComboBoxForceOption.Items.AddRange(new object[] {
            "Never",
            "Force If Hung",
            "Force All"});
            this.ComboBoxForceOption.Location = new System.Drawing.Point(111, 31);
            this.ComboBoxForceOption.Name = "ComboBoxForceOption";
            this.ComboBoxForceOption.Size = new System.Drawing.Size(149, 22);
            this.ComboBoxForceOption.TabIndex = 0;
            // 
            // LabelForceOption
            // 
            this.LabelForceOption.AutoSize = true;
            this.LabelForceOption.Location = new System.Drawing.Point(19, 34);
            this.LabelForceOption.Name = "LabelForceOption";
            this.LabelForceOption.Size = new System.Drawing.Size(86, 14);
            this.LabelForceOption.TabIndex = 9;
            this.LabelForceOption.Text = "Force Option :";
            // 
            // ButtonShutdown
            // 
            this.ButtonShutdown.Location = new System.Drawing.Point(20, 72);
            this.ButtonShutdown.Name = "ButtonShutdown";
            this.ButtonShutdown.Size = new System.Drawing.Size(101, 27);
            this.ButtonShutdown.TabIndex = 1;
            this.ButtonShutdown.Text = "Shutdown";
            this.ButtonShutdown.UseVisualStyleBackColor = true;
            this.ButtonShutdown.Click += new System.EventHandler(this.ButtonShutdown_Click);
            // 
            // ButtonPowerOff
            // 
            this.ButtonPowerOff.Location = new System.Drawing.Point(159, 72);
            this.ButtonPowerOff.Name = "ButtonPowerOff";
            this.ButtonPowerOff.Size = new System.Drawing.Size(101, 27);
            this.ButtonPowerOff.TabIndex = 2;
            this.ButtonPowerOff.Text = "Power Off";
            this.ButtonPowerOff.UseVisualStyleBackColor = true;
            this.ButtonPowerOff.Click += new System.EventHandler(this.ButtonPowerOff_Click);
            // 
            // ButtonRestart
            // 
            this.ButtonRestart.Location = new System.Drawing.Point(298, 72);
            this.ButtonRestart.Name = "ButtonRestart";
            this.ButtonRestart.Size = new System.Drawing.Size(101, 27);
            this.ButtonRestart.TabIndex = 3;
            this.ButtonRestart.Text = "Restart";
            this.ButtonRestart.UseVisualStyleBackColor = true;
            this.ButtonRestart.Click += new System.EventHandler(this.ButtonRestart_Click);
            // 
            // ButtonLogOff
            // 
            this.ButtonLogOff.Location = new System.Drawing.Point(437, 72);
            this.ButtonLogOff.Name = "ButtonLogOff";
            this.ButtonLogOff.Size = new System.Drawing.Size(101, 27);
            this.ButtonLogOff.TabIndex = 4;
            this.ButtonLogOff.Text = "Log Off";
            this.ButtonLogOff.UseVisualStyleBackColor = true;
            this.ButtonLogOff.Click += new System.EventHandler(this.ButtonLogOff_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 552);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.GroupBoxLock);
            this.Controls.Add(this.GroupBoxSuspend);
            this.Controls.Add(this.GroupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "WPC Example - Visual C#.Net";
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.GroupBoxLock.ResumeLayout(false);
            this.GroupBoxSuspend.ResumeLayout(false);
            this.GroupBoxSuspend.PerformLayout();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.Label LabelTop;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.Label LabelResultNote;
        internal System.Windows.Forms.TextBox TextBoxResult;
        internal System.Windows.Forms.GroupBox GroupBoxLock;
        internal System.Windows.Forms.Button ButtonLock;
        internal System.Windows.Forms.GroupBox GroupBoxSuspend;
        internal System.Windows.Forms.Label LabelHibernateInfo;
        internal System.Windows.Forms.Label LabelSleepInfo;
        internal System.Windows.Forms.Button ButtonCheckSupport;
        internal System.Windows.Forms.CheckBox CheckBoxForceSuspend;
        internal System.Windows.Forms.Button ButtonHibernate;
        internal System.Windows.Forms.Button ButtonSleep;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.ComboBox ComboBoxForceOption;
        internal System.Windows.Forms.Label LabelForceOption;
        internal System.Windows.Forms.Button ButtonShutdown;
        internal System.Windows.Forms.Button ButtonPowerOff;
        internal System.Windows.Forms.Button ButtonRestart;
        internal System.Windows.Forms.Button ButtonLogOff;
    }
}

