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
    public partial class ctrMain : UserControl
    {
        ctrExamin ctrExamin = new ctrExamin();

        private PrivateFontCollection modernFont = new PrivateFontCollection();
        private static ctrMain _instance { get; set; }
        PatientRepository PatientRepository = new PatientRepository();


        static bool DataGridViewFilled = false;
        public static ctrMain Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ctrMain();
                return _instance;
            }

        }
        public ctrMain()
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

        private void ctrRegister_Load(object sender, EventArgs e)
        {
            Invoke(new Action(() =>
            {
                ChangeFont(this, 11, false);
            }));
        }
        public void FillDataGridView()
        {

            dgvMenuProducts.AutoGenerateColumns = false;
            dgvMenuProducts.DataSource = PatientRepository.GetAll();
        }

        private void dgvMenuProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (((DataGridView)sender).Columns[e.ColumnIndex].CellType 
                == typeof(DataGridViewImageCell) && dgvMenuProducts.Columns[e.ColumnIndex].Name == 
                "Delete" && e.RowIndex >= 0)
            {

                var confirmResult = MessageBox.Show("هل انت متأكد من مسح هذا المريض؟", "تأكيد المسح", MessageBoxButtons.YesNo);

                if (confirmResult == DialogResult.Yes)
                {
                    int id;
                    if (int.TryParse(dgvMenuProducts.Rows[e.RowIndex].Cells["Id"].Value.ToString(), out id))
                    {

                        Patient patient = PatientRepository.Find(id);
                        if (patient != null)
                        {
                            PatientRepository.Remove(id);
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

            if (((DataGridView)sender).Columns[e.ColumnIndex].CellType
               == typeof(DataGridViewImageCell) && dgvMenuProducts.Columns[e.ColumnIndex].Name ==
               "Enter" && e.RowIndex >= 0)
            {

                int id;
                if (int.TryParse(dgvMenuProducts.Rows[e.RowIndex].Cells["Id"].Value.ToString(), out id))
                {


                    Patient patient = PatientRepository.Find(id);
                    patient.IsEntered = true;
                    patient.IsDeleted = true;
                    PatientRepository.save();

                    ctrExamin.FillDataForPatient(id);

                }
            }


            if (((DataGridView)sender).Columns[e.ColumnIndex].CellType == 
                typeof(DataGridViewImageCell) && dgvMenuProducts.Columns[e.ColumnIndex].Name == 
                "Edit" && e.RowIndex >= 0)
            {
                int id;
                if (int.TryParse(dgvMenuProducts.Rows[e.RowIndex].Cells["Id"].Value.ToString(), out id))
                {

                    Patient patient = PatientRepository.Find(id);
                    if (patient != null)
                    {
                        new frmReservation(this,id).ShowDialog();
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
