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
    public partial class A_AddWilayaForm : Form
    {
        string connectionString = @"Data Source=ORCHID\SQLEXPRESS;Initial Catalog=sonelgaz data base;Integrated Security=true;";
        public A_AddWilayaForm()
        {
            InitializeComponent();
        }

        private void AddNewCommuneSauvegarder_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                if (textBoxNewNomWilaya.Text == "")
                    MessageBox.Show("Veuillez remplir tous les champs de saisie nécessaires", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                {
                    sqlCon.Open();
                    SqlCommand sqlCmd = new SqlCommand("AddWilaya", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@NomWil", textBoxNewNomWilaya.Text.Trim());
                    sqlCmd.ExecuteNonQuery();

                    MessageBox.Show("Nouvelle commune enregistrée avec succès", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    Clear();
                }
            }
        }
        public void Clear()
        {
            textBoxNewNomWilaya.Text = "";
        }

        private void textBoxEditCodeWilaya_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxEditNomWilaya_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
