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
    public partial class A_AyantDroitForm : Form
    {
        public A_AyantDroitForm()
        {
            InitializeComponent();
        }

        private void A_AyantDroitForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sonelgaz_data_baseDataSet2.Ayant_droit' table. You can move, or remove it, as needed.
            this.ayant_droitTableAdapter.Fill(this.sonelgaz_data_baseDataSet2.Ayant_droit);

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bitmap, 0, 0);
        }

        Bitmap bitmap;


        private void buttonAyantDroitPrint_Click(object sender, EventArgs e)
        {
            Panel panel = new Panel();
            this.Controls.Add(panel);

            Graphics graphics = panel.CreateGraphics();
            Size size = this.ClientSize;
            bitmap = new Bitmap(size.Width, size.Height, graphics);
            graphics = Graphics.FromImage(bitmap);


            Point point = PointToScreen(panel.Location);
            graphics.CopyFromScreen(point.X, point.Y, 0, 0, size);

            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void buttonPrintPreview_Click(object sender, EventArgs e)
        {
            A_AyantDroitPrintForm FRM = new A_AyantDroitPrintForm();
            FRM.Show();
        }

        private void buttonEmployeeSauvegarder_Click(object sender, EventArgs e)
        {
            ayantDroitBindingSource.EndEdit();
            ayant_droitTableAdapter.Update(sonelgaz_data_baseDataSet2.Ayant_droit);
        }

        private void buttonEmployeeSupprimer_Click(object sender, EventArgs e)
        {
            ayantDroitBindingSource.RemoveCurrent();
        }

        private void buttonAddAyantDroit_Click(object sender, EventArgs e)
        {
            A_AddAyantDroitForm FRM = new A_AddAyantDroitForm();
            FRM.Show();
        }
    }
}
