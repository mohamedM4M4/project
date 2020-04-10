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
    public partial class ctrExamin : UserControl

    {
        static bool DataGridViewFilled = false;
        MedicineRepository medicineRepository = new MedicineRepository();

        private PrivateFontCollection modernFont = new PrivateFontCollection();
        private static ctrExamin _instance { get; set; }
        public static ctrExamin Instance
        {
            get
            {
              
                _instance = new ctrExamin();
                return _instance;
            }
        }
        public ctrExamin()
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

        private void ctrExamin_Load(object sender, EventArgs e)
        {
            Invoke(new Action(() =>
            {
                ChangeFont(this, 11, false);
            }));
        }

        private void printPreviewControl1_Click(object sender, EventArgs e)
        {

        }

        private void reportViewer2_Load(object sender, EventArgs e)
        {

        }

        public void FillDataForPatient(int PatientId)
        {
            PatientRepository PatientRepository = new PatientRepository();

            Patient patient = PatientRepository.Find(PatientId);
            txtPname.Text = patient.FullName;
            txtPAge.Text = patient.Age + "";
            txtPAddress.Text = patient.Address;
            txtPPhone.Text = patient.Phone;
            PatientRepository.save();

        }

        public void FillDataGridView()
        {

            dgvMedicin.AutoGenerateColumns = false;
            dgvMedicin.DataSource = medicineRepository.GetAll();
        }
        private void btadd_Click(object sender, EventArgs e)
        {
            
                Medicine medicine = new Medicine();
                medicine.Name = txtMName.Text;
                medicine.ConcentrationOfTheDrug = Convert.ToInt32(txtMConceration.Text);
                medicine.FinishDate = txtMEnd.Text;
                medicine.Quantity = Convert.ToInt32(txtMQuantity.Text);
                medicine.TimesPerDay = Convert.ToInt32(txtMTimesPerDay.Text);
                MedicineRepository medicineRepository = new MedicineRepository();
                medicineRepository.Add(medicine);
                medicineRepository.save();
                FillDataGridView();
            
        }

        private void dgvMedicin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
