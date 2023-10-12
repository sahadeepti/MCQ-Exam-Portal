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
    public partial class student : Form
    {
        public student()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-0H86OC5\\SQLEXPRESS;Initial Catalog=dotnetdatabase;Integrated Security=True");
        DataTable dt = new DataTable();
        public int scode;
        public static string studcode;
        public static string firstname;
        public static string lastname;
        private void resetbtn_Click(object sender, EventArgs e)
        {
            clearfields();
        }

        private void clearfields()
        {
            foreach (Control ctr in tabControl1.SelectedTab.Controls)
            {
                if (ctr is TextBox)
                {
                    (ctr as TextBox).Text = "";
                }
                if (ctr is ComboBox)
                {
                    (ctr as ComboBox).Text = "";
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void registerbtn_Click(object sender, EventArgs e)
        {
            string fname, lname, sage, sadd, smob, seid, sgen, bday, scat, ssub;
            fname = firstnametxt.Text;
            lname = lastnametxt.Text;
            sage = agetxt.Text;
            sadd = addressext.Text;
            smob = contacttxt.Text;
            seid = eidtxt.Text;
            sgen = gendertxt.Text;
            bday = dobpicker.Text;
            scat = categorytxt.Text;
            ssub = subboxtxt.Text;
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into student(fname,lname,age,address,mobile,email,gender,dob,category,subject) values('" + fname + "','" + lname + "'," + sage + ",'" + sadd + "','" + smob + "','" + seid + "','" + sgen + "','" + bday + "','" + scat + "','" + ssub + "') ",conn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            MessageBox.Show("Registration Successfull, Click on Get Code to know your student code.", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            conn.Close();
        }

        private void getcodebtn_Click(object sender, EventArgs e)
        {
           string seid = eidtxt.Text;
            conn.Open();
            SqlCommand cmd = new SqlCommand("select studid from student where email='"+seid+"'",conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                scode = dr.GetInt32(0);
            }
            conn.Close();
            MessageBox.Show("Your Code: "+scode);
        }

        private void continuebtn_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = logintab;
        }

        private void examlogin_Click(object sender, EventArgs e)
        {
            string fname, lname, scode;
            fname = fnametxt.Text;
            lname = lnametxt.Text;
            scode = codetxt.Text;
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from student where studid='" + scode + "' and fname='" + fname + "' and lname='" + lname + "'", conn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Login Success", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
                var sf = new studexam();
                sf.Show();
            }
            conn.Close();
        }

        private void resultlogin_Click(object sender, EventArgs e)
        {
            string fname, lname, scode;
            fname = fnametxt.Text;
            lname = lnametxt.Text;
            scode = codetxt.Text;
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from student where studid='" + scode + "' and fname='" + fname + "' and lname='" + lname + "'", conn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                firstname = fnametxt.Text;
                lastname = lnametxt.Text;
                studcode = codetxt.Text;
                MessageBox.Show("Login Success", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                var frm = new studresult();
                frm.Show();
            }
            conn.Close();           
        }
    }
}
