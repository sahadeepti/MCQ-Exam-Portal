using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineExamSystem
{
    public partial class UCadminquestion : UserControl
    {
        public UCadminquestion()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-0H86OC5\\SQLEXPRESS;Initial Catalog=dotnetdatabase;Integrated Security=True");
        DataTable dt = new DataTable();

        private void loaddata()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from questionbank", conn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            dt.Clear();
            sda.Fill(dt);
            questionview.DataSource = dt;
            conn.Close();
        }
        private void UCadminquestion_Load(object sender, EventArgs e)
        {
            loaddata();
        }
        private void addbtn_Click(object sender, EventArgs e)
        {
            string qno, question, subject, op1, op2, op3, op4, ans;
            qno = qnotxt.Text;
            question = qtext.Text;
            subject = subjecttxt.Text;
            op1 = op1txt.Text;
            op2 = op2txt.Text;
            op3 = op3txt.Text;
            op4 = op4txt.Text;
            ans = anstxt.Text;
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into questionbank(qno,subject,question,option1,option2,option3,option4,answer) values('" + qno + "','" + subject + "','" + question + "','" + op1 + "','" + op2 + "','" + op3 + "','" + op4 + "','" + ans + "' )", conn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            MessageBox.Show("Record Inserted Successfully", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            conn.Close();
        }

        private void refreshbtn_Click(object sender, EventArgs e)
        {
            loaddata();
        }

        private void resetbtn_Click(object sender, EventArgs e)
        {
            foreach (TextBox tb in Controls.OfType<TextBox>())
                tb.Text = "";
            foreach (ComboBox cb in Controls.OfType<ComboBox>())
                cb.Text = "";
        }

        DataGridViewRow sr = new DataGridViewRow();
        public string qid;

        private void editbtn_Click(object sender, EventArgs e)
        {
            string qno, question, subject, op1, op2, op3, op4, ans;
            qno = qnotxt.Text;
            question = qtext.Text;
            subject = subjecttxt.Text;
            op1 = op1txt.Text;
            op2 = op2txt.Text;
            op3 = op3txt.Text;
            op4 = op4txt.Text;
            ans = anstxt.Text;
            conn.Open();
            SqlCommand cmd = new SqlCommand("update questionbank set qno='" + qno + "',subject='" + subject + "',question='" + question + "',option1='" + op1 + "',option2='" + op2 + "',option3='" + op3 + "',option4='" + op4 + "',answer='" + ans + "' where id =" + qid + "",conn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            MessageBox.Show("Record Updated Successfully", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            sda.Fill(dt);
            conn.Close();
        }

        private void questionview_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow sr = questionview.Rows[e.RowIndex];
                qnotxt.Text = sr.Cells[0].Value.ToString();
                subjecttxt.Text = sr.Cells[1].Value.ToString();
                qtext.Text = sr.Cells[2].Value.ToString();
                op1txt.Text = sr.Cells[3].Value.ToString();
                op2txt.Text = sr.Cells[4].Value.ToString();
                op3txt.Text = sr.Cells[5].Value.ToString();
                op4txt.Text = sr.Cells[6].Value.ToString();
                anstxt.Text = sr.Cells[7].Value.ToString();
                qid = sr.Cells[8].Value.ToString();
            }
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to delete this record?", "Delete Msg", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("delete from questionbank where id =" + qid + "", conn);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                MessageBox.Show("Record Deleted Successfully", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sda.Fill(dt);
                conn.Close();
            }
   
        }
    }
}
