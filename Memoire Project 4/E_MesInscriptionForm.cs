using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace Memoire_Project_4
{
    public partial class E_MesInscriptionForm : Form
    {
        public static E_MesInscriptionForm instance;
        public E_MesInscriptionForm()
        {
            InitializeComponent();

            instance = this;

            textBoxUserNameEntered4.Text = LoginForm.instance.tb1.Text.Trim();

            GetMatriculeAgent();
        }

        private void dataGridViewMesInscriptions_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void E_MesInscriptionForm_Load(object sender, EventArgs e)
        {   try
            {
                using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString))
                {
                    if (cn.State == ConnectionState.Closed)
                        cn.Open();
                    using (SqlDataAdapter da = new SqlDataAdapter("select NumInscription, DatInscription, NumBordVers, DatVers, DatDemRetSal, MtRet, NumAutSejour, DatAutSejour, CodSejour, Valide from [Inscription] where MatriculeAgent like '" + textBoxMatricleAgent4.Text + "'", cn))
                    {
                        DataTable dt = new DataTable("Inscription");
                        da.Fill(dt);
                        dataGridViewMesInscriptions.DataSource = dt;
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public void GetMatriculeAgent()
        {
            SqlConnection con2 = new SqlConnection(@"Data Source=ORCHID\SQLEXPRESS;Initial Catalog=sonelgaz data base;Integrated Security=true;");
            con2.Open();
            SqlCommand cmd2 = new SqlCommand("select MatriculeAgent from Agent where Username=@Username", con2);
            cmd2.Parameters.AddWithValue("Username", textBoxUserNameEntered4.Text);

            SqlDataReader reader2;
            reader2 = cmd2.ExecuteReader();
            if (reader2.Read())
            {
                textBoxMatricleAgent4.Text = reader2["MatriculeAgent"].ToString();
            }
            else
            {
                MessageBox.Show("Erreur impossible de trouver les données d'agent");
            }
            con2.Close();
        }

        private void dataGridViewMesInscriptions_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 9 & e.Value != null)
            {
                if (e.Value.Equals("Non validé"))
                {
                    e.CellStyle.BackColor = Color.FromArgb(255, 92, 51);
                    e.CellStyle.ForeColor = Color.White;
                }
                else
                {
                    e.CellStyle.BackColor = Color.FromArgb(51, 204, 51);
                    e.CellStyle.ForeColor = Color.White;
                }
            }
        }
    }
}
