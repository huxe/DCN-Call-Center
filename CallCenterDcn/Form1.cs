using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CallCenterDcn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            
        }

        private void addControlsToPanel(Control c)
        {
            c.Dock = DockStyle.Fill;
            pnlMainAdmin.Controls.Clear();
            pnlMainAdmin.Controls.Add(c);
        }

        private void btnAdminReports_Click(object sender, EventArgs e)
        {
            MovePanle(btnManageContacts);

            UserControls.ucManageUser uc = new UserControls.ucManageUser();
            addControlsToPanel(uc);
        }
        private void MovePanle(Control btn)
        {
            pnlMove.Top = btn.Top;
            pnlMove.Height = btn.Height;
        }

        private void btnAdminCreateUser_Click(object sender, EventArgs e)
        {
            MovePanle(btnCallUser);
        }

        private void btnManageUser_Click(object sender, EventArgs e)
        {
            MovePanle(btnMessageUser);
            UserControls.ucMsgEmail uc = new UserControls.ucMsgEmail();
            addControlsToPanel(uc);
        }

        private void pnlMainAdmin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UserControls.ucManageUser uc = new UserControls.ucManageUser();
            addControlsToPanel(uc);
        }
    }
}
