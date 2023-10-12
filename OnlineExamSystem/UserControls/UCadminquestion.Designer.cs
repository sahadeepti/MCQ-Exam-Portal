namespace OnlineExamSystem
{
    partial class UCadminquestion
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.questionview = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.qnotxt = new System.Windows.Forms.TextBox();
            this.qtext = new System.Windows.Forms.TextBox();
            this.op1txt = new System.Windows.Forms.TextBox();
            this.op2txt = new System.Windows.Forms.TextBox();
            this.op3txt = new System.Windows.Forms.TextBox();
            this.op4txt = new System.Windows.Forms.TextBox();
            this.subjecttxt = new System.Windows.Forms.ComboBox();
            this.anstxt = new System.Windows.Forms.ComboBox();
            this.addbtn = new System.Windows.Forms.Button();
            this.editbtn = new System.Windows.Forms.Button();
            this.deletebtn = new System.Windows.Forms.Button();
            this.resetbtn = new System.Windows.Forms.Button();
            this.refreshbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.questionview)).BeginInit();
            this.SuspendLayout();
            // 
            // questionview
            // 
            this.questionview.AllowUserToAddRows = false;
            this.questionview.AllowUserToDeleteRows = false;
            this.questionview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.questionview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.questionview.Location = new System.Drawing.Point(3, 3);
            this.questionview.Name = "questionview";
            this.questionview.RowTemplate.Height = 24;
            this.questionview.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.questionview.Size = new System.Drawing.Size(1511, 384);
            this.questionview.TabIndex = 0;
            this.questionview.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.questionview_CellMouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 433);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Question No :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(532, 433);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Subject :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 494);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Question :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(34, 556);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Option1 :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(532, 556);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Option3 :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(532, 622);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 25);
            this.label6.TabIndex = 7;
            this.label6.Text = "Option4 :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(34, 622);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "Option2 :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(34, 688);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 25);
            this.label8.TabIndex = 8;
            this.label8.Text = "Answer :";
            // 
            // qnotxt
            // 
            this.qnotxt.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qnotxt.Location = new System.Drawing.Point(180, 433);
            this.qnotxt.Multiline = true;
            this.qnotxt.Name = "qnotxt";
            this.qnotxt.Size = new System.Drawing.Size(124, 25);
            this.qnotxt.TabIndex = 9;
            this.qnotxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // qtext
            // 
            this.qtext.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qtext.Location = new System.Drawing.Point(161, 494);
            this.qtext.Multiline = true;
            this.qtext.Name = "qtext";
            this.qtext.Size = new System.Drawing.Size(920, 25);
            this.qtext.TabIndex = 10;
            this.qtext.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // op1txt
            // 
            this.op1txt.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.op1txt.Location = new System.Drawing.Point(141, 555);
            this.op1txt.Multiline = true;
            this.op1txt.Name = "op1txt";
            this.op1txt.Size = new System.Drawing.Size(242, 25);
            this.op1txt.TabIndex = 11;
            this.op1txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // op2txt
            // 
            this.op2txt.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.op2txt.Location = new System.Drawing.Point(141, 621);
            this.op2txt.Multiline = true;
            this.op2txt.Name = "op2txt";
            this.op2txt.Size = new System.Drawing.Size(242, 25);
            this.op2txt.TabIndex = 12;
            this.op2txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // op3txt
            // 
            this.op3txt.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.op3txt.Location = new System.Drawing.Point(630, 556);
            this.op3txt.Multiline = true;
            this.op3txt.Name = "op3txt";
            this.op3txt.Size = new System.Drawing.Size(242, 25);
            this.op3txt.TabIndex = 13;
            // 
            // op4txt
            // 
            this.op4txt.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.op4txt.Location = new System.Drawing.Point(630, 621);
            this.op4txt.Multiline = true;
            this.op4txt.Name = "op4txt";
            this.op4txt.Size = new System.Drawing.Size(242, 25);
            this.op4txt.TabIndex = 14;
            this.op4txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // subjecttxt
            // 
            this.subjecttxt.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subjecttxt.FormattingEnabled = true;
            this.subjecttxt.Items.AddRange(new object[] {
            "php",
            "html",
            "mysql",
            "css"});
            this.subjecttxt.Location = new System.Drawing.Point(630, 432);
            this.subjecttxt.Name = "subjecttxt";
            this.subjecttxt.Size = new System.Drawing.Size(148, 33);
            this.subjecttxt.TabIndex = 15;
            // 
            // anstxt
            // 
            this.anstxt.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.anstxt.FormattingEnabled = true;
            this.anstxt.Items.AddRange(new object[] {
            "option1",
            "option2",
            "option3",
            "option4"});
            this.anstxt.Location = new System.Drawing.Point(141, 685);
            this.anstxt.Name = "anstxt";
            this.anstxt.Size = new System.Drawing.Size(148, 33);
            this.anstxt.TabIndex = 16;
            // 
            // addbtn
            // 
            this.addbtn.BackColor = System.Drawing.Color.Navy;
            this.addbtn.FlatAppearance.BorderSize = 0;
            this.addbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addbtn.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addbtn.ForeColor = System.Drawing.Color.White;
            this.addbtn.Location = new System.Drawing.Point(1130, 422);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(123, 52);
            this.addbtn.TabIndex = 17;
            this.addbtn.Text = "ADD";
            this.addbtn.UseVisualStyleBackColor = false;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // editbtn
            // 
            this.editbtn.BackColor = System.Drawing.Color.Navy;
            this.editbtn.FlatAppearance.BorderSize = 0;
            this.editbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editbtn.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editbtn.ForeColor = System.Drawing.Color.White;
            this.editbtn.Location = new System.Drawing.Point(1314, 422);
            this.editbtn.Name = "editbtn";
            this.editbtn.Size = new System.Drawing.Size(133, 52);
            this.editbtn.TabIndex = 18;
            this.editbtn.Text = "EDIT";
            this.editbtn.UseVisualStyleBackColor = false;
            this.editbtn.Click += new System.EventHandler(this.editbtn_Click);
            // 
            // deletebtn
            // 
            this.deletebtn.BackColor = System.Drawing.Color.Navy;
            this.deletebtn.FlatAppearance.BorderSize = 0;
            this.deletebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deletebtn.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletebtn.ForeColor = System.Drawing.Color.White;
            this.deletebtn.Location = new System.Drawing.Point(1130, 521);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(123, 50);
            this.deletebtn.TabIndex = 19;
            this.deletebtn.Text = "DELETE";
            this.deletebtn.UseVisualStyleBackColor = false;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // resetbtn
            // 
            this.resetbtn.BackColor = System.Drawing.Color.Navy;
            this.resetbtn.FlatAppearance.BorderSize = 0;
            this.resetbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetbtn.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetbtn.ForeColor = System.Drawing.Color.White;
            this.resetbtn.Location = new System.Drawing.Point(1314, 521);
            this.resetbtn.Name = "resetbtn";
            this.resetbtn.Size = new System.Drawing.Size(133, 50);
            this.resetbtn.TabIndex = 20;
            this.resetbtn.Text = "RESET";
            this.resetbtn.UseVisualStyleBackColor = false;
            this.resetbtn.Click += new System.EventHandler(this.resetbtn_Click);
            // 
            // refreshbtn
            // 
            this.refreshbtn.BackColor = System.Drawing.Color.Navy;
            this.refreshbtn.FlatAppearance.BorderSize = 0;
            this.refreshbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshbtn.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshbtn.ForeColor = System.Drawing.Color.White;
            this.refreshbtn.Location = new System.Drawing.Point(1229, 622);
            this.refreshbtn.Name = "refreshbtn";
            this.refreshbtn.Size = new System.Drawing.Size(132, 41);
            this.refreshbtn.TabIndex = 21;
            this.refreshbtn.Text = "REFRESH";
            this.refreshbtn.UseVisualStyleBackColor = false;
            this.refreshbtn.Click += new System.EventHandler(this.refreshbtn_Click);
            // 
            // UCadminquestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.refreshbtn);
            this.Controls.Add(this.resetbtn);
            this.Controls.Add(this.deletebtn);
            this.Controls.Add(this.editbtn);
            this.Controls.Add(this.addbtn);
            this.Controls.Add(this.anstxt);
            this.Controls.Add(this.subjecttxt);
            this.Controls.Add(this.op4txt);
            this.Controls.Add(this.op3txt);
            this.Controls.Add(this.op2txt);
            this.Controls.Add(this.op1txt);
            this.Controls.Add(this.qtext);
            this.Controls.Add(this.qnotxt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.questionview);
            this.Name = "UCadminquestion";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(1522, 749);
            this.Load += new System.EventHandler(this.UCadminquestion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.questionview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView questionview;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox qnotxt;
        private System.Windows.Forms.TextBox qtext;
        private System.Windows.Forms.TextBox op1txt;
        private System.Windows.Forms.TextBox op2txt;
        private System.Windows.Forms.TextBox op3txt;
        private System.Windows.Forms.TextBox op4txt;
        private System.Windows.Forms.ComboBox subjecttxt;
        private System.Windows.Forms.ComboBox anstxt;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.Button editbtn;
        private System.Windows.Forms.Button deletebtn;
        private System.Windows.Forms.Button resetbtn;
        private System.Windows.Forms.Button refreshbtn;
    }
}
