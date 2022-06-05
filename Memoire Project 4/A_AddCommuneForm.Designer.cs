
namespace Memoire_Project_4
{
    partial class A_AddCommuneForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(A_AddCommuneForm));
            this.panelNewEmployee = new System.Windows.Forms.Panel();
            this.comboBoxNewCodeWilaya = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNewNomCom = new System.Windows.Forms.TextBox();
            this.AddNewCommuneSauvegarder = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxShowNomWilaya = new System.Windows.Forms.TextBox();
            this.panelNewEmployee.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelNewEmployee
            // 
            this.panelNewEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(56)))));
            this.panelNewEmployee.Controls.Add(this.label2);
            this.panelNewEmployee.Controls.Add(this.textBoxShowNomWilaya);
            this.panelNewEmployee.Controls.Add(this.comboBoxNewCodeWilaya);
            this.panelNewEmployee.Controls.Add(this.label4);
            this.panelNewEmployee.Controls.Add(this.label1);
            this.panelNewEmployee.Controls.Add(this.textBoxNewNomCom);
            this.panelNewEmployee.Controls.Add(this.AddNewCommuneSauvegarder);
            this.panelNewEmployee.Location = new System.Drawing.Point(102, 99);
            this.panelNewEmployee.Name = "panelNewEmployee";
            this.panelNewEmployee.Size = new System.Drawing.Size(394, 468);
            this.panelNewEmployee.TabIndex = 42;
            // 
            // comboBoxNewCodeWilaya
            // 
            this.comboBoxNewCodeWilaya.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxNewCodeWilaya.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNewCodeWilaya.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxNewCodeWilaya.FormattingEnabled = true;
            this.comboBoxNewCodeWilaya.Location = new System.Drawing.Point(130, 177);
            this.comboBoxNewCodeWilaya.Name = "comboBoxNewCodeWilaya";
            this.comboBoxNewCodeWilaya.Size = new System.Drawing.Size(134, 23);
            this.comboBoxNewCodeWilaya.TabIndex = 82;
            this.comboBoxNewCodeWilaya.SelectedIndexChanged += new System.EventHandler(this.comboBoxNewCodeWilaya_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(56)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(128, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 15);
            this.label4.TabIndex = 81;
            this.label4.Text = "Code de la wilaya";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(56)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(128, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 15);
            this.label1.TabIndex = 80;
            this.label1.Text = "Nom de la commune";
            // 
            // textBoxNewNomCom
            // 
            this.textBoxNewNomCom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxNewNomCom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNewNomCom.Location = new System.Drawing.Point(132, 93);
            this.textBoxNewNomCom.MaxLength = 15;
            this.textBoxNewNomCom.Name = "textBoxNewNomCom";
            this.textBoxNewNomCom.Size = new System.Drawing.Size(134, 21);
            this.textBoxNewNomCom.TabIndex = 78;
            this.textBoxNewNomCom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNewNomCom_KeyPress);
            // 
            // AddNewCommuneSauvegarder
            // 
            this.AddNewCommuneSauvegarder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddNewCommuneSauvegarder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(146)))), ((int)(((byte)(39)))));
            this.AddNewCommuneSauvegarder.FlatAppearance.BorderSize = 0;
            this.AddNewCommuneSauvegarder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddNewCommuneSauvegarder.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddNewCommuneSauvegarder.Location = new System.Drawing.Point(149, 377);
            this.AddNewCommuneSauvegarder.Name = "AddNewCommuneSauvegarder";
            this.AddNewCommuneSauvegarder.Size = new System.Drawing.Size(97, 30);
            this.AddNewCommuneSauvegarder.TabIndex = 24;
            this.AddNewCommuneSauvegarder.Text = "Sauvegarder";
            this.AddNewCommuneSauvegarder.UseVisualStyleBackColor = false;
            this.AddNewCommuneSauvegarder.Click += new System.EventHandler(this.AddNewEmployeeSauvegarder_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(56)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(128, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 15);
            this.label2.TabIndex = 84;
            this.label2.Text = "Nom de la wilaya";
            // 
            // textBoxShowNomWilaya
            // 
            this.textBoxShowNomWilaya.Enabled = false;
            this.textBoxShowNomWilaya.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxShowNomWilaya.Location = new System.Drawing.Point(132, 257);
            this.textBoxShowNomWilaya.MaxLength = 15;
            this.textBoxShowNomWilaya.Name = "textBoxShowNomWilaya";
            this.textBoxShowNomWilaya.Size = new System.Drawing.Size(134, 21);
            this.textBoxShowNomWilaya.TabIndex = 83;
            // 
            // A_AddCommuneForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(24)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(599, 666);
            this.Controls.Add(this.panelNewEmployee);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "A_AddCommuneForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nouvelle commune";
            this.panelNewEmployee.ResumeLayout(false);
            this.panelNewEmployee.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelNewEmployee;
        private System.Windows.Forms.Button AddNewCommuneSauvegarder;
        private System.Windows.Forms.ComboBox comboBoxNewCodeWilaya;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNewNomCom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxShowNomWilaya;
    }
}