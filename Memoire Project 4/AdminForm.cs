using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memoire_Project_4
{
    public partial class AdminForm : Form
    {
        public static AdminForm instance;
        public AdminForm()
        {
            InitializeComponent();

            instance = this;

            labelAdminName.Text = LoginForm.instance.tb1.Text.Trim();

            // Loading the Employees form
            panelAdminButtonIndicator.Visible = true;
            panelAdminButtonIndicator.Height = buttonEmployes.Height;
            panelAdminButtonIndicator.Top = buttonEmployes.Top;
            panelAdminButtonIndicator.Left = buttonEmployes.Left;

            buttonEmployes.BackColor = Color.FromArgb(25, 24, 36);

            buttonSejour.BackColor = Color.FromArgb(36, 37, 56);
            buttonAyantDroit.BackColor = Color.FromArgb(36, 37, 56);
            buttonInscription.BackColor = Color.FromArgb(36, 37, 56);

            LoadForm(new A_EmployeesManagementForm());
        }

        public void LoadForm(object Form)
        {
            if (this.panelAdminCenter.Controls.Count > 0)
                this.panelAdminCenter.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.panelAdminCenter.Controls.Add(f);
            this.panelAdminCenter.Tag = f;
            f.Show();
        }

        private void buttonEmployes_Click(object sender, EventArgs e)
        {
            panelAdminButtonIndicator.Height = buttonEmployes.Height;
            panelAdminButtonIndicator.Top = buttonEmployes.Top;
            panelAdminButtonIndicator.Left = buttonEmployes.Left;

            //New selection tabe
            buttonEmployes.BackColor = Color.FromArgb(25, 24, 36);
            buttonAyantDroit.BackColor = Color.FromArgb(36, 37, 56);
            buttonSejour.BackColor = Color.FromArgb(36, 37, 56);
            buttonTypeSession.BackColor = Color.FromArgb(36, 37, 56);
            buttonInscription.BackColor = Color.FromArgb(36, 37, 56);
            buttonEtatsRubrique.BackColor = Color.FromArgb(36, 37, 56);
            buttonTarifs.BackColor = Color.FromArgb(36, 37, 56);
            buttonCommuneWilaya.BackColor = Color.FromArgb(36, 37, 56);
            buttonExtraitsBancaire.BackColor = Color.FromArgb(36, 37, 56);

            LoadForm(new A_EmployeesManagementForm());
        }

        private void buttonSejour_Click(object sender, EventArgs e)
        {
            panelAdminButtonIndicator.Height = buttonSejour.Height;
            panelAdminButtonIndicator.Top = buttonSejour.Top;
            panelAdminButtonIndicator.Left = buttonSejour.Left;

            buttonEmployes.BackColor = Color.FromArgb(36, 37, 56);
            buttonAyantDroit.BackColor = Color.FromArgb(36, 37, 56);
            buttonSejour.BackColor = Color.FromArgb(25, 24, 36);
            buttonTypeSession.BackColor = Color.FromArgb(36, 37, 56);
            buttonInscription.BackColor = Color.FromArgb(36, 37, 56);
            buttonEtatsRubrique.BackColor = Color.FromArgb(36, 37, 56);
            buttonTarifs.BackColor = Color.FromArgb(36, 37, 56);
            buttonCommuneWilaya.BackColor = Color.FromArgb(36, 37, 56);
            buttonExtraitsBancaire.BackColor = Color.FromArgb(36, 37, 56);

            LoadForm(new A_SejourManagementForm());

        }

        private void button2_Click(object sender, EventArgs e)
        {
            panelAdminButtonIndicator.Height = buttonAyantDroit.Height;
            panelAdminButtonIndicator.Top = buttonAyantDroit.Top;
            panelAdminButtonIndicator.Left = buttonAyantDroit.Left;

            buttonEmployes.BackColor = Color.FromArgb(36, 37, 56);
            buttonAyantDroit.BackColor = Color.FromArgb(25, 24, 36);
            buttonSejour.BackColor = Color.FromArgb(36, 37, 56);
            buttonTypeSession.BackColor = Color.FromArgb(36, 37, 56);
            buttonInscription.BackColor = Color.FromArgb(36, 37, 56);
            buttonEtatsRubrique.BackColor = Color.FromArgb(36, 37, 56);
            buttonTarifs.BackColor = Color.FromArgb(36, 37, 56);
            buttonCommuneWilaya.BackColor = Color.FromArgb(36, 37, 56);
            buttonExtraitsBancaire.BackColor = Color.FromArgb(36, 37, 56);

            LoadForm(new A_AyantDroitForm());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panelAdminButtonIndicator.Height = buttonInscription.Height;
            panelAdminButtonIndicator.Top = buttonInscription.Top;
            panelAdminButtonIndicator.Left = buttonInscription.Left;

            buttonEmployes.BackColor = Color.FromArgb(36, 37, 56);
            buttonAyantDroit.BackColor = Color.FromArgb(36, 37, 56);
            buttonSejour.BackColor = Color.FromArgb(36, 37, 56);
            buttonTypeSession.BackColor = Color.FromArgb(36, 37, 56);
            buttonInscription.BackColor = Color.FromArgb(25, 24, 36);
            buttonEtatsRubrique.BackColor = Color.FromArgb(36, 37, 56);
            buttonTarifs.BackColor = Color.FromArgb(36, 37, 56);
            buttonCommuneWilaya.BackColor = Color.FromArgb(36, 37, 56);
            buttonExtraitsBancaire.BackColor = Color.FromArgb(36, 37, 56);

            LoadForm(new A_InscriptionForm());
        }

        private void AdminForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();

            LoginForm FRM = new LoginForm();
            FRM.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            panelAdminButtonIndicator.Height = buttonCommuneWilaya.Height;
            panelAdminButtonIndicator.Top = buttonCommuneWilaya.Top;
            panelAdminButtonIndicator.Left = buttonCommuneWilaya.Left;

            //.BackColor = Color.FromArgb(25, 24, 36);

            //.BackColor = Color.FromArgb(36, 37, 56);
            


            buttonEmployes.BackColor = Color.FromArgb(36, 37, 56);
            buttonAyantDroit.BackColor = Color.FromArgb(36, 37, 56);
            buttonSejour.BackColor = Color.FromArgb(36, 37, 56);
            buttonTypeSession.BackColor = Color.FromArgb(36, 37, 56);
            buttonInscription.BackColor = Color.FromArgb(36, 37, 56);
            buttonEtatsRubrique.BackColor = Color.FromArgb(36, 37, 56);
            buttonTarifs.BackColor = Color.FromArgb(36, 37, 56);
            buttonCommuneWilaya.BackColor = Color.FromArgb(25, 24, 36);
            buttonExtraitsBancaire.BackColor = Color.FromArgb(36, 37, 56);

            LoadForm(new A_Commune_WilayaForm());
        }

        private void buttonTypeSession_Click(object sender, EventArgs e)
        {
            panelAdminButtonIndicator.Height = buttonTypeSession.Height;
            panelAdminButtonIndicator.Top = buttonTypeSession.Top;
            panelAdminButtonIndicator.Left = buttonTypeSession.Left;

            //.BackColor = Color.FromArgb(25, 24, 36);

            //.BackColor = Color.FromArgb(36, 37, 56);



            buttonEmployes.BackColor = Color.FromArgb(36, 37, 56);
            buttonAyantDroit.BackColor = Color.FromArgb(36, 37, 56);
            buttonSejour.BackColor = Color.FromArgb(36, 37, 56);
            buttonTypeSession.BackColor = Color.FromArgb(25, 24, 36);
            buttonInscription.BackColor = Color.FromArgb(36, 37, 56);
            buttonEtatsRubrique.BackColor = Color.FromArgb(36, 37, 56);
            buttonTarifs.BackColor = Color.FromArgb(36, 37, 56);
            buttonCommuneWilaya.BackColor = Color.FromArgb(36, 37, 56);
            buttonExtraitsBancaire.BackColor = Color.FromArgb(36, 37, 56);

            LoadForm(new A_TypeDeSessionForm());
        }
    }
}
