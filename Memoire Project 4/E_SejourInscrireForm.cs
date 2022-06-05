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
using System.Configuration;

namespace Memoire_Project_4
{
    public partial class E_SejourInscrireForm : Form
    {
        public static E_SejourInscrireForm instance;


        public TextBox tbMatriculeAgent;
        public TextBox tbNumeroBordereau;
        public ComboBox comboBoxCodeSejourTransfer;


        string connectionString = @"Data Source=ORCHID\SQLEXPRESS;Initial Catalog=sonelgaz data base;Integrated Security=true;";


        //Connection string for checking if the employee is already signed up for the sejour
        SqlConnection con3 = new SqlConnection(@"Data Source=ORCHID\SQLEXPRESS;Initial Catalog=sonelgaz data base;Integrated Security=true;");
        SqlCommand cmd3;
        SqlDataAdapter da3;
        DataTable dt3;
        DataSet ds3 = new DataSet();


        public E_SejourInscrireForm()
        {
            InitializeComponent();

            instance = this;

            textBoxUserNameEntered.Text = LoginForm.instance.tb1.Text.Trim();

            tbMatriculeAgent = textBoxMatricule;
            tbNumeroBordereau = textBoxNumeroBordereau;
            comboBoxCodeSejourTransfer = comboBoxCodeSejour;

            GetMatriculeAgent();

        }

        static string mycon = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        public void cbCodeSejour()
        {
            // For the Combobox

            SqlConnection con = new SqlConnection(@"Data Source=ORCHID\SQLEXPRESS;Initial Catalog=sonelgaz data base;Integrated Security=true;");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Sejour", con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBoxCodeSejour.Items.Add(dr.GetValue(0).ToString());
            }
            dr.Close();
            con.Close();
        }

        public void GetMatriculeAgent()
        {
            SqlConnection con2 = new SqlConnection(@"Data Source=ORCHID\SQLEXPRESS;Initial Catalog=sonelgaz data base;Integrated Security=true;");
            con2.Open();
            SqlCommand cmd2 = new SqlCommand("select MatriculeAgent from Agent where Username=@Username", con2);
            cmd2.Parameters.AddWithValue("Username", textBoxUserNameEntered.Text);

            SqlDataReader reader2;
            reader2 = cmd2.ExecuteReader();
            if (reader2.Read())
            {
                textBoxMatricule.Text = reader2["MatriculeAgent"].ToString();
            }
            else
            {
                MessageBox.Show("Erreur impossible de trouver les données d'agent");
            }


            con2.Close();
        }


        private void AddNewEmployeeSauvegarder_Click(object sender, EventArgs e)
        {
            //Test if the CodeSejour and the MatriculeAgent already used in the inscription

            cmd3 = new SqlCommand("SELECT * FROM Inscription WHERE CodSejour='"+ comboBoxCodeSejour.Text+ "' and MatriculeAgent='" + textBoxMatricule.Text + "' ", con3);
            SqlDataAdapter da3 = new SqlDataAdapter(cmd3);
            da3.Fill(ds3);
            int i = ds3.Tables[0].Rows.Count;


            if (i>0)
            {
                MessageBox.Show("Vous êtes déjà inscrit pour ce séjour: " + comboBoxCodeSejour.Text);
                ds3.Clear();
            }
            else
            {
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    // For filling the table

                    sqlCon.Open();
                    SqlCommand sqlCmd = new SqlCommand("Inscription2", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;

                    sqlCmd.Parameters.AddWithValue("@DatInscription", dateTimePickerDateInscription.Text.Trim());
                    //sqlCmd.Parameters.AddWithValue("@NumBordVers", textBoxNumeroBordereau.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@MatriculeAgent", textBoxMatricule.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@CodSejour", comboBoxCodeSejour.Text.Trim());

                    sqlCmd.ExecuteNonQuery();

                }

                //MessageBox.Show("Vous avez été inscrit au séjour avec succès");

                //Clear();

                this.Hide();

                E_InscrireMessageForm FRM = new E_InscrireMessageForm();
                FRM.Show();
            }

        }



        private void comboBoxMatricule_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SejourSignUpForm_Load(object sender, EventArgs e)
        {
            cbCodeSejour();
        }

        private void labelMatriculeAgent_Click(object sender, EventArgs e)
        {

        }

        private void textBoxUserNameEntered_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxCodeSejour_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
