namespace OnlineExamSystem
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.admin_login = new System.Windows.Forms.Button();
            this.student_login = new System.Windows.Forms.Button();
            this.closebtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // admin_login
            // 
            this.admin_login.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("admin_login.BackgroundImage")));
            this.admin_login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.admin_login.Location = new System.Drawing.Point(129, 128);
            this.admin_login.Name = "admin_login";
            this.admin_login.Size = new System.Drawing.Size(158, 141);
            this.admin_login.TabIndex = 0;
            this.admin_login.UseVisualStyleBackColor = true;
            this.admin_login.Click += new System.EventHandler(this.admin_login_Click);
            // 
            // student_login
            // 
            this.student_login.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("student_login.BackgroundImage")));
            this.student_login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.student_login.Location = new System.Drawing.Point(415, 128);
            this.student_login.Name = "student_login";
            this.student_login.Size = new System.Drawing.Size(162, 141);
            this.student_login.TabIndex = 1;
            this.student_login.UseVisualStyleBackColor = true;
            this.student_login.Click += new System.EventHandler(this.student_login_Click);
            // 
            // closebtn
            // 
            this.closebtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("closebtn.BackgroundImage")));
            this.closebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.closebtn.Location = new System.Drawing.Point(679, 12);
            this.closebtn.Name = "closebtn";
            this.closebtn.Size = new System.Drawing.Size(64, 57);
            this.closebtn.TabIndex = 2;
            this.closebtn.UseVisualStyleBackColor = true;
            this.closebtn.Click += new System.EventHandler(this.closebtn_Click);
            // 
            // login
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(755, 448);
            this.Controls.Add(this.closebtn);
            this.Controls.Add(this.student_login);
            this.Controls.Add(this.admin_login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "login";
            this.Text = "login";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button admin_login;
        private System.Windows.Forms.Button student_login;
        private System.Windows.Forms.Button closebtn;
    }
}