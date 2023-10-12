namespace OnlineExamSystem
{
    partial class studexam
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(studexam));
            this.codetxt = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.subboxtxt = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.sumitbtn = new System.Windows.Forms.Button();
            this.instbox = new System.Windows.Forms.GroupBox();
            this.agreebtn = new System.Windows.Forms.Button();
            this.instructi = new System.Windows.Forms.Label();
            this.ProgressBar1 = new System.Windows.Forms.ProgressBar();
            this.Label6 = new System.Windows.Forms.Label();
            this.exambtn = new System.Windows.Forms.Button();
            this.Label4 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.instbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // codetxt
            // 
            this.codetxt.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codetxt.Location = new System.Drawing.Point(162, 43);
            this.codetxt.Multiline = true;
            this.codetxt.Name = "codetxt";
            this.codetxt.Size = new System.Drawing.Size(174, 25);
            this.codetxt.TabIndex = 99;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(47, 43);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(109, 25);
            this.label15.TabIndex = 98;
            this.label15.Text = "Stud Code :";
            // 
            // subboxtxt
            // 
            this.subboxtxt.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subboxtxt.FormattingEnabled = true;
            this.subboxtxt.Items.AddRange(new object[] {
            "php",
            "html",
            "css",
            "mysql"});
            this.subboxtxt.Location = new System.Drawing.Point(516, 40);
            this.subboxtxt.Name = "subboxtxt";
            this.subboxtxt.Size = new System.Drawing.Size(148, 33);
            this.subboxtxt.TabIndex = 101;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(425, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 25);
            this.label8.TabIndex = 100;
            this.label8.Text = "Subject :";
            // 
            // sumitbtn
            // 
            this.sumitbtn.BackColor = System.Drawing.SystemColors.Menu;
            this.sumitbtn.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.sumitbtn.FlatAppearance.BorderSize = 2;
            this.sumitbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sumitbtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sumitbtn.ForeColor = System.Drawing.Color.MidnightBlue;
            this.sumitbtn.Location = new System.Drawing.Point(736, 39);
            this.sumitbtn.Name = "sumitbtn";
            this.sumitbtn.Size = new System.Drawing.Size(100, 37);
            this.sumitbtn.TabIndex = 102;
            this.sumitbtn.Text = "SUBMIT";
            this.sumitbtn.UseVisualStyleBackColor = false;
            this.sumitbtn.Click += new System.EventHandler(this.sumitbtn_Click);
            // 
            // instbox
            // 
            this.instbox.BackColor = System.Drawing.Color.White;
            this.instbox.Controls.Add(this.agreebtn);
            this.instbox.Controls.Add(this.instructi);
            this.instbox.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instbox.Location = new System.Drawing.Point(31, 163);
            this.instbox.Name = "instbox";
            this.instbox.Size = new System.Drawing.Size(568, 392);
            this.instbox.TabIndex = 112;
            this.instbox.TabStop = false;
            this.instbox.Text = "INSTRUCTION";
            // 
            // agreebtn
            // 
            this.agreebtn.BackColor = System.Drawing.Color.DarkGray;
            this.agreebtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.agreebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agreebtn.Location = new System.Drawing.Point(27, 318);
            this.agreebtn.Name = "agreebtn";
            this.agreebtn.Size = new System.Drawing.Size(112, 35);
            this.agreebtn.TabIndex = 8;
            this.agreebtn.Text = "Agree";
            this.agreebtn.UseVisualStyleBackColor = false;
            this.agreebtn.Click += new System.EventHandler(this.agreebtn_Click);
            // 
            // instructi
            // 
            this.instructi.AllowDrop = true;
            this.instructi.AutoEllipsis = true;
            this.instructi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructi.ForeColor = System.Drawing.Color.Black;
            this.instructi.Location = new System.Drawing.Point(23, 44);
            this.instructi.Name = "instructi";
            this.instructi.Size = new System.Drawing.Size(510, 255);
            this.instructi.TabIndex = 6;
            this.instructi.Text = resources.GetString("instructi.Text");
            // 
            // ProgressBar1
            // 
            this.ProgressBar1.Location = new System.Drawing.Point(698, 409);
            this.ProgressBar1.MarqueeAnimationSpeed = 200;
            this.ProgressBar1.Name = "ProgressBar1";
            this.ProgressBar1.Size = new System.Drawing.Size(320, 18);
            this.ProgressBar1.Step = 100;
            this.ProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.ProgressBar1.TabIndex = 116;
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.BackColor = System.Drawing.Color.Transparent;
            this.Label6.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.Location = new System.Drawing.Point(813, 357);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(70, 25);
            this.Label6.TabIndex = 115;
            this.Label6.Text = "Label6";
            // 
            // exambtn
            // 
            this.exambtn.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exambtn.Location = new System.Drawing.Point(715, 276);
            this.exambtn.Name = "exambtn";
            this.exambtn.Size = new System.Drawing.Size(258, 35);
            this.exambtn.TabIndex = 114;
            this.exambtn.Text = "CONTINUE TO EXAM";
            this.exambtn.UseVisualStyleBackColor = true;
            this.exambtn.Click += new System.EventHandler(this.exambtn_Click);
            // 
            // Label4
            // 
            this.Label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Label4.Location = new System.Drawing.Point(668, 200);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(329, 35);
            this.Label4.TabIndex = 113;
            this.Label4.Text = "Label4";
            this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // studexam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 614);
            this.Controls.Add(this.ProgressBar1);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.exambtn);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.instbox);
            this.Controls.Add(this.sumitbtn);
            this.Controls.Add(this.subboxtxt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.codetxt);
            this.Controls.Add(this.label15);
            this.Name = "studexam";
            this.Text = "studexam";
            this.Load += new System.EventHandler(this.studexam_Load);
            this.instbox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox codetxt;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox subboxtxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button sumitbtn;
        internal System.Windows.Forms.GroupBox instbox;
        internal System.Windows.Forms.Button agreebtn;
        internal System.Windows.Forms.Label instructi;
        internal System.Windows.Forms.ProgressBar ProgressBar1;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Button exambtn;
        internal System.Windows.Forms.Label Label4;
        private System.Windows.Forms.Timer timer1;
    }
}