
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Memoire_Project_4
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.Labelname = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.pictureBoxPassword = new System.Windows.Forms.PictureBox();
            this.pictureBoxName = new System.Windows.Forms.PictureBox();
            this.pictureBoxLogin = new System.Windows.Forms.PictureBox();
            this.checkBoxPassword = new System.Windows.Forms.CheckBox();
            this.panelLogin = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxName.Location = new System.Drawing.Point(216, 299);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(224, 25);
            this.textBoxName.TabIndex = 0;
            // 
            // Labelname
            // 
            this.Labelname.AutoSize = true;
            this.Labelname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(56)))));
            this.Labelname.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Labelname.ForeColor = System.Drawing.Color.White;
            this.Labelname.Location = new System.Drawing.Point(213, 270);
            this.Labelname.Name = "Labelname";
            this.Labelname.Size = new System.Drawing.Size(131, 21);
            this.Labelname.TabIndex = 2;
            this.Labelname.Text = "Nom d\'utilisateur";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(56)))));
            this.labelPassword.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.ForeColor = System.Drawing.Color.White;
            this.labelPassword.Location = new System.Drawing.Point(213, 342);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(102, 21);
            this.labelPassword.TabIndex = 5;
            this.labelPassword.Text = "Mot de passe";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.Location = new System.Drawing.Point(216, 371);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(224, 25);
            this.textBoxPassword.TabIndex = 1;
            this.textBoxPassword.UseSystemPasswordChar = true;
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(146)))), ((int)(((byte)(39)))));
            this.buttonLogin.FlatAppearance.BorderSize = 0;
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogin.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.Location = new System.Drawing.Point(297, 458);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(90, 30);
            this.buttonLogin.TabIndex = 2;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // pictureBoxPassword
            // 
            this.pictureBoxPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(56)))));
            this.pictureBoxPassword.Image = global::Memoire_Project_4.Properties.Resources.Password;
            this.pictureBoxPassword.Location = new System.Drawing.Point(446, 371);
            this.pictureBoxPassword.Name = "pictureBoxPassword";
            this.pictureBoxPassword.Size = new System.Drawing.Size(25, 25);
            this.pictureBoxPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPassword.TabIndex = 6;
            this.pictureBoxPassword.TabStop = false;
            // 
            // pictureBoxName
            // 
            this.pictureBoxName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(56)))));
            this.pictureBoxName.Image = global::Memoire_Project_4.Properties.Resources.Login2;
            this.pictureBoxName.Location = new System.Drawing.Point(446, 299);
            this.pictureBoxName.Name = "pictureBoxName";
            this.pictureBoxName.Size = new System.Drawing.Size(25, 25);
            this.pictureBoxName.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxName.TabIndex = 3;
            this.pictureBoxName.TabStop = false;
            // 
            // pictureBoxLogin
            // 
            this.pictureBoxLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(56)))));
            this.pictureBoxLogin.Image = global::Memoire_Project_4.Properties.Resources.Login;
            this.pictureBoxLogin.Location = new System.Drawing.Point(292, 128);
            this.pictureBoxLogin.Name = "pictureBoxLogin";
            this.pictureBoxLogin.Size = new System.Drawing.Size(100, 100);
            this.pictureBoxLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogin.TabIndex = 9;
            this.pictureBoxLogin.TabStop = false;
            // 
            // checkBoxPassword
            // 
            this.checkBoxPassword.AutoSize = true;
            this.checkBoxPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(56)))));
            this.checkBoxPassword.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxPassword.ForeColor = System.Drawing.Color.White;
            this.checkBoxPassword.Location = new System.Drawing.Point(258, 414);
            this.checkBoxPassword.Name = "checkBoxPassword";
            this.checkBoxPassword.Size = new System.Drawing.Size(169, 25);
            this.checkBoxPassword.TabIndex = 10;
            this.checkBoxPassword.Text = "Mot de passe visible";
            this.checkBoxPassword.UseVisualStyleBackColor = false;
            this.checkBoxPassword.CheckedChanged += new System.EventHandler(this.checkBoxPassword_CheckedChanged);
            // 
            // panelLogin
            // 
            this.panelLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(56)))));
            this.panelLogin.Location = new System.Drawing.Point(136, 96);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(412, 425);
            this.panelLogin.TabIndex = 11;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(24)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(684, 616);
            this.Controls.Add(this.checkBoxPassword);
            this.Controls.Add(this.pictureBoxLogin);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.pictureBoxPassword);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.pictureBoxName);
            this.Controls.Add(this.Labelname);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.panelLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoginForm_FormClosing);
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if(textBoxName.Text=="" || textBoxPassword.Text=="")
            {
                MessageBox.Show("Veuillez entrer un nom d'utilisateur et un mot de passe");
                return;
            }
            try
            {
                // Verifying the username and the password and getting the Usertype
                

                SqlConnection con = new SqlConnection(mycon);
                SqlDataAdapter sda = new SqlDataAdapter("Select UserType from agent where UserName like'"+textBoxName.Text+"' COLLATE SQL_LATIN1_GENERAL_CP1_CS_AS and Password like '"+textBoxPassword.Text+"' COLLATE SQL_LATIN1_GENERAL_CP1_CS_AS ", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                // Getting the Matricule 

                SqlConnection con2 = new SqlConnection(mycon);
                SqlDataAdapter sda2 = new SqlDataAdapter("Select MatriculeAgent from agent where UserName like'" + textBoxName.Text + "' COLLATE SQL_LATIN1_GENERAL_CP1_CS_AS and Password like '" + textBoxPassword.Text + "' COLLATE SQL_LATIN1_GENERAL_CP1_CS_AS ", con2);
                DataTable dt2 = new DataTable();
                sda2.Fill(dt2);


                if (dt.Rows.Count==1)
                {
                    ut = dt.Rows[0][0].ToString();

                    matriculeAgent = dt2.Rows[0][0].ToString();


                    if (ut== "Administrateur")
                    {
                        AdminForm FRM = new AdminForm();
                        FRM.Show();
                        this.Hide();
                    }
                    else if(ut== "Employe")
                    {
                        EmployeeForm FRM = new EmployeeForm();
                        FRM.Show();
                        this.Hide();
                    }
                }
                  else
                {
                    MessageBox.Show("Vérifier le nom d'utilisateur et le mot de passe");
                }

            }
            catch(Exception ex)
            {

            }

            //tb2.Text = matriculeAgent;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label Labelname;
        private System.Windows.Forms.PictureBox pictureBoxName;
        private System.Windows.Forms.PictureBox pictureBoxPassword;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.PictureBox pictureBoxLogin;
        private CheckBox checkBoxPassword;
        private Panel panelLogin;
    }
}

