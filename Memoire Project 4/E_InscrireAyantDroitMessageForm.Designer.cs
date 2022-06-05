
namespace Memoire_Project_4
{
    partial class E_InscrireAyantDroitMessageForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(E_InscrireAyantDroitMessageForm));
            this.buttonNonContinuer2 = new System.Windows.Forms.Button();
            this.buttonOui2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonNonContinuer2
            // 
            this.buttonNonContinuer2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(193)))), ((int)(((byte)(125)))));
            this.buttonNonContinuer2.FlatAppearance.BorderSize = 0;
            this.buttonNonContinuer2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNonContinuer2.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNonContinuer2.Location = new System.Drawing.Point(295, 147);
            this.buttonNonContinuer2.Name = "buttonNonContinuer2";
            this.buttonNonContinuer2.Size = new System.Drawing.Size(123, 30);
            this.buttonNonContinuer2.TabIndex = 29;
            this.buttonNonContinuer2.Text = "Non, continuer";
            this.buttonNonContinuer2.UseVisualStyleBackColor = false;
            this.buttonNonContinuer2.Click += new System.EventHandler(this.buttonNonContinuer2_Click);
            // 
            // buttonOui2
            // 
            this.buttonOui2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(146)))), ((int)(((byte)(39)))));
            this.buttonOui2.FlatAppearance.BorderSize = 0;
            this.buttonOui2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOui2.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOui2.Location = new System.Drawing.Point(146, 147);
            this.buttonOui2.Name = "buttonOui2";
            this.buttonOui2.Size = new System.Drawing.Size(97, 30);
            this.buttonOui2.TabIndex = 28;
            this.buttonOui2.Text = "Oui";
            this.buttonOui2.UseVisualStyleBackColor = false;
            this.buttonOui2.Click += new System.EventHandler(this.buttonOui2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(75, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(415, 44);
            this.label1.TabIndex = 27;
            this.label1.Text = "L\'ayant droit a été inscrit avec succès, souhaitez-vous\r\ninscrire un autre ?\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // E_InscrireAyantDroitMessageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(564, 230);
            this.Controls.Add(this.buttonNonContinuer2);
            this.Controls.Add(this.buttonOui2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "E_InscrireAyantDroitMessageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ayant droit inscrit avec succès";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonNonContinuer2;
        private System.Windows.Forms.Button buttonOui2;
        private System.Windows.Forms.Label label1;
    }
}