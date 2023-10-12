using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineExamSystem
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void admin_login_Click(object sender, EventArgs e)
        {
            this.Hide();
            var f2 = new adminlogin();
            f2.Show();
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void student_login_Click(object sender, EventArgs e)
        {
            this.Hide();
            var fm = new student();
            fm.Show();
        }
    }
}
