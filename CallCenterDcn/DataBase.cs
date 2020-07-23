using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
namespace CallCenterDcn
{
    class DataBase
    {
        public OleDbConnection Con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\DCN\Projects\CallCenterDcn\CallCenterDcn\bin\Debug\dbDCN.accdb");
        int a;
        OleDbCommand cmd;
        public int RunQuery(string Query)
        {
            try
            {
            cmd = new OleDbCommand(Query, Con);
            Con.Open();

            a = cmd.ExecuteNonQuery();
            Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            
            }
            return a;
        }

        OleDbDataReader rdr;
        public OleDbDataReader DB_DG(String queryDG)
        {

            try
            {
            OleDbCommand cmd = new OleDbCommand(queryDG, Con);
            DataTable dt = new DataTable();
            Con.Open();
            rdr = cmd.ExecuteReader();

            }
            catch (Exception)
            {
                MessageBox.Show("Input Error!!");
            }


            return rdr;

        }

        public DataTable DB_DataGrid(string DGquery)
        {
            DataTable dt = new DataTable();
            try
            {
            Con.Open();
            OleDbCommand cmd = new OleDbCommand(DGquery, Con);
            OleDbDataAdapter adb = new OleDbDataAdapter(cmd);

            adb.Fill(dt);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }


            return dt;
        }
    }
}
