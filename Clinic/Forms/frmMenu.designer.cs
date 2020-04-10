namespace Clinic
{
    partial class frmMenu
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
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.pnlPrescreption = new System.Windows.Forms.Panel();
            this.lblPrescreption = new System.Windows.Forms.Label();
            this.pcPrescreption = new System.Windows.Forms.PictureBox();
            this.pnlUsers = new System.Windows.Forms.Panel();
            this.lblUsers = new System.Windows.Forms.Label();
            this.pcUsers = new System.Windows.Forms.PictureBox();
            this.pnlBackUp = new System.Windows.Forms.Panel();
            this.lblBackUp = new System.Windows.Forms.Label();
            this.pcBackUp = new System.Windows.Forms.PictureBox();
            this.pnlArchive = new System.Windows.Forms.Panel();
            this.lblArchive = new System.Windows.Forms.Label();
            this.pcArchive = new System.Windows.Forms.PictureBox();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.lblSearch = new System.Windows.Forms.Label();
            this.pcSearch = new System.Windows.Forms.PictureBox();
            this.pnlExamin = new System.Windows.Forms.Panel();
            this.lblExamin = new System.Windows.Forms.Label();
            this.pcExamin = new System.Windows.Forms.PictureBox();
            this.pnlRegister = new System.Windows.Forms.Panel();
            this.lblRegister = new System.Windows.Forms.Label();
            this.PcRegister = new System.Windows.Forms.PictureBox();
            this.pnlMedicine = new System.Windows.Forms.Panel();
            this.lblMedicine = new System.Windows.Forms.Label();
            this.pcMedicine = new System.Windows.Forms.PictureBox();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.MenuUserLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.menuChangePassword = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLogOut = new System.Windows.Forms.ToolStripMenuItem();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.pnlMenu.SuspendLayout();
            this.pnlPrescreption.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcPrescreption)).BeginInit();
            this.pnlUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcUsers)).BeginInit();
            this.pnlBackUp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcBackUp)).BeginInit();
            this.pnlArchive.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcArchive)).BeginInit();
            this.pnlSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcSearch)).BeginInit();
            this.pnlExamin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcExamin)).BeginInit();
            this.pnlRegister.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PcRegister)).BeginInit();
            this.pnlMedicine.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcMedicine)).BeginInit();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.Controls.Add(this.pnlPrescreption);
            this.pnlMenu.Controls.Add(this.pnlUsers);
            this.pnlMenu.Controls.Add(this.pnlBackUp);
            this.pnlMenu.Controls.Add(this.pnlArchive);
            this.pnlMenu.Controls.Add(this.pnlSearch);
            this.pnlMenu.Controls.Add(this.pnlExamin);
            this.pnlMenu.Controls.Add(this.pnlRegister);
            this.pnlMenu.Controls.Add(this.pnlMedicine);
            this.pnlMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlMenu.Location = new System.Drawing.Point(16, 39);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(1189, 135);
            this.pnlMenu.TabIndex = 30;
            // 
            // pnlPrescreption
            // 
            this.pnlPrescreption.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(56)))), ((int)(((byte)(66)))));
            this.pnlPrescreption.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlPrescreption.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPrescreption.Controls.Add(this.lblPrescreption);
            this.pnlPrescreption.Controls.Add(this.pcPrescreption);
            this.pnlPrescreption.ForeColor = System.Drawing.SystemColors.Control;
            this.pnlPrescreption.Location = new System.Drawing.Point(456, 3);
            this.pnlPrescreption.Name = "pnlPrescreption";
            this.pnlPrescreption.Size = new System.Drawing.Size(124, 114);
            this.pnlPrescreption.TabIndex = 32;
            this.pnlPrescreption.Click += new System.EventHandler(this.pcPrescreption_Click);
            // 
            // lblPrescreption
            // 
            this.lblPrescreption.AutoSize = true;
            this.lblPrescreption.Location = new System.Drawing.Point(27, 83);
            this.lblPrescreption.Name = "lblPrescreption";
            this.lblPrescreption.Size = new System.Drawing.Size(50, 13);
            this.lblPrescreption.TabIndex = 3;
            this.lblPrescreption.Text = "الروشــتة";
            this.lblPrescreption.Click += new System.EventHandler(this.pcPrescreption_Click);
            // 
            // pcPrescreption
            // 
            this.pcPrescreption.Image = global::Clinic.Properties.Resources.prescription;
            this.pcPrescreption.Location = new System.Drawing.Point(28, 9);
            this.pcPrescreption.Name = "pcPrescreption";
            this.pcPrescreption.Size = new System.Drawing.Size(82, 72);
            this.pcPrescreption.TabIndex = 2;
            this.pcPrescreption.TabStop = false;
            this.pcPrescreption.Click += new System.EventHandler(this.pcPrescreption_Click);
            // 
            // pnlUsers
            // 
            this.pnlUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(56)))), ((int)(((byte)(66)))));
            this.pnlUsers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlUsers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlUsers.Controls.Add(this.lblUsers);
            this.pnlUsers.Controls.Add(this.pcUsers);
            this.pnlUsers.ForeColor = System.Drawing.SystemColors.Control;
            this.pnlUsers.Location = new System.Drawing.Point(3, 3);
            this.pnlUsers.Name = "pnlUsers";
            this.pnlUsers.Size = new System.Drawing.Size(124, 114);
            this.pnlUsers.TabIndex = 31;
            this.pnlUsers.Click += new System.EventHandler(this.pcUsers_Click);
            // 
            // lblUsers
            // 
            this.lblUsers.AutoSize = true;
            this.lblUsers.Location = new System.Drawing.Point(4, 83);
            this.lblUsers.Name = "lblUsers";
            this.lblUsers.Size = new System.Drawing.Size(90, 13);
            this.lblUsers.TabIndex = 3;
            this.lblUsers.Text = "ادارة المستخدمين";
            this.lblUsers.Click += new System.EventHandler(this.pcUsers_Click);
            // 
            // pcUsers
            // 
            this.pcUsers.Image = global::Clinic.Properties.Resources.icons8_user_group_70;
            this.pcUsers.Location = new System.Drawing.Point(28, 9);
            this.pcUsers.Name = "pcUsers";
            this.pcUsers.Size = new System.Drawing.Size(82, 72);
            this.pcUsers.TabIndex = 2;
            this.pcUsers.TabStop = false;
            this.pcUsers.Click += new System.EventHandler(this.pcUsers_Click);
            // 
            // pnlBackUp
            // 
            this.pnlBackUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(56)))), ((int)(((byte)(66)))));
            this.pnlBackUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlBackUp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBackUp.Controls.Add(this.lblBackUp);
            this.pnlBackUp.Controls.Add(this.pcBackUp);
            this.pnlBackUp.ForeColor = System.Drawing.SystemColors.Control;
            this.pnlBackUp.Location = new System.Drawing.Point(152, 3);
            this.pnlBackUp.Name = "pnlBackUp";
            this.pnlBackUp.Size = new System.Drawing.Size(124, 114);
            this.pnlBackUp.TabIndex = 30;
            this.pnlBackUp.Click += new System.EventHandler(this.pcBackUp_Click);
            // 
            // lblBackUp
            // 
            this.lblBackUp.AutoSize = true;
            this.lblBackUp.Location = new System.Drawing.Point(7, 83);
            this.lblBackUp.Name = "lblBackUp";
            this.lblBackUp.Size = new System.Drawing.Size(86, 13);
            this.lblBackUp.TabIndex = 3;
            this.lblBackUp.Text = "النسخ الاحتياطي";
            this.lblBackUp.Click += new System.EventHandler(this.pcBackUp_Click);
            // 
            // pcBackUp
            // 
            this.pcBackUp.Image = global::Clinic.Properties.Resources.back_up;
            this.pcBackUp.Location = new System.Drawing.Point(28, 9);
            this.pcBackUp.Name = "pcBackUp";
            this.pcBackUp.Size = new System.Drawing.Size(82, 72);
            this.pcBackUp.TabIndex = 2;
            this.pcBackUp.TabStop = false;
            this.pcBackUp.Click += new System.EventHandler(this.pcBackUp_Click);
            // 
            // pnlArchive
            // 
            this.pnlArchive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(56)))), ((int)(((byte)(66)))));
            this.pnlArchive.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlArchive.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlArchive.Controls.Add(this.lblArchive);
            this.pnlArchive.Controls.Add(this.pcArchive);
            this.pnlArchive.ForeColor = System.Drawing.SystemColors.Control;
            this.pnlArchive.Location = new System.Drawing.Point(306, 3);
            this.pnlArchive.Name = "pnlArchive";
            this.pnlArchive.Size = new System.Drawing.Size(124, 114);
            this.pnlArchive.TabIndex = 29;
            this.pnlArchive.Click += new System.EventHandler(this.pcArchive_Click);
            // 
            // lblArchive
            // 
            this.lblArchive.AutoSize = true;
            this.lblArchive.Location = new System.Drawing.Point(33, 83);
            this.lblArchive.Name = "lblArchive";
            this.lblArchive.Size = new System.Drawing.Size(55, 13);
            this.lblArchive.TabIndex = 3;
            this.lblArchive.Text = "الارشـــيف";
            this.lblArchive.Click += new System.EventHandler(this.pcArchive_Click);
            // 
            // pcArchive
            // 
            this.pcArchive.Image = global::Clinic.Properties.Resources.icons8_archive_folder_7011;
            this.pcArchive.Location = new System.Drawing.Point(28, 9);
            this.pcArchive.Name = "pcArchive";
            this.pcArchive.Size = new System.Drawing.Size(82, 72);
            this.pcArchive.TabIndex = 2;
            this.pcArchive.TabStop = false;
            this.pcArchive.Click += new System.EventHandler(this.pcArchive_Click);
            // 
            // pnlSearch
            // 
            this.pnlSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(56)))), ((int)(((byte)(66)))));
            this.pnlSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSearch.Controls.Add(this.lblSearch);
            this.pnlSearch.Controls.Add(this.pcSearch);
            this.pnlSearch.ForeColor = System.Drawing.SystemColors.Control;
            this.pnlSearch.Location = new System.Drawing.Point(603, 3);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(124, 114);
            this.pnlSearch.TabIndex = 28;
            this.pnlSearch.Click += new System.EventHandler(this.pcSearch_Click);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(33, 83);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(49, 13);
            this.lblSearch.TabIndex = 3;
            this.lblSearch.Text = "البــحـــث";
            this.lblSearch.Click += new System.EventHandler(this.pcSearch_Click);
            // 
            // pcSearch
            // 
            this.pcSearch.Image = global::Clinic.Properties.Resources.search;
            this.pcSearch.Location = new System.Drawing.Point(28, 9);
            this.pcSearch.Name = "pcSearch";
            this.pcSearch.Size = new System.Drawing.Size(82, 72);
            this.pcSearch.TabIndex = 2;
            this.pcSearch.TabStop = false;
            this.pcSearch.Click += new System.EventHandler(this.pcSearch_Click);
            // 
            // pnlExamin
            // 
            this.pnlExamin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(56)))), ((int)(((byte)(66)))));
            this.pnlExamin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlExamin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlExamin.Controls.Add(this.lblExamin);
            this.pnlExamin.Controls.Add(this.pcExamin);
            this.pnlExamin.ForeColor = System.Drawing.SystemColors.Control;
            this.pnlExamin.Location = new System.Drawing.Point(750, 3);
            this.pnlExamin.Name = "pnlExamin";
            this.pnlExamin.Size = new System.Drawing.Size(124, 114);
            this.pnlExamin.TabIndex = 27;
            this.pnlExamin.Click += new System.EventHandler(this.pcExamin_Click);
            // 
            // lblExamin
            // 
            this.lblExamin.AutoSize = true;
            this.lblExamin.Location = new System.Drawing.Point(28, 83);
            this.lblExamin.Name = "lblExamin";
            this.lblExamin.Size = new System.Drawing.Size(51, 13);
            this.lblExamin.TabIndex = 3;
            this.lblExamin.Text = "الفــحــص";
            this.lblExamin.Click += new System.EventHandler(this.pcExamin_Click);
            // 
            // pcExamin
            // 
            this.pcExamin.Image = global::Clinic.Properties.Resources.icons8_hand_with_a_pill_70;
            this.pcExamin.Location = new System.Drawing.Point(28, 9);
            this.pcExamin.Name = "pcExamin";
            this.pcExamin.Size = new System.Drawing.Size(82, 72);
            this.pcExamin.TabIndex = 2;
            this.pcExamin.TabStop = false;
            this.pcExamin.Click += new System.EventHandler(this.pcExamin_Click);
            // 
            // pnlRegister
            // 
            this.pnlRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(56)))), ((int)(((byte)(66)))));
            this.pnlRegister.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlRegister.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlRegister.Controls.Add(this.lblRegister);
            this.pnlRegister.Controls.Add(this.PcRegister);
            this.pnlRegister.ForeColor = System.Drawing.SystemColors.Control;
            this.pnlRegister.Location = new System.Drawing.Point(1040, 3);
            this.pnlRegister.Name = "pnlRegister";
            this.pnlRegister.Size = new System.Drawing.Size(124, 114);
            this.pnlRegister.TabIndex = 26;
            this.pnlRegister.Click += new System.EventHandler(this.PcRegister_Click);
            this.pnlRegister.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlRegister_Paint);
            // 
            // lblRegister
            // 
            this.lblRegister.AutoSize = true;
            this.lblRegister.Location = new System.Drawing.Point(26, 82);
            this.lblRegister.Name = "lblRegister";
            this.lblRegister.Size = new System.Drawing.Size(62, 13);
            this.lblRegister.TabIndex = 1;
            this.lblRegister.Text = "تـــسـجــيـل";
            this.lblRegister.Click += new System.EventHandler(this.PcRegister_Click);
            // 
            // PcRegister
            // 
            this.PcRegister.Image = global::Clinic.Properties.Resources.patient1;
            this.PcRegister.Location = new System.Drawing.Point(23, 10);
            this.PcRegister.Name = "PcRegister";
            this.PcRegister.Size = new System.Drawing.Size(82, 72);
            this.PcRegister.TabIndex = 0;
            this.PcRegister.TabStop = false;
            this.PcRegister.Click += new System.EventHandler(this.PcRegister_Click);
            // 
            // pnlMedicine
            // 
            this.pnlMedicine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(56)))), ((int)(((byte)(66)))));
            this.pnlMedicine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlMedicine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMedicine.Controls.Add(this.lblMedicine);
            this.pnlMedicine.Controls.Add(this.pcMedicine);
            this.pnlMedicine.ForeColor = System.Drawing.SystemColors.Control;
            this.pnlMedicine.Location = new System.Drawing.Point(897, 3);
            this.pnlMedicine.Name = "pnlMedicine";
            this.pnlMedicine.Size = new System.Drawing.Size(124, 114);
            this.pnlMedicine.TabIndex = 25;
            this.pnlMedicine.Click += new System.EventHandler(this.pcMedicine_Click);
            // 
            // lblMedicine
            // 
            this.lblMedicine.AutoSize = true;
            this.lblMedicine.Location = new System.Drawing.Point(23, 83);
            this.lblMedicine.Name = "lblMedicine";
            this.lblMedicine.Size = new System.Drawing.Size(54, 13);
            this.lblMedicine.TabIndex = 3;
            this.lblMedicine.Text = "الادويــــــة";
            this.lblMedicine.Click += new System.EventHandler(this.pcMedicine_Click);
            // 
            // pcMedicine
            // 
            this.pcMedicine.Image = global::Clinic.Properties.Resources.medicine;
            this.pcMedicine.Location = new System.Drawing.Point(28, 14);
            this.pcMedicine.Name = "pcMedicine";
            this.pcMedicine.Size = new System.Drawing.Size(82, 72);
            this.pcMedicine.TabIndex = 2;
            this.pcMedicine.TabStop = false;
            this.pcMedicine.Click += new System.EventHandler(this.pcMedicine_Click);
            // 
            // pnlContainer
            // 
            this.pnlContainer.AutoScroll = true;
            this.pnlContainer.Location = new System.Drawing.Point(19, 183);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(1174, 543);
            this.pnlContainer.TabIndex = 31;
            this.pnlContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlContainer_Paint);
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(56)))), ((int)(((byte)(66)))));
            this.menuStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuUserLogin});
            this.menuStrip.Location = new System.Drawing.Point(16, 2);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(50, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "Menu";
            // 
            // MenuUserLogin
            // 
            this.MenuUserLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(56)))), ((int)(((byte)(66)))));
            this.MenuUserLogin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuChangePassword,
            this.menuLogOut});
            this.MenuUserLogin.ForeColor = System.Drawing.Color.Tomato;
            this.MenuUserLogin.Name = "MenuUserLogin";
            this.MenuUserLogin.Size = new System.Drawing.Size(42, 20);
            this.MenuUserLogin.Text = "User";
            // 
            // menuChangePassword
            // 
            this.menuChangePassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(56)))), ((int)(((byte)(66)))));
            this.menuChangePassword.ForeColor = System.Drawing.Color.Tomato;
            this.menuChangePassword.Name = "menuChangePassword";
            this.menuChangePassword.Size = new System.Drawing.Size(148, 22);
            this.menuChangePassword.Text = "تغيير كلمة السر";
            // 
            // menuLogOut
            // 
            this.menuLogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(56)))), ((int)(((byte)(66)))));
            this.menuLogOut.ForeColor = System.Drawing.Color.Tomato;
            this.menuLogOut.Name = "menuLogOut";
            this.menuLogOut.Size = new System.Drawing.Size(148, 22);
            this.menuLogOut.Text = "تسجيل الخروج";
            // 
            // btnClose
            // 
            this.btnClose.Image = global::Clinic.Properties.Resources.close;
            this.btnClose.Location = new System.Drawing.Point(1171, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 31);
            this.btnClose.TabIndex = 28;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(56)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(1202, 728);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Menu_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Menu_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Menu_MouseUp);
            this.pnlMenu.ResumeLayout(false);
            this.pnlPrescreption.ResumeLayout(false);
            this.pnlPrescreption.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcPrescreption)).EndInit();
            this.pnlUsers.ResumeLayout(false);
            this.pnlUsers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcUsers)).EndInit();
            this.pnlBackUp.ResumeLayout(false);
            this.pnlBackUp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcBackUp)).EndInit();
            this.pnlArchive.ResumeLayout(false);
            this.pnlArchive.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcArchive)).EndInit();
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcSearch)).EndInit();
            this.pnlExamin.ResumeLayout(false);
            this.pnlExamin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcExamin)).EndInit();
            this.pnlRegister.ResumeLayout(false);
            this.pnlRegister.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PcRegister)).EndInit();
            this.pnlMedicine.ResumeLayout(false);
            this.pnlMedicine.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcMedicine)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.Panel pnlMedicine;
        private System.Windows.Forms.Panel pnlRegister;
        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem MenuUserLogin;
        private System.Windows.Forms.ToolStripMenuItem menuChangePassword;
        private System.Windows.Forms.ToolStripMenuItem menuLogOut;
        private System.Windows.Forms.Label lblRegister;
        private System.Windows.Forms.PictureBox PcRegister;
        private System.Windows.Forms.Label lblMedicine;
        private System.Windows.Forms.PictureBox pcMedicine;
        private System.Windows.Forms.Panel pnlExamin;
        private System.Windows.Forms.Label lblExamin;
        private System.Windows.Forms.PictureBox pcExamin;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.PictureBox pcSearch;
        private System.Windows.Forms.Panel pnlArchive;
        private System.Windows.Forms.Label lblArchive;
        private System.Windows.Forms.PictureBox pcArchive;
        private System.Windows.Forms.Panel pnlUsers;
        private System.Windows.Forms.Label lblUsers;
        private System.Windows.Forms.PictureBox pcUsers;
        private System.Windows.Forms.Panel pnlBackUp;
        private System.Windows.Forms.Label lblBackUp;
        private System.Windows.Forms.PictureBox pcBackUp;
        private System.Windows.Forms.Panel pnlPrescreption;
        private System.Windows.Forms.Label lblPrescreption;
        private System.Windows.Forms.PictureBox pcPrescreption;
    }
}