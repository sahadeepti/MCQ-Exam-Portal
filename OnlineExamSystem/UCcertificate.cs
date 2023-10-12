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
    public partial class UCcertificate : UserControl
    {
        public UCcertificate()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-0H86OC5\\SQLEXPRESS;Initial Catalog=dotnetdatabase;Integrated Security=True");
        DataTable dt = new DataTable();
        private void UCcertificate_Load(object sender, EventArgs e)
        {
            string scode=student.studcode;
            conn.Open();
            SqlCommand cmd = new SqlCommand("select fname,lname,studpercent,grade,subject from student where studid='" + scode + "'", conn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                string firstname = dt.Rows[0]["fname"].ToString();
                string lastname = dt.Rows[0]["lname"].ToString();
                string percent = dt.Rows[0]["studpercent"].ToString();
                string grade = dt.Rows[0]["grade"].ToString();
                string subject = dt.Rows[0]["subject"].ToString();
                label1.Text = "This is to certify "+firstname+" "+lastname+" succesfully completed the exam with "+percent +" with grade "+ grade.ToUpper();
            }
            conn.Close();           
        }
      }
    }

