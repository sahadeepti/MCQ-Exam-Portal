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
    public partial class adminlogin : Form
    {
        public adminlogin()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-0H86OC5\\SQLEXPRESS;Initial Catalog=dotnetdatabase;Integrated Security=True");

        private void loginbtn_Click(object sender, EventArgs e)
        {
            string name,password;
            name = admin.Text;
            password=pass.Text;
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from admin where admin_name='" + name + "' and admin_pass='" + password + "'", conn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd );
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if(dt.Rows.Count >0)
            {
                MessageBox.Show("Login Success", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                var nf = new adminlogged();
                nf.Show();
            }
            conn.Close();
        }

        private void resetbtn_Click(object sender, EventArgs e)
        {
            admin.Text = "";
            pass.Text = "";
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
