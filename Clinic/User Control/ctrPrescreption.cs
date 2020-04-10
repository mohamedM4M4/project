using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing.Text;
using System.Linq;
using System.Windows.Forms;
using Clinic.Model;
using Clinic.DAL;
namespace Clinic
{
    public partial class ctrPrescreption : UserControl
    {
        ClinicRepository ClinicRepository;
        DoctorRepository DoctorRepository;

        private PrivateFontCollection modernFont = new PrivateFontCollection();
        private static ctrPrescreption _instance { get; set; }
        public static ctrPrescreption Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ctrPrescreption();
                return _instance;
            }
        }
        public ctrPrescreption()
        {

            InitializeComponent();
            groupBox1.Visible = true;
            pictureBox1.Visible = true;
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

        private void ctrPrescreption_Load(object sender, EventArgs e)
        {
            Invoke(new Action(() =>
            {
                ChangeFont(this, 11, false);
            }));
        }

       
        private void btnEditInformation_Click(object sender, EventArgs e)
        {

            Model.Clinic clinic = ClinicRepository.Find(1);
            Doctor doctor = DoctorRepository.Find(1);
            
            clinic.Location = txtClinicLocation.Text;
            ClinicRepository.Add(clinic);
            ClinicRepository.save();

            doctor.FullName = txtDoctorName.Text;
            doctor.Phone = txtDoctorPhone.Text;
            doctor.Qualification = txtQualificationAndPositionForDoctor.Text;
            DoctorRepository.Add(doctor);
            DoctorRepository.save();

            clearAllTextBox();
            //txtDoctorName.Clear();
            //txtDoctorName.Clear();
            //txtDoctorName.Clear();
            //txtDoctorName.Clear();
            var confirmResult =
            MessageBox.Show("تم تعديل البيانات بنجاح","", MessageBoxButtons.OK);


        }
        private void clearAllTextBox()
        {
            foreach (Control c in Controls)
            {
                if (c is TextBox)
                {
                    c.Text = "";
                }
            }
        }
    }
}
