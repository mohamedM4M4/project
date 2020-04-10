namespace Clinic
{
    partial class frmReservation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReservation));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.txtPatientName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cmbPatiendGender = new System.Windows.Forms.ComboBox();
            this.btnReservation = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPatientPhone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPatientAddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPatientAge = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(485, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 18);
            this.label1.TabIndex = 30;
            this.label1.Text = "اسـم الـمـريــض";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Clinic.Properties.Resources.rsz_7_doctor_and_nurse_visiting_patient_cartoon_clipart_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(231, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(236, 128);
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(65)))), ((int)(((byte)(82)))));
            this.btnClose.Image = global::Clinic.Properties.Resources.close;
            this.btnClose.Location = new System.Drawing.Point(702, 1);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 31);
            this.btnClose.TabIndex = 28;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtPatientName
            // 
            this.txtPatientName.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtPatientName.Location = new System.Drawing.Point(103, 32);
            this.txtPatientName.Name = "txtPatientName";
            this.txtPatientName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPatientName.Size = new System.Drawing.Size(272, 25);
            this.txtPatientName.TabIndex = 32;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.cmbPatiendGender);
            this.groupBox1.Controls.Add(this.btnReservation);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtPatientPhone);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtPatientAddress);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtPatientAge);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtPatientName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(32, 164);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(667, 427);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Tahoma", 11F);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(103, 295);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dateTimePicker1.Size = new System.Drawing.Size(272, 20);
            this.dateTimePicker1.TabIndex = 45;
            // 
            // cmbPatiendGender
            // 
            this.cmbPatiendGender.Font = new System.Drawing.Font("Tahoma", 11F);
            this.cmbPatiendGender.FormattingEnabled = true;
            this.cmbPatiendGender.Location = new System.Drawing.Point(103, 245);
            this.cmbPatiendGender.Name = "cmbPatiendGender";
            this.cmbPatiendGender.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbPatiendGender.Size = new System.Drawing.Size(272, 26);
            this.cmbPatiendGender.TabIndex = 44;
            // 
            // btnReservation
            // 
            this.btnReservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReservation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnReservation.Location = new System.Drawing.Point(269, 358);
            this.btnReservation.Name = "btnReservation";
            this.btnReservation.Size = new System.Drawing.Size(148, 41);
            this.btnReservation.TabIndex = 43;
            this.btnReservation.Text = "حـجــــز";
            this.btnReservation.UseVisualStyleBackColor = true;
            this.btnReservation.Click += new System.EventHandler(this.btnReservation_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 11F);
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(528, 295);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 18);
            this.label6.TabIndex = 41;
            this.label6.Text = "الميعـــاد";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 11F);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(533, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 18);
            this.label5.TabIndex = 39;
            this.label5.Text = "الجنس ";
            // 
            // txtPatientPhone
            // 
            this.txtPatientPhone.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtPatientPhone.Location = new System.Drawing.Point(103, 190);
            this.txtPatientPhone.Name = "txtPatientPhone";
            this.txtPatientPhone.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPatientPhone.Size = new System.Drawing.Size(272, 25);
            this.txtPatientPhone.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 11F);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(506, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 18);
            this.label4.TabIndex = 37;
            this.label4.Text = "رقم التليفون";
            // 
            // txtPatientAddress
            // 
            this.txtPatientAddress.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtPatientAddress.Location = new System.Drawing.Point(103, 140);
            this.txtPatientAddress.Name = "txtPatientAddress";
            this.txtPatientAddress.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPatientAddress.Size = new System.Drawing.Size(272, 25);
            this.txtPatientAddress.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11F);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(519, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 18);
            this.label3.TabIndex = 35;
            this.label3.Text = "العـــــنوان";
            // 
            // txtPatientAge
            // 
            this.txtPatientAge.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtPatientAge.Location = new System.Drawing.Point(103, 86);
            this.txtPatientAge.Name = "txtPatientAge";
            this.txtPatientAge.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPatientAge.Size = new System.Drawing.Size(272, 25);
            this.txtPatientAge.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11F);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(522, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 18);
            this.label2.TabIndex = 33;
            this.label2.Text = "الــعـمــــر";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            this.errorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider.Icon")));
            this.errorProvider.RightToLeft = true;
            // 
            // frmReservation
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(75)))), ((int)(((byte)(94)))));
            this.ClientSize = new System.Drawing.Size(734, 616);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmReservation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.frmReservation_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Menu_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Menu_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Menu_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtPatientName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPatientAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPatientAge;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPatientPhone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnReservation;
        private System.Windows.Forms.ComboBox cmbPatiendGender;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}