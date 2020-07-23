namespace CallCenterDcn.UserControls
{
    partial class ucManageUser
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
            this.dtaCreateCustumar = new System.Windows.Forms.DataGridView();
            this.dtaManageUser = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.btnCreateUserSingUp = new System.Windows.Forms.Button();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhoneNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAddInGroup = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtGroupName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.lblEmailChange = new System.Windows.Forms.Label();
            this.lblPhoneNo = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbNameNum = new System.Windows.Forms.ComboBox();
            this.btnAddNameInGroup = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbGroup = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbSelectGrpup = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtaCreateCustumar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtaManageUser)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtaCreateCustumar
            // 
            this.dtaCreateCustumar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.dtaCreateCustumar.BackgroundColor = System.Drawing.Color.White;
            this.dtaCreateCustumar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtaCreateCustumar.GridColor = System.Drawing.Color.Blue;
            this.dtaCreateCustumar.Location = new System.Drawing.Point(-662, -158);
            this.dtaCreateCustumar.Name = "dtaCreateCustumar";
            this.dtaCreateCustumar.Size = new System.Drawing.Size(591, 488);
            this.dtaCreateCustumar.TabIndex = 25;
            this.dtaCreateCustumar.TabStop = false;
            // 
            // dtaManageUser
            // 
            this.dtaManageUser.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.dtaManageUser.BackgroundColor = System.Drawing.Color.White;
            this.dtaManageUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtaManageUser.GridColor = System.Drawing.Color.Blue;
            this.dtaManageUser.Location = new System.Drawing.Point(0, 129);
            this.dtaManageUser.Name = "dtaManageUser";
            this.dtaManageUser.Size = new System.Drawing.Size(574, 488);
            this.dtaManageUser.TabIndex = 26;
            this.dtaManageUser.TabStop = false;
            this.dtaManageUser.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtaManageUser_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(127, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 25);
            this.label1.TabIndex = 27;
            this.label1.Text = "Add Contacts";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AliceBlue;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.btnCreateUserSingUp);
            this.panel1.Controls.Add(this.lblEmail);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.txtPhoneNo);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(655, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(397, 230);
            this.panel1.TabIndex = 28;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button2.BackColor = System.Drawing.Color.SeaGreen;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(273, 175);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 36);
            this.button2.TabIndex = 30;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnCreateUserSingUp
            // 
            this.btnCreateUserSingUp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCreateUserSingUp.BackColor = System.Drawing.Color.Blue;
            this.btnCreateUserSingUp.FlatAppearance.BorderSize = 0;
            this.btnCreateUserSingUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateUserSingUp.ForeColor = System.Drawing.Color.White;
            this.btnCreateUserSingUp.Location = new System.Drawing.Point(113, 175);
            this.btnCreateUserSingUp.Name = "btnCreateUserSingUp";
            this.btnCreateUserSingUp.Size = new System.Drawing.Size(96, 36);
            this.btnCreateUserSingUp.TabIndex = 29;
            this.btnCreateUserSingUp.Text = "Add";
            this.btnCreateUserSingUp.UseVisualStyleBackColor = false;
            this.btnCreateUserSingUp.Click += new System.EventHandler(this.btnCreateUserSingUp_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(20, 128);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(51, 21);
            this.lblEmail.TabIndex = 28;
            this.lblEmail.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(113, 128);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(247, 27);
            this.txtEmail.TabIndex = 29;
            // 
            // txtPhoneNo
            // 
            this.txtPhoneNo.Location = new System.Drawing.Point(113, 95);
            this.txtPhoneNo.Name = "txtPhoneNo";
            this.txtPhoneNo.Size = new System.Drawing.Size(247, 27);
            this.txtPhoneNo.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 21);
            this.label3.TabIndex = 28;
            this.label3.Text = "Phone No";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(113, 62);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(247, 27);
            this.txtName.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 21);
            this.label2.TabIndex = 28;
            this.label2.Text = " Name";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Moccasin;
            this.panel2.Controls.Add(this.btnAddInGroup);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtGroupName);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(655, 296);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(397, 90);
            this.panel2.TabIndex = 29;
            // 
            // btnAddInGroup
            // 
            this.btnAddInGroup.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddInGroup.BackColor = System.Drawing.Color.Blue;
            this.btnAddInGroup.FlatAppearance.BorderSize = 0;
            this.btnAddInGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddInGroup.ForeColor = System.Drawing.Color.White;
            this.btnAddInGroup.Location = new System.Drawing.Point(315, 47);
            this.btnAddInGroup.Name = "btnAddInGroup";
            this.btnAddInGroup.Size = new System.Drawing.Size(70, 27);
            this.btnAddInGroup.TabIndex = 31;
            this.btnAddInGroup.Text = "Add";
            this.btnAddInGroup.UseVisualStyleBackColor = false;
            this.btnAddInGroup.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 21);
            this.label5.TabIndex = 29;
            this.label5.Text = "Goup Name";
            // 
            // txtGroupName
            // 
            this.txtGroupName.Location = new System.Drawing.Point(137, 47);
            this.txtGroupName.Name = "txtGroupName";
            this.txtGroupName.Size = new System.Drawing.Size(165, 27);
            this.txtGroupName.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(127, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 25);
            this.label4.TabIndex = 27;
            this.label4.Text = "Add Groups";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.lblEmailChange);
            this.panel3.Controls.Add(this.lblPhoneNo);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.cmbNameNum);
            this.panel3.Controls.Add(this.btnAddNameInGroup);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.cmbGroup);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Location = new System.Drawing.Point(655, 425);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(397, 238);
            this.panel3.TabIndex = 30;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(172, 199);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 29);
            this.button1.TabIndex = 35;
            this.button1.Text = "Remove";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // lblEmailChange
            // 
            this.lblEmailChange.AutoSize = true;
            this.lblEmailChange.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailChange.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblEmailChange.Location = new System.Drawing.Point(133, 166);
            this.lblEmailChange.Name = "lblEmailChange";
            this.lblEmailChange.Size = new System.Drawing.Size(44, 19);
            this.lblEmailChange.TabIndex = 32;
            this.lblEmailChange.Text = "-----";
            // 
            // lblPhoneNo
            // 
            this.lblPhoneNo.AutoSize = true;
            this.lblPhoneNo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblPhoneNo.Location = new System.Drawing.Point(133, 133);
            this.lblPhoneNo.Name = "lblPhoneNo";
            this.lblPhoneNo.Size = new System.Drawing.Size(44, 19);
            this.lblPhoneNo.TabIndex = 32;
            this.lblPhoneNo.Text = "-----";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(24, 164);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 21);
            this.label12.TabIndex = 31;
            this.label12.Text = "Email";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(24, 131);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 21);
            this.label10.TabIndex = 31;
            this.label10.Text = "Phone No";
            // 
            // cmbNameNum
            // 
            this.cmbNameNum.FormattingEnabled = true;
            this.cmbNameNum.Location = new System.Drawing.Point(137, 87);
            this.cmbNameNum.Name = "cmbNameNum";
            this.cmbNameNum.Size = new System.Drawing.Size(223, 29);
            this.cmbNameNum.TabIndex = 30;
            this.cmbNameNum.SelectedIndexChanged += new System.EventHandler(this.cmbNameNum_SelectedIndexChanged);
            // 
            // btnAddNameInGroup
            // 
            this.btnAddNameInGroup.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddNameInGroup.BackColor = System.Drawing.Color.Blue;
            this.btnAddNameInGroup.FlatAppearance.BorderSize = 0;
            this.btnAddNameInGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNameInGroup.ForeColor = System.Drawing.Color.White;
            this.btnAddNameInGroup.Location = new System.Drawing.Point(272, 199);
            this.btnAddNameInGroup.Name = "btnAddNameInGroup";
            this.btnAddNameInGroup.Size = new System.Drawing.Size(96, 29);
            this.btnAddNameInGroup.TabIndex = 29;
            this.btnAddNameInGroup.Text = "Add";
            this.btnAddNameInGroup.UseVisualStyleBackColor = false;
            this.btnAddNameInGroup.Click += new System.EventHandler(this.btnCreatUserSingUp_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 21);
            this.label8.TabIndex = 29;
            this.label8.Text = "Name";
            // 
            // cmbGroup
            // 
            this.cmbGroup.FormattingEnabled = true;
            this.cmbGroup.Location = new System.Drawing.Point(137, 49);
            this.cmbGroup.Name = "cmbGroup";
            this.cmbGroup.Size = new System.Drawing.Size(223, 29);
            this.cmbGroup.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 21);
            this.label6.TabIndex = 29;
            this.label6.Text = "Goup Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(84, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(262, 25);
            this.label7.TabIndex = 27;
            this.label7.Text = "Add Members In Groups";
            // 
            // cmbSelectGrpup
            // 
            this.cmbSelectGrpup.FormattingEnabled = true;
            this.cmbSelectGrpup.Location = new System.Drawing.Point(372, 56);
            this.cmbSelectGrpup.Name = "cmbSelectGrpup";
            this.cmbSelectGrpup.Size = new System.Drawing.Size(176, 29);
            this.cmbSelectGrpup.TabIndex = 32;
            this.cmbSelectGrpup.SelectedIndexChanged += new System.EventHandler(this.cmbSelectGrpup_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(227, 59);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 21);
            this.label9.TabIndex = 33;
            this.label9.Text = "Select Groups";
            // 
            // btnShowAll
            // 
            this.btnShowAll.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnShowAll.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnShowAll.FlatAppearance.BorderSize = 0;
            this.btnShowAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowAll.ForeColor = System.Drawing.Color.White;
            this.btnShowAll.Location = new System.Drawing.Point(40, 55);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(108, 28);
            this.btnShowAll.TabIndex = 29;
            this.btnShowAll.Text = "Show All";
            this.btnShowAll.UseVisualStyleBackColor = false;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(317, 636);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(163, 36);
            this.button3.TabIndex = 34;
            this.button3.Text = "Delete Contact";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button4.BackColor = System.Drawing.Color.SeaGreen;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(56, 636);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(146, 36);
            this.button4.TabIndex = 35;
            this.button4.Text = "Update";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // ucManageUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnShowAll);
            this.Controls.Add(this.cmbSelectGrpup);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dtaManageUser);
            this.Controls.Add(this.dtaCreateCustumar);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Blue;
            this.Margin = new System.Windows.Forms.Padding(9);
            this.Name = "ucManageUser";
            this.Size = new System.Drawing.Size(1081, 693);
            this.Load += new System.EventHandler(this.ucManageUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtaCreateCustumar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtaManageUser)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtaCreateCustumar;
        private System.Windows.Forms.DataGridView dtaManageUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnCreateUserSingUp;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtPhoneNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtGroupName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cmbNameNum;
        private System.Windows.Forms.Button btnAddNameInGroup;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbGroup;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.ComboBox cmbSelectGrpup;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnAddInGroup;
        private System.Windows.Forms.Label lblEmailChange;
        private System.Windows.Forms.Label lblPhoneNo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
    }
}
