using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memoire_Project_4
{
    public partial class A_InscriptionForm : Form
    {
        public A_InscriptionForm()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBoxEditSitPrAgent_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePickerEditDatNaisAgent_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxEditPrenomAgent_TextChanged(object sender, EventArgs e)
        {

        }

        private void A_InscriptionForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sonelgaz_data_baseDataSet3.Inscription' table. You can move, or remove it, as needed.
            this.inscriptionTableAdapter.Fill(this.sonelgaz_data_baseDataSet3.Inscription);

        }

        private void buttonSejourSauvegarder_Click(object sender, EventArgs e)
        {
            inscriptionBindingSource.EndEdit();
            inscriptionTableAdapter.Update(sonelgaz_data_baseDataSet3.Inscription);
            MessageBox.Show("Informations enregistrées avec succès");
        }

        private void buttonSejourSupprimer_Click(object sender, EventArgs e)
        {
            inscriptionBindingSource.RemoveCurrent();
            MessageBox.Show("La ligne a été supprimée avec succès");
        }

        private void dataGridViewInscriptions_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 10 & e.Value != null)
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
