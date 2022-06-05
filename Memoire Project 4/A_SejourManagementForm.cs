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
    public partial class A_SejourManagementForm : Form
    {
        public A_SejourManagementForm()
        {
            InitializeComponent();
        }

        private void A_SejourManagementForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sonelgaz_data_baseDataSet5.Sejour' table. You can move, or remove it, as needed.
            this.sejourTableAdapter.Fill(this.sonelgaz_data_baseDataSet5.Sejour);

        }

        private void buttonEmployeeSupprimer_Click(object sender, EventArgs e)
        {
            sejourBindingSource.RemoveCurrent();
            MessageBox.Show("La ligne a été supprimée avec succès");
        }

        private void buttonEmployeeSauvegarder_Click(object sender, EventArgs e)
        {
            sejourBindingSource.EndEdit();
            sejourTableAdapter.Update(sonelgaz_data_baseDataSet5);
            MessageBox.Show("Informations enregistrées avec succès");
        }

        private void textBoxEditCodeSejour_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxEditLibelle_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxEditMontVers_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void buttonAddAyantDroit_Click(object sender, EventArgs e)
        {
            A_AddSejourForm FRM = new A_AddSejourForm();
            FRM.Show();
        }
    }
}
