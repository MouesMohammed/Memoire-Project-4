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
    public partial class A_AddSejourForm : Form
    {
        string connectionString = @"Data Source=ORCHID\SQLEXPRESS;Initial Catalog=sonelgaz data base;Integrated Security=true;";

        public A_AddSejourForm()
        {
            InitializeComponent();
            getCodeCommune();
            getCodetypeSession();
        }

        public void getCodeCommune()
        {
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Commune", con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBoxNewCodeCom.Items.Add(dr.GetValue(0).ToString());

            }
            dr.Close();
            con.Close();
        }

        public void getCodetypeSession()
        {
            SqlConnection con1 = new SqlConnection(connectionString);
            con1.Open();
            SqlCommand cmd1 = new SqlCommand("select * from [Type session]", con1);
            SqlDataReader dr1 = cmd1.ExecuteReader();
            while (dr1.Read())
            {
                comboBoxNewCodeTypSes.Items.Add(dr1.GetValue(0).ToString());

            }
            dr1.Close();
            con1.Close();
        }

        public void getNomCommune()
        {
            SqlConnection con2 = new SqlConnection(connectionString);
            con2.Open();
            SqlCommand cmd2 = new SqlCommand("select * from Commune where CodeCom like '" + comboBoxNewCodeCom.Text + "' ", con2);
            SqlDataReader dr2 = cmd2.ExecuteReader();
            while (dr2.Read())
            {
                textBoxNomComShow.Text = dr2.GetValue(1).ToString();
            }
            dr2.Close();
            con2.Close();
        }

        public void getDesignationDeTypeSession()
        {
            SqlConnection con3 = new SqlConnection(connectionString);
            con3.Open();
            SqlCommand cmd3 = new SqlCommand("select * from [Type session] where CodTypSes like '" + comboBoxNewCodeTypSes.Text + "' ", con3);
            SqlDataReader dr3 = cmd3.ExecuteReader();
            while (dr3.Read())
            {
                textBoxDesignationShow.Text = dr3.GetValue(1).ToString();
            }
            dr3.Close();
            con3.Close();
        }

        private void textBoxNewCodeSejour_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxNewLibelle_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxNewMontVers_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void AddNewSejourSauvegarder_Click(object sender, EventArgs e)
        {
            using (SqlConnection Con4 = new SqlConnection(connectionString))
            {
                if (textBoxNewLibelle.Text == "" || dateTimePickerNewDebut.Text == "" || dateTimePickerNewfin.Text == "" || textBoxNewMontVers.Text == "" || comboBoxNewCodeCom.Text == "" || comboBoxNewCodeTypSes.Text == "")
                    MessageBox.Show("Veuillez remplir tous les champs de saisie nécessaires", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                {
                    Con4.Open();
                    SqlCommand Cmd4 = new SqlCommand("AddSejour", Con4);
                    Cmd4.CommandType = CommandType.StoredProcedure;

                    Cmd4.Parameters.AddWithValue("@LibSejour", textBoxNewLibelle.Text.Trim());
                    Cmd4.Parameters.AddWithValue("@DatDebSejour", dateTimePickerNewDebut.Text.Trim());
                    Cmd4.Parameters.AddWithValue("@DatFinSejour", dateTimePickerNewfin.Text.Trim());
                    Cmd4.Parameters.AddWithValue("@MtVers", textBoxNewMontVers.Text.Trim());
                    Cmd4.Parameters.AddWithValue("@CodeCom", comboBoxNewCodeCom.Text.Trim());
                    Cmd4.Parameters.AddWithValue("@CodTypSes", comboBoxNewCodeTypSes.Text.Trim());


                    Cmd4.ExecuteNonQuery();
                    MessageBox.Show("Nouvelle séjour enregistrée avec succès", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();
                }
            }
        }

        public void Clear()
        {
            textBoxNewLibelle.Text = dateTimePickerNewDebut.Text = dateTimePickerNewfin.Text = textBoxNewMontVers.Text = comboBoxNewCodeCom.Text = comboBoxNewCodeTypSes.Text = textBoxNomComShow.Text = textBoxDesignationShow.Text = "";
        }

        private void comboBoxNewCodeCom_SelectedValueChanged(object sender, EventArgs e)
        {
            getNomCommune();
        }

        private void comboBoxNewCodeTypSes_SelectedValueChanged(object sender, EventArgs e)
        {
            getDesignationDeTypeSession();
        }
    }
}
