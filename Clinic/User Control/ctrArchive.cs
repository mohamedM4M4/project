using Clinic.DAL;
using Clinic.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing.Text;
using System.Linq;
using System.Windows.Forms;

namespace Clinic
{
    public partial class ctrArchive : UserControl
    {

        static bool DataGridViewFilled = false;
        PatientRepository PatientRepository = new PatientRepository();

        private PrivateFontCollection modernFont = new PrivateFontCollection();
        private static ctrArchive _instance { get; set; }
        public static ctrArchive Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ctrArchive();
                return _instance;
            }
        }
        public ctrArchive()
        {

            InitializeComponent();
            if (!DataGridViewFilled)
            {
                DataGridViewFilled = true;
                FillDataGridView();
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

        private void ctrArchive_Load(object sender, EventArgs e)
        {
            Invoke(new Action(() =>
            {
                ChangeFont(this, 11, false);
            }));
        }





        public void FillDataGridView()
        {

            dgvSearchDeletedPatient.AutoGenerateColumns = false;
            dgvSearchDeletedPatient.DataSource = PatientRepository.GetAllDeletedPatient();
        }
        private void txtSearchForDeletedPatient_TextChanged(object sender, EventArgs e)
        {
            AutoCompleteStringCollection autoText = new AutoCompleteStringCollection();

            foreach (var item in PatientRepository.GetFullNameForDeletedPatient())
            {
                autoText.Add(item);
            }

            txtSearchForDeletedPatient.AutoCompleteCustomSource = autoText;


        }

        private void btnSearchForDeletedPatient_Click(object sender, EventArgs e)
        {
            if (txtSearchForDeletedPatient.Text == "")
            {

                return;
            }
            string patientName = txtSearchForDeletedPatient.Text;

            dgvSearchDeletedPatient.AutoGenerateColumns = false;
            dgvSearchDeletedPatient.DataSource = PatientRepository.GetPatienDeletedWithSpcificName(patientName);
            txtSearchForDeletedPatient.Clear();

        }

        private void dgvSearchDeletedPatient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (((DataGridView)sender).Columns[e.ColumnIndex].CellType
                == typeof(DataGridViewImageCell) && dgvSearchDeletedPatient.Columns[e.ColumnIndex].Name ==
                "Delete" && e.RowIndex >= 0)
            {

                var confirmResult = MessageBox.Show("هل انت متأكد من مسح هذا المريض؟", "تأكيد المسح", MessageBoxButtons.YesNo);

                if (confirmResult == DialogResult.Yes)
                {
                    int id;
                    if (int.TryParse(dgvSearchDeletedPatient.Rows[e.RowIndex].Cells["Id"].Value.ToString(), out id))
                    {

                        Patient patient = PatientRepository.Find(id);
                        if (patient != null)
                        {
                            PatientRepository.RemoveFromArchive(id);
                            PatientRepository.save();
                            Invoke(new Action(() => { FillDataGridView(); }));
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
                typeof(DataGridViewImageCell) && dgvSearchDeletedPatient.Columns[e.ColumnIndex].Name ==
                "Edit" && e.RowIndex >= 0)
            {
                
                var confirmResult =
                MessageBox.Show("هل انت متأكد من استعادة هذا المريض؟", "تأكيد الاستعادة", MessageBoxButtons.YesNo);

                if (confirmResult == DialogResult.Yes)
                {
                    int id;
                    if (int.TryParse(dgvSearchDeletedPatient.Rows[e.RowIndex].Cells["Id"].Value.ToString(), out id))
                    {

                        Patient patient = PatientRepository.Find(id);
                        if (patient != null)
                        {
                            PatientRepository.Recovery(id);
                            PatientRepository.save();
                            Invoke(new Action(() => { FillDataGridView(); }));

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
        }
    }
}
