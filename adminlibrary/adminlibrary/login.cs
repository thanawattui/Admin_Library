using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace adminlibrary
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {

            if ((string.IsNullOrEmpty(this.txt_username.Text.Trim())) ||
                (string.IsNullOrEmpty(this.txt_password.Text.Trim())))
            {
                MessageBox.Show("Enter your username and password", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                if (this.txt_username.CanSelect)
                {
                    this.txt_username.Select();
                }
                return;
            }

            CallCenter.sql = "SELECT * FROM tb_login WHERE Username = @us AND Password = @pa";

            CallCenter.cmd.Parameters.Clear();
            CallCenter.cmd.CommandType = CommandType.Text;
            CallCenter.cmd.CommandText = CallCenter.sql;

            CallCenter.cmd.Parameters.AddWithValue("@us", this.txt_username.Text.Trim().ToString());
            CallCenter.cmd.Parameters.AddWithValue("@pa", this.txt_password.Text.Trim().ToString());

            CallCenter.openConnection();

            CallCenter.rd = CallCenter.cmd.ExecuteReader();

            if (CallCenter.rd.HasRows)
            {
                while (CallCenter.rd.Read())
                {
                    CallCenter.currentUsername = CallCenter.rd[1].ToString();

                    MessageBox.Show("Welcome  " + CallCenter.currentUsername,"\n Login Successed :)",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    Welcome frm = new Welcome();
                    frm.Show();

                }
                this.txt_password.Text = string.Empty;
                this.txt_username.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("ผิดพลาด", "Invalid Username or Password",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                if (this.txt_username.CanSelect)
                {
                    this.txt_username.Select();
                }

                this.txt_password.Text = string.Empty;
                this.txt_username.Text = string.Empty;
                //MessageBox.Show(CallCenter.currentUsername);

            }

            CallCenter.rd.Close();
            CallCenter.closeConnection();
        }

        private void txt_username_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
