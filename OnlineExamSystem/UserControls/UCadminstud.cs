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
    public partial class UCadminstud : UserControl
    {
        public UCadminstud()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-0H86OC5\\SQLEXPRESS;Initial Catalog=dotnetdatabase;Integrated Security=True");
        DataTable dt = new DataTable();
        public string sid;
        private void loadstuddata()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("select studid, fname,lname,age,address,mobile,email,gender,dob,category,subject from student", conn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            dt.Clear();
            sda.Fill(dt);
            studentview.DataSource = dt;
            conn.Close();
        }

        private void UCadminstud_Load(object sender, EventArgs e)
        {
            loadstuddata();
        }
        DataGridViewRow sr = new DataGridViewRow();
        private void studentview_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow sr = studentview.Rows[e.RowIndex];
                sid = sr.Cells[0].Value.ToString();
                firstnametxt.Text = sr.Cells[1].Value.ToString();
                lastnametxt.Text = sr.Cells[2].Value.ToString();
                agetxt.Text = sr.Cells[3].Value.ToString();
                addressext.Text = sr.Cells[4].Value.ToString();
                contacttxt.Text = sr.Cells[5].Value.ToString();
                eidtxt.Text = sr.Cells[6].Value.ToString();
                gendertxt.Text = sr.Cells[7].Value.ToString();
                dobpicker.Value = Convert.ToDateTime(sr.Cells[8].Value);
                categorytxt.Text = sr.Cells[9].Value.ToString();
               subboxtxt.Text = sr.Cells[10].Value.ToString();
            }
        }

        private void refreshbtn_Click(object sender, EventArgs e)
        {
            loadstuddata();
        }

        private void editbtn_Click(object sender, EventArgs e)
        {
            string fname, lname, sage, sadd,smob,seid,sgen,bday,scat,ssub;
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
            SqlCommand cmd = new SqlCommand("update student set fname='" + fname + "', lname='" + lname + "',age='" + sage + "',address='" + sadd  + "',mobile='" + smob + "',email='" + seid + "',gender='" + sgen + "',dob='" + bday + "',category='" + scat + "',subject='" + ssub + "'  where studid =" + sid + "", conn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            MessageBox.Show("Record Updated Successfully", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            sda.Fill(dt);
            conn.Close();
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to delete this record?", "Delete Msg", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("delete from student where studid =" + sid + "", conn);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                MessageBox.Show("Record Deleted Successfully", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sda.Fill(dt);
                conn.Close();
            }
        }

        private void resetbtn_Click(object sender, EventArgs e)
        {
            foreach (TextBox tb in Controls.OfType<TextBox>())
                tb.Text = "";
            foreach (ComboBox cb in Controls.OfType<ComboBox>())
                cb.Text = "";
        }
    }
}
