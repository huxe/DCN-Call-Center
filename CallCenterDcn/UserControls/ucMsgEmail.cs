using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;
using System.Data.OleDb;

namespace CallCenterDcn.UserControls
{
    public partial class ucMsgEmail : UserControl
    {
        
        public ucMsgEmail()
        {
            InitializeComponent();
            txtSubjext.Enabled = true;
            rdoAll.Checked = true;
            rdoEmail.Checked = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        DataBase DB = new DataBase();
        string queryCmbo;
        UserControls.ucManageUser uc = new ucManageUser();
        private void mailAndMsg()
        {
            try
            {
                if (rdoEmail.Checked==true)
                {
                    
                
                if (rdoAll.Checked==true)
                {
                    queryCmbo = "select Email from Contacts";
                }
                else if (rdoGroupName.Checked==true)
                {
                    queryCmbo = "select Email from Contacts where "+txtEmailAddress.Text+"='Y'";
                }
                else if (rdoIndividualPerson.Checked==true)
                {
                    queryCmbo = "select Email from Contacts where Email='"+txtEmailAddress.Text+"'";
                }
                }
                else
                {
                    if (rdoAll.Checked == true)
                    {
                        queryCmbo = "select PhoneNo from Contacts";
                    }
                    else if (rdoGroupName.Checked == true)
                    {
                        queryCmbo = "select PhoneNo from Contacts where " + txtEmailAddress.Text + "='Y'";
                    }
                    else if (rdoIndividualPerson.Checked == true)
                    {
                        queryCmbo = "select PhoneNo from Contacts where PhoneNo='" + txtEmailAddress.Text + "'";
                    }
                }
                OleDbDataReader rdr = DB.DB_DG(queryCmbo);


                
            while (rdr.Read())
                {
                    if (rdoEmail.Checked==true)
                    {
                        const string p = "uxe.ahmed2@gmail.com";

                        MailMessage message = new MailMessage();
                        SmtpClient smtp = new SmtpClient();

                        message.From = new MailAddress("huxe.ahmed9@gmail.com");
                        message.To.Add(new MailAddress(rdr[0].ToString()));
                        message.Subject = txtSubjext.Text;
                        message.Body = txtMailText.Text;
                        message.Attachments.Add(new System.Net.Mail.Attachment(txtAttatchFile.Text));

                        smtp.Port = 587;
                        smtp.Host = "smtp.gmail.com";
                        smtp.EnableSsl = true;
                        smtp.UseDefaultCredentials = false;
                        smtp.Credentials = new NetworkCredential("huxe.ahmed9@gmail.com", p);
                        smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                        smtp.Send(message);
                    }
                    else
                    {
                        string MyUsername = "923483202592";
                        string MyPassword = "3265";
                        string toNumber = rdr[0].ToString();
                        string Masking = "huzaifa";
                        string MessageText = txtMailText.Text;
                        string jsonResponse = SendSMS(Masking, toNumber, MessageText, MyUsername, MyPassword);
                        MessageBox.Show(jsonResponse);
            
                    }
                    

                    }

                MessageBox.Show("Message has been sent");
                DB.Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnCreateUserSingUp_Click(object sender, EventArgs e)
        {
             
            mailAndMsg();   
            
                
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            txtEmailAddress.Items.Clear();
            if (rdoMessage.Checked==true)
            {
                lblChange.Text = "Phone Number";
            }
            else
            {
                lblChange.Text = "Email Address";
            }
            txtEmailAddress.Enabled = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            txtEmailAddress.Items.Clear();
            txtEmailAddress.Enabled = true;
            lblChange.Text = "Group Name";

            DB.Con.Open();
            var cmd1 = new OleDbCommand("select * from Contacts", DB.Con);
            var reader = cmd1.ExecuteReader(CommandBehavior.SchemaOnly);
            int count = 0;
            var table = reader.GetSchemaTable();
            var nameCol = table.Columns["ColumnName"];
            foreach (DataRow row in table.Rows)
            {
                count++;
                if (count > 4)
                {
                    txtEmailAddress.Items.Add(row[nameCol].ToString());
                }
            }
            DB.Con.Close();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            txtEmailAddress.Items.Clear();
            if (rdoEmail.Checked==true)
            {
                txtEmailAddress.Enabled = true;
                lblChange.Text = "Email Address";

                queryCmbo = "select Email from Contacts";
    
            }
            else
            {
                txtEmailAddress.Enabled = true;
                lblChange.Text = "Phone No";

                queryCmbo = "select PhoneNo from Contacts";

            }
            
            OleDbDataReader rdr = DB.DB_DG(queryCmbo);

            while (rdr.Read())
            {
                txtEmailAddress.Items.Add(rdr[0].ToString());
            }

            DB.Con.Close();

        }
        

        private void btnForgetPasswordChange_Click(object sender, EventArgs e)
        {
            OpenFileDialog OPDG = new OpenFileDialog();

            if (OPDG.ShowDialog()==DialogResult.OK)
            {
                txtAttatchFile.Text = OPDG.FileName;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void rdoMessage_CheckedChanged(object sender, EventArgs e)
        {
            txtAttatchFile.Enabled = false;
            btnOpenFile.Enabled = false;
            lblChange.Text = "Phone Number";
            txtSubjext.Enabled = false;
        }

        private void rdoEmail_CheckedChanged(object sender, EventArgs e)
        {
            txtAttatchFile.Enabled = true;
            btnOpenFile.Enabled = true;
            lblChange.Text = "Email Address";
            txtSubjext.Enabled = true;
        
        }

        private void ucMsgEmail_Load(object sender, EventArgs e)
        {
        }
        private int h, m, s, ms;
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            ms--;
            if (ms == 0 && s != 0)
            {
                ms = 60;
                s--;
            }
            if (s== 0&&m!=0)
            {
                s = 60;
                m--;
            }
            if (m == 0 && h != 0)
            {
                m = 60;
                h--;
            }
            if (ms==-1)
            {
                timer1.Stop();
                
                    mailAndMsg();
                
                
                    
                
            }
            txtMS.Text = ms.ToString();
            txtS.Text = s.ToString();
            txtM.Text = m.ToString();
            txtH.Text = h.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                txtH.Enabled=false;
                txtM.Enabled = false;
                txtS.Enabled = false;
                txtMS.Enabled = false;

            h = int.Parse(txtH.Text);
            m = int.Parse(txtM.Text);
            s = int.Parse(txtS.Text);
            ms = 60;

            timer1 = new System.Windows.Forms.Timer();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 10;
            timer1.Start();
            txtS.Text = txtMS.ToString();
        }

        private void chkTimer_CheckedChanged(object sender, EventArgs e)
        {
            txtMS.Enabled = true;
            txtS.Enabled = true;
            txtM.Enabled = true;
            txtH.Enabled = true;
            btnStart.Enabled = true;
            btnCreateUserSingUp.Enabled = false;
        }

        //Send message

        public static string SendSMS(string Masking, string toNumber, string MessageText, string MyUsername, string MyPassword)
        {
            String URI = "http://sendpk.com" +
            "/api/sms.php?" +
            "username=" + MyUsername +
            "&password=" + MyPassword +
            "&sender=" + Masking +
            "&mobile=" + toNumber +
            "&message=" + Uri.UnescapeDataString(MessageText);

            try
            {
                WebRequest req = WebRequest.Create(URI);
                WebResponse resp = req.GetResponse();
                var sr = new System.IO.StreamReader(resp.GetResponseStream());
                return sr.ReadToEnd().Trim();
            }
            catch (WebException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return null;
        }

    }
}
