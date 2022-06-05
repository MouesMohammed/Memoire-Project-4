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
    public partial class A_AddAyantDroitForm : Form
    {
        public static A_AddAyantDroitForm instance;
        string connectionString = @"Data Source=ORCHID\SQLEXPRESS;Initial Catalog=sonelgaz data base;Integrated Security=true;";


        public A_AddAyantDroitForm()
        {
            InitializeComponent();

            instance = this;
            textBoxUsernameHolder.Text = LoginForm.instance.tb1.Text.Trim();

            GetMatriculeAgent();
        }

        private void dateTimePickerEditDatNaisAD_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panelNewEmployee_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AddNewEmployeeSauvegarder_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                if (textBoxEditNomAD.Text == "" || textBoxEditPrenomAD.Text == "" || textBoxEditNumPasAD.Text == "")
                    MessageBox.Show("Veuillez remplir toutes les cases obligatoires");
                else
                {
                    sqlCon.Open();
                    SqlCommand sqlCmd = new SqlCommand("AddAyantDroit", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;


                    sqlCmd.Parameters.AddWithValue("@PrenomAyaDroit", textBoxEditPrenomAD.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@NomAyaDroit", textBoxEditNomAD.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@DatNaisAyaDroit", dateTimePickerEditDatNaisAD.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@NumPasAyaDroit", textBoxEditNumPasAD.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@DatDelPasAyaDroit", dateTimePickerEditDatDelPasAD.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Lien", comboBoxEditLien.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@MatriculeAgent", textBoxMatriculeAgentHolder.Text.Trim());


                    sqlCmd.ExecuteNonQuery();
                    MessageBox.Show("Nouvel employé enregistré");
                    Clear();
                }
            }
        }

        void Clear()
        {
            textBoxEditPrenomAD.Text = textBoxEditNomAD.Text = dateTimePickerEditDatNaisAD.Text = textBoxEditNumPasAD.Text = dateTimePickerEditDatDelPasAD.Text = comboBoxEditLien.Text = textBoxMatriculeAgentHolder.Text = "";
        }

        public void GetMatriculeAgent()
        {
            SqlConnection con2 = new SqlConnection(@"Data Source=ORCHID\SQLEXPRESS;Initial Catalog=sonelgaz data base;Integrated Security=true;");
            con2.Open();
            SqlCommand cmd2 = new SqlCommand("select MatriculeAgent from Agent where Username=@Username", con2);
            cmd2.Parameters.AddWithValue("Username", textBoxUsernameHolder.Text);

            SqlDataReader reader2;
            reader2 = cmd2.ExecuteReader();
            if (reader2.Read())
            {
                textBoxMatriculeAgentHolder.Text = reader2["MatriculeAgent"].ToString();
            }
            else
            {
                MessageBox.Show("Erreur impossible de trouver les données d'agent");
            }
            con2.Close();
        }
    }
}
