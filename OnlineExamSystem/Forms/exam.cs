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
    public partial class exam : Form
    {
        public exam()
        {
            InitializeComponent();
        }
       
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-0H86OC5\\SQLEXPRESS;Initial Catalog=dotnetdatabase;Integrated Security=True");
        DataTable dt = new DataTable();
        string[] ans = new string[31], sans = new string[31];
        int times, scores, marks, total, percentage;
        int i = 0, k=0,m=0;
        string subject, grade;

        private void exam_Load(object sender, EventArgs e)
        {
            subject = studexam.subtext;
            subjecttxt.Text = subject;
            datelabel.Text = DateTime.Now.ToShortDateString();
            times = 60;
            showtime.Interval = 1000;
            showtime.Start();
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from questionbank where subject='" + subject + "'", conn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            displaydata(i);
            conn.Close();
        }

        private void displaydata(int index)
        {
            qnotxt.Text = dt.Rows[index]["qno"].ToString();
            qtext.Text = dt.Rows[index]["question"].ToString();
            op1txt.Text = dt.Rows[index]["option1"].ToString();
            op2txt.Text = dt.Rows[index]["option2"].ToString();
            op3txt.Text = dt.Rows[index]["option3"].ToString();
            op4txt.Text = dt.Rows[index]["option4"].ToString();
        }

        private void nextbtn_Click(object sender, EventArgs e)
        {
            i += 1;
            if (i > dt.Rows.Count - 1)
            {
                i = dt.Rows.Count - 1;
                 nextbtn.Enabled = false;
            MessageBox.Show("All Questions Over. Please Click On Submit");
            examtimer.Stop();
            }
            displaydata(i);
            if (op1.Checked)
            {
                sans[k] = "option1";
                k += 1;
            }
            else if(op2.Checked)
            {
                sans[k] = "option2";
                k += 1;
            }
            else if (op3.Checked)
            {
                sans[k] = "option3";
                k += 1;
            }
            else if (op4.Checked)
            {
                sans[k] = "option4";
                k += 1;
            }
            op1.Checked = false;
            op2.Checked = false;
            op3.Checked = false;
            op4.Checked = false;
        }
        private void collectanswer()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("select answer from questionbank where subject='" + subject + "'", conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ans[m] = dr.GetString(0);
                m += 1;
            }
          conn.Close();
        }
        private void checkanswer()
        {
            for (int j = 0; j <= m; j++)
            {
                if (ans[j] == sans[j])
                {
                    scores += 1;
                }
            }
            marks = scores - 1;
        marks = marks * 10;
        total = m * 10;
        }

        private void sumitbtn_Click(object sender, EventArgs e)
        {
            string stcode= studexam.studcode;
            collectanswer();
            checkanswer();
            MessageBox.Show("Marks = " + marks.ToString() + " out of " + total.ToString(), "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            percentage = marks * 100 /total;
            if (percentage >= 80)
            {
                grade = "A+";
            }
            else if (percentage >= 60)
            {
                grade = "A";
            }
            else if (percentage >= 40)
            {
                grade = "B";
            }
            else if (percentage <= 30)
            {
                grade = "F";
            }
            MessageBox.Show(percentage.ToString()+"% "+ grade);
            conn.Open();
            SqlCommand cmd = new SqlCommand("update student set marks =" + marks + ", studpercent="+percentage +" , grade = '"+grade +"' where studid='" + stcode + "'  ", conn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            conn.Close();
            this.Dispose();
            var frm = new student();
            frm.Show();
        }

        private void examtimer_Tick(object sender, EventArgs e)
        {
            timeleft.Text = times + "seconds";
            times -=1 ;
            if (times == -1)
            {
                this.examtimer.Stop();
                MessageBox.Show("Exam Time Is Over");
                timeleft.Visible = false;
            }

        }

        private void showtime_Tick(object sender, EventArgs e)
        {
            timelabel.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
