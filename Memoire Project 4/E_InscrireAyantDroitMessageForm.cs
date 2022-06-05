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
    public partial class E_InscrireAyantDroitMessageForm : Form
    {
        public E_InscrireAyantDroitMessageForm()
        {
            InitializeComponent();
        }

        private void buttonOui2_Click(object sender, EventArgs e)
        {
            this.Hide();

            E_InscrireAyantDroitForm adf = new E_InscrireAyantDroitForm();
            adf.Show();
        }

        private void buttonNonContinuer2_Click(object sender, EventArgs e)
        {
            this.Hide();

            E_DownloadOrPrintMessageDemande adf = new E_DownloadOrPrintMessageDemande();
            adf.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
