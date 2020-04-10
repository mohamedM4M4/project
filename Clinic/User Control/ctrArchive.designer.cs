namespace Clinic
{
    partial class ctrArchive
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearchForDeletedPatient = new System.Windows.Forms.Button();
            this.txtSearchForDeletedPatient = new MetroFramework.Controls.MetroTextBox();
            this.dgvSearchDeletedPatient = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchDeletedPatient)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSearchForDeletedPatient);
            this.groupBox1.Controls.Add(this.txtSearchForDeletedPatient);
            this.groupBox1.Location = new System.Drawing.Point(238, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(686, 70);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            // 
            // btnSearchForDeletedPatient
            // 
            this.btnSearchForDeletedPatient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(75)))), ((int)(((byte)(94)))));
            this.btnSearchForDeletedPatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchForDeletedPatient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSearchForDeletedPatient.Location = new System.Drawing.Point(78, 19);
            this.btnSearchForDeletedPatient.Name = "btnSearchForDeletedPatient";
            this.btnSearchForDeletedPatient.Size = new System.Drawing.Size(148, 41);
            this.btnSearchForDeletedPatient.TabIndex = 43;
            this.btnSearchForDeletedPatient.Text = "بحث";
            this.btnSearchForDeletedPatient.UseVisualStyleBackColor = false;
            this.btnSearchForDeletedPatient.Click += new System.EventHandler(this.btnSearchForDeletedPatient_Click);
            // 
            // txtSearchForDeletedPatient
            // 
            this.txtSearchForDeletedPatient.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtSearchForDeletedPatient.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            // 
            // 
            // 
            this.txtSearchForDeletedPatient.CustomButton.Image = null;
            this.txtSearchForDeletedPatient.CustomButton.Location = new System.Drawing.Point(213, 1);
            this.txtSearchForDeletedPatient.CustomButton.Name = "";
            this.txtSearchForDeletedPatient.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSearchForDeletedPatient.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSearchForDeletedPatient.CustomButton.TabIndex = 1;
            this.txtSearchForDeletedPatient.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSearchForDeletedPatient.CustomButton.UseSelectable = true;
            this.txtSearchForDeletedPatient.CustomButton.Visible = false;
            this.txtSearchForDeletedPatient.Lines = new string[0];
            this.txtSearchForDeletedPatient.Location = new System.Drawing.Point(424, 29);
            this.txtSearchForDeletedPatient.MaxLength = 32767;
            this.txtSearchForDeletedPatient.Name = "txtSearchForDeletedPatient";
            this.txtSearchForDeletedPatient.PasswordChar = '\0';
            this.txtSearchForDeletedPatient.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearchForDeletedPatient.SelectedText = "";
            this.txtSearchForDeletedPatient.SelectionLength = 0;
            this.txtSearchForDeletedPatient.SelectionStart = 0;
            this.txtSearchForDeletedPatient.ShortcutsEnabled = true;
            this.txtSearchForDeletedPatient.Size = new System.Drawing.Size(235, 23);
            this.txtSearchForDeletedPatient.TabIndex = 37;
            this.txtSearchForDeletedPatient.UseSelectable = true;
            this.txtSearchForDeletedPatient.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSearchForDeletedPatient.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtSearchForDeletedPatient.TextChanged += new System.EventHandler(this.txtSearchForDeletedPatient_TextChanged);
            // 
            // dgvSearchDeletedPatient
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DarkKhaki;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSearchDeletedPatient.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSearchDeletedPatient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearchDeletedPatient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.FullName,
            this.Address,
            this.Age,
            this.Phone,
            this.Edit,
            this.Delete});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSearchDeletedPatient.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvSearchDeletedPatient.Location = new System.Drawing.Point(5, 102);
            this.dgvSearchDeletedPatient.Name = "dgvSearchDeletedPatient";
            this.dgvSearchDeletedPatient.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvSearchDeletedPatient.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSearchDeletedPatient.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvSearchDeletedPatient.RowHeadersVisible = false;
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvSearchDeletedPatient.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvSearchDeletedPatient.RowTemplate.Height = 35;
            this.dgvSearchDeletedPatient.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvSearchDeletedPatient.Size = new System.Drawing.Size(1155, 413);
            this.dgvSearchDeletedPatient.TabIndex = 41;
            this.dgvSearchDeletedPatient.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSearchDeletedPatient_CellContentClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "PatientId";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Id.Visible = false;
            // 
            // FullName
            // 
            this.FullName.DataPropertyName = "FullName";
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FullName.DefaultCellStyle = dataGridViewCellStyle2;
            this.FullName.HeaderText = "اسم المريض";
            this.FullName.Name = "FullName";
            this.FullName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.FullName.Width = 200;
            // 
            // Address
            // 
            this.Address.DataPropertyName = "Address";
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Address.DefaultCellStyle = dataGridViewCellStyle3;
            this.Address.HeaderText = "العنوان";
            this.Address.Name = "Address";
            this.Address.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Address.Width = 200;
            // 
            // Age
            // 
            this.Age.DataPropertyName = "Age";
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Age.DefaultCellStyle = dataGridViewCellStyle4;
            this.Age.HeaderText = "العمـــر";
            this.Age.Name = "Age";
            this.Age.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Age.Width = 190;
            // 
            // Phone
            // 
            this.Phone.DataPropertyName = "Phone";
            this.Phone.HeaderText = "رقم التليفون";
            this.Phone.Name = "Phone";
            this.Phone.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Phone.Width = 200;
            // 
            // Edit
            // 
            this.Edit.HeaderText = "استعادة";
            this.Edit.Image = global::Clinic.Properties.Resources.icons8_edit_251;
            this.Edit.Name = "Edit";
            this.Edit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Edit.Width = 180;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "مسح";
            this.Delete.Image = global::Clinic.Properties.Resources.icons8_delete_25;
            this.Delete.Name = "Delete";
            this.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Delete.Width = 180;
            // 
            // ctrArchive
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(56)))), ((int)(((byte)(66)))));
            this.Controls.Add(this.dgvSearchDeletedPatient);
            this.Controls.Add(this.groupBox1);
            this.Name = "ctrArchive";
            this.Size = new System.Drawing.Size(1163, 518);
            this.Load += new System.EventHandler(this.ctrArchive_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchDeletedPatient)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSearchForDeletedPatient;
        private MetroFramework.Controls.MetroTextBox txtSearchForDeletedPatient;
        private System.Windows.Forms.DataGridView dgvSearchDeletedPatient;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Age;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewImageColumn Edit;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
    }
}
