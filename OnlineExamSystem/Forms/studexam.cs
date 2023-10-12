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
    public partial class studexam : Form
    {
        public studexam()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-0H86OC5\\SQLEXPRESS;Initial Catalog=dotnetdatabase;Integrated Security=True");
        DataTable dt = new DataTable();
        public static string subtext;
        public static string studcode;

        private void sumitbtn_Click(object sender, EventArgs e)
        {
            string code, sub, sfname;
            code = codetxt.Text;
            sub = subboxtxt.Text;
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from student where studid='"+code+"' and subject='"+sub+"'",conn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Details Matched", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                instbox.Visible = true;
                subtext = subboxtxt.Text;
                studcode = code;
            }
            else {
                MessageBox.Show("Details does not match");
            }
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                sfname = dr.GetString(1);
                Label4.Text = "Welcome " + sfname;
            }
            conn.Close();
        }

        private void studexam_Load(object sender, EventArgs e)
        {
            instbox.Visible = false;
            Label4.Visible = false;
            Label6.Visible = false;
            ProgressBar1.Visible = false;
            timer1.Enabled = false;
            exambtn.Visible = false;
            
        }

        private void agreebtn_Click(object sender, EventArgs e)
        {
            Label4.Visible = true;
            exambtn.Visible = true;
        }

        private void exambtn_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            ProgressBar1.Visible = true;
            Label6.Visible = true;
            exambtn.Enabled = false;
            Label6.Text = "Good Luck";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ProgressBar1.Value = ProgressBar1.Value + 1;
            if (ProgressBar1.Value >= 100)
            {
                timer1.Stop();
                this.Hide();
                var fm = new exam();
                fm.Show();
            }
        }
    }
}
