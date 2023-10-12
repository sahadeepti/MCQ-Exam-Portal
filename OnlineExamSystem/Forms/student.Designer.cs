namespace OnlineExamSystem
{
    partial class student
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.logintab = new System.Windows.Forms.TabPage();
            this.label16 = new System.Windows.Forms.Label();
            this.resultlogin = new System.Windows.Forms.Button();
            this.examlogin = new System.Windows.Forms.Button();
            this.btnreset = new System.Windows.Forms.Button();
            this.codetxt = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lnametxt = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.fnametxt = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.regtab = new System.Windows.Forms.TabPage();
            this.continuebtn = new System.Windows.Forms.Button();
            this.registerbtn = new System.Windows.Forms.Button();
            this.getcodebtn = new System.Windows.Forms.Button();
            this.resetbtn = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.subboxtxt = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dobpicker = new System.Windows.Forms.DateTimePicker();
            this.agetxt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lastnametxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.categorytxt = new System.Windows.Forms.ComboBox();
            this.eidtxt = new System.Windows.Forms.TextBox();
            this.gendertxt = new System.Windows.Forms.TextBox();
            this.contacttxt = new System.Windows.Forms.TextBox();
            this.addressext = new System.Windows.Forms.TextBox();
            this.firstnametxt = new System.Windows.Forms.TextBox();
            this.Category = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.logintab.SuspendLayout();
            this.regtab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.logintab);
            this.tabControl1.Controls.Add(this.regtab);
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(43, 85);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1342, 581);
            this.tabControl1.TabIndex = 1;
            // 
            // logintab
            // 
            this.logintab.Controls.Add(this.label16);
            this.logintab.Controls.Add(this.resultlogin);
            this.logintab.Controls.Add(this.examlogin);
            this.logintab.Controls.Add(this.btnreset);
            this.logintab.Controls.Add(this.codetxt);
            this.logintab.Controls.Add(this.label15);
            this.logintab.Controls.Add(this.label14);
            this.logintab.Controls.Add(this.lnametxt);
            this.logintab.Controls.Add(this.label12);
            this.logintab.Controls.Add(this.fnametxt);
            this.logintab.Controls.Add(this.label13);
            this.logintab.Location = new System.Drawing.Point(4, 40);
            this.logintab.Name = "logintab";
            this.logintab.Padding = new System.Windows.Forms.Padding(3);
            this.logintab.Size = new System.Drawing.Size(1334, 537);
            this.logintab.TabIndex = 1;
            this.logintab.Text = "Login";
            this.logintab.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.ForeColor = System.Drawing.Color.Red;
            this.label16.Location = new System.Drawing.Point(375, 10);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(604, 54);
            this.label16.TabIndex = 104;
            this.label16.Text = "(If you have not registered, click on register)";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // resultlogin
            // 
            this.resultlogin.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.resultlogin.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.resultlogin.FlatAppearance.BorderSize = 2;
            this.resultlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resultlogin.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultlogin.ForeColor = System.Drawing.Color.MidnightBlue;
            this.resultlogin.Location = new System.Drawing.Point(801, 392);
            this.resultlogin.Name = "resultlogin";
            this.resultlogin.Size = new System.Drawing.Size(139, 41);
            this.resultlogin.TabIndex = 103;
            this.resultlogin.Text = "RESULT";
            this.resultlogin.UseVisualStyleBackColor = false;
            this.resultlogin.Click += new System.EventHandler(this.resultlogin_Click);
            // 
            // examlogin
            // 
            this.examlogin.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.examlogin.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.examlogin.FlatAppearance.BorderSize = 2;
            this.examlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.examlogin.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.examlogin.ForeColor = System.Drawing.Color.MidnightBlue;
            this.examlogin.Location = new System.Drawing.Point(613, 394);
            this.examlogin.Name = "examlogin";
            this.examlogin.Size = new System.Drawing.Size(139, 41);
            this.examlogin.TabIndex = 102;
            this.examlogin.Text = "EXAM";
            this.examlogin.UseVisualStyleBackColor = false;
            this.examlogin.Click += new System.EventHandler(this.examlogin_Click);
            // 
            // btnreset
            // 
            this.btnreset.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnreset.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnreset.FlatAppearance.BorderSize = 2;
            this.btnreset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnreset.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreset.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnreset.Location = new System.Drawing.Point(425, 395);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(139, 41);
            this.btnreset.TabIndex = 101;
            this.btnreset.Text = "RESET";
            this.btnreset.UseVisualStyleBackColor = false;
            // 
            // codetxt
            // 
            this.codetxt.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codetxt.Location = new System.Drawing.Point(619, 294);
            this.codetxt.Multiline = true;
            this.codetxt.Name = "codetxt";
            this.codetxt.Size = new System.Drawing.Size(174, 25);
            this.codetxt.TabIndex = 97;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(497, 294);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(109, 25);
            this.label15.TabIndex = 96;
            this.label15.Text = "Stud Code :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.MediumBlue;
            this.label14.Location = new System.Drawing.Point(505, 120);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(288, 28);
            this.label14.TabIndex = 95;
            this.label14.Text = "PLEASE LOGIN TO CONTINUE";
            // 
            // lnametxt
            // 
            this.lnametxt.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnametxt.Location = new System.Drawing.Point(619, 239);
            this.lnametxt.Multiline = true;
            this.lnametxt.Name = "lnametxt";
            this.lnametxt.Size = new System.Drawing.Size(174, 25);
            this.lnametxt.TabIndex = 94;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(497, 239);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(113, 25);
            this.label12.TabIndex = 93;
            this.label12.Text = "Last Name :";
            // 
            // fnametxt
            // 
            this.fnametxt.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fnametxt.Location = new System.Drawing.Point(616, 182);
            this.fnametxt.Multiline = true;
            this.fnametxt.Name = "fnametxt";
            this.fnametxt.Size = new System.Drawing.Size(171, 25);
            this.fnametxt.TabIndex = 92;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(494, 182);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(116, 25);
            this.label13.TabIndex = 91;
            this.label13.Text = "First Name :";
            // 
            // regtab
            // 
            this.regtab.Controls.Add(this.continuebtn);
            this.regtab.Controls.Add(this.registerbtn);
            this.regtab.Controls.Add(this.getcodebtn);
            this.regtab.Controls.Add(this.resetbtn);
            this.regtab.Controls.Add(this.label11);
            this.regtab.Controls.Add(this.subboxtxt);
            this.regtab.Controls.Add(this.label8);
            this.regtab.Controls.Add(this.dobpicker);
            this.regtab.Controls.Add(this.agetxt);
            this.regtab.Controls.Add(this.label9);
            this.regtab.Controls.Add(this.lastnametxt);
            this.regtab.Controls.Add(this.label2);
            this.regtab.Controls.Add(this.categorytxt);
            this.regtab.Controls.Add(this.eidtxt);
            this.regtab.Controls.Add(this.gendertxt);
            this.regtab.Controls.Add(this.contacttxt);
            this.regtab.Controls.Add(this.addressext);
            this.regtab.Controls.Add(this.firstnametxt);
            this.regtab.Controls.Add(this.Category);
            this.regtab.Controls.Add(this.label6);
            this.regtab.Controls.Add(this.label7);
            this.regtab.Controls.Add(this.label5);
            this.regtab.Controls.Add(this.label4);
            this.regtab.Controls.Add(this.label3);
            this.regtab.Controls.Add(this.label10);
            this.regtab.Location = new System.Drawing.Point(4, 40);
            this.regtab.Name = "regtab";
            this.regtab.Padding = new System.Windows.Forms.Padding(3);
            this.regtab.Size = new System.Drawing.Size(1334, 537);
            this.regtab.TabIndex = 0;
            this.regtab.Text = "Register";
            this.regtab.UseVisualStyleBackColor = true;
            // 
            // continuebtn
            // 
            this.continuebtn.BackColor = System.Drawing.SystemColors.Menu;
            this.continuebtn.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.continuebtn.FlatAppearance.BorderSize = 2;
            this.continuebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.continuebtn.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.continuebtn.ForeColor = System.Drawing.Color.Navy;
            this.continuebtn.Location = new System.Drawing.Point(812, 459);
            this.continuebtn.Name = "continuebtn";
            this.continuebtn.Size = new System.Drawing.Size(131, 41);
            this.continuebtn.TabIndex = 100;
            this.continuebtn.Text = "CONTINUE";
            this.continuebtn.UseVisualStyleBackColor = false;
            this.continuebtn.Click += new System.EventHandler(this.continuebtn_Click);
            // 
            // registerbtn
            // 
            this.registerbtn.BackColor = System.Drawing.SystemColors.Menu;
            this.registerbtn.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.registerbtn.FlatAppearance.BorderSize = 2;
            this.registerbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registerbtn.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerbtn.ForeColor = System.Drawing.Color.MidnightBlue;
            this.registerbtn.Location = new System.Drawing.Point(295, 459);
            this.registerbtn.Name = "registerbtn";
            this.registerbtn.Size = new System.Drawing.Size(130, 41);
            this.registerbtn.TabIndex = 99;
            this.registerbtn.Text = "REGISTER";
            this.registerbtn.UseVisualStyleBackColor = false;
            this.registerbtn.Click += new System.EventHandler(this.registerbtn_Click);
            // 
            // getcodebtn
            // 
            this.getcodebtn.BackColor = System.Drawing.SystemColors.Menu;
            this.getcodebtn.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.getcodebtn.FlatAppearance.BorderSize = 2;
            this.getcodebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.getcodebtn.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getcodebtn.ForeColor = System.Drawing.Color.MidnightBlue;
            this.getcodebtn.Location = new System.Drawing.Point(643, 459);
            this.getcodebtn.Name = "getcodebtn";
            this.getcodebtn.Size = new System.Drawing.Size(128, 41);
            this.getcodebtn.TabIndex = 98;
            this.getcodebtn.Text = "GET CODE";
            this.getcodebtn.UseVisualStyleBackColor = false;
            this.getcodebtn.Click += new System.EventHandler(this.getcodebtn_Click);
            // 
            // resetbtn
            // 
            this.resetbtn.BackColor = System.Drawing.SystemColors.Menu;
            this.resetbtn.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.resetbtn.FlatAppearance.BorderSize = 2;
            this.resetbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetbtn.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.resetbtn.Location = new System.Drawing.Point(483, 459);
            this.resetbtn.Name = "resetbtn";
            this.resetbtn.Size = new System.Drawing.Size(108, 41);
            this.resetbtn.TabIndex = 97;
            this.resetbtn.Text = "RESET";
            this.resetbtn.UseVisualStyleBackColor = false;
            this.resetbtn.Click += new System.EventHandler(this.resetbtn_Click);
            // 
            // label11
            // 
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(441, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(416, 33);
            this.label11.TabIndex = 96;
            this.label11.Text = "Fill up the below form to register";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.subboxtxt.Location = new System.Drawing.Point(750, 364);
            this.subboxtxt.Name = "subboxtxt";
            this.subboxtxt.Size = new System.Drawing.Size(148, 33);
            this.subboxtxt.TabIndex = 95;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(643, 367);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 25);
            this.label8.TabIndex = 94;
            this.label8.Text = "Subject :";
            // 
            // dobpicker
            // 
            this.dobpicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dobpicker.Location = new System.Drawing.Point(738, 294);
            this.dobpicker.Name = "dobpicker";
            this.dobpicker.Size = new System.Drawing.Size(221, 34);
            this.dobpicker.TabIndex = 93;
            // 
            // agetxt
            // 
            this.agetxt.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agetxt.Location = new System.Drawing.Point(295, 178);
            this.agetxt.Multiline = true;
            this.agetxt.Name = "agetxt";
            this.agetxt.Size = new System.Drawing.Size(174, 25);
            this.agetxt.TabIndex = 92;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(233, 178);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 25);
            this.label9.TabIndex = 91;
            this.label9.Text = "Age :";
            // 
            // lastnametxt
            // 
            this.lastnametxt.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastnametxt.Location = new System.Drawing.Point(765, 113);
            this.lastnametxt.Multiline = true;
            this.lastnametxt.Name = "lastnametxt";
            this.lastnametxt.Size = new System.Drawing.Size(174, 25);
            this.lastnametxt.TabIndex = 90;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(643, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 25);
            this.label2.TabIndex = 89;
            this.label2.Text = "Last Name :";
            // 
            // categorytxt
            // 
            this.categorytxt.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categorytxt.FormattingEnabled = true;
            this.categorytxt.Items.AddRange(new object[] {
            "SC",
            "ST",
            "OBC",
            "GEN"});
            this.categorytxt.Location = new System.Drawing.Point(336, 365);
            this.categorytxt.Name = "categorytxt";
            this.categorytxt.Size = new System.Drawing.Size(148, 33);
            this.categorytxt.TabIndex = 88;
            // 
            // eidtxt
            // 
            this.eidtxt.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eidtxt.Location = new System.Drawing.Point(738, 236);
            this.eidtxt.Multiline = true;
            this.eidtxt.Name = "eidtxt";
            this.eidtxt.Size = new System.Drawing.Size(294, 25);
            this.eidtxt.TabIndex = 87;
            // 
            // gendertxt
            // 
            this.gendertxt.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gendertxt.Location = new System.Drawing.Point(336, 301);
            this.gendertxt.Multiline = true;
            this.gendertxt.Name = "gendertxt";
            this.gendertxt.Size = new System.Drawing.Size(186, 25);
            this.gendertxt.TabIndex = 86;
            // 
            // contacttxt
            // 
            this.contacttxt.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contacttxt.Location = new System.Drawing.Point(336, 235);
            this.contacttxt.Multiline = true;
            this.contacttxt.Name = "contacttxt";
            this.contacttxt.Size = new System.Drawing.Size(186, 25);
            this.contacttxt.TabIndex = 85;
            // 
            // addressext
            // 
            this.addressext.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressext.Location = new System.Drawing.Point(741, 178);
            this.addressext.Multiline = true;
            this.addressext.Name = "addressext";
            this.addressext.Size = new System.Drawing.Size(389, 25);
            this.addressext.TabIndex = 84;
            // 
            // firstnametxt
            // 
            this.firstnametxt.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstnametxt.Location = new System.Drawing.Point(351, 113);
            this.firstnametxt.Multiline = true;
            this.firstnametxt.Name = "firstnametxt";
            this.firstnametxt.Size = new System.Drawing.Size(171, 25);
            this.firstnametxt.TabIndex = 83;
            // 
            // Category
            // 
            this.Category.AutoSize = true;
            this.Category.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Category.Location = new System.Drawing.Point(229, 368);
            this.Category.Name = "Category";
            this.Category.Size = new System.Drawing.Size(101, 25);
            this.Category.TabIndex = 82;
            this.Category.Text = "Category :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(643, 302);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 25);
            this.label6.TabIndex = 81;
            this.label6.Text = "D.O.B :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(229, 302);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 25);
            this.label7.TabIndex = 80;
            this.label7.Text = "Gender :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(640, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 25);
            this.label5.TabIndex = 79;
            this.label5.Text = "Email Id :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(229, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 25);
            this.label4.TabIndex = 78;
            this.label4.Text = "Contact :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(638, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 25);
            this.label3.TabIndex = 77;
            this.label3.Text = "Address :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(229, 113);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 25);
            this.label10.TabIndex = 76;
            this.label10.Text = "First Name :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(486, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(442, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "WELCOME TO STUDENT PORTAL";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Red;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("MS PGothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(1277, 30);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(108, 41);
            this.button4.TabIndex = 98;
            this.button4.Text = "EXIT";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // student
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1411, 669);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "student";
            this.Text = "student";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tabControl1.ResumeLayout(false);
            this.logintab.ResumeLayout(false);
            this.logintab.PerformLayout();
            this.regtab.ResumeLayout(false);
            this.regtab.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage regtab;
        private System.Windows.Forms.TabPage logintab;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox subboxtxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dobpicker;
        private System.Windows.Forms.TextBox agetxt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox lastnametxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox categorytxt;
        private System.Windows.Forms.TextBox eidtxt;
        private System.Windows.Forms.TextBox gendertxt;
        private System.Windows.Forms.TextBox contacttxt;
        private System.Windows.Forms.TextBox addressext;
        private System.Windows.Forms.TextBox firstnametxt;
        private System.Windows.Forms.Label Category;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button resetbtn;
        private System.Windows.Forms.Button continuebtn;
        private System.Windows.Forms.Button registerbtn;
        private System.Windows.Forms.Button getcodebtn;
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.TextBox codetxt;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox lnametxt;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox fnametxt;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button resultlogin;
        private System.Windows.Forms.Button examlogin;
        private System.Windows.Forms.Label label16;
    }
}