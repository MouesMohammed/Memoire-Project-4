
using System;
using System.Windows.Forms;

namespace Memoire_Project_4
{
    partial class NewEmployeeRegistrationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewEmployeeRegistrationForm));
            this.textBoxNewNomAgent = new System.Windows.Forms.TextBox();
            this.textBoxNewAdrAgent = new System.Windows.Forms.TextBox();
            this.textBoxNewUsername = new System.Windows.Forms.TextBox();
            this.textBoxNewPrenomAgent = new System.Windows.Forms.TextBox();
            this.textBoxNewTelAgent = new System.Windows.Forms.TextBox();
            this.textBoxNewNumPasAgent = new System.Windows.Forms.TextBox();
            this.textBoxNewPassword = new System.Windows.Forms.TextBox();
            this.Labelname = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxNewSitPrAgent = new System.Windows.Forms.TextBox();
            this.AddNewEmployeeSauvegarder = new System.Windows.Forms.Button();
            this.textBoxNewVilleAgent = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dateTimePickerNewDatDelPasAgent = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerNewDatNaisAgent = new System.Windows.Forms.DateTimePicker();
            this.textBoxNewPasswordConfirm = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.comboBoxNewUserType = new System.Windows.Forms.ComboBox();
            this.textBoxNewSitFamAgent = new System.Windows.Forms.TextBox();
            this.panelNewEmployee = new System.Windows.Forms.Panel();
            this.panelNewEmployee.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxNewNomAgent
            // 
            this.textBoxNewNomAgent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNewNomAgent.Location = new System.Drawing.Point(138, 90);
            this.textBoxNewNomAgent.MaxLength = 15;
            this.textBoxNewNomAgent.Name = "textBoxNewNomAgent";
            this.textBoxNewNomAgent.Size = new System.Drawing.Size(134, 21);
            this.textBoxNewNomAgent.TabIndex = 0;
            this.textBoxNewNomAgent.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNewNomAgent_KeyPress);
            // 
            // textBoxNewAdrAgent
            // 
            this.textBoxNewAdrAgent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNewAdrAgent.Location = new System.Drawing.Point(138, 200);
            this.textBoxNewAdrAgent.MaxLength = 50;
            this.textBoxNewAdrAgent.Name = "textBoxNewAdrAgent";
            this.textBoxNewAdrAgent.Size = new System.Drawing.Size(326, 21);
            this.textBoxNewAdrAgent.TabIndex = 3;
            this.textBoxNewAdrAgent.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNewAdrAgent_KeyPress);
            // 
            // textBoxNewUsername
            // 
            this.textBoxNewUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNewUsername.Location = new System.Drawing.Point(138, 420);
            this.textBoxNewUsername.MaxLength = 50;
            this.textBoxNewUsername.Name = "textBoxNewUsername";
            this.textBoxNewUsername.Size = new System.Drawing.Size(134, 21);
            this.textBoxNewUsername.TabIndex = 7;
            this.textBoxNewUsername.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            this.textBoxNewUsername.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNewUsername_KeyPress);
            // 
            // textBoxNewPrenomAgent
            // 
            this.textBoxNewPrenomAgent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNewPrenomAgent.Location = new System.Drawing.Point(330, 95);
            this.textBoxNewPrenomAgent.MaxLength = 15;
            this.textBoxNewPrenomAgent.Name = "textBoxNewPrenomAgent";
            this.textBoxNewPrenomAgent.Size = new System.Drawing.Size(134, 21);
            this.textBoxNewPrenomAgent.TabIndex = 9;
            this.textBoxNewPrenomAgent.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNewPrenomAgent_KeyPress);
            // 
            // textBoxNewTelAgent
            // 
            this.textBoxNewTelAgent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNewTelAgent.Location = new System.Drawing.Point(330, 255);
            this.textBoxNewTelAgent.MaxLength = 9;
            this.textBoxNewTelAgent.Name = "textBoxNewTelAgent";
            this.textBoxNewTelAgent.Size = new System.Drawing.Size(134, 21);
            this.textBoxNewTelAgent.TabIndex = 10;
            this.textBoxNewTelAgent.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNewTelAgent_KeyPress);
            // 
            // textBoxNewNumPasAgent
            // 
            this.textBoxNewNumPasAgent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNewNumPasAgent.Location = new System.Drawing.Point(138, 365);
            this.textBoxNewNumPasAgent.MaxLength = 7;
            this.textBoxNewNumPasAgent.Name = "textBoxNewNumPasAgent";
            this.textBoxNewNumPasAgent.Size = new System.Drawing.Size(134, 21);
            this.textBoxNewNumPasAgent.TabIndex = 12;
            this.textBoxNewNumPasAgent.TextChanged += new System.EventHandler(this.textBoxNewNumPasAgent_TextChanged);
            this.textBoxNewNumPasAgent.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNewNumPasAgent_KeyPress);
            // 
            // textBoxNewPassword
            // 
            this.textBoxNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNewPassword.Location = new System.Drawing.Point(138, 475);
            this.textBoxNewPassword.MaxLength = 50;
            this.textBoxNewPassword.Name = "textBoxNewPassword";
            this.textBoxNewPassword.PasswordChar = '*';
            this.textBoxNewPassword.Size = new System.Drawing.Size(134, 21);
            this.textBoxNewPassword.TabIndex = 15;
            this.textBoxNewPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNewPassword_KeyPress);
            // 
            // Labelname
            // 
            this.Labelname.AutoSize = true;
            this.Labelname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(56)))));
            this.Labelname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Labelname.ForeColor = System.Drawing.Color.White;
            this.Labelname.Location = new System.Drawing.Point(134, 67);
            this.Labelname.Name = "Labelname";
            this.Labelname.Size = new System.Drawing.Size(34, 15);
            this.Labelname.TabIndex = 16;
            this.Labelname.Text = "Nom";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(56)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(326, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 17;
            this.label1.Text = "Prenom";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(56)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(134, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 15);
            this.label2.TabIndex = 18;
            this.label2.Text = "Date de naissance";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(56)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(134, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 15);
            this.label3.TabIndex = 19;
            this.label3.Text = "Adresse";
            // 
            // textBoxNewSitPrAgent
            // 
            this.textBoxNewSitPrAgent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNewSitPrAgent.Location = new System.Drawing.Point(331, 310);
            this.textBoxNewSitPrAgent.MaxLength = 1;
            this.textBoxNewSitPrAgent.Name = "textBoxNewSitPrAgent";
            this.textBoxNewSitPrAgent.Size = new System.Drawing.Size(134, 21);
            this.textBoxNewSitPrAgent.TabIndex = 23;
            this.textBoxNewSitPrAgent.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNewSitPrAgent_KeyPress);
            // 
            // AddNewEmployeeSauvegarder
            // 
            this.AddNewEmployeeSauvegarder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(146)))), ((int)(((byte)(39)))));
            this.AddNewEmployeeSauvegarder.FlatAppearance.BorderSize = 0;
            this.AddNewEmployeeSauvegarder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddNewEmployeeSauvegarder.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddNewEmployeeSauvegarder.Location = new System.Drawing.Point(149, 548);
            this.AddNewEmployeeSauvegarder.Name = "AddNewEmployeeSauvegarder";
            this.AddNewEmployeeSauvegarder.Size = new System.Drawing.Size(97, 30);
            this.AddNewEmployeeSauvegarder.TabIndex = 24;
            this.AddNewEmployeeSauvegarder.Text = "Sauvegarder";
            this.AddNewEmployeeSauvegarder.UseVisualStyleBackColor = false;
            this.AddNewEmployeeSauvegarder.Click += new System.EventHandler(this.AddNewEmployeeSauvegarder_Click);
            // 
            // textBoxNewVilleAgent
            // 
            this.textBoxNewVilleAgent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNewVilleAgent.Location = new System.Drawing.Point(138, 255);
            this.textBoxNewVilleAgent.MaxLength = 20;
            this.textBoxNewVilleAgent.Name = "textBoxNewVilleAgent";
            this.textBoxNewVilleAgent.Size = new System.Drawing.Size(134, 21);
            this.textBoxNewVilleAgent.TabIndex = 25;
            this.textBoxNewVilleAgent.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNewVilleAgent_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(56)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(326, 342);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 15);
            this.label4.TabIndex = 26;
            this.label4.Text = "Date de délivrance";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(56)))));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(134, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 15);
            this.label5.TabIndex = 27;
            this.label5.Text = "Ville";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(56)))));
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(327, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 15);
            this.label6.TabIndex = 28;
            this.label6.Text = "Téléphone";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(56)))));
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(134, 287);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 15);
            this.label7.TabIndex = 29;
            this.label7.Text = "Situation familiale";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(56)))));
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(326, 287);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(142, 15);
            this.label8.TabIndex = 30;
            this.label8.Text = "Situation professionnelle";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(56)))));
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(134, 342);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 15);
            this.label9.TabIndex = 31;
            this.label9.Text = "Num passeport";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(56)))));
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(134, 397);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 15);
            this.label10.TabIndex = 32;
            this.label10.Text = "Nom d\'utilisateur";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(56)))));
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(134, 452);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 15);
            this.label11.TabIndex = 33;
            this.label11.Text = "Mot de passe";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(56)))));
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(134, 507);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 15);
            this.label12.TabIndex = 34;
            this.label12.Text = "UserType";
            // 
            // dateTimePickerNewDatDelPasAgent
            // 
            this.dateTimePickerNewDatDelPasAgent.CustomFormat = "yyyy-MM-dd";
            this.dateTimePickerNewDatDelPasAgent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerNewDatDelPasAgent.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerNewDatDelPasAgent.Location = new System.Drawing.Point(330, 365);
            this.dateTimePickerNewDatDelPasAgent.Name = "dateTimePickerNewDatDelPasAgent";
            this.dateTimePickerNewDatDelPasAgent.Size = new System.Drawing.Size(134, 21);
            this.dateTimePickerNewDatDelPasAgent.TabIndex = 35;
            // 
            // dateTimePickerNewDatNaisAgent
            // 
            this.dateTimePickerNewDatNaisAgent.CustomFormat = "yyyy-MM-dd";
            this.dateTimePickerNewDatNaisAgent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerNewDatNaisAgent.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerNewDatNaisAgent.Location = new System.Drawing.Point(138, 145);
            this.dateTimePickerNewDatNaisAgent.Name = "dateTimePickerNewDatNaisAgent";
            this.dateTimePickerNewDatNaisAgent.Size = new System.Drawing.Size(134, 21);
            this.dateTimePickerNewDatNaisAgent.TabIndex = 36;
            // 
            // textBoxNewPasswordConfirm
            // 
            this.textBoxNewPasswordConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNewPasswordConfirm.Location = new System.Drawing.Point(330, 475);
            this.textBoxNewPasswordConfirm.MaxLength = 50;
            this.textBoxNewPasswordConfirm.Name = "textBoxNewPasswordConfirm";
            this.textBoxNewPasswordConfirm.PasswordChar = '*';
            this.textBoxNewPasswordConfirm.Size = new System.Drawing.Size(133, 21);
            this.textBoxNewPasswordConfirm.TabIndex = 37;
            this.textBoxNewPasswordConfirm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNewPasswordConfirm_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(56)))));
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(326, 452);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(140, 15);
            this.label13.TabIndex = 38;
            this.label13.Text = "Confirmez mot de passe";
            // 
            // comboBoxNewUserType
            // 
            this.comboBoxNewUserType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNewUserType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxNewUserType.FormattingEnabled = true;
            this.comboBoxNewUserType.Items.AddRange(new object[] {
            "Employe",
            "Administrateur"});
            this.comboBoxNewUserType.Location = new System.Drawing.Point(138, 530);
            this.comboBoxNewUserType.Name = "comboBoxNewUserType";
            this.comboBoxNewUserType.Size = new System.Drawing.Size(134, 23);
            this.comboBoxNewUserType.TabIndex = 39;
            // 
            // textBoxNewSitFamAgent
            // 
            this.textBoxNewSitFamAgent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNewSitFamAgent.Location = new System.Drawing.Point(138, 310);
            this.textBoxNewSitFamAgent.MaxLength = 1;
            this.textBoxNewSitFamAgent.Name = "textBoxNewSitFamAgent";
            this.textBoxNewSitFamAgent.Size = new System.Drawing.Size(134, 21);
            this.textBoxNewSitFamAgent.TabIndex = 40;
            // 
            // panelNewEmployee
            // 
            this.panelNewEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(56)))));
            this.panelNewEmployee.Controls.Add(this.AddNewEmployeeSauvegarder);
            this.panelNewEmployee.Location = new System.Drawing.Point(102, 52);
            this.panelNewEmployee.Name = "panelNewEmployee";
            this.panelNewEmployee.Size = new System.Drawing.Size(394, 604);
            this.panelNewEmployee.TabIndex = 41;
            // 
            // NewEmployeeRegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(24)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(599, 708);
            this.Controls.Add(this.textBoxNewSitFamAgent);
            this.Controls.Add(this.comboBoxNewUserType);
            this.Controls.Add(this.textBoxNewPasswordConfirm);
            this.Controls.Add(this.dateTimePickerNewDatNaisAgent);
            this.Controls.Add(this.dateTimePickerNewDatDelPasAgent);
            this.Controls.Add(this.textBoxNewVilleAgent);
            this.Controls.Add(this.textBoxNewSitPrAgent);
            this.Controls.Add(this.textBoxNewPassword);
            this.Controls.Add(this.textBoxNewNumPasAgent);
            this.Controls.Add(this.textBoxNewTelAgent);
            this.Controls.Add(this.textBoxNewUsername);
            this.Controls.Add(this.textBoxNewAdrAgent);
            this.Controls.Add(this.textBoxNewNomAgent);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Labelname);
            this.Controls.Add(this.textBoxNewPrenomAgent);
            this.Controls.Add(this.panelNewEmployee);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NewEmployeeRegistrationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nouvel employé";
            this.panelNewEmployee.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNewNomAgent;
        private System.Windows.Forms.TextBox textBoxNewAdrAgent;
        private System.Windows.Forms.TextBox textBoxNewUsername;
        private System.Windows.Forms.TextBox textBoxNewPrenomAgent;
        private System.Windows.Forms.TextBox textBoxNewTelAgent;
        private System.Windows.Forms.TextBox textBoxNewNumPasAgent;
        private System.Windows.Forms.TextBox textBoxNewPassword;
        private System.Windows.Forms.Label Labelname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxNewSitPrAgent;
        private System.Windows.Forms.Button AddNewEmployeeSauvegarder;
        private System.Windows.Forms.TextBox textBoxNewVilleAgent;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dateTimePickerNewDatDelPasAgent;
        private System.Windows.Forms.DateTimePicker dateTimePickerNewDatNaisAgent;
        private System.Windows.Forms.TextBox textBoxNewPasswordConfirm;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox comboBoxNewUserType;
        private KeyEventHandler textBoxNewSitFamAgent_KeyDown;
        private TextBox textBoxNewSitFamAgent;
        private Panel panelNewEmployee;
    }
}