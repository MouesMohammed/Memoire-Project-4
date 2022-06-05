
using System;
using System.Windows.Forms;

namespace Memoire_Project_4
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.panelAdminTop = new System.Windows.Forms.Panel();
            this.panelAdminCenter = new System.Windows.Forms.Panel();
            this.panelAdminLeft = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.panelAdminButtonIndicator = new System.Windows.Forms.Panel();
            this.panelTopLeft = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.labelAdminName = new System.Windows.Forms.Label();
            this.buttonEtatsRubrique = new System.Windows.Forms.Button();
            this.buttonExtraitsBancaire = new System.Windows.Forms.Button();
            this.buttonCommuneWilaya = new System.Windows.Forms.Button();
            this.buttonTypeSession = new System.Windows.Forms.Button();
            this.buttonTarifs = new System.Windows.Forms.Button();
            this.buttonInscription = new System.Windows.Forms.Button();
            this.buttonAyantDroit = new System.Windows.Forms.Button();
            this.buttonSejour = new System.Windows.Forms.Button();
            this.buttonEmployes = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelAdminLeft.SuspendLayout();
            this.panelTopLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelAdminTop
            // 
            this.panelAdminTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(56)))));
            this.panelAdminTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAdminTop.Location = new System.Drawing.Point(215, 0);
            this.panelAdminTop.Name = "panelAdminTop";
            this.panelAdminTop.Size = new System.Drawing.Size(944, 39);
            this.panelAdminTop.TabIndex = 3;
            // 
            // panelAdminCenter
            // 
            this.panelAdminCenter.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelAdminCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAdminCenter.Location = new System.Drawing.Point(215, 39);
            this.panelAdminCenter.Name = "panelAdminCenter";
            this.panelAdminCenter.Size = new System.Drawing.Size(944, 672);
            this.panelAdminCenter.TabIndex = 4;
            // 
            // panelAdminLeft
            // 
            this.panelAdminLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(56)))));
            this.panelAdminLeft.Controls.Add(this.panelAdminButtonIndicator);
            this.panelAdminLeft.Controls.Add(this.buttonEtatsRubrique);
            this.panelAdminLeft.Controls.Add(this.buttonExtraitsBancaire);
            this.panelAdminLeft.Controls.Add(this.buttonCommuneWilaya);
            this.panelAdminLeft.Controls.Add(this.buttonTypeSession);
            this.panelAdminLeft.Controls.Add(this.linkLabel1);
            this.panelAdminLeft.Controls.Add(this.buttonTarifs);
            this.panelAdminLeft.Controls.Add(this.buttonInscription);
            this.panelAdminLeft.Controls.Add(this.buttonAyantDroit);
            this.panelAdminLeft.Controls.Add(this.buttonSejour);
            this.panelAdminLeft.Controls.Add(this.buttonEmployes);
            this.panelAdminLeft.Controls.Add(this.panelTopLeft);
            this.panelAdminLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelAdminLeft.Location = new System.Drawing.Point(0, 0);
            this.panelAdminLeft.Name = "panelAdminLeft";
            this.panelAdminLeft.Size = new System.Drawing.Size(215, 711);
            this.panelAdminLeft.TabIndex = 2;
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(146)))), ((int)(((byte)(39)))));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9.75F);
            this.linkLabel1.LinkColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(58, 681);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(98, 17);
            this.linkLabel1.TabIndex = 10;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Se déconnecter";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // panelAdminButtonIndicator
            // 
            this.panelAdminButtonIndicator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(146)))), ((int)(((byte)(39)))));
            this.panelAdminButtonIndicator.Location = new System.Drawing.Point(0, 142);
            this.panelAdminButtonIndicator.Name = "panelAdminButtonIndicator";
            this.panelAdminButtonIndicator.Size = new System.Drawing.Size(6, 58);
            this.panelAdminButtonIndicator.TabIndex = 8;
            this.panelAdminButtonIndicator.Visible = false;
            // 
            // panelTopLeft
            // 
            this.panelTopLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(56)))));
            this.panelTopLeft.Controls.Add(this.label1);
            this.panelTopLeft.Controls.Add(this.labelAdminName);
            this.panelTopLeft.Controls.Add(this.pictureBox1);
            this.panelTopLeft.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopLeft.Location = new System.Drawing.Point(0, 0);
            this.panelTopLeft.Name = "panelTopLeft";
            this.panelTopLeft.Size = new System.Drawing.Size(215, 140);
            this.panelTopLeft.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(76, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "(Administrateur)";
            // 
            // labelAdminName
            // 
            this.labelAdminName.AutoSize = true;
            this.labelAdminName.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdminName.ForeColor = System.Drawing.Color.White;
            this.labelAdminName.Location = new System.Drawing.Point(77, 52);
            this.labelAdminName.Name = "labelAdminName";
            this.labelAdminName.Size = new System.Drawing.Size(71, 17);
            this.labelAdminName.TabIndex = 7;
            this.labelAdminName.Text = "UserName";
            // 
            // buttonEtatsRubrique
            // 
            this.buttonEtatsRubrique.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(56)))));
            this.buttonEtatsRubrique.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonEtatsRubrique.FlatAppearance.BorderSize = 0;
            this.buttonEtatsRubrique.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEtatsRubrique.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEtatsRubrique.ForeColor = System.Drawing.Color.White;
            this.buttonEtatsRubrique.Image = global::Memoire_Project_4.Properties.Resources.EtatRub;
            this.buttonEtatsRubrique.Location = new System.Drawing.Point(0, 432);
            this.buttonEtatsRubrique.Name = "buttonEtatsRubrique";
            this.buttonEtatsRubrique.Padding = new System.Windows.Forms.Padding(17, 0, 0, 0);
            this.buttonEtatsRubrique.Size = new System.Drawing.Size(215, 58);
            this.buttonEtatsRubrique.TabIndex = 4;
            this.buttonEtatsRubrique.Text = "  États rubrique";
            this.buttonEtatsRubrique.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonEtatsRubrique.UseVisualStyleBackColor = false;
            // 
            // buttonExtraitsBancaire
            // 
            this.buttonExtraitsBancaire.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(56)))));
            this.buttonExtraitsBancaire.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonExtraitsBancaire.FlatAppearance.BorderSize = 0;
            this.buttonExtraitsBancaire.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExtraitsBancaire.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExtraitsBancaire.ForeColor = System.Drawing.Color.White;
            this.buttonExtraitsBancaire.Image = global::Memoire_Project_4.Properties.Resources.Extrait;
            this.buttonExtraitsBancaire.Location = new System.Drawing.Point(0, 606);
            this.buttonExtraitsBancaire.Name = "buttonExtraitsBancaire";
            this.buttonExtraitsBancaire.Padding = new System.Windows.Forms.Padding(17, 0, 0, 0);
            this.buttonExtraitsBancaire.Size = new System.Drawing.Size(215, 58);
            this.buttonExtraitsBancaire.TabIndex = 13;
            this.buttonExtraitsBancaire.Text = "  Extraits bancaire";
            this.buttonExtraitsBancaire.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonExtraitsBancaire.UseVisualStyleBackColor = false;
            // 
            // buttonCommuneWilaya
            // 
            this.buttonCommuneWilaya.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(56)))));
            this.buttonCommuneWilaya.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonCommuneWilaya.FlatAppearance.BorderSize = 0;
            this.buttonCommuneWilaya.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCommuneWilaya.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCommuneWilaya.ForeColor = System.Drawing.Color.White;
            this.buttonCommuneWilaya.Image = global::Memoire_Project_4.Properties.Resources.Location;
            this.buttonCommuneWilaya.Location = new System.Drawing.Point(0, 548);
            this.buttonCommuneWilaya.Name = "buttonCommuneWilaya";
            this.buttonCommuneWilaya.Padding = new System.Windows.Forms.Padding(17, 0, 0, 0);
            this.buttonCommuneWilaya.Size = new System.Drawing.Size(215, 58);
            this.buttonCommuneWilaya.TabIndex = 12;
            this.buttonCommuneWilaya.Text = "  Communes/Wilayas";
            this.buttonCommuneWilaya.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonCommuneWilaya.UseVisualStyleBackColor = false;
            this.buttonCommuneWilaya.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // buttonTypeSession
            // 
            this.buttonTypeSession.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(56)))));
            this.buttonTypeSession.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonTypeSession.FlatAppearance.BorderSize = 0;
            this.buttonTypeSession.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTypeSession.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTypeSession.ForeColor = System.Drawing.Color.White;
            this.buttonTypeSession.Image = global::Memoire_Project_4.Properties.Resources.TypeDeSession;
            this.buttonTypeSession.Location = new System.Drawing.Point(0, 316);
            this.buttonTypeSession.Name = "buttonTypeSession";
            this.buttonTypeSession.Padding = new System.Windows.Forms.Padding(17, 0, 0, 0);
            this.buttonTypeSession.Size = new System.Drawing.Size(215, 58);
            this.buttonTypeSession.TabIndex = 11;
            this.buttonTypeSession.Text = "  Types de session";
            this.buttonTypeSession.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonTypeSession.UseVisualStyleBackColor = false;
            this.buttonTypeSession.Click += new System.EventHandler(this.buttonTypeSession_Click);
            // 
            // buttonTarifs
            // 
            this.buttonTarifs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(56)))));
            this.buttonTarifs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonTarifs.FlatAppearance.BorderSize = 0;
            this.buttonTarifs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTarifs.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTarifs.ForeColor = System.Drawing.Color.White;
            this.buttonTarifs.Image = global::Memoire_Project_4.Properties.Resources.Tarifs;
            this.buttonTarifs.Location = new System.Drawing.Point(0, 490);
            this.buttonTarifs.Name = "buttonTarifs";
            this.buttonTarifs.Padding = new System.Windows.Forms.Padding(17, 0, 0, 0);
            this.buttonTarifs.Size = new System.Drawing.Size(215, 58);
            this.buttonTarifs.TabIndex = 5;
            this.buttonTarifs.Text = "  Les tarifs";
            this.buttonTarifs.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonTarifs.UseVisualStyleBackColor = false;
            // 
            // buttonInscription
            // 
            this.buttonInscription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(56)))));
            this.buttonInscription.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonInscription.FlatAppearance.BorderSize = 0;
            this.buttonInscription.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInscription.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInscription.ForeColor = System.Drawing.Color.White;
            this.buttonInscription.Image = global::Memoire_Project_4.Properties.Resources.Inscription_3;
            this.buttonInscription.Location = new System.Drawing.Point(0, 374);
            this.buttonInscription.Name = "buttonInscription";
            this.buttonInscription.Padding = new System.Windows.Forms.Padding(17, 0, 0, 0);
            this.buttonInscription.Size = new System.Drawing.Size(215, 58);
            this.buttonInscription.TabIndex = 3;
            this.buttonInscription.Text = "  les inscriptions";
            this.buttonInscription.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonInscription.UseVisualStyleBackColor = false;
            this.buttonInscription.Click += new System.EventHandler(this.button5_Click);
            // 
            // buttonAyantDroit
            // 
            this.buttonAyantDroit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(56)))));
            this.buttonAyantDroit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonAyantDroit.FlatAppearance.BorderSize = 0;
            this.buttonAyantDroit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAyantDroit.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAyantDroit.ForeColor = System.Drawing.Color.White;
            this.buttonAyantDroit.Image = global::Memoire_Project_4.Properties.Resources._23;
            this.buttonAyantDroit.Location = new System.Drawing.Point(0, 200);
            this.buttonAyantDroit.Name = "buttonAyantDroit";
            this.buttonAyantDroit.Padding = new System.Windows.Forms.Padding(17, 0, 0, 0);
            this.buttonAyantDroit.Size = new System.Drawing.Size(215, 58);
            this.buttonAyantDroit.TabIndex = 2;
            this.buttonAyantDroit.Text = "  Les ayant droit";
            this.buttonAyantDroit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonAyantDroit.UseVisualStyleBackColor = false;
            this.buttonAyantDroit.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonSejour
            // 
            this.buttonSejour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(56)))));
            this.buttonSejour.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonSejour.FlatAppearance.BorderSize = 0;
            this.buttonSejour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSejour.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSejour.ForeColor = System.Drawing.Color.White;
            this.buttonSejour.Image = global::Memoire_Project_4.Properties.Resources.Sejour_2_23;
            this.buttonSejour.Location = new System.Drawing.Point(0, 258);
            this.buttonSejour.Name = "buttonSejour";
            this.buttonSejour.Padding = new System.Windows.Forms.Padding(17, 0, 0, 0);
            this.buttonSejour.Size = new System.Drawing.Size(215, 58);
            this.buttonSejour.TabIndex = 1;
            this.buttonSejour.Text = "  les séjour";
            this.buttonSejour.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSejour.UseVisualStyleBackColor = false;
            this.buttonSejour.Click += new System.EventHandler(this.buttonSejour_Click);
            // 
            // buttonEmployes
            // 
            this.buttonEmployes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(56)))));
            this.buttonEmployes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonEmployes.FlatAppearance.BorderSize = 0;
            this.buttonEmployes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEmployes.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEmployes.ForeColor = System.Drawing.Color.White;
            this.buttonEmployes.Image = global::Memoire_Project_4.Properties.Resources.Agent1;
            this.buttonEmployes.Location = new System.Drawing.Point(0, 142);
            this.buttonEmployes.Name = "buttonEmployes";
            this.buttonEmployes.Padding = new System.Windows.Forms.Padding(17, 0, 0, 0);
            this.buttonEmployes.Size = new System.Drawing.Size(215, 58);
            this.buttonEmployes.TabIndex = 0;
            this.buttonEmployes.Text = "  les agent";
            this.buttonEmployes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonEmployes.UseVisualStyleBackColor = false;
            this.buttonEmployes.Click += new System.EventHandler(this.buttonEmployes_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Memoire_Project_4.Properties.Resources.Login1;
            this.pictureBox1.Location = new System.Drawing.Point(26, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1159, 711);
            this.Controls.Add(this.panelAdminCenter);
            this.Controls.Add(this.panelAdminTop);
            this.Controls.Add(this.panelAdminLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SONELGAZ - Gestion des séjours";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminForm_FormClosing);
            this.panelAdminLeft.ResumeLayout(false);
            this.panelAdminLeft.PerformLayout();
            this.panelTopLeft.ResumeLayout(false);
            this.panelTopLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelAdminTop;
        private System.Windows.Forms.Panel panelAdminCenter;
        private System.Windows.Forms.Button buttonEmployes;
        private System.Windows.Forms.Panel panelAdminLeft;
        private System.Windows.Forms.Button buttonTarifs;
        private System.Windows.Forms.Button buttonEtatsRubrique;
        private System.Windows.Forms.Button buttonInscription;
        private System.Windows.Forms.Button buttonAyantDroit;
        private System.Windows.Forms.Button buttonSejour;
        private System.Windows.Forms.PictureBox pictureBox1;
        private PaintEventHandler panelAdminLeft_Paint;
        private Panel panelTopLeft;
        private Label labelAdminName;
        private Panel panelAdminButtonIndicator;
        private Label label1;
        private LinkLabel linkLabel1;
        private Button buttonExtraitsBancaire;
        private Button buttonCommuneWilaya;
        private Button buttonTypeSession;
    }
}