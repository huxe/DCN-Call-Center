namespace CallCenterDcn
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pnlMainAdmin = new System.Windows.Forms.Panel();
            this.PanelLeft = new System.Windows.Forms.Panel();
            this.btnMessageUser = new System.Windows.Forms.Button();
            this.pnlMove = new System.Windows.Forms.Panel();
            this.btnManageContacts = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.btnCallUser = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.PanelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMainAdmin
            // 
            this.pnlMainAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMainAdmin.Location = new System.Drawing.Point(238, 66);
            this.pnlMainAdmin.Name = "pnlMainAdmin";
            this.pnlMainAdmin.Size = new System.Drawing.Size(1014, 474);
            this.pnlMainAdmin.TabIndex = 15;
            this.pnlMainAdmin.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMainAdmin_Paint);
            // 
            // PanelLeft
            // 
            this.PanelLeft.BackColor = System.Drawing.Color.Blue;
            this.PanelLeft.Controls.Add(this.btnMessageUser);
            this.PanelLeft.Controls.Add(this.pnlMove);
            this.PanelLeft.Controls.Add(this.btnManageContacts);
            this.PanelLeft.Controls.Add(this.button8);
            this.PanelLeft.Controls.Add(this.btnCallUser);
            this.PanelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelLeft.Location = new System.Drawing.Point(0, 66);
            this.PanelLeft.Name = "PanelLeft";
            this.PanelLeft.Size = new System.Drawing.Size(238, 474);
            this.PanelLeft.TabIndex = 14;
            // 
            // btnMessageUser
            // 
            this.btnMessageUser.BackColor = System.Drawing.Color.Blue;
            this.btnMessageUser.FlatAppearance.BorderSize = 0;
            this.btnMessageUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMessageUser.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMessageUser.ForeColor = System.Drawing.Color.White;
            this.btnMessageUser.Image = ((System.Drawing.Image)(resources.GetObject("btnMessageUser.Image")));
            this.btnMessageUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMessageUser.Location = new System.Drawing.Point(12, 164);
            this.btnMessageUser.Name = "btnMessageUser";
            this.btnMessageUser.Size = new System.Drawing.Size(210, 45);
            this.btnMessageUser.TabIndex = 4;
            this.btnMessageUser.Text = "     Message Users";
            this.btnMessageUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMessageUser.UseVisualStyleBackColor = false;
            this.btnMessageUser.Click += new System.EventHandler(this.btnManageUser_Click);
            // 
            // pnlMove
            // 
            this.pnlMove.BackColor = System.Drawing.Color.White;
            this.pnlMove.Location = new System.Drawing.Point(3, 63);
            this.pnlMove.Name = "pnlMove";
            this.pnlMove.Size = new System.Drawing.Size(7, 45);
            this.pnlMove.TabIndex = 6;
            // 
            // btnManageContacts
            // 
            this.btnManageContacts.BackColor = System.Drawing.Color.Blue;
            this.btnManageContacts.FlatAppearance.BorderSize = 0;
            this.btnManageContacts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageContacts.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageContacts.ForeColor = System.Drawing.Color.White;
            this.btnManageContacts.Image = ((System.Drawing.Image)(resources.GetObject("btnManageContacts.Image")));
            this.btnManageContacts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageContacts.Location = new System.Drawing.Point(12, 62);
            this.btnManageContacts.Name = "btnManageContacts";
            this.btnManageContacts.Size = new System.Drawing.Size(222, 45);
            this.btnManageContacts.TabIndex = 3;
            this.btnManageContacts.Text = "     Manage Contacts";
            this.btnManageContacts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageContacts.UseVisualStyleBackColor = false;
            this.btnManageContacts.Click += new System.EventHandler(this.btnAdminReports_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Blue;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Image = ((System.Drawing.Image)(resources.GetObject("button8.Image")));
            this.button8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.Location = new System.Drawing.Point(181, 6);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(41, 36);
            this.button8.TabIndex = 3;
            this.button8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // btnCallUser
            // 
            this.btnCallUser.BackColor = System.Drawing.Color.Blue;
            this.btnCallUser.FlatAppearance.BorderSize = 0;
            this.btnCallUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCallUser.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCallUser.ForeColor = System.Drawing.Color.White;
            this.btnCallUser.Image = ((System.Drawing.Image)(resources.GetObject("btnCallUser.Image")));
            this.btnCallUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCallUser.Location = new System.Drawing.Point(12, 113);
            this.btnCallUser.Name = "btnCallUser";
            this.btnCallUser.Size = new System.Drawing.Size(191, 45);
            this.btnCallUser.TabIndex = 3;
            this.btnCallUser.Text = "     Call Users";
            this.btnCallUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCallUser.UseVisualStyleBackColor = false;
            this.btnCallUser.Click += new System.EventHandler(this.btnAdminCreateUser_Click);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 58);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1252, 8);
            this.panel2.TabIndex = 13;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.Blue;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.Blue;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(1182, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(77, 58);
            this.button2.TabIndex = 3;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 52);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Blue;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(78, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Call Center";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Blue;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1252, 58);
            this.panel1.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1252, 540);
            this.Controls.Add(this.pnlMainAdmin);
            this.Controls.Add(this.PanelLeft);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.PanelLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMainAdmin;
        private System.Windows.Forms.Panel PanelLeft;
        private System.Windows.Forms.Panel pnlMove;
        private System.Windows.Forms.Button btnManageContacts;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button btnCallUser;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnMessageUser;
    }
}

