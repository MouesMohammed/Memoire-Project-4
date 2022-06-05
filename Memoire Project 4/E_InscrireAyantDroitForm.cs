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
    public partial class E_InscrireAyantDroitForm : Form
    {
        string connectionString = (@"Data Source=ORCHID\SQLEXPRESS;Initial Catalog=sonelgaz data base;Integrated Security=true;");

        public static E_InscrireAyantDroitForm instance;

        public E_InscrireAyantDroitForm()
        {
            InitializeComponent();

            instance = this;

            textBoxtextBoxMatriculeAyantDroit.Text = E_SejourInscrireForm.instance.tbMatriculeAgent.Text.Trim();

            textBoxCodeSejour2.Text = E_SejourInscrireForm.instance.comboBoxCodeSejourTransfer.Text.Trim();

            //textBoxNumeroBordereau2.Text = E_SejourInscrireForm.instance.tbNumeroBordereau.Text.Trim();

            GetNumInscription();

        }

        static string mycon = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        public static string numInsc;


        public void cbCodeAyantDroit()
        {
            SqlConnection con = new SqlConnection(@"Data Source=ORCHID\SQLEXPRESS;Initial Catalog=sonelgaz data base;Integrated Security=true;");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from [Ayant droit] where MatriculeAgent like'" + textBoxtextBoxMatriculeAyantDroit.Text + "' COLLATE SQL_LATIN1_GENERAL_CP1_CS_AS", con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBoxCodeAyantDroit.Items.Add(dr.GetValue(0).ToString());

            }
            dr.Close();
            con.Close();
        }


        public void textBoxsAyantDroit()
        {
            SqlConnection con2 = new SqlConnection(@"Data Source=ORCHID\SQLEXPRESS;Initial Catalog=sonelgaz data base;Integrated Security=true;");
            con2.Open();
            SqlCommand cmd2 = new SqlCommand("select * from [Ayant droit] where MatriculeAgent like'" + textBoxtextBoxMatriculeAyantDroit.Text + "' COLLATE SQL_LATIN1_GENERAL_CP1_CS_AS and CodAyaDroit like '" + comboBoxCodeAyantDroit.Text + "' COLLATE SQL_LATIN1_GENERAL_CP1_CS_AS ", con2);
            SqlDataReader dr2 = cmd2.ExecuteReader();
            while (dr2.Read())
            {
                textBoxAyantDroitPrenom.Text = dr2.GetValue(1).ToString();
                textBoxAyantDroitNom.Text = dr2.GetValue(2).ToString();
                dateTimePickerAyantDroitDateNais.Text = dr2.GetValue(3).ToString();
                textBoxAyantDroitLien.Text = dr2.GetValue(6).ToString();
                textBoxAyantDroitNumPass.Text = dr2.GetValue(4).ToString();
                dateTimePickerAyantDroitPassDel.Text = dr2.GetValue(5).ToString();

            }
            dr2.Close();
            con2.Close();
        }


        private void panelSejourSignUp_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dateTimePickerDateInscription_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxCodeSejour_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddSejourSignUpConfirm_Click(object sender, EventArgs e)
        {
            //Ayant Droit Add

            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlCommand sqlCmd = new SqlCommand("ADDInscriptionAyantDroit", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;

                sqlCmd.Parameters.AddWithValue("@NumInscription", textBoxNumInscription2.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@CodAyaDroit", comboBoxCodeAyantDroit.Text.Trim());

                sqlCmd.ExecuteNonQuery();

            }

            Cleare();

            this.Hide();

            E_InscrireAyantDroitMessageForm FRM = new E_InscrireAyantDroitMessageForm();
            FRM.Show();
        }

        void Cleare()
        {
            comboBoxCodeAyantDroit.Text = textBoxAyantDroitPrenom.Text = textBoxAyantDroitNom.Text = textBoxAyantDroitLien.Text = textBoxAyantDroitNumPass.Text = textBoxtextBoxMatriculeAyantDroit.Text = textBoxCodeSejour2.Text = textBoxNumeroBordereau2.Text = textBoxNumInscription2.Text = dateTimePickerAyantDroitDateNais.Text = dateTimePickerAyantDroitPassDel.Text = "";
        }

        void GetNumInscription()
        {
            SqlConnection con = new SqlConnection(mycon);
            con.Open();

            //Old not working because the NumBordVer doesnt exist yet
            //string q = "Select NumInscription from Inscription where MatriculeAgent ='" + textBoxtextBoxMatriculeAyantDroit.Text + "' and CodSejour = '" + textBoxCodeSejour2.Text + "' and NumBordVers = '" + textBoxNumeroBordereau2.Text + "'";
            
            string q = "Select NumInscription from Inscription where MatriculeAgent ='" + textBoxtextBoxMatriculeAyantDroit.Text + "' and CodSejour = '" + textBoxCodeSejour2.Text + "'";
            SqlCommand cmd = new SqlCommand(q, con);
            SqlDataReader dr = cmd.ExecuteReader();

            while(dr.Read())
            {
                textBoxNumInscription2.Text = dr[0].ToString();
                
            }
            con.Close();
        }

        private void textBoxMatricule_TextChanged(object sender, EventArgs e)
        {

        }

        private void E_InscrireAyantDroitForm_Load(object sender, EventArgs e)
        {
            cbCodeAyantDroit();
        }

        private void comboBoxCodeAyantDroit_SelectedValueChanged(object sender, EventArgs e)
        {
            textBoxsAyantDroit();
        }

        private void comboBoxCodeAyantDroit_MouseHover(object sender, EventArgs e)
        {
        }

        private void comboBoxCodeAyantDroit_SelectionChangeCommitted(object sender, EventArgs e)
        {
            // Change with each new value selescted from the combo box
            //textBoxsAyantDroit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBoxtextBoxMatriculeAyantDroit_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
