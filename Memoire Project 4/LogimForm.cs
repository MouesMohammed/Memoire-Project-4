using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Memoire_Project_4
{
    public partial class LoginForm : Form
    {
        public static LoginForm instance;
        public TextBox tb1;

        //Working on the matricule agent
        public TextBox tb2;

        public LoginForm()
        {
            InitializeComponent();
            instance = this;
            tb1 = textBoxName;
        }
        static string mycon = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;
        public static string ut;
        public static string matriculeAgent;

        private void checkBoxPassword_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxPassword.Checked==true)
            {
                textBoxPassword.UseSystemPasswordChar = false;
            }
            else
            {
                textBoxPassword.UseSystemPasswordChar = true;
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
