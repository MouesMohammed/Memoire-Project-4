
namespace Memoire_Project_4
{
    partial class E_DownloadOrPrintMessageDemande
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(E_DownloadOrPrintMessageDemande));
            this.buttonImprimer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonImprimer
            // 
            this.buttonImprimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(146)))), ((int)(((byte)(39)))));
            this.buttonImprimer.FlatAppearance.BorderSize = 0;
            this.buttonImprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonImprimer.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonImprimer.Location = new System.Drawing.Point(234, 147);
            this.buttonImprimer.Name = "buttonImprimer";
            this.buttonImprimer.Size = new System.Drawing.Size(97, 30);
            this.buttonImprimer.TabIndex = 31;
            this.buttonImprimer.Text = "Consulter";
            this.buttonImprimer.UseVisualStyleBackColor = false;
            this.buttonImprimer.Click += new System.EventHandler(this.buttonImprimer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(97, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(370, 44);
            this.label1.TabIndex = 30;
            this.label1.Text = "Votre demande de retenue sur salaire est prête\r\nà être imprimer/télécharger";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // E_DownloadOrPrintMessageDemande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(564, 230);
            this.Controls.Add(this.buttonImprimer);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "E_DownloadOrPrintMessageDemande";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "La demande de retenue sur salaire";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonImprimer;
        private System.Windows.Forms.Label label1;
    }
}