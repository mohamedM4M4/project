namespace Clinic
{
    partial class ctrMedicine
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btadd = new System.Windows.Forms.Button();
            this.txtMedcineConceration = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMedcineName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvMedicine = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConcentrationOfTheDrug = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn4 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn5 = new System.Windows.Forms.DataGridViewImageColumn();
            this.backgroundWorker3 = new System.ComponentModel.BackgroundWorker();
            this.dataGridViewImageColumn6 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn7 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn8 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn9 = new System.Windows.Forms.DataGridViewImageColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicine)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.Frozen = true;
            this.dataGridViewImageColumn2.HeaderText = "مسح";
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dataGridViewImageColumn2.Width = 82;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btadd);
            this.groupBox1.Controls.Add(this.txtMedcineConceration);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtMedcineName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(650, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(495, 417);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btadd
            // 
            this.btadd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(75)))), ((int)(((byte)(94)))));
            this.btadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btadd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btadd.Location = new System.Drawing.Point(165, 209);
            this.btadd.Name = "btadd";
            this.btadd.Size = new System.Drawing.Size(148, 41);
            this.btadd.TabIndex = 43;
            this.btadd.Text = "اضافة";
            this.btadd.UseVisualStyleBackColor = false;
            this.btadd.Click += new System.EventHandler(this.btadd_Click);
            // 
            // txtMedcineConceration
            // 
            this.txtMedcineConceration.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtMedcineConceration.Location = new System.Drawing.Point(30, 126);
            this.txtMedcineConceration.Name = "txtMedcineConceration";
            this.txtMedcineConceration.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtMedcineConceration.Size = new System.Drawing.Size(189, 25);
            this.txtMedcineConceration.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11F);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(330, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 18);
            this.label2.TabIndex = 37;
            this.label2.Text = "التركيز";
            // 
            // txtMedcineName
            // 
            this.txtMedcineName.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtMedcineName.Location = new System.Drawing.Point(30, 72);
            this.txtMedcineName.Name = "txtMedcineName";
            this.txtMedcineName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtMedcineName.Size = new System.Drawing.Size(189, 25);
            this.txtMedcineName.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(329, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 18);
            this.label1.TabIndex = 35;
            this.label1.Text = "الاسم";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvMedicine);
            this.groupBox2.Location = new System.Drawing.Point(11, 33);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(610, 417);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // dgvMedicine
            // 
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.DarkKhaki;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMedicine.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvMedicine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedicine.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.FullName,
            this.ConcentrationOfTheDrug,
            this.Delete});
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMedicine.DefaultCellStyle = dataGridViewCellStyle16;
            this.dgvMedicine.Location = new System.Drawing.Point(6, 19);
            this.dgvMedicine.Name = "dgvMedicine";
            this.dgvMedicine.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvMedicine.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMedicine.RowHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dgvMedicine.RowHeadersVisible = false;
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvMedicine.RowsDefaultCellStyle = dataGridViewCellStyle18;
            this.dgvMedicine.RowTemplate.Height = 35;
            this.dgvMedicine.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvMedicine.Size = new System.Drawing.Size(584, 242);
            this.dgvMedicine.TabIndex = 34;
            this.dgvMedicine.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMedicine_CellContentClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "MedicineId";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Id.Visible = false;
            // 
            // FullName
            // 
            this.FullName.DataPropertyName = "Name";
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FullName.DefaultCellStyle = dataGridViewCellStyle14;
            this.FullName.HeaderText = "اسم ";
            this.FullName.Name = "FullName";
            this.FullName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.FullName.Width = 250;
            // 
            // ConcentrationOfTheDrug
            // 
            this.ConcentrationOfTheDrug.DataPropertyName = "ConcentrationOfTheDrug";
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ConcentrationOfTheDrug.DefaultCellStyle = dataGridViewCellStyle15;
            this.ConcentrationOfTheDrug.HeaderText = "الكمية";
            this.ConcentrationOfTheDrug.Name = "ConcentrationOfTheDrug";
            this.ConcentrationOfTheDrug.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ConcentrationOfTheDrug.Width = 200;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "مسح";
            this.Delete.Image = global::Clinic.Properties.Resources.icons8_delete_25;
            this.Delete.Name = "Delete";
            this.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Delete.Width = 130;
            // 
            // dataGridViewImageColumn3
            // 
            this.dataGridViewImageColumn3.Frozen = true;
            this.dataGridViewImageColumn3.HeaderText = "مسح";
            this.dataGridViewImageColumn3.Image = global::Clinic.Properties.Resources.icons8_delete_25;
            this.dataGridViewImageColumn3.Name = "dataGridViewImageColumn3";
            this.dataGridViewImageColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewImageColumn3.Width = 130;
            // 
            // dataGridViewImageColumn4
            // 
            this.dataGridViewImageColumn4.Frozen = true;
            this.dataGridViewImageColumn4.HeaderText = "دخول";
            this.dataGridViewImageColumn4.Image = global::Clinic.Properties.Resources.icons8_enter_25__1_;
            this.dataGridViewImageColumn4.Name = "dataGridViewImageColumn4";
            this.dataGridViewImageColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewImageColumn4.Width = 130;
            // 
            // dataGridViewImageColumn5
            // 
            this.dataGridViewImageColumn5.Frozen = true;
            this.dataGridViewImageColumn5.HeaderText = "دخول";
            this.dataGridViewImageColumn5.Image = global::Clinic.Properties.Resources.icons8_enter_25__1_;
            this.dataGridViewImageColumn5.Name = "dataGridViewImageColumn5";
            this.dataGridViewImageColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewImageColumn5.Width = 130;
            // 
            // dataGridViewImageColumn6
            // 
            this.dataGridViewImageColumn6.Frozen = true;
            this.dataGridViewImageColumn6.HeaderText = "مسح";
            this.dataGridViewImageColumn6.Name = "dataGridViewImageColumn6";
            this.dataGridViewImageColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dataGridViewImageColumn6.Width = 82;
            // 
            // dataGridViewImageColumn7
            // 
            this.dataGridViewImageColumn7.Frozen = true;
            this.dataGridViewImageColumn7.HeaderText = "مسح";
            this.dataGridViewImageColumn7.Image = global::Clinic.Properties.Resources.icons8_delete_25;
            this.dataGridViewImageColumn7.Name = "dataGridViewImageColumn7";
            this.dataGridViewImageColumn7.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewImageColumn7.Width = 130;
            // 
            // dataGridViewImageColumn8
            // 
            this.dataGridViewImageColumn8.Frozen = true;
            this.dataGridViewImageColumn8.HeaderText = "دخول";
            this.dataGridViewImageColumn8.Image = global::Clinic.Properties.Resources.icons8_enter_25__1_;
            this.dataGridViewImageColumn8.Name = "dataGridViewImageColumn8";
            this.dataGridViewImageColumn8.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewImageColumn8.Width = 130;
            // 
            // dataGridViewImageColumn9
            // 
            this.dataGridViewImageColumn9.Frozen = true;
            this.dataGridViewImageColumn9.HeaderText = "دخول";
            this.dataGridViewImageColumn9.Image = global::Clinic.Properties.Resources.icons8_enter_25__1_;
            this.dataGridViewImageColumn9.Name = "dataGridViewImageColumn9";
            this.dataGridViewImageColumn9.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn9.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewImageColumn9.Width = 130;
            // 
            // ctrMedicine
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(56)))), ((int)(((byte)(66)))));
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ctrMedicine";
            this.Size = new System.Drawing.Size(1163, 518);
            this.Load += new System.EventHandler(this.ctrMedicine_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicine)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn3;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn4;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtMedcineConceration;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMedcineName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btadd;
        private System.ComponentModel.BackgroundWorker backgroundWorker3;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn6;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn7;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn8;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn9;
        private System.Windows.Forms.DataGridView dgvMedicine;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConcentrationOfTheDrug;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
    }
}
