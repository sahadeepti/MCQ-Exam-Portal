using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineExamSystem
{
    public partial class UCresult : UserControl
    {
        public UCresult()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-0H86OC5\\SQLEXPRESS;Initial Catalog=dotnetdatabase;Integrated Security=True");
        DataTable dt = new DataTable();
        private void UCresult_Load(object sender, EventArgs e)
        {
            string studid = student.studcode;
            string fname = student.firstname;
            string lname = student.lastname;
            string fullname = fname + " " + lname;
            stid.Text = studid;
            stname.Text = fullname;
            conn.Open();
            SqlCommand cmd = new SqlCommand("select subject,marks,studpercent,grade from student where studid='" + studid + "'", conn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                stsub.Text = dt.Rows[0]["subject"].ToString();
                stmarks.Text = dt.Rows[0]["marks"].ToString();
                stpercent.Text = dt.Rows[0]["studpercent"].ToString();
                stgrade.Text = dt.Rows[0]["grade"].ToString();
            }
            conn.Close();
        }
    }
}
