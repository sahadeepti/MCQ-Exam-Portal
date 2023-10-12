namespace OnlineExamSystem
{
    partial class studresult
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
            this.btnpanel = new System.Windows.Forms.Panel();
            this.exit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.resultbtn = new System.Windows.Forms.Button();
            this.intropanel = new System.Windows.Forms.Panel();
            this.studname = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnpanel.SuspendLayout();
            this.intropanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnpanel
            // 
            this.btnpanel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnpanel.Controls.Add(this.exit);
            this.btnpanel.Controls.Add(this.button1);
            this.btnpanel.Controls.Add(this.resultbtn);
            this.btnpanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnpanel.Location = new System.Drawing.Point(0, 0);
            this.btnpanel.Name = "btnpanel";
            this.btnpanel.Size = new System.Drawing.Size(200, 644);
            this.btnpanel.TabIndex = 0;
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.Gainsboro;
            this.exit.FlatAppearance.BorderSize = 0;
            this.exit.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.ForeColor = System.Drawing.Color.Red;
            this.exit.Location = new System.Drawing.Point(0, 577);
            this.exit.Margin = new System.Windows.Forms.Padding(0);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(199, 67);
            this.exit.TabIndex = 2;
            this.exit.Text = "EXIT";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gainsboro;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(0, 174);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(194, 73);
            this.button1.TabIndex = 1;
            this.button1.Text = " CERTIFICATE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // resultbtn
            // 
            this.resultbtn.BackColor = System.Drawing.Color.Gainsboro;
            this.resultbtn.FlatAppearance.BorderSize = 0;
            this.resultbtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultbtn.Location = new System.Drawing.Point(0, 108);
            this.resultbtn.Margin = new System.Windows.Forms.Padding(0);
            this.resultbtn.Name = "resultbtn";
            this.resultbtn.Size = new System.Drawing.Size(194, 56);
            this.resultbtn.TabIndex = 0;
            this.resultbtn.Text = "RESULT";
            this.resultbtn.UseVisualStyleBackColor = false;
            this.resultbtn.Click += new System.EventHandler(this.resultbtn_Click);
            // 
            // intropanel
            // 
            this.intropanel.Controls.Add(this.studname);
            this.intropanel.Controls.Add(this.label2);
            this.intropanel.Controls.Add(this.label1);
            this.intropanel.Location = new System.Drawing.Point(206, 0);
            this.intropanel.Name = "intropanel";
            this.intropanel.Size = new System.Drawing.Size(1304, 644);
            this.intropanel.TabIndex = 3;
            // 
            // studname
            // 
            this.studname.Font = new System.Drawing.Font("Segoe Script", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studname.ForeColor = System.Drawing.Color.Maroon;
            this.studname.Location = new System.Drawing.Point(553, 107);
            this.studname.Name = "studname";
            this.studname.Size = new System.Drawing.Size(264, 56);
            this.studname.TabIndex = 2;
            this.studname.Text = "STUDNAME";
            this.studname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe Script", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(74, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1001, 57);
            this.label2.TabIndex = 1;
            this.label2.Text = "CLICK ON RESULT/CERTIFICATE TO VIEW RESULT/CERTIFICATE";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe Script", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(322, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "WELCOME \r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // studresult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1509, 644);
            this.Controls.Add(this.intropanel);
            this.Controls.Add(this.btnpanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "studresult";
            this.Text = "studresult";
            this.Load += new System.EventHandler(this.studresult_Load);
            this.btnpanel.ResumeLayout(false);
            this.intropanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel btnpanel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button resultbtn;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Panel intropanel;
        private System.Windows.Forms.Label studname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}