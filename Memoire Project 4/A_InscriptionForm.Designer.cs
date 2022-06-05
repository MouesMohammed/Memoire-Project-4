
namespace Memoire_Project_4
{
    partial class A_InscriptionForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewInscriptions = new System.Windows.Forms.DataGridView();
            this.numInscriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datInscriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matriculeAgentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codSejourDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numBordVersDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datVersDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datDemRetSalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mtRetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numAutSejourDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datAutSejourDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valideDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inscriptionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sonelgaz_data_baseDataSet3 = new Memoire_Project_4.sonelgaz_data_baseDataSet3();
            this.panelEditInscriptions = new System.Windows.Forms.Panel();
            this.guna2VSeparator1 = new Guna.UI2.WinForms.Guna2VSeparator();
            this.textBoxCodeSejour = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNumInscription = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerAutorisation = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerInscription = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDemandeRetenue = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerVersement = new System.Windows.Forms.DateTimePicker();
            this.buttonSejourSupprimer = new System.Windows.Forms.Button();
            this.comboBoxEditValide = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxMontantDeRetenue = new System.Windows.Forms.TextBox();
            this.textBoxNumAutorisation = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxNumBordereau = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxMatriculeAgent = new System.Windows.Forms.TextBox();
            this.Labeln = new System.Windows.Forms.Label();
            this.buttonSejourSauvegarder = new System.Windows.Forms.Button();
            this.inscriptionTableAdapter = new Memoire_Project_4.sonelgaz_data_baseDataSet3TableAdapters.InscriptionTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInscriptions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inscriptionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sonelgaz_data_baseDataSet3)).BeginInit();
            this.panelEditInscriptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewInscriptions
            // 
            this.dataGridViewInscriptions.AllowUserToAddRows = false;
            this.dataGridViewInscriptions.AllowUserToDeleteRows = false;
            this.dataGridViewInscriptions.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewInscriptions.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewInscriptions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewInscriptions.AutoGenerateColumns = false;
            this.dataGridViewInscriptions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewInscriptions.BackgroundColor = System.Drawing.Color.Silver;
            this.dataGridViewInscriptions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(68)))), ((int)(((byte)(120)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(34)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewInscriptions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewInscriptions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInscriptions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numInscriptionDataGridViewTextBoxColumn,
            this.datInscriptionDataGridViewTextBoxColumn,
            this.matriculeAgentDataGridViewTextBoxColumn,
            this.codSejourDataGridViewTextBoxColumn,
            this.numBordVersDataGridViewTextBoxColumn,
            this.datVersDataGridViewTextBoxColumn,
            this.datDemRetSalDataGridViewTextBoxColumn,
            this.mtRetDataGridViewTextBoxColumn,
            this.numAutSejourDataGridViewTextBoxColumn,
            this.datAutSejourDataGridViewTextBoxColumn,
            this.valideDataGridViewTextBoxColumn});
            this.dataGridViewInscriptions.DataSource = this.inscriptionBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(24)))), ((int)(((byte)(36)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewInscriptions.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewInscriptions.EnableHeadersVisualStyles = false;
            this.dataGridViewInscriptions.Location = new System.Drawing.Point(27, 57);
            this.dataGridViewInscriptions.Name = "dataGridViewInscriptions";
            this.dataGridViewInscriptions.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewInscriptions.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewInscriptions.RowHeadersVisible = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewInscriptions.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewInscriptions.Size = new System.Drawing.Size(891, 340);
            this.dataGridViewInscriptions.TabIndex = 1;
            this.dataGridViewInscriptions.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewInscriptions_CellFormatting);
            // 
            // numInscriptionDataGridViewTextBoxColumn
            // 
            this.numInscriptionDataGridViewTextBoxColumn.DataPropertyName = "NumInscription";
            this.numInscriptionDataGridViewTextBoxColumn.HeaderText = "Numéro d’inscription";
            this.numInscriptionDataGridViewTextBoxColumn.Name = "numInscriptionDataGridViewTextBoxColumn";
            this.numInscriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datInscriptionDataGridViewTextBoxColumn
            // 
            this.datInscriptionDataGridViewTextBoxColumn.DataPropertyName = "DatInscription";
            this.datInscriptionDataGridViewTextBoxColumn.HeaderText = "Date d’inscription";
            this.datInscriptionDataGridViewTextBoxColumn.Name = "datInscriptionDataGridViewTextBoxColumn";
            this.datInscriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // matriculeAgentDataGridViewTextBoxColumn
            // 
            this.matriculeAgentDataGridViewTextBoxColumn.DataPropertyName = "MatriculeAgent";
            this.matriculeAgentDataGridViewTextBoxColumn.HeaderText = "Matricule Agent";
            this.matriculeAgentDataGridViewTextBoxColumn.Name = "matriculeAgentDataGridViewTextBoxColumn";
            this.matriculeAgentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // codSejourDataGridViewTextBoxColumn
            // 
            this.codSejourDataGridViewTextBoxColumn.DataPropertyName = "CodSejour";
            this.codSejourDataGridViewTextBoxColumn.HeaderText = "Code séjour";
            this.codSejourDataGridViewTextBoxColumn.Name = "codSejourDataGridViewTextBoxColumn";
            this.codSejourDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numBordVersDataGridViewTextBoxColumn
            // 
            this.numBordVersDataGridViewTextBoxColumn.DataPropertyName = "NumBordVers";
            this.numBordVersDataGridViewTextBoxColumn.HeaderText = "Numéro de bordereau";
            this.numBordVersDataGridViewTextBoxColumn.Name = "numBordVersDataGridViewTextBoxColumn";
            this.numBordVersDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datVersDataGridViewTextBoxColumn
            // 
            this.datVersDataGridViewTextBoxColumn.DataPropertyName = "DatVers";
            this.datVersDataGridViewTextBoxColumn.HeaderText = "Date de versement";
            this.datVersDataGridViewTextBoxColumn.Name = "datVersDataGridViewTextBoxColumn";
            this.datVersDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datDemRetSalDataGridViewTextBoxColumn
            // 
            this.datDemRetSalDataGridViewTextBoxColumn.DataPropertyName = "DatDemRetSal";
            this.datDemRetSalDataGridViewTextBoxColumn.HeaderText = "Date demande de retenue";
            this.datDemRetSalDataGridViewTextBoxColumn.Name = "datDemRetSalDataGridViewTextBoxColumn";
            this.datDemRetSalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mtRetDataGridViewTextBoxColumn
            // 
            this.mtRetDataGridViewTextBoxColumn.DataPropertyName = "MtRet";
            this.mtRetDataGridViewTextBoxColumn.HeaderText = "Montant de la retenue";
            this.mtRetDataGridViewTextBoxColumn.Name = "mtRetDataGridViewTextBoxColumn";
            this.mtRetDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numAutSejourDataGridViewTextBoxColumn
            // 
            this.numAutSejourDataGridViewTextBoxColumn.DataPropertyName = "NumAutSejour";
            this.numAutSejourDataGridViewTextBoxColumn.HeaderText = "Numéro d’autorisation";
            this.numAutSejourDataGridViewTextBoxColumn.Name = "numAutSejourDataGridViewTextBoxColumn";
            this.numAutSejourDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datAutSejourDataGridViewTextBoxColumn
            // 
            this.datAutSejourDataGridViewTextBoxColumn.DataPropertyName = "DatAutSejour";
            this.datAutSejourDataGridViewTextBoxColumn.HeaderText = "Date autorisation";
            this.datAutSejourDataGridViewTextBoxColumn.Name = "datAutSejourDataGridViewTextBoxColumn";
            this.datAutSejourDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // valideDataGridViewTextBoxColumn
            // 
            this.valideDataGridViewTextBoxColumn.DataPropertyName = "Valide";
            this.valideDataGridViewTextBoxColumn.HeaderText = "Statut d\'inscription";
            this.valideDataGridViewTextBoxColumn.Name = "valideDataGridViewTextBoxColumn";
            this.valideDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // inscriptionBindingSource
            // 
            this.inscriptionBindingSource.DataMember = "Inscription";
            this.inscriptionBindingSource.DataSource = this.sonelgaz_data_baseDataSet3;
            // 
            // sonelgaz_data_baseDataSet3
            // 
            this.sonelgaz_data_baseDataSet3.DataSetName = "sonelgaz_data_baseDataSet3";
            this.sonelgaz_data_baseDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panelEditInscriptions
            // 
            this.panelEditInscriptions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelEditInscriptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(56)))));
            this.panelEditInscriptions.Controls.Add(this.guna2VSeparator1);
            this.panelEditInscriptions.Controls.Add(this.textBoxCodeSejour);
            this.panelEditInscriptions.Controls.Add(this.label2);
            this.panelEditInscriptions.Controls.Add(this.textBoxNumInscription);
            this.panelEditInscriptions.Controls.Add(this.label4);
            this.panelEditInscriptions.Controls.Add(this.label1);
            this.panelEditInscriptions.Controls.Add(this.dateTimePickerAutorisation);
            this.panelEditInscriptions.Controls.Add(this.dateTimePickerInscription);
            this.panelEditInscriptions.Controls.Add(this.dateTimePickerDemandeRetenue);
            this.panelEditInscriptions.Controls.Add(this.dateTimePickerVersement);
            this.panelEditInscriptions.Controls.Add(this.buttonSejourSupprimer);
            this.panelEditInscriptions.Controls.Add(this.comboBoxEditValide);
            this.panelEditInscriptions.Controls.Add(this.label12);
            this.panelEditInscriptions.Controls.Add(this.label9);
            this.panelEditInscriptions.Controls.Add(this.textBoxMontantDeRetenue);
            this.panelEditInscriptions.Controls.Add(this.textBoxNumAutorisation);
            this.panelEditInscriptions.Controls.Add(this.label6);
            this.panelEditInscriptions.Controls.Add(this.label8);
            this.panelEditInscriptions.Controls.Add(this.label7);
            this.panelEditInscriptions.Controls.Add(this.textBoxNumBordereau);
            this.panelEditInscriptions.Controls.Add(this.label5);
            this.panelEditInscriptions.Controls.Add(this.label3);
            this.panelEditInscriptions.Controls.Add(this.textBoxMatriculeAgent);
            this.panelEditInscriptions.Controls.Add(this.Labeln);
            this.panelEditInscriptions.Controls.Add(this.buttonSejourSauvegarder);
            this.panelEditInscriptions.Location = new System.Drawing.Point(26, 422);
            this.panelEditInscriptions.Name = "panelEditInscriptions";
            this.panelEditInscriptions.Size = new System.Drawing.Size(891, 227);
            this.panelEditInscriptions.TabIndex = 43;
            // 
            // guna2VSeparator1
            // 
            this.guna2VSeparator1.Location = new System.Drawing.Point(369, 14);
            this.guna2VSeparator1.Name = "guna2VSeparator1";
            this.guna2VSeparator1.Size = new System.Drawing.Size(10, 198);
            this.guna2VSeparator1.TabIndex = 63;
            // 
            // textBoxCodeSejour
            // 
            this.textBoxCodeSejour.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inscriptionBindingSource, "CodSejour", true));
            this.textBoxCodeSejour.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCodeSejour.Location = new System.Drawing.Point(188, 114);
            this.textBoxCodeSejour.MaxLength = 15;
            this.textBoxCodeSejour.Name = "textBoxCodeSejour";
            this.textBoxCodeSejour.Size = new System.Drawing.Size(134, 21);
            this.textBoxCodeSejour.TabIndex = 61;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(56)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(182, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 15);
            this.label2.TabIndex = 43;
            this.label2.Text = "Date d’inscription ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBoxNumInscription
            // 
            this.textBoxNumInscription.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inscriptionBindingSource, "NumInscription", true));
            this.textBoxNumInscription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNumInscription.Location = new System.Drawing.Point(28, 39);
            this.textBoxNumInscription.MaxLength = 15;
            this.textBoxNumInscription.Name = "textBoxNumInscription";
            this.textBoxNumInscription.Size = new System.Drawing.Size(134, 21);
            this.textBoxNumInscription.TabIndex = 26;
            this.textBoxNumInscription.TextChanged += new System.EventHandler(this.textBoxEditPrenomAgent_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(56)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(184, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 15);
            this.label4.TabIndex = 62;
            this.label4.Text = "Code séjour";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(56)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(24, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 15);
            this.label1.TabIndex = 28;
            this.label1.Text = "Numéro d’inscription ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dateTimePickerAutorisation
            // 
            this.dateTimePickerAutorisation.CustomFormat = "yyyy-MM-dd";
            this.dateTimePickerAutorisation.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inscriptionBindingSource, "DatAutSejour", true));
            this.dateTimePickerAutorisation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerAutorisation.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerAutorisation.Location = new System.Drawing.Point(587, 114);
            this.dateTimePickerAutorisation.Name = "dateTimePickerAutorisation";
            this.dateTimePickerAutorisation.Size = new System.Drawing.Size(134, 21);
            this.dateTimePickerAutorisation.TabIndex = 60;
            this.dateTimePickerAutorisation.ValueChanged += new System.EventHandler(this.dateTimePicker3_ValueChanged);
            // 
            // dateTimePickerInscription
            // 
            this.dateTimePickerInscription.CustomFormat = "yyyy-MM-dd";
            this.dateTimePickerInscription.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inscriptionBindingSource, "DatInscription", true));
            this.dateTimePickerInscription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerInscription.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerInscription.Location = new System.Drawing.Point(186, 39);
            this.dateTimePickerInscription.Name = "dateTimePickerInscription";
            this.dateTimePickerInscription.Size = new System.Drawing.Size(134, 21);
            this.dateTimePickerInscription.TabIndex = 44;
            this.dateTimePickerInscription.ValueChanged += new System.EventHandler(this.dateTimePickerEditDatNaisAgent_ValueChanged);
            // 
            // dateTimePickerDemandeRetenue
            // 
            this.dateTimePickerDemandeRetenue.CustomFormat = "yyyy-MM-dd";
            this.dateTimePickerDemandeRetenue.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inscriptionBindingSource, "DatDemRetSal", true));
            this.dateTimePickerDemandeRetenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerDemandeRetenue.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDemandeRetenue.Location = new System.Drawing.Point(428, 37);
            this.dateTimePickerDemandeRetenue.Name = "dateTimePickerDemandeRetenue";
            this.dateTimePickerDemandeRetenue.Size = new System.Drawing.Size(134, 21);
            this.dateTimePickerDemandeRetenue.TabIndex = 59;
            // 
            // dateTimePickerVersement
            // 
            this.dateTimePickerVersement.CustomFormat = "yyyy-MM-dd";
            this.dateTimePickerVersement.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inscriptionBindingSource, "DatVers", true));
            this.dateTimePickerVersement.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerVersement.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerVersement.Location = new System.Drawing.Point(187, 189);
            this.dateTimePickerVersement.Name = "dateTimePickerVersement";
            this.dateTimePickerVersement.Size = new System.Drawing.Size(134, 21);
            this.dateTimePickerVersement.TabIndex = 58;
            this.dateTimePickerVersement.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // buttonSejourSupprimer
            // 
            this.buttonSejourSupprimer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSejourSupprimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(200)))), ((int)(((byte)(139)))));
            this.buttonSejourSupprimer.FlatAppearance.BorderSize = 0;
            this.buttonSejourSupprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSejourSupprimer.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSejourSupprimer.Location = new System.Drawing.Point(767, 98);
            this.buttonSejourSupprimer.Name = "buttonSejourSupprimer";
            this.buttonSejourSupprimer.Size = new System.Drawing.Size(107, 30);
            this.buttonSejourSupprimer.TabIndex = 57;
            this.buttonSejourSupprimer.Text = "Supprimer";
            this.buttonSejourSupprimer.UseVisualStyleBackColor = false;
            this.buttonSejourSupprimer.Click += new System.EventHandler(this.buttonSejourSupprimer_Click);
            // 
            // comboBoxEditValide
            // 
            this.comboBoxEditValide.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inscriptionBindingSource, "Valide", true));
            this.comboBoxEditValide.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEditValide.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxEditValide.FormattingEnabled = true;
            this.comboBoxEditValide.Items.AddRange(new object[] {
            "Validé",
            "Non validé"});
            this.comboBoxEditValide.Location = new System.Drawing.Point(427, 187);
            this.comboBoxEditValide.Name = "comboBoxEditValide";
            this.comboBoxEditValide.Size = new System.Drawing.Size(134, 23);
            this.comboBoxEditValide.TabIndex = 56;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(56)))));
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(423, 164);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(28, 15);
            this.label12.TabIndex = 55;
            this.label12.Text = "État";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(56)))));
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(584, 91);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 15);
            this.label9.TabIndex = 49;
            this.label9.Text = "Date autorisation";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // textBoxMontantDeRetenue
            // 
            this.textBoxMontantDeRetenue.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inscriptionBindingSource, "MtRet", true));
            this.textBoxMontantDeRetenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMontantDeRetenue.Location = new System.Drawing.Point(587, 39);
            this.textBoxMontantDeRetenue.MaxLength = 4;
            this.textBoxMontantDeRetenue.Name = "textBoxMontantDeRetenue";
            this.textBoxMontantDeRetenue.Size = new System.Drawing.Size(134, 21);
            this.textBoxMontantDeRetenue.TabIndex = 46;
            // 
            // textBoxNumAutorisation
            // 
            this.textBoxNumAutorisation.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inscriptionBindingSource, "NumAutSejour", true));
            this.textBoxNumAutorisation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNumAutorisation.Location = new System.Drawing.Point(430, 114);
            this.textBoxNumAutorisation.MaxLength = 6;
            this.textBoxNumAutorisation.Name = "textBoxNumAutorisation";
            this.textBoxNumAutorisation.Size = new System.Drawing.Size(134, 21);
            this.textBoxNumAutorisation.TabIndex = 43;
            this.textBoxNumAutorisation.TextChanged += new System.EventHandler(this.textBoxEditSitPrAgent_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(56)))));
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(425, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 15);
            this.label6.TabIndex = 46;
            this.label6.Text = "Date demande de retenue";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(56)))));
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(425, 91);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 15);
            this.label8.TabIndex = 45;
            this.label8.Text = "Numéro d’autorisation";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(56)))));
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(583, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 15);
            this.label7.TabIndex = 44;
            this.label7.Text = "Montant de la retenue";
            // 
            // textBoxNumBordereau
            // 
            this.textBoxNumBordereau.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inscriptionBindingSource, "NumBordVers", true));
            this.textBoxNumBordereau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNumBordereau.Location = new System.Drawing.Point(27, 189);
            this.textBoxNumBordereau.MaxLength = 50;
            this.textBoxNumBordereau.Name = "textBoxNumBordereau";
            this.textBoxNumBordereau.Size = new System.Drawing.Size(133, 21);
            this.textBoxNumBordereau.TabIndex = 43;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(56)))));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(182, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 15);
            this.label5.TabIndex = 44;
            this.label5.Text = "Date de versement";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(56)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(23, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 15);
            this.label3.TabIndex = 44;
            this.label3.Text = "Numéro de bordereau";
            // 
            // textBoxMatriculeAgent
            // 
            this.textBoxMatriculeAgent.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inscriptionBindingSource, "MatriculeAgent", true));
            this.textBoxMatriculeAgent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMatriculeAgent.Location = new System.Drawing.Point(28, 114);
            this.textBoxMatriculeAgent.MaxLength = 15;
            this.textBoxMatriculeAgent.Name = "textBoxMatriculeAgent";
            this.textBoxMatriculeAgent.Size = new System.Drawing.Size(134, 21);
            this.textBoxMatriculeAgent.TabIndex = 25;
            // 
            // Labeln
            // 
            this.Labeln.AutoSize = true;
            this.Labeln.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(56)))));
            this.Labeln.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Labeln.ForeColor = System.Drawing.Color.White;
            this.Labeln.Location = new System.Drawing.Point(24, 91);
            this.Labeln.Name = "Labeln";
            this.Labeln.Size = new System.Drawing.Size(115, 15);
            this.Labeln.TabIndex = 27;
            this.Labeln.Text = "Matricule de l’agent";
            // 
            // buttonSejourSauvegarder
            // 
            this.buttonSejourSauvegarder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSejourSauvegarder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(146)))), ((int)(((byte)(39)))));
            this.buttonSejourSauvegarder.FlatAppearance.BorderSize = 0;
            this.buttonSejourSauvegarder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSejourSauvegarder.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSejourSauvegarder.Location = new System.Drawing.Point(767, 165);
            this.buttonSejourSauvegarder.Name = "buttonSejourSauvegarder";
            this.buttonSejourSauvegarder.Size = new System.Drawing.Size(107, 30);
            this.buttonSejourSauvegarder.TabIndex = 24;
            this.buttonSejourSauvegarder.Text = "Sauvegarder";
            this.buttonSejourSauvegarder.UseVisualStyleBackColor = false;
            this.buttonSejourSauvegarder.Click += new System.EventHandler(this.buttonSejourSauvegarder_Click);
            // 
            // inscriptionTableAdapter
            // 
            this.inscriptionTableAdapter.ClearBeforeFill = true;
            // 
            // A_InscriptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(24)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(944, 672);
            this.Controls.Add(this.panelEditInscriptions);
            this.Controls.Add(this.dataGridViewInscriptions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "A_InscriptionForm";
            this.Text = "A_InscriptionForm";
            this.Load += new System.EventHandler(this.A_InscriptionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInscriptions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inscriptionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sonelgaz_data_baseDataSet3)).EndInit();
            this.panelEditInscriptions.ResumeLayout(false);
            this.panelEditInscriptions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewInscriptions;
        private System.Windows.Forms.Panel panelEditInscriptions;
        private System.Windows.Forms.Button buttonSejourSupprimer;
        private System.Windows.Forms.ComboBox comboBoxEditValide;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxMontantDeRetenue;
        private System.Windows.Forms.TextBox textBoxNumAutorisation;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxNumBordereau;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePickerInscription;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxMatriculeAgent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Labeln;
        private System.Windows.Forms.TextBox textBoxNumInscription;
        private System.Windows.Forms.Button buttonSejourSauvegarder;
        private System.Windows.Forms.DateTimePicker dateTimePickerAutorisation;
        private System.Windows.Forms.DateTimePicker dateTimePickerDemandeRetenue;
        private System.Windows.Forms.DateTimePicker dateTimePickerVersement;
        private System.Windows.Forms.TextBox textBoxCodeSejour;
        private System.Windows.Forms.Label label4;
        private sonelgaz_data_baseDataSet3 sonelgaz_data_baseDataSet3;
        private System.Windows.Forms.BindingSource inscriptionBindingSource;
        private sonelgaz_data_baseDataSet3TableAdapters.InscriptionTableAdapter inscriptionTableAdapter;
        private Guna.UI2.WinForms.Guna2VSeparator guna2VSeparator1;
        private System.Windows.Forms.DataGridViewTextBoxColumn numInscriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datInscriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn matriculeAgentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codSejourDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numBordVersDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datVersDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datDemRetSalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mtRetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numAutSejourDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datAutSejourDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valideDataGridViewTextBoxColumn;
    }
}