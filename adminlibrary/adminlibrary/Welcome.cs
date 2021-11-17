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
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
            login f1 = new login();
            f1.Show();
        }

        private void btn_student_Click(object sender, EventArgs e)
        {
            this.Hide();
            student cf1 = new student ();         
            cf1.Show();            
        }

        private void btn_teacher_Click(object sender, EventArgs e)
        {
            this.Hide();
            teacher cf1 = new teacher ();
            cf1.Show();
        }

        private void btn_borrow_Click(object sender, EventArgs e)
        {
            this.Hide();
            borrow cf1 = new borrow();
            cf1.Show();
        }
    }
}
