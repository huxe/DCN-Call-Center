namespace CallCenterDcn.UserControls
{
    partial class ucMsgEmail
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkTimer = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rdoEmail = new System.Windows.Forms.RadioButton();
            this.rdoMessage = new System.Windows.Forms.RadioButton();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.txtEmailAddress = new System.Windows.Forms.ComboBox();
            this.rdoIndividualPerson = new System.Windows.Forms.RadioButton();
            this.rdoGroupName = new System.Windows.Forms.RadioButton();
            this.rdoAll = new System.Windows.Forms.RadioButton();
            this.btnCreateUserSingUp = new System.Windows.Forms.Button();
            this.txtMailText = new System.Windows.Forms.TextBox();
            this.txtAttatchFile = new System.Windows.Forms.TextBox();
            this.txtSubjext = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblChange = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtH = new System.Windows.Forms.TextBox();
            this.txtMS = new System.Windows.Forms.TextBox();
            this.txtS = new System.Windows.Forms.TextBox();
            this.txtM = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chkTimer);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnOpenFile);
            this.panel1.Controls.Add(this.txtEmailAddress);
            this.panel1.Controls.Add(this.rdoIndividualPerson);
            this.panel1.Controls.Add(this.rdoGroupName);
            this.panel1.Controls.Add(this.rdoAll);
            this.panel1.Controls.Add(this.btnCreateUserSingUp);
            this.panel1.Controls.Add(this.txtMailText);
            this.panel1.Controls.Add(this.txtAttatchFile);
            this.panel1.Controls.Add(this.txtSubjext);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblChange);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(95, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(544, 622);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // chkTimer
            // 
            this.chkTimer.AutoSize = true;
            this.chkTimer.Location = new System.Drawing.Point(219, 558);
            this.chkTimer.Name = "chkTimer";
            this.chkTimer.Size = new System.Drawing.Size(109, 25);
            this.chkTimer.TabIndex = 37;
            this.chkTimer.Text = "Add Timer";
            this.chkTimer.UseVisualStyleBackColor = true;
            this.chkTimer.CheckedChanged += new System.EventHandler(this.chkTimer_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rdoEmail);
            this.panel2.Controls.Add(this.rdoMessage);
            this.panel2.Location = new System.Drawing.Point(112, 65);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(332, 38);
            this.panel2.TabIndex = 36;
            // 
            // rdoEmail
            // 
            this.rdoEmail.AutoSize = true;
            this.rdoEmail.Location = new System.Drawing.Point(160, 7);
            this.rdoEmail.Name = "rdoEmail";
            this.rdoEmail.Size = new System.Drawing.Size(69, 25);
            this.rdoEmail.TabIndex = 1;
            this.rdoEmail.TabStop = true;
            this.rdoEmail.Text = "Email";
            this.rdoEmail.UseVisualStyleBackColor = true;
            this.rdoEmail.CheckedChanged += new System.EventHandler(this.rdoEmail_CheckedChanged);
            // 
            // rdoMessage
            // 
            this.rdoMessage.AutoSize = true;
            this.rdoMessage.Location = new System.Drawing.Point(17, 6);
            this.rdoMessage.Name = "rdoMessage";
            this.rdoMessage.Size = new System.Drawing.Size(97, 25);
            this.rdoMessage.TabIndex = 0;
            this.rdoMessage.TabStop = true;
            this.rdoMessage.Text = "Message";
            this.rdoMessage.UseVisualStyleBackColor = true;
            this.rdoMessage.CheckedChanged += new System.EventHandler(this.rdoMessage_CheckedChanged);
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.BackColor = System.Drawing.Color.Blue;
            this.btnOpenFile.FlatAppearance.BorderSize = 0;
            this.btnOpenFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenFile.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenFile.ForeColor = System.Drawing.Color.White;
            this.btnOpenFile.Location = new System.Drawing.Point(403, 471);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(84, 27);
            this.btnOpenFile.TabIndex = 35;
            this.btnOpenFile.Text = "Open File";
            this.btnOpenFile.UseVisualStyleBackColor = false;
            this.btnOpenFile.Click += new System.EventHandler(this.btnForgetPasswordChange_Click);
            // 
            // txtEmailAddress
            // 
            this.txtEmailAddress.FormattingEnabled = true;
            this.txtEmailAddress.Location = new System.Drawing.Point(182, 167);
            this.txtEmailAddress.Name = "txtEmailAddress";
            this.txtEmailAddress.Size = new System.Drawing.Size(305, 29);
            this.txtEmailAddress.TabIndex = 34;
            // 
            // rdoIndividualPerson
            // 
            this.rdoIndividualPerson.AutoSize = true;
            this.rdoIndividualPerson.Location = new System.Drawing.Point(319, 121);
            this.rdoIndividualPerson.Name = "rdoIndividualPerson";
            this.rdoIndividualPerson.Size = new System.Drawing.Size(159, 25);
            this.rdoIndividualPerson.TabIndex = 33;
            this.rdoIndividualPerson.TabStop = true;
            this.rdoIndividualPerson.Text = "Individual Person";
            this.rdoIndividualPerson.UseVisualStyleBackColor = true;
            this.rdoIndividualPerson.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // rdoGroupName
            // 
            this.rdoGroupName.AutoSize = true;
            this.rdoGroupName.Location = new System.Drawing.Point(135, 121);
            this.rdoGroupName.Name = "rdoGroupName";
            this.rdoGroupName.Size = new System.Drawing.Size(159, 25);
            this.rdoGroupName.TabIndex = 32;
            this.rdoGroupName.TabStop = true;
            this.rdoGroupName.Text = "Individual Group";
            this.rdoGroupName.UseVisualStyleBackColor = true;
            this.rdoGroupName.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rdoAll
            // 
            this.rdoAll.AutoSize = true;
            this.rdoAll.Location = new System.Drawing.Point(55, 121);
            this.rdoAll.Name = "rdoAll";
            this.rdoAll.Size = new System.Drawing.Size(47, 25);
            this.rdoAll.TabIndex = 31;
            this.rdoAll.TabStop = true;
            this.rdoAll.Text = "All";
            this.rdoAll.UseVisualStyleBackColor = true;
            this.rdoAll.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // btnCreateUserSingUp
            // 
            this.btnCreateUserSingUp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCreateUserSingUp.BackColor = System.Drawing.Color.Green;
            this.btnCreateUserSingUp.FlatAppearance.BorderSize = 0;
            this.btnCreateUserSingUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateUserSingUp.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateUserSingUp.ForeColor = System.Drawing.Color.White;
            this.btnCreateUserSingUp.Location = new System.Drawing.Point(382, 552);
            this.btnCreateUserSingUp.Name = "btnCreateUserSingUp";
            this.btnCreateUserSingUp.Size = new System.Drawing.Size(96, 34);
            this.btnCreateUserSingUp.TabIndex = 30;
            this.btnCreateUserSingUp.Text = "Send";
            this.btnCreateUserSingUp.UseVisualStyleBackColor = false;
            this.btnCreateUserSingUp.Click += new System.EventHandler(this.btnCreateUserSingUp_Click);
            // 
            // txtMailText
            // 
            this.txtMailText.Location = new System.Drawing.Point(182, 280);
            this.txtMailText.Multiline = true;
            this.txtMailText.Name = "txtMailText";
            this.txtMailText.Size = new System.Drawing.Size(305, 154);
            this.txtMailText.TabIndex = 2;
            // 
            // txtAttatchFile
            // 
            this.txtAttatchFile.Location = new System.Drawing.Point(182, 471);
            this.txtAttatchFile.Name = "txtAttatchFile";
            this.txtAttatchFile.Size = new System.Drawing.Size(207, 27);
            this.txtAttatchFile.TabIndex = 2;
            // 
            // txtSubjext
            // 
            this.txtSubjext.Location = new System.Drawing.Point(182, 222);
            this.txtSubjext.Name = "txtSubjext";
            this.txtSubjext.Size = new System.Drawing.Size(305, 27);
            this.txtSubjext.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 474);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 21);
            this.label5.TabIndex = 1;
            this.label5.Text = "Attatch File";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 283);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 21);
            this.label4.TabIndex = 1;
            this.label4.Text = "Enter Text";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "SubJect";
            // 
            // lblChange
            // 
            this.lblChange.AutoSize = true;
            this.lblChange.Location = new System.Drawing.Point(23, 170);
            this.lblChange.Name = "lblChange";
            this.lblChange.Size = new System.Drawing.Size(117, 21);
            this.lblChange.TabIndex = 1;
            this.lblChange.Text = "Email Address";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(138, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email And Messages";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(896, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "S";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(954, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 21);
            this.label6.TabIndex = 4;
            this.label6.Text = "MS";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(869, 241);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 28);
            this.label7.TabIndex = 5;
            this.label7.Text = ":";
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Blue;
            this.btnStart.Enabled = false;
            this.btnStart.FlatAppearance.BorderSize = 0;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.Location = new System.Drawing.Point(900, 287);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(65, 28);
            this.btnStart.TabIndex = 31;
            this.btnStart.Text = "Send";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(802, 239);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(19, 28);
            this.label8.TabIndex = 38;
            this.label8.Text = ":";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(832, 216);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(25, 21);
            this.label9.TabIndex = 37;
            this.label9.Text = "M";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(769, 216);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(21, 21);
            this.label10.TabIndex = 35;
            this.label10.Text = "H";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(929, 241);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(19, 28);
            this.label11.TabIndex = 39;
            this.label11.Text = ":";
            // 
            // txtH
            // 
            this.txtH.Enabled = false;
            this.txtH.Location = new System.Drawing.Point(767, 244);
            this.txtH.Name = "txtH";
            this.txtH.Size = new System.Drawing.Size(28, 27);
            this.txtH.TabIndex = 40;
            this.txtH.Text = "00";
            this.txtH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMS
            // 
            this.txtMS.Enabled = false;
            this.txtMS.Location = new System.Drawing.Point(954, 243);
            this.txtMS.Name = "txtMS";
            this.txtMS.Size = new System.Drawing.Size(28, 27);
            this.txtMS.TabIndex = 41;
            this.txtMS.Text = "00";
            this.txtMS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtS
            // 
            this.txtS.Enabled = false;
            this.txtS.Location = new System.Drawing.Point(891, 244);
            this.txtS.Name = "txtS";
            this.txtS.Size = new System.Drawing.Size(28, 27);
            this.txtS.TabIndex = 42;
            this.txtS.Text = "00";
            this.txtS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtM
            // 
            this.txtM.Enabled = false;
            this.txtM.Location = new System.Drawing.Point(829, 244);
            this.txtM.Name = "txtM";
            this.txtM.Size = new System.Drawing.Size(28, 27);
            this.txtM.TabIndex = 43;
            this.txtM.Text = "00";
            this.txtM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ucMsgEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.txtM);
            this.Controls.Add(this.txtS);
            this.Controls.Add(this.txtMS);
            this.Controls.Add(this.txtH);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Blue;
            this.Margin = new System.Windows.Forms.Padding(15);
            this.Name = "ucMsgEmail";
            this.Size = new System.Drawing.Size(1060, 730);
            this.Load += new System.EventHandler(this.ucMsgEmail_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblChange;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMailText;
        private System.Windows.Forms.TextBox txtAttatchFile;
        private System.Windows.Forms.TextBox txtSubjext;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCreateUserSingUp;
        private System.Windows.Forms.RadioButton rdoIndividualPerson;
        private System.Windows.Forms.RadioButton rdoGroupName;
        private System.Windows.Forms.RadioButton rdoAll;
        private System.Windows.Forms.ComboBox txtEmailAddress;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rdoEmail;
        private System.Windows.Forms.RadioButton rdoMessage;
        private System.Windows.Forms.CheckBox chkTimer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtH;
        private System.Windows.Forms.TextBox txtMS;
        private System.Windows.Forms.TextBox txtS;
        private System.Windows.Forms.TextBox txtM;
        private System.Windows.Forms.Timer timer1;

    }
}
