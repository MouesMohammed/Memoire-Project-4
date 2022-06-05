
namespace Memoire_Project_4
{
    partial class A_AyantDroitPrintForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(A_AyantDroitPrintForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ayantDroitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sonelgaz_data_baseDataSet2 = new Memoire_Project_4.sonelgaz_data_baseDataSet2();
            this.ayant_droitTableAdapter = new Memoire_Project_4.sonelgaz_data_baseDataSet2TableAdapters.Ayant_droitTableAdapter();
            this.buttonAyantDroitPrintConfirm = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.panelAyantDritPrint = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewAyaDroit = new System.Windows.Forms.DataGridView();
            this.codAyaDroitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenomAyaDroitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomAyaDroitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datNaisAyaDroitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numPasAyaDroitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datDelPasAyaDroitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matriculeAgentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ayantDroitBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sonelgaz_data_baseDataSet2)).BeginInit();
            this.panelAyantDritPrint.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAyaDroit)).BeginInit();
            this.SuspendLayout();
            // 
            // ayantDroitBindingSource
            // 
            this.ayantDroitBindingSource.DataMember = "Ayant droit";
            this.ayantDroitBindingSource.DataSource = this.sonelgaz_data_baseDataSet2;
            // 
            // sonelgaz_data_baseDataSet2
            // 
            this.sonelgaz_data_baseDataSet2.DataSetName = "sonelgaz_data_baseDataSet2";
            this.sonelgaz_data_baseDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ayant_droitTableAdapter
            // 
            this.ayant_droitTableAdapter.ClearBeforeFill = true;
            // 
            // buttonAyantDroitPrintConfirm
            // 
            this.buttonAyantDroitPrintConfirm.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonAyantDroitPrintConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(146)))), ((int)(((byte)(39)))));
            this.buttonAyantDroitPrintConfirm.FlatAppearance.BorderSize = 0;
            this.buttonAyantDroitPrintConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAyantDroitPrintConfirm.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAyantDroitPrintConfirm.Location = new System.Drawing.Point(359, 12);
            this.buttonAyantDroitPrintConfirm.Name = "buttonAyantDroitPrintConfirm";
            this.buttonAyantDroitPrintConfirm.Size = new System.Drawing.Size(113, 30);
            this.buttonAyantDroitPrintConfirm.TabIndex = 5;
            this.buttonAyantDroitPrintConfirm.Text = "Imprimer";
            this.buttonAyantDroitPrintConfirm.UseVisualStyleBackColor = false;
            this.buttonAyantDroitPrintConfirm.Click += new System.EventHandler(this.buttonAyantDroitPrint_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // panelAyantDritPrint
            // 
            this.panelAyantDritPrint.BackColor = System.Drawing.Color.White;
            this.panelAyantDritPrint.Controls.Add(this.label1);
            this.panelAyantDritPrint.Controls.Add(this.dataGridViewAyaDroit);
            this.panelAyantDritPrint.Location = new System.Drawing.Point(42, 62);
            this.panelAyantDritPrint.Name = "panelAyantDritPrint";
            this.panelAyantDritPrint.Size = new System.Drawing.Size(740, 747);
            this.panelAyantDritPrint.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft New Tai Lue", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(157, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(427, 46);
            this.label1.TabIndex = 3;
            this.label1.Text = "Liste théorique des agents";
            // 
            // dataGridViewAyaDroit
            // 
            this.dataGridViewAyaDroit.AllowUserToAddRows = false;
            this.dataGridViewAyaDroit.AllowUserToDeleteRows = false;
            this.dataGridViewAyaDroit.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewAyaDroit.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewAyaDroit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewAyaDroit.AutoGenerateColumns = false;
            this.dataGridViewAyaDroit.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAyaDroit.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewAyaDroit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAyaDroit.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewAyaDroit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAyaDroit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codAyaDroitDataGridViewTextBoxColumn,
            this.prenomAyaDroitDataGridViewTextBoxColumn,
            this.nomAyaDroitDataGridViewTextBoxColumn,
            this.datNaisAyaDroitDataGridViewTextBoxColumn,
            this.numPasAyaDroitDataGridViewTextBoxColumn,
            this.datDelPasAyaDroitDataGridViewTextBoxColumn,
            this.lienDataGridViewTextBoxColumn,
            this.matriculeAgentDataGridViewTextBoxColumn});
            this.dataGridViewAyaDroit.DataSource = this.ayantDroitBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(24)))), ((int)(((byte)(36)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewAyaDroit.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewAyaDroit.EnableHeadersVisualStyles = false;
            this.dataGridViewAyaDroit.Location = new System.Drawing.Point(21, 237);
            this.dataGridViewAyaDroit.Name = "dataGridViewAyaDroit";
            this.dataGridViewAyaDroit.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAyaDroit.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewAyaDroit.RowHeadersVisible = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewAyaDroit.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewAyaDroit.Size = new System.Drawing.Size(699, 477);
            this.dataGridViewAyaDroit.TabIndex = 2;
            // 
            // codAyaDroitDataGridViewTextBoxColumn
            // 
            this.codAyaDroitDataGridViewTextBoxColumn.DataPropertyName = "CodAyaDroit";
            this.codAyaDroitDataGridViewTextBoxColumn.HeaderText = "Code";
            this.codAyaDroitDataGridViewTextBoxColumn.Name = "codAyaDroitDataGridViewTextBoxColumn";
            this.codAyaDroitDataGridViewTextBoxColumn.ReadOnly = true;
            this.codAyaDroitDataGridViewTextBoxColumn.Visible = false;
            // 
            // prenomAyaDroitDataGridViewTextBoxColumn
            // 
            this.prenomAyaDroitDataGridViewTextBoxColumn.DataPropertyName = "PrenomAyaDroit";
            this.prenomAyaDroitDataGridViewTextBoxColumn.HeaderText = "Prénom";
            this.prenomAyaDroitDataGridViewTextBoxColumn.Name = "prenomAyaDroitDataGridViewTextBoxColumn";
            this.prenomAyaDroitDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomAyaDroitDataGridViewTextBoxColumn
            // 
            this.nomAyaDroitDataGridViewTextBoxColumn.DataPropertyName = "NomAyaDroit";
            this.nomAyaDroitDataGridViewTextBoxColumn.HeaderText = "Nom";
            this.nomAyaDroitDataGridViewTextBoxColumn.Name = "nomAyaDroitDataGridViewTextBoxColumn";
            this.nomAyaDroitDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datNaisAyaDroitDataGridViewTextBoxColumn
            // 
            this.datNaisAyaDroitDataGridViewTextBoxColumn.DataPropertyName = "DatNaisAyaDroit";
            this.datNaisAyaDroitDataGridViewTextBoxColumn.HeaderText = "Date naissance";
            this.datNaisAyaDroitDataGridViewTextBoxColumn.Name = "datNaisAyaDroitDataGridViewTextBoxColumn";
            this.datNaisAyaDroitDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numPasAyaDroitDataGridViewTextBoxColumn
            // 
            this.numPasAyaDroitDataGridViewTextBoxColumn.DataPropertyName = "NumPasAyaDroit";
            this.numPasAyaDroitDataGridViewTextBoxColumn.HeaderText = "Numéro passeport";
            this.numPasAyaDroitDataGridViewTextBoxColumn.Name = "numPasAyaDroitDataGridViewTextBoxColumn";
            this.numPasAyaDroitDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datDelPasAyaDroitDataGridViewTextBoxColumn
            // 
            this.datDelPasAyaDroitDataGridViewTextBoxColumn.DataPropertyName = "DatDelPasAyaDroit";
            this.datDelPasAyaDroitDataGridViewTextBoxColumn.HeaderText = "Date de délivrance";
            this.datDelPasAyaDroitDataGridViewTextBoxColumn.Name = "datDelPasAyaDroitDataGridViewTextBoxColumn";
            this.datDelPasAyaDroitDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lienDataGridViewTextBoxColumn
            // 
            this.lienDataGridViewTextBoxColumn.DataPropertyName = "Lien";
            this.lienDataGridViewTextBoxColumn.HeaderText = "Lien de parenté";
            this.lienDataGridViewTextBoxColumn.Name = "lienDataGridViewTextBoxColumn";
            this.lienDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // matriculeAgentDataGridViewTextBoxColumn
            // 
            this.matriculeAgentDataGridViewTextBoxColumn.DataPropertyName = "MatriculeAgent";
            this.matriculeAgentDataGridViewTextBoxColumn.HeaderText = "Matricule";
            this.matriculeAgentDataGridViewTextBoxColumn.Name = "matriculeAgentDataGridViewTextBoxColumn";
            this.matriculeAgentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // A_AyantDroitPrintForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(824, 861);
            this.Controls.Add(this.buttonAyantDroitPrintConfirm);
            this.Controls.Add(this.panelAyantDritPrint);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "A_AyantDroitPrintForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Imprimer la liste théorique";
            this.Load += new System.EventHandler(this.A_AyantDroitPrintForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ayantDroitBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sonelgaz_data_baseDataSet2)).EndInit();
            this.panelAyantDritPrint.ResumeLayout(false);
            this.panelAyantDritPrint.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAyaDroit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private sonelgaz_data_baseDataSet2 sonelgaz_data_baseDataSet2;
        private System.Windows.Forms.BindingSource ayantDroitBindingSource;
        private sonelgaz_data_baseDataSet2TableAdapters.Ayant_droitTableAdapter ayant_droitTableAdapter;
        private System.Windows.Forms.Button buttonAyantDroitPrintConfirm;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Panel panelAyantDritPrint;
        private System.Windows.Forms.DataGridView dataGridViewAyaDroit;
        private System.Windows.Forms.DataGridViewTextBoxColumn codAyaDroitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenomAyaDroitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomAyaDroitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datNaisAyaDroitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numPasAyaDroitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datDelPasAyaDroitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn matriculeAgentDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
    }
}