using Clinic.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing.Text;
using System.Linq;
using System.Windows.Forms;
using Clinic.DAL;
namespace Clinic
{
    public partial class ctrMedicine : UserControl
    {
        static bool DataGridViewFilled = false;
        MedicineRepository medicineRepository = new MedicineRepository();


        private PrivateFontCollection modernFont = new PrivateFontCollection();
        private static ctrMedicine _instance { get; set; }
        public static ctrMedicine Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ctrMedicine();
                return _instance;
            }
        }
        public ctrMedicine()
        {

            InitializeComponent();

            if (!DataGridViewFilled)
            {
                DataGridViewFilled = true;
                FillDataGridView();
            }


        }

        public void FillDataGridView()
        {

            dgvMedicine.AutoGenerateColumns = false;
            dgvMedicine.DataSource = medicineRepository.GetAll();
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

        private void ctrMedicine_Load(object sender, EventArgs e)
        {
            Invoke(new Action(() =>
            {
                ChangeFont(this, 11, false);
            }));
        }

            

        private void btadd_Click(object sender, EventArgs e)
        {
           
            if (string.IsNullOrEmpty(txtMedcineName.Text) || txtMedcineName.Text.Length < 3)
            {
                
                return;   
            }
            
            Medicine medicine = new Medicine();
            medicine.Name = txtMedcineName.Text;
            medicine.ConcentrationOfTheDrug = Convert.ToInt32(txtMedcineConceration.Text);
            medicine.Quantity = 3;
            medicine.TimesPerDay = 4;
            MedicineRepository medicineRepository = new MedicineRepository();
            medicineRepository.Add(medicine);
            medicineRepository.save();
            FillDataGridView();
            txtMedcineName.Clear();
            txtMedcineConceration.Clear();
        }

        private void dgvMedicine_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (((DataGridView)sender).Columns[e.ColumnIndex].CellType
               == typeof(DataGridViewImageCell) && dgvMedicine.Columns[e.ColumnIndex].Name ==
               "Delete" && e.RowIndex >= 0)
            {

                var confirmResult = MessageBox.Show("هل انت متأكد من مسح هذا الدواء؟", "تأكيد المسح", MessageBoxButtons.YesNo);

                if (confirmResult == DialogResult.Yes)
                {
                    int id;
                    if (int.TryParse(dgvMedicine.Rows[e.RowIndex].Cells["Id"].Value.ToString(), out id))
                    {

                        Medicine Medicine = medicineRepository.Find(id);
                        if (Medicine != null)
                        {
                            medicineRepository.Remove(id);
                            medicineRepository.save();
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
