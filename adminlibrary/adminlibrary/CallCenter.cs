using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;


namespace adminlibrary
{
    class CallCenter
    {
        public static OleDbConnection conn = new OleDbConnection();
        public static OleDbCommand cmd = new OleDbCommand("", conn);
        public static OleDbDataAdapter da;
        public static OleDbDataReader rd;
        public static DataSet ds = new DataSet();

        public static string currentUsername = "";

        public static string sql;

        public static bool IsFind = false;


        public static void openConnection()
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=../../../db_library.accdb.accdb;";
                    conn.Open();
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show("ระบบไม่สามารถสร้างการเชื่อมต่อได้" + "\n" +
                    "รายละเอียด: " + ex.Message.ToString(), "ผิดพลาด",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void closeConnection()
        {
            try
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }

            }
            catch
            {
                MessageBox.Show("Close Connection Failed");

            }
        }

    }
}
