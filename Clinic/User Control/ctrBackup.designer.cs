namespace Clinic
{
    partial class ctrBackUp
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
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.pnlBackup = new System.Windows.Forms.Panel();
            this.lblBackup = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlRestore = new System.Windows.Forms.Panel();
            this.pcRestore = new System.Windows.Forms.PictureBox();
            this.lblRestore = new System.Windows.Forms.Label();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.pnlBackup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlRestore.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcRestore)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.Frozen = true;
            this.dataGridViewImageColumn1.HeaderText = "مسح";
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dataGridViewImageColumn1.Width = 82;
            // 
            // pnlBackup
            // 
            this.pnlBackup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(56)))), ((int)(((byte)(66)))));
            this.pnlBackup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlBackup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBackup.Controls.Add(this.lblBackup);
            this.pnlBackup.Controls.Add(this.pictureBox1);
            this.pnlBackup.ForeColor = System.Drawing.SystemColors.Control;
            this.pnlBackup.Location = new System.Drawing.Point(638, 96);
            this.pnlBackup.Name = "pnlBackup";
            this.pnlBackup.Size = new System.Drawing.Size(160, 167);
            this.pnlBackup.TabIndex = 33;
            this.pnlBackup.Click += new System.EventHandler(this.lblBackup_Click);
            // 
            // lblBackup
            // 
            this.lblBackup.AutoSize = true;
            this.lblBackup.Location = new System.Drawing.Point(42, 139);
            this.lblBackup.Name = "lblBackup";
            this.lblBackup.Size = new System.Drawing.Size(72, 13);
            this.lblBackup.TabIndex = 2;
            this.lblBackup.Text = "نسخ احتياطي";
            this.lblBackup.Click += new System.EventHandler(this.lblBackup_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Clinic.Properties.Resources.icons8_data_backup_90;
            this.pictureBox1.Location = new System.Drawing.Point(27, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 110);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.lblBackup_Click);
            // 
            // pnlRestore
            // 
            this.pnlRestore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(56)))), ((int)(((byte)(66)))));
            this.pnlRestore.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlRestore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlRestore.Controls.Add(this.pcRestore);
            this.pnlRestore.Controls.Add(this.lblRestore);
            this.pnlRestore.ForeColor = System.Drawing.SystemColors.Control;
            this.pnlRestore.Location = new System.Drawing.Point(300, 96);
            this.pnlRestore.Name = "pnlRestore";
            this.pnlRestore.Size = new System.Drawing.Size(160, 167);
            this.pnlRestore.TabIndex = 32;
            this.pnlRestore.Click += new System.EventHandler(this.pnlRestore_Click);
            // 
            // pcRestore
            // 
            this.pcRestore.Image = global::Clinic.Properties.Resources.icons8_database_restore_90;
            this.pcRestore.Location = new System.Drawing.Point(35, 12);
            this.pcRestore.Name = "pcRestore";
            this.pcRestore.Size = new System.Drawing.Size(96, 110);
            this.pcRestore.TabIndex = 0;
            this.pcRestore.TabStop = false;
            this.pcRestore.Click += new System.EventHandler(this.pnlRestore_Click);
            // 
            // lblRestore
            // 
            this.lblRestore.AutoSize = true;
            this.lblRestore.Location = new System.Drawing.Point(54, 139);
            this.lblRestore.Name = "lblRestore";
            this.lblRestore.Size = new System.Drawing.Size(47, 13);
            this.lblRestore.TabIndex = 1;
            this.lblRestore.Text = "استرجاع";
            this.lblRestore.Click += new System.EventHandler(this.pnlRestore_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // ctrBackUp
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(56)))), ((int)(((byte)(66)))));
            this.Controls.Add(this.pnlBackup);
            this.Controls.Add(this.pnlRestore);
            this.Name = "ctrBackUp";
            this.Size = new System.Drawing.Size(1163, 518);
            this.Load += new System.EventHandler(this.ctrBackUp_Load);
            this.pnlBackup.ResumeLayout(false);
            this.pnlBackup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlRestore.ResumeLayout(false);
            this.pnlRestore.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcRestore)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.Panel pnlBackup;
        private System.Windows.Forms.Label lblBackup;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlRestore;
        private System.Windows.Forms.PictureBox pcRestore;
        private System.Windows.Forms.Label lblRestore;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}
