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
    public partial class A_AyantDroitPrintForm : Form
    {
        public A_AyantDroitPrintForm()
        {
            InitializeComponent();
        }

        private void A_AyantDroitPrintForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sonelgaz_data_baseDataSet2.Ayant_droit' table. You can move, or remove it, as needed.
            this.ayant_droitTableAdapter.Fill(this.sonelgaz_data_baseDataSet2.Ayant_droit);


        }

        private async void buttonAyantDroitPrint_Click(object sender, EventArgs e)
        {
            buttonAyantDroitPrintConfirm.Visible = false;

            //await Task.Delay(1000);

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

            buttonAyantDroitPrintConfirm.Visible = true;
        }

        Bitmap bitmap;

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bitmap, 0, 0);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }
    }
}
