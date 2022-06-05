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
    public partial class E_DownloadOrPrintMessageDemande : Form
    {
        public E_DownloadOrPrintMessageDemande()
        {
            InitializeComponent();
        }

        private void buttonImprimer_Click(object sender, EventArgs e)
        {
            this.Hide();

            E_DownloadDeamande adf = new E_DownloadDeamande();
            adf.Show();
        }
    }
}
