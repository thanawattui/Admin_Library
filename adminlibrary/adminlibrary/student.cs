using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace adminlibrary
{
    public partial class student : Form
    {
        public student()
        {
            InitializeComponent();
        }

        string strConn = "provider=Microsoft.ACE.OLEDB.12.0;data source=../../../../student.accdb";
        public string sql;
        OleDbConnection Conn = new OleDbConnection();
        OleDbDataAdapter da;
        DataSet ds = new DataSet();
        bool IsFind = false;

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
            Welcome f1 = new Welcome();
            f1.Show();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {

        }

        private void student_Load(object sender, EventArgs e)
        {
            if (Conn.State == ConnectionState.Open)
            {
                Conn.Close();
            }
            Conn.ConnectionString = strConn;
            Conn.Open();

            showAllData();
        }

        private void showAllData()
        {
            string sqlStu = "select * from student";
            if (IsFind == true)
            {
                ds.Tables["student"].Clear();
            }
            da = new OleDbDataAdapter(sqlStu, Conn);
            da.Fill(ds, "student");
            if (ds.Tables["student"].Rows.Count != 0)
            {
                IsFind = true;
                DGV_student.ReadOnly = true;
                DGV_student.DataSource = ds.Tables["student"];
            }
            else
            {
                IsFind = false;
            }
        }

        private void formatDataStudent()
        {
            DataGridViewCellStyle cs = new DataGridViewCellStyle();
            cs.Font = new Font("ms Sans Serif", 9, FontStyle.Regular);
            DGV_student.ColumnHeadersDefaultCellStyle = cs;
            DGV_student.Columns[0].HeaderText = "รหัสนักศึกษา";
            DGV_student.Columns[1].HeaderText = "ชื่อ";
            DGV_student.Columns[2].HeaderText = "นามสกุล";
            DGV_student.Columns[3].HeaderText = "กำลังศึกษาอยู่";
            DGV_student.Columns[4].HeaderText = "คณะ";
            DGV_student.Columns[5].HeaderText = "สาขา";
            DGV_student.Columns[6].HeaderText = "วันที่สมัคร";
            DGV_student.Columns[7].HeaderText = "ที่อยู่";
            DGV_student.Columns[8].HeaderText = "รหัสไปรษณย์";
            DGV_student.Columns[9].HeaderText = "เบอร์";
            DGV_student.Columns[10].HeaderText = "gmail";

            DGV_student.Columns[0].Width = 80;
            DGV_student.Columns[1].Width = 120;
            DGV_student.Columns[2].Width = 120;
            DGV_student.Columns[3].Width = 100;
            DGV_student.Columns[4].Width = 80;
            DGV_student.Columns[5].Width = 80;
            DGV_student.Columns[6].Width = 80;
            DGV_student.Columns[7].Width = 80;
            DGV_student.Columns[8].Width = 80;
            DGV_student.Columns[9].Width = 80;
            DGV_student.Columns[10].Width = 80;
        }

        private void DGV_student_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == DGV_student.Rows.Count - 1)
            {
                return;
            }
            try
            {
                txt_id.Text = DGV_student.Rows[e.RowIndex].Cells[0].Value.ToString();
                txt_name.Text = DGV_student.Rows[e.RowIndex].Cells[1].Value.ToString();
                txt_surname.Text = DGV_student.Rows[e.RowIndex].Cells[2].Value.ToString();
                txt_status.Text = DGV_student.Rows[e.RowIndex].Cells[3].Value.ToString();
                txt_group .Text = DGV_student.Rows[e.RowIndex].Cells[4].Value.ToString();
                txt_branch .Text = DGV_student.Rows[e.RowIndex].Cells[5].Value.ToString();
                dtp_day .Value = Convert.ToDateTime(DGV_student.Rows[e.RowIndex].Cells[6].Value.ToString());
                txt_address .Text = DGV_student.Rows[e.RowIndex].Cells[7].Value.ToString();
                txt_zip .Text = DGV_student.Rows[e.RowIndex].Cells[8].Value.ToString();
                txt_phone .Text = DGV_student.Rows[e.RowIndex].Cells[9].Value.ToString();
                txt_gmail .Text = DGV_student.Rows[e.RowIndex].Cells[10].Value.ToString();
            }
            catch
            {
                MessageBox.Show("เกิดข้อผิดพลาด");
            }
        }
    }
}
