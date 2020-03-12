namespace School_Mangement_System
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabAbout = new System.Windows.Forms.TabControl();
            this.tabNewStudent = new System.Windows.Forms.TabPage();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtId1 = new System.Windows.Forms.TextBox();
            this.txtLastName1 = new System.Windows.Forms.TextBox();
            this.txtFirstName1 = new System.Windows.Forms.TextBox();
            this.labId = new System.Windows.Forms.Label();
            this.labLastName = new System.Windows.Forms.Label();
            this.labFirstName = new System.Windows.Forms.Label();
            this.tabSearchStudent = new System.Windows.Forms.TabPage();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit2 = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lstStudentSearch = new System.Windows.Forms.ListBox();
            this.txtId2 = new System.Windows.Forms.TextBox();
            this.txtLastName2 = new System.Windows.Forms.TextBox();
            this.txtFirstName2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabExportStudent = new System.Windows.Forms.TabPage();
            this.tabAboutPage = new System.Windows.Forms.TabPage();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtEmail1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblDateReal = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEmail2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCancel2 = new System.Windows.Forms.Button();
            this.btnSearch2 = new System.Windows.Forms.Button();
            this.lstExport = new System.Windows.Forms.ListBox();
            this.btnExport = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.tabAbout.SuspendLayout();
            this.tabNewStudent.SuspendLayout();
            this.tabSearchStudent.SuspendLayout();
            this.tabExportStudent.SuspendLayout();
            this.tabAboutPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // tabAbout
            // 
            this.tabAbout.Controls.Add(this.tabNewStudent);
            this.tabAbout.Controls.Add(this.tabSearchStudent);
            this.tabAbout.Controls.Add(this.tabExportStudent);
            this.tabAbout.Controls.Add(this.tabAboutPage);
            this.tabAbout.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabAbout.Location = new System.Drawing.Point(16, 142);
            this.tabAbout.Name = "tabAbout";
            this.tabAbout.SelectedIndex = 0;
            this.tabAbout.Size = new System.Drawing.Size(402, 295);
            this.tabAbout.TabIndex = 0;
            // 
            // tabNewStudent
            // 
            this.tabNewStudent.Controls.Add(this.txtEmail1);
            this.tabNewStudent.Controls.Add(this.label5);
            this.tabNewStudent.Controls.Add(this.btnExit);
            this.tabNewStudent.Controls.Add(this.btnSave);
            this.tabNewStudent.Controls.Add(this.txtId1);
            this.tabNewStudent.Controls.Add(this.txtLastName1);
            this.tabNewStudent.Controls.Add(this.txtFirstName1);
            this.tabNewStudent.Controls.Add(this.labId);
            this.tabNewStudent.Controls.Add(this.labLastName);
            this.tabNewStudent.Controls.Add(this.labFirstName);
            this.tabNewStudent.Location = new System.Drawing.Point(4, 25);
            this.tabNewStudent.Name = "tabNewStudent";
            this.tabNewStudent.Padding = new System.Windows.Forms.Padding(3);
            this.tabNewStudent.Size = new System.Drawing.Size(394, 266);
            this.tabNewStudent.TabIndex = 0;
            this.tabNewStudent.Text = "New Student";
            this.tabNewStudent.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(118, 201);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(153, 23);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Close";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(118, 172);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(153, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // txtId1
            // 
            this.txtId1.Location = new System.Drawing.Point(180, 92);
            this.txtId1.Name = "txtId1";
            this.txtId1.Size = new System.Drawing.Size(100, 23);
            this.txtId1.TabIndex = 5;
            // 
            // txtLastName1
            // 
            this.txtLastName1.Location = new System.Drawing.Point(180, 63);
            this.txtLastName1.Name = "txtLastName1";
            this.txtLastName1.Size = new System.Drawing.Size(100, 23);
            this.txtLastName1.TabIndex = 4;
            // 
            // txtFirstName1
            // 
            this.txtFirstName1.Location = new System.Drawing.Point(180, 36);
            this.txtFirstName1.Name = "txtFirstName1";
            this.txtFirstName1.Size = new System.Drawing.Size(100, 23);
            this.txtFirstName1.TabIndex = 3;
            // 
            // labId
            // 
            this.labId.AutoSize = true;
            this.labId.Location = new System.Drawing.Point(126, 95);
            this.labId.Name = "labId";
            this.labId.Size = new System.Drawing.Size(41, 16);
            this.labId.TabIndex = 2;
            this.labId.Text = "ID No:";
            // 
            // labLastName
            // 
            this.labLastName.AutoSize = true;
            this.labLastName.Location = new System.Drawing.Point(97, 70);
            this.labLastName.Name = "labLastName";
            this.labLastName.Size = new System.Drawing.Size(70, 16);
            this.labLastName.TabIndex = 1;
            this.labLastName.Text = "Last Name :";
            // 
            // labFirstName
            // 
            this.labFirstName.AutoSize = true;
            this.labFirstName.Location = new System.Drawing.Point(96, 42);
            this.labFirstName.Name = "labFirstName";
            this.labFirstName.Size = new System.Drawing.Size(71, 16);
            this.labFirstName.TabIndex = 0;
            this.labFirstName.Text = "First Name :";
            // 
            // tabSearchStudent
            // 
            this.tabSearchStudent.Controls.Add(this.btnCancel2);
            this.tabSearchStudent.Controls.Add(this.btnSearch2);
            this.tabSearchStudent.Controls.Add(this.txtEmail2);
            this.tabSearchStudent.Controls.Add(this.label7);
            this.tabSearchStudent.Controls.Add(this.btnClear);
            this.tabSearchStudent.Controls.Add(this.btnExit2);
            this.tabSearchStudent.Controls.Add(this.btnSearch);
            this.tabSearchStudent.Controls.Add(this.label4);
            this.tabSearchStudent.Controls.Add(this.lstStudentSearch);
            this.tabSearchStudent.Controls.Add(this.txtId2);
            this.tabSearchStudent.Controls.Add(this.txtLastName2);
            this.tabSearchStudent.Controls.Add(this.txtFirstName2);
            this.tabSearchStudent.Controls.Add(this.label1);
            this.tabSearchStudent.Controls.Add(this.label2);
            this.tabSearchStudent.Controls.Add(this.label3);
            this.tabSearchStudent.Location = new System.Drawing.Point(4, 25);
            this.tabSearchStudent.Name = "tabSearchStudent";
            this.tabSearchStudent.Padding = new System.Windows.Forms.Padding(3);
            this.tabSearchStudent.Size = new System.Drawing.Size(394, 266);
            this.tabSearchStudent.TabIndex = 1;
            this.tabSearchStudent.Text = "Search Student";
            this.tabSearchStudent.UseVisualStyleBackColor = true;
            this.tabSearchStudent.Click += new System.EventHandler(this.TabSearchStudent_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(113, 273);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 16;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnExit2
            // 
            this.btnExit2.Location = new System.Drawing.Point(357, 273);
            this.btnExit2.Name = "btnExit2";
            this.btnExit2.Size = new System.Drawing.Size(75, 23);
            this.btnExit2.TabIndex = 15;
            this.btnExit2.Text = "Exit";
            this.btnExit2.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(20, 273);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 14;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(272, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Search Result";
            // 
            // lstStudentSearch
            // 
            this.lstStudentSearch.FormattingEnabled = true;
            this.lstStudentSearch.ItemHeight = 16;
            this.lstStudentSearch.Location = new System.Drawing.Point(212, 38);
            this.lstStudentSearch.Name = "lstStudentSearch";
            this.lstStudentSearch.Size = new System.Drawing.Size(159, 196);
            this.lstStudentSearch.TabIndex = 12;
            // 
            // txtId2
            // 
            this.txtId2.Location = new System.Drawing.Point(94, 94);
            this.txtId2.Name = "txtId2";
            this.txtId2.Size = new System.Drawing.Size(100, 23);
            this.txtId2.TabIndex = 11;
            this.txtId2.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // txtLastName2
            // 
            this.txtLastName2.Location = new System.Drawing.Point(94, 65);
            this.txtLastName2.Name = "txtLastName2";
            this.txtLastName2.Size = new System.Drawing.Size(100, 23);
            this.txtLastName2.TabIndex = 10;
            this.txtLastName2.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
            // 
            // txtFirstName2
            // 
            this.txtFirstName2.Location = new System.Drawing.Point(94, 38);
            this.txtFirstName2.Name = "txtFirstName2";
            this.txtFirstName2.Size = new System.Drawing.Size(100, 23);
            this.txtFirstName2.TabIndex = 9;
            this.txtFirstName2.TextChanged += new System.EventHandler(this.TextBox3_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "ID No :";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Last Name :";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "First Name :";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // tabExportStudent
            // 
            this.tabExportStudent.Controls.Add(this.btnExport);
            this.tabExportStudent.Controls.Add(this.lstExport);
            this.tabExportStudent.Location = new System.Drawing.Point(4, 25);
            this.tabExportStudent.Name = "tabExportStudent";
            this.tabExportStudent.Padding = new System.Windows.Forms.Padding(3);
            this.tabExportStudent.Size = new System.Drawing.Size(394, 266);
            this.tabExportStudent.TabIndex = 2;
            this.tabExportStudent.Text = "Export Student";
            this.tabExportStudent.UseVisualStyleBackColor = true;
            // 
            // tabAboutPage
            // 
            this.tabAboutPage.Controls.Add(this.pictureBox4);
            this.tabAboutPage.Controls.Add(this.pictureBox3);
            this.tabAboutPage.Controls.Add(this.pictureBox2);
            this.tabAboutPage.Location = new System.Drawing.Point(4, 25);
            this.tabAboutPage.Name = "tabAboutPage";
            this.tabAboutPage.Padding = new System.Windows.Forms.Padding(3);
            this.tabAboutPage.Size = new System.Drawing.Size(394, 266);
            this.tabAboutPage.TabIndex = 3;
            this.tabAboutPage.Text = "About";
            this.tabAboutPage.UseVisualStyleBackColor = true;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(188, 19);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(187, 231);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 2;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(21, 79);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(147, 171);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(21, 19);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(147, 54);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.PictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(268, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // txtEmail1
            // 
            this.txtEmail1.Location = new System.Drawing.Point(180, 121);
            this.txtEmail1.Name = "txtEmail1";
            this.txtEmail1.Size = new System.Drawing.Size(100, 23);
            this.txtEmail1.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(124, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Email :";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(13, 119);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(36, 13);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "Date :";
            // 
            // lblDateReal
            // 
            this.lblDateReal.AutoSize = true;
            this.lblDateReal.Location = new System.Drawing.Point(55, 119);
            this.lblDateReal.Name = "lblDateReal";
            this.lblDateReal.Size = new System.Drawing.Size(13, 13);
            this.lblDateReal.TabIndex = 2;
            this.lblDateReal.Text = "..";
            this.lblDateReal.Click += new System.EventHandler(this.LblDateReal_Click);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(55, 98);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(13, 13);
            this.lblTime.TabIndex = 4;
            this.lblTime.Text = "..";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Time :";
            // 
            // txtEmail2
            // 
            this.txtEmail2.Location = new System.Drawing.Point(94, 123);
            this.txtEmail2.Name = "txtEmail2";
            this.txtEmail2.Size = new System.Drawing.Size(100, 23);
            this.txtEmail2.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(45, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 16);
            this.label7.TabIndex = 17;
            this.label7.Text = "Email :";
            // 
            // btnCancel2
            // 
            this.btnCancel2.Location = new System.Drawing.Point(36, 211);
            this.btnCancel2.Name = "btnCancel2";
            this.btnCancel2.Size = new System.Drawing.Size(158, 23);
            this.btnCancel2.TabIndex = 24;
            this.btnCancel2.Text = "Cancel";
            this.btnCancel2.UseVisualStyleBackColor = true;
            this.btnCancel2.Click += new System.EventHandler(this.BtnCancel2_Click);
            // 
            // btnSearch2
            // 
            this.btnSearch2.Location = new System.Drawing.Point(36, 182);
            this.btnSearch2.Name = "btnSearch2";
            this.btnSearch2.Size = new System.Drawing.Size(158, 23);
            this.btnSearch2.TabIndex = 23;
            this.btnSearch2.Text = "Search";
            this.btnSearch2.UseVisualStyleBackColor = true;
            this.btnSearch2.Click += new System.EventHandler(this.BtnSearch2_Click);
            // 
            // lstExport
            // 
            this.lstExport.FormattingEnabled = true;
            this.lstExport.ItemHeight = 16;
            this.lstExport.Location = new System.Drawing.Point(16, 26);
            this.lstExport.Name = "lstExport";
            this.lstExport.Size = new System.Drawing.Size(363, 180);
            this.lstExport.TabIndex = 0;
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(16, 213);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(363, 23);
            this.btnExport.TabIndex = 1;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(318, 12);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(100, 50);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 6;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.PictureBox5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 462);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblDateReal);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tabAbout);
            this.Name = "Form1";
            this.Text = "School Management System";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabAbout.ResumeLayout(false);
            this.tabNewStudent.ResumeLayout(false);
            this.tabNewStudent.PerformLayout();
            this.tabSearchStudent.ResumeLayout(false);
            this.tabSearchStudent.PerformLayout();
            this.tabExportStudent.ResumeLayout(false);
            this.tabAboutPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabAbout;
        private System.Windows.Forms.TabPage tabNewStudent;
        private System.Windows.Forms.TabPage tabSearchStudent;
        private System.Windows.Forms.TabPage tabExportStudent;
        private System.Windows.Forms.TabPage tabAboutPage;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtId1;
        private System.Windows.Forms.TextBox txtLastName1;
        private System.Windows.Forms.TextBox txtFirstName1;
        private System.Windows.Forms.Label labId;
        private System.Windows.Forms.Label labLastName;
        private System.Windows.Forms.Label labFirstName;
        private System.Windows.Forms.TextBox txtId2;
        private System.Windows.Forms.TextBox txtLastName2;
        private System.Windows.Forms.TextBox txtFirstName2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lstStudentSearch;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox txtEmail1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblDateReal;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEmail2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCancel2;
        private System.Windows.Forms.Button btnSearch2;
        private System.Windows.Forms.ListBox lstExport;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.PictureBox pictureBox5;
    }
}

