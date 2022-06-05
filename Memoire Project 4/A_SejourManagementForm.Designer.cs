
namespace Memoire_Project_4
{
    partial class A_SejourManagementForm
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
            this.dataGridViewAgent = new System.Windows.Forms.DataGridView();
            this.codSejourDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.libSejourDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datDebSejourDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datFinSejourDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mtVersDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeComDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codTypSesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sejourBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sonelgaz_data_baseDataSet5 = new Memoire_Project_4.sonelgaz_data_baseDataSet5();
            this.sejourTableAdapter = new Memoire_Project_4.sonelgaz_data_baseDataSet5TableAdapters.SejourTableAdapter();
            this.panelEditEmployee = new System.Windows.Forms.Panel();
            this.buttonAddAyantDroit = new System.Windows.Forms.Button();
            this.buttonEmployeeSupprimer = new System.Windows.Forms.Button();
            this.buttonEmployeeSauvegarder = new System.Windows.Forms.Button();
            this.comboBoxEditCodeTypSes = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePickerEditfin = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2VSeparator1 = new Guna.UI2.WinForms.Guna2VSeparator();
            this.comboBoxEditCodeCom = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxEditMontVers = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePickerEditDebut = new System.Windows.Forms.DateTimePicker();
            this.textBoxEditCodeSejour = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Labelname = new System.Windows.Forms.Label();
            this.textBoxEditLibelle = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAgent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sejourBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sonelgaz_data_baseDataSet5)).BeginInit();
            this.panelEditEmployee.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewAgent
            // 
            this.dataGridViewAgent.AllowUserToAddRows = false;
            this.dataGridViewAgent.AllowUserToDeleteRows = false;
            this.dataGridViewAgent.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewAgent.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewAgent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewAgent.AutoGenerateColumns = false;
            this.dataGridViewAgent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAgent.BackgroundColor = System.Drawing.Color.Silver;
            this.dataGridViewAgent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(68)))), ((int)(((byte)(120)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(34)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAgent.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewAgent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAgent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codSejourDataGridViewTextBoxColumn,
            this.libSejourDataGridViewTextBoxColumn,
            this.datDebSejourDataGridViewTextBoxColumn,
            this.datFinSejourDataGridViewTextBoxColumn,
            this.mtVersDataGridViewTextBoxColumn,
            this.codeComDataGridViewTextBoxColumn,
            this.codTypSesDataGridViewTextBoxColumn});
            this.dataGridViewAgent.DataSource = this.sejourBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(24)))), ((int)(((byte)(36)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewAgent.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewAgent.EnableHeadersVisualStyles = false;
            this.dataGridViewAgent.Location = new System.Drawing.Point(27, 57);
            this.dataGridViewAgent.Name = "dataGridViewAgent";
            this.dataGridViewAgent.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAgent.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewAgent.RowHeadersVisible = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewAgent.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewAgent.Size = new System.Drawing.Size(891, 340);
            this.dataGridViewAgent.TabIndex = 1;
            // 
            // codSejourDataGridViewTextBoxColumn
            // 
            this.codSejourDataGridViewTextBoxColumn.DataPropertyName = "CodSejour";
            this.codSejourDataGridViewTextBoxColumn.HeaderText = "Code séjour";
            this.codSejourDataGridViewTextBoxColumn.Name = "codSejourDataGridViewTextBoxColumn";
            this.codSejourDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // libSejourDataGridViewTextBoxColumn
            // 
            this.libSejourDataGridViewTextBoxColumn.DataPropertyName = "LibSejour";
            this.libSejourDataGridViewTextBoxColumn.HeaderText = "Libellé de séjour";
            this.libSejourDataGridViewTextBoxColumn.Name = "libSejourDataGridViewTextBoxColumn";
            this.libSejourDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datDebSejourDataGridViewTextBoxColumn
            // 
            this.datDebSejourDataGridViewTextBoxColumn.DataPropertyName = "DatDebSejour";
            this.datDebSejourDataGridViewTextBoxColumn.HeaderText = "Date début séjour";
            this.datDebSejourDataGridViewTextBoxColumn.Name = "datDebSejourDataGridViewTextBoxColumn";
            this.datDebSejourDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datFinSejourDataGridViewTextBoxColumn
            // 
            this.datFinSejourDataGridViewTextBoxColumn.DataPropertyName = "DatFinSejour";
            this.datFinSejourDataGridViewTextBoxColumn.HeaderText = "Date fin séjour";
            this.datFinSejourDataGridViewTextBoxColumn.Name = "datFinSejourDataGridViewTextBoxColumn";
            this.datFinSejourDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mtVersDataGridViewTextBoxColumn
            // 
            this.mtVersDataGridViewTextBoxColumn.DataPropertyName = "MtVers";
            this.mtVersDataGridViewTextBoxColumn.HeaderText = "Montant de versement";
            this.mtVersDataGridViewTextBoxColumn.Name = "mtVersDataGridViewTextBoxColumn";
            this.mtVersDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // codeComDataGridViewTextBoxColumn
            // 
            this.codeComDataGridViewTextBoxColumn.DataPropertyName = "CodeCom";
            this.codeComDataGridViewTextBoxColumn.HeaderText = "Code de la commune";
            this.codeComDataGridViewTextBoxColumn.Name = "codeComDataGridViewTextBoxColumn";
            this.codeComDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // codTypSesDataGridViewTextBoxColumn
            // 
            this.codTypSesDataGridViewTextBoxColumn.DataPropertyName = "CodTypSes";
            this.codTypSesDataGridViewTextBoxColumn.HeaderText = "Code type session";
            this.codTypSesDataGridViewTextBoxColumn.Name = "codTypSesDataGridViewTextBoxColumn";
            this.codTypSesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sejourBindingSource
            // 
            this.sejourBindingSource.DataMember = "Sejour";
            this.sejourBindingSource.DataSource = this.sonelgaz_data_baseDataSet5;
            // 
            // sonelgaz_data_baseDataSet5
            // 
            this.sonelgaz_data_baseDataSet5.DataSetName = "sonelgaz_data_baseDataSet5";
            this.sonelgaz_data_baseDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sejourTableAdapter
            // 
            this.sejourTableAdapter.ClearBeforeFill = true;
            // 
            // panelEditEmployee
            // 
            this.panelEditEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelEditEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(56)))));
            this.panelEditEmployee.Controls.Add(this.buttonAddAyantDroit);
            this.panelEditEmployee.Controls.Add(this.buttonEmployeeSupprimer);
            this.panelEditEmployee.Controls.Add(this.buttonEmployeeSauvegarder);
            this.panelEditEmployee.Controls.Add(this.comboBoxEditCodeTypSes);
            this.panelEditEmployee.Controls.Add(this.label4);
            this.panelEditEmployee.Controls.Add(this.dateTimePickerEditfin);
            this.panelEditEmployee.Controls.Add(this.label3);
            this.panelEditEmployee.Controls.Add(this.guna2VSeparator1);
            this.panelEditEmployee.Controls.Add(this.comboBoxEditCodeCom);
            this.panelEditEmployee.Controls.Add(this.label12);
            this.panelEditEmployee.Controls.Add(this.textBoxEditMontVers);
            this.panelEditEmployee.Controls.Add(this.label7);
            this.panelEditEmployee.Controls.Add(this.dateTimePickerEditDebut);
            this.panelEditEmployee.Controls.Add(this.textBoxEditCodeSejour);
            this.panelEditEmployee.Controls.Add(this.label2);
            this.panelEditEmployee.Controls.Add(this.label1);
            this.panelEditEmployee.Controls.Add(this.Labelname);
            this.panelEditEmployee.Controls.Add(this.textBoxEditLibelle);
            this.panelEditEmployee.Location = new System.Drawing.Point(26, 422);
            this.panelEditEmployee.Name = "panelEditEmployee";
            this.panelEditEmployee.Size = new System.Drawing.Size(891, 227);
            this.panelEditEmployee.TabIndex = 43;
            // 
            // buttonAddAyantDroit
            // 
            this.buttonAddAyantDroit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(146)))), ((int)(((byte)(39)))));
            this.buttonAddAyantDroit.FlatAppearance.BorderSize = 0;
            this.buttonAddAyantDroit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddAyantDroit.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddAyantDroit.Location = new System.Drawing.Point(767, 33);
            this.buttonAddAyantDroit.Name = "buttonAddAyantDroit";
            this.buttonAddAyantDroit.Size = new System.Drawing.Size(107, 30);
            this.buttonAddAyantDroit.TabIndex = 65;
            this.buttonAddAyantDroit.Text = "Ajouter";
            this.buttonAddAyantDroit.UseVisualStyleBackColor = false;
            this.buttonAddAyantDroit.Click += new System.EventHandler(this.buttonAddAyantDroit_Click);
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
            this.buttonEmployeeSupprimer.TabIndex = 66;
            this.buttonEmployeeSupprimer.Text = "Supprimer";
            this.buttonEmployeeSupprimer.UseVisualStyleBackColor = false;
            this.buttonEmployeeSupprimer.Click += new System.EventHandler(this.buttonEmployeeSupprimer_Click);
            // 
            // buttonEmployeeSauvegarder
            // 
            this.buttonEmployeeSauvegarder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEmployeeSauvegarder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(146)))), ((int)(((byte)(39)))));
            this.buttonEmployeeSauvegarder.FlatAppearance.BorderSize = 0;
            this.buttonEmployeeSauvegarder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEmployeeSauvegarder.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEmployeeSauvegarder.Location = new System.Drawing.Point(767, 163);
            this.buttonEmployeeSauvegarder.Name = "buttonEmployeeSauvegarder";
            this.buttonEmployeeSauvegarder.Size = new System.Drawing.Size(107, 30);
            this.buttonEmployeeSauvegarder.TabIndex = 64;
            this.buttonEmployeeSauvegarder.Text = "Sauvegarder";
            this.buttonEmployeeSauvegarder.UseVisualStyleBackColor = false;
            this.buttonEmployeeSauvegarder.Click += new System.EventHandler(this.buttonEmployeeSauvegarder_Click);
            // 
            // comboBoxEditCodeTypSes
            // 
            this.comboBoxEditCodeTypSes.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sejourBindingSource, "CodTypSes", true));
            this.comboBoxEditCodeTypSes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEditCodeTypSes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxEditCodeTypSes.FormattingEnabled = true;
            this.comboBoxEditCodeTypSes.Items.AddRange(new object[] {
            "Employe",
            "Administrateur"});
            this.comboBoxEditCodeTypSes.Location = new System.Drawing.Point(587, 172);
            this.comboBoxEditCodeTypSes.Name = "comboBoxEditCodeTypSes";
            this.comboBoxEditCodeTypSes.Size = new System.Drawing.Size(134, 23);
            this.comboBoxEditCodeTypSes.TabIndex = 63;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(56)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(583, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 15);
            this.label4.TabIndex = 62;
            this.label4.Text = "Code type session";
            // 
            // dateTimePickerEditfin
            // 
            this.dateTimePickerEditfin.CustomFormat = "yyyy-MM-dd";
            this.dateTimePickerEditfin.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sejourBindingSource, "DatFinSejour", true));
            this.dateTimePickerEditfin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerEditfin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerEditfin.Location = new System.Drawing.Point(191, 173);
            this.dateTimePickerEditfin.Name = "dateTimePickerEditfin";
            this.dateTimePickerEditfin.Size = new System.Drawing.Size(134, 21);
            this.dateTimePickerEditfin.TabIndex = 61;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(56)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(187, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 15);
            this.label3.TabIndex = 60;
            this.label3.Text = "Date fin séjour";
            // 
            // guna2VSeparator1
            // 
            this.guna2VSeparator1.Location = new System.Drawing.Point(368, 10);
            this.guna2VSeparator1.Name = "guna2VSeparator1";
            this.guna2VSeparator1.Size = new System.Drawing.Size(10, 207);
            this.guna2VSeparator1.TabIndex = 59;
            // 
            // comboBoxEditCodeCom
            // 
            this.comboBoxEditCodeCom.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sejourBindingSource, "CodeCom", true));
            this.comboBoxEditCodeCom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEditCodeCom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxEditCodeCom.FormattingEnabled = true;
            this.comboBoxEditCodeCom.Items.AddRange(new object[] {
            "Employe",
            "Administrateur"});
            this.comboBoxEditCodeCom.Location = new System.Drawing.Point(423, 172);
            this.comboBoxEditCodeCom.Name = "comboBoxEditCodeCom";
            this.comboBoxEditCodeCom.Size = new System.Drawing.Size(134, 23);
            this.comboBoxEditCodeCom.TabIndex = 56;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(56)))));
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(419, 149);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(125, 15);
            this.label12.TabIndex = 55;
            this.label12.Text = "Code de la commune";
            // 
            // textBoxEditMontVers
            // 
            this.textBoxEditMontVers.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sejourBindingSource, "MtVers", true));
            this.textBoxEditMontVers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEditMontVers.Location = new System.Drawing.Point(422, 54);
            this.textBoxEditMontVers.MaxLength = 8;
            this.textBoxEditMontVers.Name = "textBoxEditMontVers";
            this.textBoxEditMontVers.Size = new System.Drawing.Size(134, 21);
            this.textBoxEditMontVers.TabIndex = 46;
            this.textBoxEditMontVers.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxEditMontVers_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(56)))));
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(419, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 15);
            this.label7.TabIndex = 44;
            this.label7.Text = "Montant de versement";
            // 
            // dateTimePickerEditDebut
            // 
            this.dateTimePickerEditDebut.CustomFormat = "yyyy-MM-dd";
            this.dateTimePickerEditDebut.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sejourBindingSource, "DatDebSejour", true));
            this.dateTimePickerEditDebut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerEditDebut.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerEditDebut.Location = new System.Drawing.Point(25, 173);
            this.dateTimePickerEditDebut.Name = "dateTimePickerEditDebut";
            this.dateTimePickerEditDebut.Size = new System.Drawing.Size(134, 21);
            this.dateTimePickerEditDebut.TabIndex = 44;
            // 
            // textBoxEditCodeSejour
            // 
            this.textBoxEditCodeSejour.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sejourBindingSource, "CodSejour", true));
            this.textBoxEditCodeSejour.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEditCodeSejour.Location = new System.Drawing.Point(25, 55);
            this.textBoxEditCodeSejour.MaxLength = 8;
            this.textBoxEditCodeSejour.Name = "textBoxEditCodeSejour";
            this.textBoxEditCodeSejour.Size = new System.Drawing.Size(134, 21);
            this.textBoxEditCodeSejour.TabIndex = 25;
            this.textBoxEditCodeSejour.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxEditCodeSejour_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(56)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(21, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 15);
            this.label2.TabIndex = 43;
            this.label2.Text = "Date début séjour";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(56)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(186, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 15);
            this.label1.TabIndex = 28;
            this.label1.Text = "Libellé de séjour";
            // 
            // Labelname
            // 
            this.Labelname.AutoSize = true;
            this.Labelname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(56)))));
            this.Labelname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Labelname.ForeColor = System.Drawing.Color.White;
            this.Labelname.Location = new System.Drawing.Point(21, 32);
            this.Labelname.Name = "Labelname";
            this.Labelname.Size = new System.Drawing.Size(73, 15);
            this.Labelname.TabIndex = 27;
            this.Labelname.Text = "Code séjour";
            // 
            // textBoxEditLibelle
            // 
            this.textBoxEditLibelle.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sejourBindingSource, "LibSejour", true));
            this.textBoxEditLibelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEditLibelle.Location = new System.Drawing.Point(190, 55);
            this.textBoxEditLibelle.MaxLength = 15;
            this.textBoxEditLibelle.Name = "textBoxEditLibelle";
            this.textBoxEditLibelle.Size = new System.Drawing.Size(134, 21);
            this.textBoxEditLibelle.TabIndex = 26;
            this.textBoxEditLibelle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxEditLibelle_KeyPress);
            // 
            // A_SejourManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(24)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(944, 672);
            this.Controls.Add(this.panelEditEmployee);
            this.Controls.Add(this.dataGridViewAgent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "A_SejourManagementForm";
            this.Text = "A_SejourManagementForm";
            this.Load += new System.EventHandler(this.A_SejourManagementForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAgent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sejourBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sonelgaz_data_baseDataSet5)).EndInit();
            this.panelEditEmployee.ResumeLayout(false);
            this.panelEditEmployee.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewAgent;
        private sonelgaz_data_baseDataSet5 sonelgaz_data_baseDataSet5;
        private System.Windows.Forms.BindingSource sejourBindingSource;
        private sonelgaz_data_baseDataSet5TableAdapters.SejourTableAdapter sejourTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codSejourDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn libSejourDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datDebSejourDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datFinSejourDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mtVersDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeComDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codTypSesDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panelEditEmployee;
        private Guna.UI2.WinForms.Guna2VSeparator guna2VSeparator1;
        private System.Windows.Forms.ComboBox comboBoxEditCodeCom;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxEditMontVers;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePickerEditDebut;
        private System.Windows.Forms.TextBox textBoxEditCodeSejour;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Labelname;
        private System.Windows.Forms.TextBox textBoxEditLibelle;
        private System.Windows.Forms.DateTimePicker dateTimePickerEditfin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxEditCodeTypSes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonAddAyantDroit;
        private System.Windows.Forms.Button buttonEmployeeSupprimer;
        private System.Windows.Forms.Button buttonEmployeeSauvegarder;
    }
}