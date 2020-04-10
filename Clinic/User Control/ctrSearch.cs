using Clinic.DAL;
using Clinic.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing.Text;
using System.Linq;
using System.Windows.Forms;
using Clinic.DBContext;

namespace Clinic
{
    public partial class ctrSearch : UserControl
    {

        static bool DataGridViewFilled = false;
        
        PatientRepository PatientRepository = new PatientRepository();

        private PrivateFontCollection modernFont = new PrivateFontCollection();
        private static ctrSearch _instance { get; set; }
        public static ctrSearch Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ctrSearch();
                return _instance;
            }
        }
        public ctrSearch()
        {

            InitializeComponent();
          
            if (!DataGridViewFilled)
            {
                DataGridViewFilled = true;
                FillDataGridViewForSearch();
            }

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

        private void ctrSearch_Load(object sender, EventArgs e)
        {
            Invoke(new Action(() =>
            {
                ChangeFont(this, 11, false);
            }));
        }

        public void FillDataGridViewForSearch()
        {

            dgvSearchPatient.AutoGenerateColumns = false;
            dgvSearchPatient.DataSource = PatientRepository.GetAll();
        }

        
        private void dgvSearchPatient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (((DataGridView)sender).Columns[e.ColumnIndex].CellType 
                == typeof(DataGridViewImageCell) && dgvSearchPatient.Columns[e.ColumnIndex].Name == 
                "Delete" && e.RowIndex >= 0)
            {

                var confirmResult = MessageBox.Show("هل انت متأكد من مسح هذا المريض؟", "تأكيد المسح", MessageBoxButtons.YesNo);

                if (confirmResult == DialogResult.Yes)
                {
                    int id;
                    if (int.TryParse(dgvSearchPatient.Rows[e.RowIndex].Cells["Id"].Value.ToString(), out id))
                    {

                        Patient patient = PatientRepository.Find(id);
                        if (patient != null)
                        {
                            PatientRepository.Remove(id);
                            PatientRepository.save();
                            Invoke(new Action(() => { FillDataGridViewForSearch(); }));
                        }
                        else
                        {
                            MessageBox.Show("خطأ ");
                        }
                    }
                    else
                    {
                        MessageBox.Show("اختيار خطأ");
                    }
                }
            }


            if (((DataGridView)sender).Columns[e.ColumnIndex].CellType ==
                typeof(DataGridViewImageCell) && dgvSearchPatient.Columns[e.ColumnIndex].Name ==
                "Edit" && e.RowIndex >= 0)
            {
                int id;
                if (int.TryParse(dgvSearchPatient.Rows[e.RowIndex].Cells["Id"].Value.ToString(), out id))
                {

                    Patient patient = PatientRepository.Find(id);
                    if (patient != null)
                    {
                        new frmReservation(this, id).ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("خطأ ");
                    }
                }
                else
                {
                    MessageBox.Show("اختيار خطأ");
                }
            }


        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

            AutoCompleteStringCollection autoText = new AutoCompleteStringCollection();

            foreach (var item in PatientRepository.GetFullName())
            {
                autoText.Add(item);
            }

            txtSearch.AutoCompleteCustomSource=autoText; 
                       


            }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {

                 return;
            }
            string patientName = txtSearch.Text;

            dgvSearchPatient.AutoGenerateColumns = false;
            dgvSearchPatient.DataSource = PatientRepository.GetPatienWithSpcificName(patientName);
            txtSearch.Clear();

        }

       
    }
    }

