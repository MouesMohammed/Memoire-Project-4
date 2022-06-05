
namespace Memoire_Project_4
{
    partial class A_AddWilayaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(A_AddWilayaForm));
            this.panelNewEmployee = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNewNomWilaya = new System.Windows.Forms.TextBox();
            this.AddNewCommuneSauvegarder = new System.Windows.Forms.Button();
            this.panelNewEmployee.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelNewEmployee
            // 
            this.panelNewEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(56)))));
            this.panelNewEmployee.Controls.Add(this.label2);
            this.panelNewEmployee.Controls.Add(this.textBoxNewNomWilaya);
            this.panelNewEmployee.Controls.Add(this.AddNewCommuneSauvegarder);
            this.panelNewEmployee.Location = new System.Drawing.Point(102, 108);
            this.panelNewEmployee.Name = "panelNewEmployee";
            this.panelNewEmployee.Size = new System.Drawing.Size(394, 245);
            this.panelNewEmployee.TabIndex = 43;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(56)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(114, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 15);
            this.label2.TabIndex = 74;
            this.label2.Text = "Nom de la wilaya";
            // 
            // textBoxNewNomWilaya
            // 
            this.textBoxNewNomWilaya.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNewNomWilaya.Location = new System.Drawing.Point(116, 89);
            this.textBoxNewNomWilaya.MaxLength = 15;
            this.textBoxNewNomWilaya.Name = "textBoxNewNomWilaya";
            this.textBoxNewNomWilaya.Size = new System.Drawing.Size(162, 21);
            this.textBoxNewNomWilaya.TabIndex = 72;
            this.textBoxNewNomWilaya.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxEditNomWilaya_KeyPress);
            // 
            // AddNewCommuneSauvegarder
            // 
            this.AddNewCommuneSauvegarder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddNewCommuneSauvegarder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(146)))), ((int)(((byte)(39)))));
            this.AddNewCommuneSauvegarder.FlatAppearance.BorderSize = 0;
            this.AddNewCommuneSauvegarder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddNewCommuneSauvegarder.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddNewCommuneSauvegarder.Location = new System.Drawing.Point(149, 164);
            this.AddNewCommuneSauvegarder.Name = "AddNewCommuneSauvegarder";
            this.AddNewCommuneSauvegarder.Size = new System.Drawing.Size(97, 30);
            this.AddNewCommuneSauvegarder.TabIndex = 24;
            this.AddNewCommuneSauvegarder.Text = "Sauvegarder";
            this.AddNewCommuneSauvegarder.UseVisualStyleBackColor = false;
            this.AddNewCommuneSauvegarder.Click += new System.EventHandler(this.AddNewCommuneSauvegarder_Click);
            // 
            // A_AddWilayaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(24)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(599, 461);
            this.Controls.Add(this.panelNewEmployee);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "A_AddWilayaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nouvelle wilaya";
            this.panelNewEmployee.ResumeLayout(false);
            this.panelNewEmployee.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelNewEmployee;
        private System.Windows.Forms.Button AddNewCommuneSauvegarder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNewNomWilaya;
    }
}