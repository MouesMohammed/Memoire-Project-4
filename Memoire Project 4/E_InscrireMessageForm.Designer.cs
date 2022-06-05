
namespace Memoire_Project_4
{
    partial class E_InscrireMessageForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(E_InscrireMessageForm));
            this.label1 = new System.Windows.Forms.Label();
            this.buttonOui = new System.Windows.Forms.Button();
            this.buttonNonContinuer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(93, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(379, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Votre inscription a réussi, vous souhaitez inscrire\r\nun ayant droit au séjour ?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonOui
            // 
            this.buttonOui.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(146)))), ((int)(((byte)(39)))));
            this.buttonOui.FlatAppearance.BorderSize = 0;
            this.buttonOui.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOui.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOui.Location = new System.Drawing.Point(146, 147);
            this.buttonOui.Name = "buttonOui";
            this.buttonOui.Size = new System.Drawing.Size(97, 30);
            this.buttonOui.TabIndex = 25;
            this.buttonOui.Text = "Oui";
            this.buttonOui.UseVisualStyleBackColor = false;
            this.buttonOui.Click += new System.EventHandler(this.buttonOui_Click);
            // 
            // buttonNonContinuer
            // 
            this.buttonNonContinuer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(193)))), ((int)(((byte)(125)))));
            this.buttonNonContinuer.FlatAppearance.BorderSize = 0;
            this.buttonNonContinuer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNonContinuer.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNonContinuer.Location = new System.Drawing.Point(295, 147);
            this.buttonNonContinuer.Name = "buttonNonContinuer";
            this.buttonNonContinuer.Size = new System.Drawing.Size(123, 30);
            this.buttonNonContinuer.TabIndex = 26;
            this.buttonNonContinuer.Text = "Non, continuer";
            this.buttonNonContinuer.UseVisualStyleBackColor = false;
            this.buttonNonContinuer.Click += new System.EventHandler(this.buttonNonContinuer_Click);
            // 
            // E_InscrireMessageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(564, 230);
            this.Controls.Add(this.buttonNonContinuer);
            this.Controls.Add(this.buttonOui);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "E_InscrireMessageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inscription réussie";
            this.Load += new System.EventHandler(this.InscrireAyantDroitAyantForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonOui;
        private System.Windows.Forms.Button buttonNonContinuer;
    }
}