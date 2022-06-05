using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace Memoire_Project_4
{
    public partial class E_SejoursForm : Form
    {
        WebClient wc = new WebClient();

        public E_SejoursForm()
        {
            InitializeComponent();
        }

        private void EmployeeSejoursListeForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sonelgaz_data_baseDataSet1.Sejour' table. You can move, or remove it, as needed.
            this.sejourTableAdapter.Fill(this.sonelgaz_data_baseDataSet1.Sejour);

        }

        private void Demande_Click(object sender, EventArgs e)
        {
            //wc.DownloadFileCompleted += new AsyncCompletedEventHandler(FileCompleted);
            Uri pdfURL = new Uri("https://drive.google.com/uc?export=download&id=1XQxg0fqhlnc-8PsEi9gm_RpSbphhlaoc");
            wc.DownloadFileAsync(pdfURL, "C:/Users/Viper/Downloads/Demande_de_retenue.pdf");
            MessageBox.Show("La demande de retenue a été téléchargé sur votre ordinateur");
        }
        private void FileCompleted(Object sender, AsyncCompletedEventArgs e)
        {
            MessageBox.Show("La demande de retenue a été téléchargé sur votre ordinateur");
        }

        private void buttonSignUpSejour_Click(object sender, EventArgs e)
        {
            E_SejourInscrireForm FRM = new E_SejourInscrireForm();
            FRM.Show();
        }
    }
}
