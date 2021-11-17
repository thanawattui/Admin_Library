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
            if ((txt_username .Text=="admin" )&&(txt_password .Text=="12345" ))
                {
                this.Hide();
                Welcome f2 = new Welcome();
                f2.Show();
            }
            else 
            {
                MessageBox.Show("Wrong username of password .try Again","wrnning!!");
                txt_username.Clear();
                txt_password.Clear();
                txt_username.Select();
            }
        }

        private void txt_username_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
