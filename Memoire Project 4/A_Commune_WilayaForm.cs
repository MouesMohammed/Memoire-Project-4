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
    public partial class A_Commune_WilayaForm : Form
    {
        string connectionString = @"Data Source=ORCHID\SQLEXPRESS;Initial Catalog=sonelgaz data base;Integrated Security=true;";

        public A_Commune_WilayaForm()
        {
            InitializeComponent();
        }

        private void A_Commune_WilayaForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sonelgaz_data_baseDataSet7.Wilaya' table. You can move, or remove it, as needed.
            this.wilayaTableAdapter.Fill(this.sonelgaz_data_baseDataSet7.Wilaya);
            // TODO: This line of code loads data into the 'sonelgaz_data_baseDataSet6.Commune' table. You can move, or remove it, as needed.
            this.communeTableAdapter.Fill(this.sonelgaz_data_baseDataSet6.Commune);

        }
        public void getNomWilaya()
        {
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Wilaya", con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBoxEditCodeWilaya.Items.Add(dr.GetValue(0).ToString());

            }
            dr.Close();
            con.Close();

        }
            private void panelEditEmployee_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBoxEditNomCom_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxEditCodeCom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxEditNomCom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
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

        private void buttonDeleteCom_Click(object sender, EventArgs e)
        {
            communeBindingSource.RemoveCurrent();
            MessageBox.Show("La ligne a été supprimée avec succès", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            wilayaBindingSource.RemoveCurrent();
            MessageBox.Show("La ligne a été supprimée avec succès", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonSaveCom_Click(object sender, EventArgs e)
        {
            communeBindingSource.EndEdit();
            communeTableAdapter.Update(sonelgaz_data_baseDataSet6);
            MessageBox.Show("Informations enregistrées avec succès", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            wilayaBindingSource.EndEdit();
            wilayaTableAdapter.Update(sonelgaz_data_baseDataSet7);
            MessageBox.Show("Informations enregistrées avec succès", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonAddCom_Click(object sender, EventArgs e)
        {
            A_AddCommuneForm FRM = new A_AddCommuneForm();
            FRM.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            A_AddWilayaForm FRM = new A_AddWilayaForm();
            FRM.Show();
        }

        private void textBoxEditCodeCom_TextChanged(object sender, EventArgs e)
        {
            getNomWilaya();
        }

        private void button4_Click(object sender, EventArgs e)
        {
        }

        private void comboBoxEditCodeWilaya_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
