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
    public partial class adminlogged : Form
    {
        public adminlogged()
        {
            InitializeComponent();
        }

        private void addControls(UserControl uc)
        {
            panelControls.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            panelControls.Controls.Add(uc);
            uc.BringToFront();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            UCadminquestion ad = new UCadminquestion();
            addControls(ad);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UCadminstud astud = new UCadminstud();
            addControls(astud);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            var frm = new adminlogin();
            frm.Show();
        }
    }
}
