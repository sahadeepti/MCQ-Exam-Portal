using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineExamSystem
{
    public partial class studresult : Form
    {
        public studresult()
        {
            InitializeComponent();
        }
        private void studresult_Load(object sender, EventArgs e)
        {
            string fname = student.firstname;
            string lname = student.lastname;
            string fullname = fname + " " + lname;
            studname.Text = fullname.ToUpper();
        }
        private void addControls(UserControl uc)
        {
            intropanel.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            intropanel.Controls.Add(uc);
            uc.BringToFront();
        }
        private void resultbtn_Click(object sender, EventArgs e)
        {
            UCresult sr = new UCresult();
            addControls(sr);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UCcertificate cer = new UCcertificate();
            addControls(cer);
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
