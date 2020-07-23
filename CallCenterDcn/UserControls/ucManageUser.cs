using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Windows.Forms;

namespace CallCenterDcn.UserControls
{
    public partial class ucManageUser : UserControl
    {
        DataBase DB = new DataBase();
        public ucManageUser()
        {
            InitializeComponent();
        }

        private void dtaGruird()
        {
            dtaManageUser.DataSource = DB.DB_DataGrid("select ID,Name,PhoneNo,Email from Contacts");
            DB.Con.Close();

        }

        private void ucManageUser_Load(object sender, EventArgs e)
        {
            dtaGruird();
            dtaManageUser.Columns[0].Width = 40;
            dtaManageUser.Columns[1].Width = 130;
            dtaManageUser.Columns[2].Width = 140;

            dtaManageUser.Columns[3].Width = 250;
            AddIDsInComboBox();
            AddNumInComboBox();
        }

        //Add in combo box of groups
        public void AddIDsInComboBox()
        {
                  DB.Con.Open();
                  var cmd1 = new OleDbCommand("select * from Contacts", DB.Con);
                  var reader = cmd1.ExecuteReader(CommandBehavior.SchemaOnly);
                  int count = 0;
                      var table = reader.GetSchemaTable();
                      var nameCol = table.Columns["ColumnName"];
                      foreach (DataRow row in table.Rows)
                      {
                          count++;
                          if (count>4)
                          {
                              cmbGroup.Items.Add(row[nameCol].ToString());
                              cmbSelectGrpup.Items.Add(row[nameCol].ToString());
                          }
                      }
                      DB.Con.Close();
        }
        //Add in Num combo boc
        string queryCmbo;
        private void AddNumInComboBox()
        {

            queryCmbo = "select Name from Contacts";

            OleDbDataReader rdr = DB.DB_DG(queryCmbo);

            while (rdr.Read())
            {
                    cmbNameNum.Items.Add(rdr[0].ToString());
                
            }
            DB.Con.Close();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCreateUserSingUp_Click(object sender, EventArgs e)
        {
            DB.RunQuery("insert into Contacts (Name,PhoneNo,Email) values ('"+txtName.Text+"','"+txtPhoneNo.Text+"','"+txtEmail.Text+"')");
            MessageBox.Show("Data has been inserted");
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DB.RunQuery("ALTER TABLE Contacts ADD "+txtGroupName.Text+" text");
            MessageBox.Show("Created");
        }

        private void cmbNameNum_SelectedIndexChanged(object sender, EventArgs e)
        {
            queryCmbo = "select PhoneNo,Email from Contacts Where Name='"+cmbNameNum.Text+"'";

            OleDbDataReader rdr = DB.DB_DG(queryCmbo);

            while (rdr.Read())
            {
                lblPhoneNo.Text = rdr[0].ToString();
                lblEmailChange.Text = rdr[1].ToString();
            }
            DB.Con.Close();

        }

        private void btnCreatUserSingUp_Click(object sender, EventArgs e)
        {

            DB.RunQuery("update Contacts set  [" + cmbGroup.Text + "]='Y' where Name='" + cmbNameNum.Text + "'");
            MessageBox.Show("Data has been updated");
        }

        private void cmbSelectGrpup_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtaManageUser.DataSource = DB.DB_DataGrid("select Name,PhoneNo,Email from Contacts where "+cmbSelectGrpup.Text+"='Y'");
            DB.Con.Close();
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            cmbSelectGrpup.Text = "";
            dtaGruird();
        }
        // Get Selected Value

        string SelectedId;
        public void GetSelectedDataValue()
        {

            int rowindex = dtaManageUser.CurrentCell.RowIndex;

            SelectedId = dtaManageUser.Rows[rowindex].Cells[0].Value.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            GetSelectedDataValue();

            DB.RunQuery("DELETE FROM Contacts WHERE ID=" +SelectedId + "");
            dtaManageUser.Rows.RemoveAt(this.dtaManageUser.SelectedRows[0].Index);
            MessageBox.Show("Data Has Been Deleted");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string[] a = new string[4];
            for (int i = 0; i < 4; i++)
            {

                int rowindex = dtaManageUser.CurrentCell.RowIndex;
                a[i] = dtaManageUser.Rows[rowindex].Cells[i].Value.ToString();

                switch (i)
                {
                    case 1: txtName.Text = a[i]; break;
                    case 2: txtPhoneNo.Text = a[i]; break;
                    case 3: txtEmail.Text = a[i]; break;
                }

            }
            this.Refresh();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            GetSelectedDataValue();
            DB.RunQuery("update Contacts set Name='" + txtName.Text + "',[Email]='" + txtEmail.Text + "',[PhoneNo]='" + txtPhoneNo.Text + "' where ID = " + SelectedId + "");
            MessageBox.Show("Data has been updated");
        }

        private void dtaManageUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
