using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memoire_Project_4
{
    public partial class E_MesAyantsDroit : Form
    {
        public static E_MesAyantsDroit instance;
        public E_MesAyantsDroit()
        {
            InitializeComponent();

            instance = this;

            textBoxUserNameEntered3.Text = LoginForm.instance.tb1.Text.Trim();

            GetMatriculeAgent();
        }

        private void E_MesAyantsDroit_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sonelgaz_data_baseDataSet4.Ayant_droit' table. You can move, or remove it, as needed.
            this.ayant_droitTableAdapter.Fill(this.sonelgaz_data_baseDataSet4.Ayant_droit);

            try
            {
                using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString))
                {
                    if (cn.State == ConnectionState.Closed)
                        cn.Open();
                    using(SqlDataAdapter da = new SqlDataAdapter("select CodAyaDroit, PrenomAyaDroit, NomAyaDroit, DatNaisAyaDroit, NumPasAyaDroit, DatDelPasAyaDroit, Lien from [Ayant droit] where MatriculeAgent like '" + textBoxMatricleAgent3.Text + "'", cn))
                    {
                        DataTable dt = new DataTable("[Ayant droit]");
                        da.Fill(dt);
                        dataGridViewMesAyantsDroit.DataSource = dt;
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
            cmd2.Parameters.AddWithValue("Username", textBoxUserNameEntered3.Text);

            SqlDataReader reader2;
            reader2 = cmd2.ExecuteReader();
            if (reader2.Read())
            {
                textBoxMatricleAgent3.Text = reader2["MatriculeAgent"].ToString();
            }
            else
            {
                MessageBox.Show("Erreur impossible de trouver les données d'agent");
            }
            con2.Close();
        }

        private void dataGridViewMesAyantsDroit_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

    }
}
