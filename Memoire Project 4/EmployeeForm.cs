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
    public partial class EmployeeForm : Form
    {
        public static EmployeeForm instance;
        public EmployeeForm()
        {
            InitializeComponent();

            instance = this;
            SetTheUsername();

            LoadForm(new E_SejoursForm());

            panelAdminButtonIndicator.Visible = true;
            panelAdminButtonIndicator.Height = buttonSejours.Height;
            panelAdminButtonIndicator.Top = buttonSejours.Top;
            panelAdminButtonIndicator.Left = buttonSejours.Left;

            buttonSejours.BackColor = Color.FromArgb(25, 24, 36);

            //buttonSejour.BackColor = Color.FromArgb(36, 37, 56);

        }

        public void LoadForm(object Form)
        {
            if (this.panelEmployeeCenter.Controls.Count > 0)
                this.panelEmployeeCenter.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.panelEmployeeCenter.Controls.Add(f);
            this.panelEmployeeCenter.Tag = f;
            f.Show();
        }

        public void SetTheUsername()
        {
            labelAgentName.Text=LoginForm.instance.tb1.Text.Trim();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonEmployes_Click(object sender, EventArgs e)
        {
            panelAdminButtonIndicator.Height = buttonSejours.Height;
            panelAdminButtonIndicator.Top = buttonSejours.Top;
            panelAdminButtonIndicator.Left = buttonSejours.Left;

            buttonSejours.BackColor = Color.FromArgb(25, 24, 36);
            buttonMesAyantDroit.BackColor = Color.FromArgb(36, 37, 56);
            buttonMesInscription.BackColor = Color.FromArgb(36, 37, 56);

            LoadForm(new E_SejoursForm());
        }

        private void EmployeeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panelAdminButtonIndicator.Height = buttonMesAyantDroit.Height;
            panelAdminButtonIndicator.Top = buttonMesAyantDroit.Top;
            panelAdminButtonIndicator.Left = buttonMesAyantDroit.Left;

            buttonSejours.BackColor = Color.FromArgb(36, 37, 56);
            buttonMesAyantDroit.BackColor = Color.FromArgb(25, 24, 36);
            buttonMesInscription.BackColor = Color.FromArgb(36, 37, 56);

            LoadForm(new E_MesAyantsDroit());
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();

            LoginForm FRM = new LoginForm();
            FRM.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panelAdminButtonIndicator.Height = buttonMesInscription.Height;
            panelAdminButtonIndicator.Top = buttonMesInscription.Top;
            panelAdminButtonIndicator.Left = buttonMesInscription.Left;

            buttonSejours.BackColor = Color.FromArgb(36, 37, 56);
            buttonMesAyantDroit.BackColor = Color.FromArgb(36, 37, 56);
            buttonMesInscription.BackColor = Color.FromArgb(25, 24, 36);

            LoadForm(new E_MesInscriptionForm());
        }
    }
}
