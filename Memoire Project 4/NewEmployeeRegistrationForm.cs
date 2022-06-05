using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Memoire_Project_4
{
    public partial class NewEmployeeRegistrationForm : Form
    {
        string connectionString = @"Data Source=ORCHID\SQLEXPRESS;Initial Catalog=sonelgaz data base;Integrated Security=true;";

        public NewEmployeeRegistrationForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddNewEmployeeSauvegarder_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                if (textBoxNewUsername.Text == "" || textBoxNewPassword.Text == "" || comboBoxNewUserType.Text == "")
                    MessageBox.Show("Veuillez remplir toutes les cases obligatoires");
                else if (textBoxNewPassword.Text != textBoxNewPasswordConfirm.Text)
                    MessageBox.Show("Mots de passe ne correspondent pas!");
                else
                {
                    sqlCon.Open();
                    SqlCommand sqlCmd = new SqlCommand("UserADD", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@NomAgent", textBoxNewNomAgent.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@PrenomAgent", textBoxNewPrenomAgent.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@DatNaisAgent", dateTimePickerNewDatNaisAgent.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@AdrAgent", textBoxNewAdrAgent.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@VilleAgent", textBoxNewVilleAgent.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@TelAgent", textBoxNewTelAgent.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@SitFamAgent", textBoxNewSitFamAgent.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@SitPrAgent", textBoxNewSitPrAgent.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@NumPasAgent", textBoxNewNumPasAgent.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@DatDelPasAgent", dateTimePickerNewDatDelPasAgent.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Username", textBoxNewUsername.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Password", textBoxNewPassword.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@UserType", comboBoxNewUserType.Text.Trim());
                    sqlCmd.ExecuteNonQuery();
                    MessageBox.Show("Nouvel employé enregistré");
                    Clear();
                }
            }
        }

        void Clear()
        {
            textBoxNewNomAgent.Text = textBoxNewPrenomAgent.Text = dateTimePickerNewDatNaisAgent.Text = textBoxNewAdrAgent.Text = textBoxNewVilleAgent.Text = textBoxNewTelAgent.Text = textBoxNewSitFamAgent.Text = textBoxNewSitPrAgent.Text = textBoxNewNumPasAgent.Text = dateTimePickerNewDatDelPasAgent.Text = textBoxNewUsername.Text = textBoxNewPassword.Text = textBoxNewPasswordConfirm.Text = comboBoxNewUserType.Text = "";
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBoxNewTelAgent_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxNewNumPasAgent_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxNewNumPasAgent_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxNewNomAgent_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxNewPrenomAgent_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxNewAdrAgent_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBoxNewVilleAgent_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxNewSitFamAgent_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxNewSitPrAgent_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxNewUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxNewPassword_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBoxNewPasswordConfirm_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
