﻿using System;
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
    public partial class E_DownloadDeamande : Form
    {
        public E_DownloadDeamande()
        {
            InitializeComponent();

            axAcroPDF1.src = "C:/Users/Viper/Downloads/Demande_de_retenue_sur_salaire.pdf";
        }

        private void axAcroPDF1_Enter(object sender, EventArgs e)
        {

        }
    }
}