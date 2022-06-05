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
    public partial class A_AddCommuneForm : Form
    {
        string connectionString = @"Data Source=ORCHID\SQLEXPRESS;Initial Catalog=sonelgaz data base;Integrated Security=true;";

        public A_AddCommuneForm()
        {
            InitializeComponent();
            cbGetCodeWilaya();
        }

        private void AddNewEmployeeSauvegarder_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                if (textBoxNewNomCom.Text == "" || comboBoxNewCodeWilaya.Text == "")
                    MessageBox.Show("Veuillez remplir tous les champs de saisie nécessaires", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                {
                    sqlCon.Open();
                    SqlCommand sqlCmd = new SqlCommand("AddCommune", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@NomCom", textBoxNewNomCom.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@CodeWil", comboBoxNewCodeWilaya.Text.Trim());

                    sqlCmd.ExecuteNonQuery();
                    MessageBox.Show("Nouvelle commune enregistrée avec succès", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();
                }
            }
        }

        public void Clear()
        {
            textBoxNewNomCom.Text = comboBoxNewCodeWilaya.Text = "";
        }

        public void cbGetCodeWilaya()
        {
            SqlConnection con1 = new SqlConnection(connectionString);
            con1.Open();
            SqlCommand cmd1 = new SqlCommand("Select * from Wilaya", con1);
            SqlDataReader dr1 = cmd1.ExecuteReader();
            while (dr1.Read())
            {
                comboBoxNewCodeWilaya.Items.Add(dr1.GetValue(0).ToString());
            }
            dr1.Close();

            con1.Close();
        }

        public void getNomWilaya()
        {
            SqlConnection con2 = new SqlConnection(connectionString);
            con2.Open();
            SqlCommand cmd2 = new SqlCommand("select * from Wilaya where CodeWil like'" + comboBoxNewCodeWilaya.Text + "'", con2);
            SqlDataReader dr2 = cmd2.ExecuteReader();
            while (dr2.Read())
            {
                textBoxShowNomWilaya.Text = dr2.GetValue(1).ToString();

            }
            dr2.Close();
            con2.Close();
        }
        private void textBoxNewCodeCom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxNewNomCom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void comboBoxNewCodeWilaya_SelectedIndexChanged(object sender, EventArgs e)
        {
            getNomWilaya();
        }
    }
}
