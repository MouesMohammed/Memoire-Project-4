using System;
using System.Windows.Forms;

namespace Memoire_Project_4
{
    public partial class A_EmployeesManagementForm : Form
    {
        public A_EmployeesManagementForm()
        {
            InitializeComponent();
        }

        private void EmployeesManagementForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sonelgaz_data_baseDataSet.Agent' table. You can move, or remove it, as needed.
            this.agentTableAdapter.Fill(this.sonelgaz_data_baseDataSet.Agent);

        }

        private void buttonAddEmployee_Click(object sender, EventArgs e)
        {
            agentBindingSource.AddNew();
        }

        private void buttonSaveEmployee_Click(object sender, EventArgs e)
        {
            agentBindingSource.EndEdit();
            agentTableAdapter.Update(sonelgaz_data_baseDataSet.Agent);
        }

        private void AddNewEmployee_Click(object sender, EventArgs e)
        {
            NewEmployeeRegistrationForm FRM = new NewEmployeeRegistrationForm();
            FRM.Show();
        }

        private void EmployeeSauvegarder_Click(object sender, EventArgs e)
        {
            agentBindingSource.EndEdit();
            agentTableAdapter.Update(sonelgaz_data_baseDataSet);
            MessageBox.Show("Informations enregistrées avec succès");
        }

        private void buttonEmployeeSupprimer_Click(object sender, EventArgs e)
        {
            agentBindingSource.RemoveCurrent();
            MessageBox.Show("La ligne a été supprimée avec succès");
        }

        private void textBoxEditPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxEditNumPasAgent_TextChanged(object sender, EventArgs e)
        {

        }

        private void panelEditEmployee_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBoxEditPrenomAgent_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxEditNumPasAgent_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void comboBoxEditUserType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
