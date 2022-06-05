
namespace Memoire_Project_4
{
    partial class A_AyantDroitForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle56 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle57 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle58 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle59 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle60 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(A_AyantDroitForm));
            this.dataGridViewAyaDroit = new System.Windows.Forms.DataGridView();
            this.codAyaDroitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenomAyaDroitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomAyaDroitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datNaisAyaDroitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numPasAyaDroitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datDelPasAyaDroitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matriculeAgentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ayantDroitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sonelgaz_data_baseDataSet2 = new Memoire_Project_4.sonelgaz_data_baseDataSet2();
            this.ayant_droitTableAdapter = new Memoire_Project_4.sonelgaz_data_baseDataSet2TableAdapters.Ayant_droitTableAdapter();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.buttonPrintPreview = new System.Windows.Forms.Button();
            this.panelEditEmployee = new System.Windows.Forms.Panel();
            this.guna2VSeparator1 = new Guna.UI2.WinForms.Guna2VSeparator();
            this.buttonEmployeeSupprimer = new System.Windows.Forms.Button();
            this.comboBoxEditLien = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dateTimePickerEditDatDelPasAD = new System.Windows.Forms.DateTimePicker();
            this.textBoxEditNumPasAD = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePickerEditDatNaisAD = new System.Windows.Forms.DateTimePicker();
            this.textBoxEditNomAD = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Labelname = new System.Windows.Forms.Label();
            this.textBoxEditPrenomAD = new System.Windows.Forms.TextBox();
            this.buttonEmployeeSauvegarder = new System.Windows.Forms.Button();
            this.buttonAddAyantDroit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAyaDroit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ayantDroitBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sonelgaz_data_baseDataSet2)).BeginInit();
            this.panelEditEmployee.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewAyaDroit
            // 
            this.dataGridViewAyaDroit.AllowUserToAddRows = false;
            this.dataGridViewAyaDroit.AllowUserToDeleteRows = false;
            this.dataGridViewAyaDroit.AllowUserToResizeRows = false;
            dataGridViewCellStyle56.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewAyaDroit.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle56;
            this.dataGridViewAyaDroit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewAyaDroit.AutoGenerateColumns = false;
            this.dataGridViewAyaDroit.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAyaDroit.BackgroundColor = System.Drawing.Color.Silver;
            this.dataGridViewAyaDroit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle57.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle57.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(68)))), ((int)(((byte)(120)))));
            dataGridViewCellStyle57.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle57.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle57.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(34)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle57.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle57.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAyaDroit.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle57;
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
            dataGridViewCellStyle58.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle58.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(24)))), ((int)(((byte)(36)))));
            dataGridViewCellStyle58.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle58.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle58.SelectionBackColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle58.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle58.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewAyaDroit.DefaultCellStyle = dataGridViewCellStyle58;
            this.dataGridViewAyaDroit.EnableHeadersVisualStyles = false;
            this.dataGridViewAyaDroit.Location = new System.Drawing.Point(27, 57);
            this.dataGridViewAyaDroit.Name = "dataGridViewAyaDroit";
            this.dataGridViewAyaDroit.ReadOnly = true;
            dataGridViewCellStyle59.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle59.BackColor = System.Drawing.SystemColors.AppWorkspace;
            dataGridViewCellStyle59.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle59.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle59.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle59.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle59.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAyaDroit.RowHeadersDefaultCellStyle = dataGridViewCellStyle59;
            this.dataGridViewAyaDroit.RowHeadersVisible = false;
            dataGridViewCellStyle60.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle60.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle60.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle60.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle60.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle60.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewAyaDroit.RowsDefaultCellStyle = dataGridViewCellStyle60;
            this.dataGridViewAyaDroit.Size = new System.Drawing.Size(891, 340);
            this.dataGridViewAyaDroit.TabIndex = 1;
            // 
            // codAyaDroitDataGridViewTextBoxColumn
            // 
            this.codAyaDroitDataGridViewTextBoxColumn.DataPropertyName = "CodAyaDroit";
            this.codAyaDroitDataGridViewTextBoxColumn.HeaderText = "Code";
            this.codAyaDroitDataGridViewTextBoxColumn.Name = "codAyaDroitDataGridViewTextBoxColumn";
            this.codAyaDroitDataGridViewTextBoxColumn.ReadOnly = true;
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
            this.matriculeAgentDataGridViewTextBoxColumn.HeaderText = "Matricule de l’agent";
            this.matriculeAgentDataGridViewTextBoxColumn.Name = "matriculeAgentDataGridViewTextBoxColumn";
            this.matriculeAgentDataGridViewTextBoxColumn.ReadOnly = true;
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
            // buttonPrintPreview
            // 
            this.buttonPrintPreview.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPrintPreview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(146)))), ((int)(((byte)(39)))));
            this.buttonPrintPreview.FlatAppearance.BorderSize = 0;
            this.buttonPrintPreview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPrintPreview.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPrintPreview.Location = new System.Drawing.Point(26, 12);
            this.buttonPrintPreview.Name = "buttonPrintPreview";
            this.buttonPrintPreview.Size = new System.Drawing.Size(113, 30);
            this.buttonPrintPreview.TabIndex = 5;
            this.buttonPrintPreview.Text = "Imprimer";
            this.buttonPrintPreview.UseVisualStyleBackColor = false;
            this.buttonPrintPreview.Click += new System.EventHandler(this.buttonPrintPreview_Click);
            // 
            // panelEditEmployee
            // 
            this.panelEditEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelEditEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(56)))));
            this.panelEditEmployee.Controls.Add(this.buttonAddAyantDroit);
            this.panelEditEmployee.Controls.Add(this.guna2VSeparator1);
            this.panelEditEmployee.Controls.Add(this.buttonEmployeeSupprimer);
            this.panelEditEmployee.Controls.Add(this.comboBoxEditLien);
            this.panelEditEmployee.Controls.Add(this.label12);
            this.panelEditEmployee.Controls.Add(this.dateTimePickerEditDatDelPasAD);
            this.panelEditEmployee.Controls.Add(this.textBoxEditNumPasAD);
            this.panelEditEmployee.Controls.Add(this.label9);
            this.panelEditEmployee.Controls.Add(this.label4);
            this.panelEditEmployee.Controls.Add(this.dateTimePickerEditDatNaisAD);
            this.panelEditEmployee.Controls.Add(this.textBoxEditNomAD);
            this.panelEditEmployee.Controls.Add(this.label2);
            this.panelEditEmployee.Controls.Add(this.label1);
            this.panelEditEmployee.Controls.Add(this.Labelname);
            this.panelEditEmployee.Controls.Add(this.textBoxEditPrenomAD);
            this.panelEditEmployee.Controls.Add(this.buttonEmployeeSauvegarder);
            this.panelEditEmployee.Location = new System.Drawing.Point(26, 422);
            this.panelEditEmployee.Name = "panelEditEmployee";
            this.panelEditEmployee.Size = new System.Drawing.Size(891, 227);
            this.panelEditEmployee.TabIndex = 44;
            // 
            // guna2VSeparator1
            // 
            this.guna2VSeparator1.Location = new System.Drawing.Point(365, 26);
            this.guna2VSeparator1.Name = "guna2VSeparator1";
            this.guna2VSeparator1.Size = new System.Drawing.Size(10, 187);
            this.guna2VSeparator1.TabIndex = 58;
            // 
            // buttonEmployeeSupprimer
            // 
            this.buttonEmployeeSupprimer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEmployeeSupprimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(193)))), ((int)(((byte)(125)))));
            this.buttonEmployeeSupprimer.FlatAppearance.BorderSize = 0;
            this.buttonEmployeeSupprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEmployeeSupprimer.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEmployeeSupprimer.Location = new System.Drawing.Point(767, 98);
            this.buttonEmployeeSupprimer.Name = "buttonEmployeeSupprimer";
            this.buttonEmployeeSupprimer.Size = new System.Drawing.Size(107, 30);
            this.buttonEmployeeSupprimer.TabIndex = 57;
            this.buttonEmployeeSupprimer.Text = "Supprimer";
            this.buttonEmployeeSupprimer.UseVisualStyleBackColor = false;
            this.buttonEmployeeSupprimer.Click += new System.EventHandler(this.buttonEmployeeSupprimer_Click);
            // 
            // comboBoxEditLien
            // 
            this.comboBoxEditLien.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ayantDroitBindingSource, "Lien", true));
            this.comboBoxEditLien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEditLien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxEditLien.FormattingEnabled = true;
            this.comboBoxEditLien.Items.AddRange(new object[] {
            "P",
            "M",
            "C"});
            this.comboBoxEditLien.Location = new System.Drawing.Point(419, 158);
            this.comboBoxEditLien.Name = "comboBoxEditLien";
            this.comboBoxEditLien.Size = new System.Drawing.Size(134, 23);
            this.comboBoxEditLien.TabIndex = 56;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(56)))));
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(415, 135);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(31, 15);
            this.label12.TabIndex = 55;
            this.label12.Text = "Lien";
            // 
            // dateTimePickerEditDatDelPasAD
            // 
            this.dateTimePickerEditDatDelPasAD.CustomFormat = "yyyy-MM-dd";
            this.dateTimePickerEditDatDelPasAD.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ayantDroitBindingSource, "DatDelPasAyaDroit", true));
            this.dateTimePickerEditDatDelPasAD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerEditDatDelPasAD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerEditDatDelPasAD.Location = new System.Drawing.Point(583, 68);
            this.dateTimePickerEditDatDelPasAD.Name = "dateTimePickerEditDatDelPasAD";
            this.dateTimePickerEditDatDelPasAD.Size = new System.Drawing.Size(134, 21);
            this.dateTimePickerEditDatDelPasAD.TabIndex = 50;
            // 
            // textBoxEditNumPasAD
            // 
            this.textBoxEditNumPasAD.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ayantDroitBindingSource, "NumPasAyaDroit", true));
            this.textBoxEditNumPasAD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEditNumPasAD.Location = new System.Drawing.Point(419, 68);
            this.textBoxEditNumPasAD.MaxLength = 7;
            this.textBoxEditNumPasAD.Name = "textBoxEditNumPasAD";
            this.textBoxEditNumPasAD.Size = new System.Drawing.Size(134, 21);
            this.textBoxEditNumPasAD.TabIndex = 47;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(56)))));
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(416, 45);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 15);
            this.label9.TabIndex = 49;
            this.label9.Text = "Num passeport";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(56)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(579, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 15);
            this.label4.TabIndex = 48;
            this.label4.Text = "Date de délivrance";
            // 
            // dateTimePickerEditDatNaisAD
            // 
            this.dateTimePickerEditDatNaisAD.CustomFormat = "yyyy-MM-dd";
            this.dateTimePickerEditDatNaisAD.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ayantDroitBindingSource, "DatNaisAyaDroit", true));
            this.dateTimePickerEditDatNaisAD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerEditDatNaisAD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerEditDatNaisAD.Location = new System.Drawing.Point(28, 156);
            this.dateTimePickerEditDatNaisAD.Name = "dateTimePickerEditDatNaisAD";
            this.dateTimePickerEditDatNaisAD.Size = new System.Drawing.Size(134, 21);
            this.dateTimePickerEditDatNaisAD.TabIndex = 44;
            // 
            // textBoxEditNomAD
            // 
            this.textBoxEditNomAD.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ayantDroitBindingSource, "NomAyaDroit", true));
            this.textBoxEditNomAD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEditNomAD.Location = new System.Drawing.Point(27, 68);
            this.textBoxEditNomAD.MaxLength = 15;
            this.textBoxEditNomAD.Name = "textBoxEditNomAD";
            this.textBoxEditNomAD.Size = new System.Drawing.Size(134, 21);
            this.textBoxEditNomAD.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(56)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(24, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 15);
            this.label2.TabIndex = 43;
            this.label2.Text = "Date de naissance";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(56)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(183, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 28;
            this.label1.Text = "Prenom";
            // 
            // Labelname
            // 
            this.Labelname.AutoSize = true;
            this.Labelname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(56)))));
            this.Labelname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Labelname.ForeColor = System.Drawing.Color.White;
            this.Labelname.Location = new System.Drawing.Point(23, 45);
            this.Labelname.Name = "Labelname";
            this.Labelname.Size = new System.Drawing.Size(34, 15);
            this.Labelname.TabIndex = 27;
            this.Labelname.Text = "Nom";
            // 
            // textBoxEditPrenomAD
            // 
            this.textBoxEditPrenomAD.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ayantDroitBindingSource, "PrenomAyaDroit", true));
            this.textBoxEditPrenomAD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEditPrenomAD.Location = new System.Drawing.Point(187, 68);
            this.textBoxEditPrenomAD.MaxLength = 15;
            this.textBoxEditPrenomAD.Name = "textBoxEditPrenomAD";
            this.textBoxEditPrenomAD.Size = new System.Drawing.Size(134, 21);
            this.textBoxEditPrenomAD.TabIndex = 26;
            // 
            // buttonEmployeeSauvegarder
            // 
            this.buttonEmployeeSauvegarder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEmployeeSauvegarder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(146)))), ((int)(((byte)(39)))));
            this.buttonEmployeeSauvegarder.FlatAppearance.BorderSize = 0;
            this.buttonEmployeeSauvegarder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEmployeeSauvegarder.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEmployeeSauvegarder.Location = new System.Drawing.Point(767, 165);
            this.buttonEmployeeSauvegarder.Name = "buttonEmployeeSauvegarder";
            this.buttonEmployeeSauvegarder.Size = new System.Drawing.Size(107, 30);
            this.buttonEmployeeSauvegarder.TabIndex = 24;
            this.buttonEmployeeSauvegarder.Text = "Sauvegarder";
            this.buttonEmployeeSauvegarder.UseVisualStyleBackColor = false;
            this.buttonEmployeeSauvegarder.Click += new System.EventHandler(this.buttonEmployeeSauvegarder_Click);
            // 
            // buttonAddAyantDroit
            // 
            this.buttonAddAyantDroit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(146)))), ((int)(((byte)(39)))));
            this.buttonAddAyantDroit.FlatAppearance.BorderSize = 0;
            this.buttonAddAyantDroit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddAyantDroit.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddAyantDroit.Location = new System.Drawing.Point(767, 31);
            this.buttonAddAyantDroit.Name = "buttonAddAyantDroit";
            this.buttonAddAyantDroit.Size = new System.Drawing.Size(107, 30);
            this.buttonAddAyantDroit.TabIndex = 45;
            this.buttonAddAyantDroit.Text = "Ajouter";
            this.buttonAddAyantDroit.UseVisualStyleBackColor = false;
            this.buttonAddAyantDroit.Click += new System.EventHandler(this.buttonAddAyantDroit_Click);
            // 
            // A_AyantDroitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(24)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(944, 672);
            this.Controls.Add(this.panelEditEmployee);
            this.Controls.Add(this.buttonPrintPreview);
            this.Controls.Add(this.dataGridViewAyaDroit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "A_AyantDroitForm";
            this.Text = "A_AyantDroitForm";
            this.Load += new System.EventHandler(this.A_AyantDroitForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAyaDroit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ayantDroitBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sonelgaz_data_baseDataSet2)).EndInit();
            this.panelEditEmployee.ResumeLayout(false);
            this.panelEditEmployee.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewAyaDroit;
        private sonelgaz_data_baseDataSet2 sonelgaz_data_baseDataSet2;
        private System.Windows.Forms.BindingSource ayantDroitBindingSource;
        private sonelgaz_data_baseDataSet2TableAdapters.Ayant_droitTableAdapter ayant_droitTableAdapter;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Button buttonPrintPreview;
        private System.Windows.Forms.DataGridViewTextBoxColumn codAyaDroitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenomAyaDroitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomAyaDroitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datNaisAyaDroitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numPasAyaDroitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datDelPasAyaDroitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn matriculeAgentDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panelEditEmployee;
        private Guna.UI2.WinForms.Guna2VSeparator guna2VSeparator1;
        private System.Windows.Forms.Button buttonEmployeeSupprimer;
        private System.Windows.Forms.ComboBox comboBoxEditLien;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dateTimePickerEditDatDelPasAD;
        private System.Windows.Forms.TextBox textBoxEditNumPasAD;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePickerEditDatNaisAD;
        private System.Windows.Forms.TextBox textBoxEditNomAD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Labelname;
        private System.Windows.Forms.TextBox textBoxEditPrenomAD;
        private System.Windows.Forms.Button buttonEmployeeSauvegarder;
        private System.Windows.Forms.Button buttonAddAyantDroit;
    }
}