using Clinic.DAL;
using Clinic.DBContext;
using Clinic.Design_Helper;
using Clinic.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Drawing.Text;
using System.Linq;
using System.Windows.Forms;

namespace Clinic
{
    public partial class frmReservation : Form
    {

        int TogMove;
        int MValX;
        int MValY;
        private PrivateFontCollection modernFont;
        private ClinicDBContext ClincDbContext;
        private PatientRepository PatientRepository;
        UserControl ControlForAll;
        


        private int PatientId;
        public frmReservation(UserControl register, int? id = null)
        {
            InitializeComponent();
            modernFont = new PrivateFontCollection();
            ChangeFont(this, 10);

            ClincDbContext = new ClinicDBContext();
            PatientRepository = new PatientRepository();

            cmbPatiendGender.DataSource = ClincDbContext.Genders.ToList();
            cmbPatiendGender.ValueMember = "Id";
            cmbPatiendGender.DisplayMember = "GenderType";
            ControlForAll = register;

            if (id.HasValue)
            {
                btnReservation.Text = "تعديل";
                PatientId = id.Value;
                Patient patient = PatientRepository.Find(PatientId);

                txtPatientName.Text = patient.FullName;
                txtPatientPhone.Text = patient.Phone;
                txtPatientAge.Text = patient.Age + "";
                txtPatientAddress.Text = patient.Address;                            
            }
        }
      
        private void Menu_MouseDown(object sender, MouseEventArgs e)
        {
            TogMove = 1;
            MValX = e.X;
            MValY = e.Y;

        }

        private void Menu_MouseUp(object sender, MouseEventArgs e)
        {
            TogMove = 0;
        }

        private void Menu_MouseMove(object sender, MouseEventArgs e)
        {
            if (TogMove == 1)
            {
                this.SetDesktopLocation(MousePosition.X - MValX, MousePosition.Y - MValY);

            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        public void ChangeFont(Form form, int size)
        {

            modernFont.AddFontFile("Font.ttf");

            form.Font = new System.Drawing.Font(modernFont.Families[0], size);
        }

        private void btnReservation_Click(object sender, EventArgs e)
        {
            bool allValuesValid = true;
            errorProvider.Clear();

            if (string.IsNullOrEmpty(txtPatientName.Text) || txtPatientName.Text.Length < 3)
            {
                errorProvider.SetError(txtPatientName, "ادخل اسم صحيح");
                allValuesValid = false;
            }
            if (string.IsNullOrEmpty(txtPatientPhone.Text) || !long.TryParse(txtPatientPhone.Text, out var phone) || phone.ToString().Length != 10 || !txtPatientPhone.Text.StartsWith("01"))
            {
                errorProvider.SetError(txtPatientPhone, "ادخل اسم رقم تليفون صحيح");
                allValuesValid = false;
            }
            if (string.IsNullOrEmpty(txtPatientAge.Text) || !int.TryParse(txtPatientAge.Text, out var age) || age > 120 || age < 1)
            {
                errorProvider.SetError(txtPatientAge, "ادخل سن صحيح");
                allValuesValid = false;
            }
            if (string.IsNullOrEmpty(txtPatientAddress.Text))
            {
                errorProvider.SetError(txtPatientAddress, "ادخل عنوان صحيح");
                allValuesValid = false;
            }
            if (dateTimePicker1.Value.Date.CompareTo(DateTime.Now.Date) < 0)
            {
                errorProvider.SetError(dateTimePicker1, "ادخل تاريخ صحيح");
            }

            if (allValuesValid)
            {
                if (PatientId == 0)
               {
               
                    PatientRepository.Add(
                        new Patient()
                        {
                            Address = txtPatientAddress.Text,
                            Age = int.Parse(txtPatientAge.Text),
                            FullName = txtPatientName.Text,
                            IsExamined = false,
                            Phone = txtPatientPhone.Text,
                            Order = 1,
                            GenderId = (cmbPatiendGender.SelectedItem as Gender).Id,
                            Appointment = new List<Appointment>(){ new Appointment()
                        {
                            Date=dateTimePicker1.Value.Date.ToShortDateString()
                         }
                            }
                        }
                        );
                    PatientRepository.save();
                    ctrMain ctrMain = (ctrMain)ControlForAll;
                    ctrMain.FillDataGridView();
                    this.Close();

                }
                else
                {

                    Patient patient = PatientRepository.Find(PatientId);
                    patient.FullName = txtPatientName.Text;
                    patient.Phone = txtPatientPhone.Text;
                    patient.Address = txtPatientAddress.Text;
                    patient.Age = Convert.ToInt32(txtPatientAge.Text);
                    patient.GenderId = (cmbPatiendGender.SelectedItem as Gender).Id;
                    patient.Appointment = new List<Appointment>(){ new Appointment()
                        {
                            Date=dateTimePicker1.Value.Date.ToShortDateString()
                         }
                         };
                    PatientRepository.save();
                    if (ControlForAll is ctrMain)
                    {
                        ctrMain ctrMain = (ctrMain)ControlForAll;
                        ctrMain.FillDataGridView();
                        this.Close();
                    }
                    else if (ControlForAll is ctrSearch)
                    {
                        ctrSearch ctrSearch = (ctrSearch)ControlForAll;
                        ctrSearch.FillDataGridViewForSearch();
                        this.Close();
                    }

                }
            }
          
        }

        private void frmReservation_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}

