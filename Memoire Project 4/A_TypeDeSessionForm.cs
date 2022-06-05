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
    public partial class A_TypeDeSessionForm : Form
    {
        public A_TypeDeSessionForm()
        {
            InitializeComponent();
        }

        private void A_TypeDeSessionForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sonelgaz_data_baseDataSet8.Type_session' table. You can move, or remove it, as needed.
            this.type_sessionTableAdapter.Fill(this.sonelgaz_data_baseDataSet8.Type_session);

        }

        private void textBoxEditDesignation_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxEditCodeTypSes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void buttonEmployeeSupprimer_Click(object sender, EventArgs e)
        {
            typeSessionBindingSource.RemoveCurrent();
            MessageBox.Show("La ligne a été supprimée avec succès", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonEmployeeSauvegarder_Click(object sender, EventArgs e)
        {
            typeSessionBindingSource.EndEdit();
            type_sessionTableAdapter.Update(sonelgaz_data_baseDataSet8);
            MessageBox.Show("Informations enregistrées avec succès", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonAddAyantDroit_Click(object sender, EventArgs e)
        {
            A_AddTypeDeSessionForm FRM = new A_AddTypeDeSessionForm();
            FRM.Show();
        }
    }
}
