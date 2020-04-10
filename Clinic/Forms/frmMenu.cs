using Clinic.DAL;
using Clinic.Design_Helper;
using Clinic.Model;
using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Windows.Forms;

namespace Clinic
{
    public partial class frmMenu : Form
    {

        int TogMove;
        int MValX;
        int MValY;
        private PrivateFontCollection modernFont = new PrivateFontCollection();
        static List<ClassModel> AllMenuPanel;
        UserDAL userDAL = new UserDAL();
        List<Permissions> Permissioins = new List<Permissions>();

        public frmMenu()
        {
            InitializeComponent();

            AllMenuPanel = new List<ClassModel>()
                   {

                     new ClassModel() { PanelTxt= nameof(pnlRegister),Panel= pnlRegister },
                     new ClassModel() { PanelTxt= nameof(pnlRegister),Panel= pnlExamin },
                     new ClassModel() { PanelTxt= nameof(pnlRegister),Panel= pnlMedicine },
                     new ClassModel() { PanelTxt= nameof(pnlRegister),Panel= pnlPrescreption },
                     new ClassModel() { PanelTxt= nameof(pnlRegister),Panel= pnlSearch },
                     new ClassModel() { PanelTxt= nameof(pnlRegister),Panel= pnlUsers },
                     new ClassModel() { PanelTxt= nameof(pnlRegister),Panel= pnlBackUp },
                     new ClassModel() { PanelTxt= nameof(pnlRegister),Panel= pnlArchive }
                };

            //Permissioins = Services_Program.Forms.frmLogin.UserObj.Permissions.ToList();

            //for (int i = 0; i < AllMenuPanel.Count; i++)
            //{
            //    if (Permissioins.Exists(c => c.PermissionPnl == AllMenuPanel[i].PanelTxt))
            //    {
            //        continue;
            //    }
            //    AllMenuPanel[i].Panel.Enabled = false;
            //}


            ChangeFont(this, 10);
            ChangeFont(menuStrip, 9);

            ctrArchive.Instance.Name = nameof(ctrArchive);
            ctrBackUp.Instance.Name = nameof(ctrBackUp);
            ctrMedicine.Instance.Name = nameof(ctrMedicine);
            ctrPrescreption.Instance.Name = nameof(ctrPrescreption);
            ctrMain.Instance.Name = nameof(ctrMain);
            ctrSearch.Instance.Name = nameof(ctrSearch);
            ctrUsers.Instance.Name = nameof(ctrUsers);


            pnlContainer.Controls.Add(ctrPrescreption.Instance);
            pnlContainer.Controls.Add(ctrMain.Instance);
            pnlContainer.Controls.Add(ctrSearch.Instance);
            pnlContainer.Controls.Add(ctrUsers.Instance);
            pnlContainer.Controls.Add(ctrArchive.Instance);
            pnlContainer.Controls.Add(ctrBackUp.Instance);
            pnlContainer.Controls.Add(ctrExamin.Instance);
            pnlContainer.Controls.Add(ctrMedicine.Instance);



            var control = pnlContainer.Controls.Find(nameof(ctrMain), false).FirstOrDefault();
            control.BringToFront();
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
        public void ChangeFont(MenuStrip menu, int size)
        {

            modernFont.AddFontFile("Font.ttf");
            menu.Font = new System.Drawing.Font(modernFont.Families[0], size);
        }

        private void PcRegister_Click(object sender, EventArgs e)
        {

            new frmReservation(ctrMain.Instance).ShowDialog();
        }

        private void pcMedicine_Click(object sender, EventArgs e)
        {
            var control = pnlContainer.Controls.Find(nameof(ctrMedicine), false).FirstOrDefault();
            control.BringToFront();
        }

        private void pcExamin_Click(object sender, EventArgs e)
        {
            var control = pnlContainer.Controls.Find(nameof(ctrExamin), false).FirstOrDefault();
            control.BringToFront();
        }

        private void pcSearch_Click(object sender, EventArgs e)
        {
            var control = pnlContainer.Controls.Find(nameof(ctrSearch), false).FirstOrDefault();
            control.BringToFront();
        }

        private void pcPrescreption_Click(object sender, EventArgs e)
        {
            var control = pnlContainer.Controls.Find(nameof(ctrPrescreption), false).FirstOrDefault();
            control.BringToFront();
        }

        private void pcArchive_Click(object sender, EventArgs e)
        {
            var control = pnlContainer.Controls.Find(nameof(ctrArchive), false).FirstOrDefault();
            control.BringToFront();
        }

        private void pcBackUp_Click(object sender, EventArgs e)
        {
            var control = pnlContainer.Controls.Find(nameof(ctrBackUp), false).FirstOrDefault();
            control.BringToFront();
        }

        private void pcUsers_Click(object sender, EventArgs e)
        {
            var control = pnlContainer.Controls.Find(nameof(ctrUsers), false).FirstOrDefault();
            control.BringToFront();
        }

        private void pnlRegister_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlContainer_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

