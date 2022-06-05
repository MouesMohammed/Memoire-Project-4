
namespace Memoire_Project_4
{
    partial class E_SejourInscrireForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(E_SejourInscrireForm));
            this.panelSejourSignUp = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxUserNameEntered = new System.Windows.Forms.TextBox();
            this.comboBoxCodeSejour = new System.Windows.Forms.ComboBox();
            this.textBoxMatricule = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePickerDateInscription = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.Labelname = new System.Windows.Forms.Label();
            this.AddSejourSignUpConfirm = new System.Windows.Forms.Button();
            this.textBoxNumeroBordereau = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxMatriculeAganetCheck = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panelSejourSignUp.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSejourSignUp
            // 
            this.panelSejourSignUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(56)))));
            this.panelSejourSignUp.Controls.Add(this.label4);
            this.panelSejourSignUp.Controls.Add(this.textBoxUserNameEntered);
            this.panelSejourSignUp.Controls.Add(this.comboBoxCodeSejour);
            this.panelSejourSignUp.Controls.Add(this.textBoxMatricule);
            this.panelSejourSignUp.Controls.Add(this.label3);
            this.panelSejourSignUp.Controls.Add(this.dateTimePickerDateInscription);
            this.panelSejourSignUp.Controls.Add(this.label2);
            this.panelSejourSignUp.Controls.Add(this.Labelname);
            this.panelSejourSignUp.Controls.Add(this.AddSejourSignUpConfirm);
            this.panelSejourSignUp.Location = new System.Drawing.Point(98, 103);
            this.panelSejourSignUp.Name = "panelSejourSignUp";
            this.panelSejourSignUp.Size = new System.Drawing.Size(394, 449);
            this.panelSejourSignUp.TabIndex = 42;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(56)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(32, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 15);
            this.label4.TabIndex = 49;
            this.label4.Text = "Nom d\'utilisateur";
            // 
            // textBoxUserNameEntered
            // 
            this.textBoxUserNameEntered.Enabled = false;
            this.textBoxUserNameEntered.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUserNameEntered.Location = new System.Drawing.Point(36, 101);
            this.textBoxUserNameEntered.MaxLength = 15;
            this.textBoxUserNameEntered.Name = "textBoxUserNameEntered";
            this.textBoxUserNameEntered.Size = new System.Drawing.Size(134, 21);
            this.textBoxUserNameEntered.TabIndex = 47;
            this.textBoxUserNameEntered.TextChanged += new System.EventHandler(this.textBoxUserNameEntered_TextChanged);
            // 
            // comboBoxCodeSejour
            // 
            this.comboBoxCodeSejour.FormattingEnabled = true;
            this.comboBoxCodeSejour.Location = new System.Drawing.Point(35, 234);
            this.comboBoxCodeSejour.Name = "comboBoxCodeSejour";
            this.comboBoxCodeSejour.Size = new System.Drawing.Size(134, 21);
            this.comboBoxCodeSejour.TabIndex = 45;
            this.comboBoxCodeSejour.SelectedIndexChanged += new System.EventHandler(this.comboBoxCodeSejour_SelectedIndexChanged);
            // 
            // textBoxMatricule
            // 
            this.textBoxMatricule.Enabled = false;
            this.textBoxMatricule.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMatricule.Location = new System.Drawing.Point(229, 101);
            this.textBoxMatricule.MaxLength = 15;
            this.textBoxMatricule.Name = "textBoxMatricule";
            this.textBoxMatricule.Size = new System.Drawing.Size(134, 21);
            this.textBoxMatricule.TabIndex = 41;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(56)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(225, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 15);
            this.label3.TabIndex = 42;
            this.label3.Text = "Matricule d\'agent";
            // 
            // dateTimePickerDateInscription
            // 
            this.dateTimePickerDateInscription.CustomFormat = "yyyy-MM-dd";
            this.dateTimePickerDateInscription.Enabled = false;
            this.dateTimePickerDateInscription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerDateInscription.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDateInscription.Location = new System.Drawing.Point(228, 234);
            this.dateTimePickerDateInscription.Name = "dateTimePickerDateInscription";
            this.dateTimePickerDateInscription.Size = new System.Drawing.Size(134, 21);
            this.dateTimePickerDateInscription.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(56)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(224, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 15);
            this.label2.TabIndex = 37;
            this.label2.Text = "Date d’inscription ";
            // 
            // Labelname
            // 
            this.Labelname.AutoSize = true;
            this.Labelname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(56)))));
            this.Labelname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Labelname.ForeColor = System.Drawing.Color.White;
            this.Labelname.Location = new System.Drawing.Point(32, 211);
            this.Labelname.Name = "Labelname";
            this.Labelname.Size = new System.Drawing.Size(73, 15);
            this.Labelname.TabIndex = 27;
            this.Labelname.Text = "Code séjour";
            // 
            // AddSejourSignUpConfirm
            // 
            this.AddSejourSignUpConfirm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddSejourSignUpConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(146)))), ((int)(((byte)(39)))));
            this.AddSejourSignUpConfirm.FlatAppearance.BorderSize = 0;
            this.AddSejourSignUpConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddSejourSignUpConfirm.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddSejourSignUpConfirm.Location = new System.Drawing.Point(149, 346);
            this.AddSejourSignUpConfirm.Name = "AddSejourSignUpConfirm";
            this.AddSejourSignUpConfirm.Size = new System.Drawing.Size(97, 30);
            this.AddSejourSignUpConfirm.TabIndex = 24;
            this.AddSejourSignUpConfirm.Text = "Sauvegarder";
            this.AddSejourSignUpConfirm.UseVisualStyleBackColor = false;
            this.AddSejourSignUpConfirm.Click += new System.EventHandler(this.AddNewEmployeeSauvegarder_Click);
            // 
            // textBoxNumeroBordereau
            // 
            this.textBoxNumeroBordereau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNumeroBordereau.Location = new System.Drawing.Point(113, 608);
            this.textBoxNumeroBordereau.MaxLength = 15;
            this.textBoxNumeroBordereau.Name = "textBoxNumeroBordereau";
            this.textBoxNumeroBordereau.Size = new System.Drawing.Size(134, 21);
            this.textBoxNumeroBordereau.TabIndex = 39;
            this.textBoxNumeroBordereau.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(56)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(110, 572);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 30);
            this.label1.TabIndex = 40;
            this.label1.Text = "Numéro de bordereau\r\nde versement";
            this.label1.Visible = false;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxMatriculeAganetCheck
            // 
            this.textBoxMatriculeAganetCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMatriculeAganetCheck.Location = new System.Drawing.Point(326, 608);
            this.textBoxMatriculeAganetCheck.MaxLength = 15;
            this.textBoxMatriculeAganetCheck.Name = "textBoxMatriculeAganetCheck";
            this.textBoxMatriculeAganetCheck.Size = new System.Drawing.Size(134, 21);
            this.textBoxMatriculeAganetCheck.TabIndex = 43;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(56)))));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(323, 587);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 15);
            this.label5.TabIndex = 50;
            this.label5.Text = "Matricule agant from data base";
            // 
            // E_SejourInscrireForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(24)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(590, 655);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxMatriculeAganetCheck);
            this.Controls.Add(this.panelSejourSignUp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNumeroBordereau);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "E_SejourInscrireForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inscription aux séjour";
            this.Load += new System.EventHandler(this.SejourSignUpForm_Load);
            this.panelSejourSignUp.ResumeLayout(false);
            this.panelSejourSignUp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelSejourSignUp;
        private System.Windows.Forms.Button AddSejourSignUpConfirm;
        private System.Windows.Forms.Label Labelname;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateInscription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxMatricule;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxNumeroBordereau;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxCodeSejour;
        private System.Windows.Forms.TextBox textBoxUserNameEntered;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxMatriculeAganetCheck;
        private System.Windows.Forms.Label label5;
    }
}