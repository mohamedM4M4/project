using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing.Text;
using System.Linq;
using System.Windows.Forms;

namespace Clinic
{
    public partial class ctrBackUp : UserControl
    {
        private PrivateFontCollection modernFont = new PrivateFontCollection();
        private SqlConnection SqlConnection;
        private static ctrBackUp _instance { get; set; }
        public static ctrBackUp Instance
        {
            get
            {

                _instance = new ctrBackUp();
                return _instance;
            }
        }
        public ctrBackUp()
        {

            InitializeComponent();
            SqlConnection = new SqlConnection("data source=.;database=clinic;integrated security=true");

        }



        internal void ChangeFont(UserControl control, int size, bool isBold = false)
        {
            modernFont.AddFontFile("Font.ttf");
            control.Font = new System.Drawing.Font(modernFont.Families[0], size, isBold ? System.Drawing.FontStyle.Bold : System.Drawing.FontStyle.Regular);
        }
        internal void ChangeFont(DataGridViewCellStyle columnHeadersDefaultCellStyle, int size, bool isBold)
        {
            modernFont.AddFontFile("Font.ttf");
            columnHeadersDefaultCellStyle.Font = new System.Drawing.Font(modernFont.Families[0], size, isBold ? System.Drawing.FontStyle.Bold : System.Drawing.FontStyle.Regular);
        }

        private void ctrBackUp_Load(object sender, EventArgs e)
        {
            Invoke(new Action(() =>
            {
                ChangeFont(this, 11, false);
            }));
        }

        private void lblBackup_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                string query = $@"backup database clinic to disk = '{folderBrowserDialog.SelectedPath}\clinic.bak'";
                using (SqlCommand sqlCommand = new SqlCommand(query, SqlConnection))
                {

                    if (SqlConnection.State != ConnectionState.Open)
                        SqlConnection.Open();

                    sqlCommand.ExecuteNonQuery();
                    SqlConnection.Close();

                    MessageBox.Show("تم النسخ الاحتياطي");
                }
            }
        }

        private void pnlRestore_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                openFileDialog.Filter = "Sql server Database Backup |*.bak";
                openFileDialog.Title = "DataBase Restore..";

                if (SqlConnection.State != ConnectionState.Open)
                    SqlConnection.Open();

                
                SqlCommand command1 = new SqlCommand("ALTER DATABASE clinic set SINGLE_USER WITH ROLLBACK IMMEDIATE", SqlConnection);
                command1.ExecuteNonQuery();

                SqlCommand command2 = new SqlCommand($"use master restore database clinic from disk = '{openFileDialog.FileName}' with replace;", SqlConnection);
                command2.ExecuteNonQuery();

                SqlCommand command3 = new SqlCommand($"alter database clinic set multi_user", SqlConnection);
                command3.ExecuteNonQuery();

                MessageBox.Show("تم استرجاع المعلومات");
                SqlConnection.Close();
            }
        }
    }
}