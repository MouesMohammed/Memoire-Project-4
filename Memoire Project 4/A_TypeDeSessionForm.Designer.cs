
namespace Memoire_Project_4
{
    partial class A_TypeDeSessionForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewAgent = new System.Windows.Forms.DataGridView();
            this.sonelgaz_data_baseDataSet8 = new Memoire_Project_4.sonelgaz_data_baseDataSet8();
            this.typeSessionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.type_sessionTableAdapter = new Memoire_Project_4.sonelgaz_data_baseDataSet8TableAdapters.Type_sessionTableAdapter();
            this.codTypSesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.designationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelEditEmployee = new System.Windows.Forms.Panel();
            this.buttonAddAyantDroit = new System.Windows.Forms.Button();
            this.buttonEmployeeSupprimer = new System.Windows.Forms.Button();
            this.buttonEmployeeSauvegarder = new System.Windows.Forms.Button();
            this.guna2VSeparator1 = new Guna.UI2.WinForms.Guna2VSeparator();
            this.textBoxEditCodeTypSes = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Labelname = new System.Windows.Forms.Label();
            this.textBoxEditDesignation = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAgent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sonelgaz_data_baseDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeSessionBindingSource)).BeginInit();
            this.panelEditEmployee.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewAgent
            // 
            this.dataGridViewAgent.AllowUserToAddRows = false;
            this.dataGridViewAgent.AllowUserToDeleteRows = false;
            this.dataGridViewAgent.AllowUserToResizeRows = false;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewAgent.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dataGridViewAgent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewAgent.AutoGenerateColumns = false;
            this.dataGridViewAgent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAgent.BackgroundColor = System.Drawing.Color.Silver;
            this.dataGridViewAgent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(68)))), ((int)(((byte)(120)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(34)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAgent.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dataGridViewAgent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAgent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codTypSesDataGridViewTextBoxColumn,
            this.designationDataGridViewTextBoxColumn});
            this.dataGridViewAgent.DataSource = this.typeSessionBindingSource;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(24)))), ((int)(((byte)(36)))));
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewAgent.DefaultCellStyle = dataGridViewCellStyle18;
            this.dataGridViewAgent.EnableHeadersVisualStyles = false;
            this.dataGridViewAgent.Location = new System.Drawing.Point(27, 57);
            this.dataGridViewAgent.Name = "dataGridViewAgent";
            this.dataGridViewAgent.ReadOnly = true;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.AppWorkspace;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAgent.RowHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.dataGridViewAgent.RowHeadersVisible = false;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewAgent.RowsDefaultCellStyle = dataGridViewCellStyle20;
            this.dataGridViewAgent.Size = new System.Drawing.Size(891, 340);
            this.dataGridViewAgent.TabIndex = 2;
            // 
            // sonelgaz_data_baseDataSet8
            // 
            this.sonelgaz_data_baseDataSet8.DataSetName = "sonelgaz_data_baseDataSet8";
            this.sonelgaz_data_baseDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // typeSessionBindingSource
            // 
            this.typeSessionBindingSource.DataMember = "Type session";
            this.typeSessionBindingSource.DataSource = this.sonelgaz_data_baseDataSet8;
            // 
            // type_sessionTableAdapter
            // 
            this.type_sessionTableAdapter.ClearBeforeFill = true;
            // 
            // codTypSesDataGridViewTextBoxColumn
            // 
            this.codTypSesDataGridViewTextBoxColumn.DataPropertyName = "CodTypSes";
            this.codTypSesDataGridViewTextBoxColumn.HeaderText = "Code de Type Session";
            this.codTypSesDataGridViewTextBoxColumn.Name = "codTypSesDataGridViewTextBoxColumn";
            this.codTypSesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // designationDataGridViewTextBoxColumn
            // 
            this.designationDataGridViewTextBoxColumn.DataPropertyName = "Designation";
            this.designationDataGridViewTextBoxColumn.HeaderText = "Designation";
            this.designationDataGridViewTextBoxColumn.Name = "designationDataGridViewTextBoxColumn";
            this.designationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // panelEditEmployee
            // 
            this.panelEditEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelEditEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(56)))));
            this.panelEditEmployee.Controls.Add(this.buttonAddAyantDroit);
            this.panelEditEmployee.Controls.Add(this.buttonEmployeeSupprimer);
            this.panelEditEmployee.Controls.Add(this.buttonEmployeeSauvegarder);
            this.panelEditEmployee.Controls.Add(this.guna2VSeparator1);
            this.panelEditEmployee.Controls.Add(this.textBoxEditCodeTypSes);
            this.panelEditEmployee.Controls.Add(this.label1);
            this.panelEditEmployee.Controls.Add(this.Labelname);
            this.panelEditEmployee.Controls.Add(this.textBoxEditDesignation);
            this.panelEditEmployee.Location = new System.Drawing.Point(476, 422);
            this.panelEditEmployee.Name = "panelEditEmployee";
            this.panelEditEmployee.Size = new System.Drawing.Size(441, 227);
            this.panelEditEmployee.TabIndex = 44;
            // 
            // buttonAddAyantDroit
            // 
            this.buttonAddAyantDroit.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonAddAyantDroit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(146)))), ((int)(((byte)(39)))));
            this.buttonAddAyantDroit.FlatAppearance.BorderSize = 0;
            this.buttonAddAyantDroit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddAyantDroit.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddAyantDroit.Location = new System.Drawing.Point(317, 33);
            this.buttonAddAyantDroit.Name = "buttonAddAyantDroit";
            this.buttonAddAyantDroit.Size = new System.Drawing.Size(107, 30);
            this.buttonAddAyantDroit.TabIndex = 65;
            this.buttonAddAyantDroit.Text = "Ajouter";
            this.buttonAddAyantDroit.UseVisualStyleBackColor = false;
            this.buttonAddAyantDroit.Click += new System.EventHandler(this.buttonAddAyantDroit_Click);
            // 
            // buttonEmployeeSupprimer
            // 
            this.buttonEmployeeSupprimer.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonEmployeeSupprimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(193)))), ((int)(((byte)(125)))));
            this.buttonEmployeeSupprimer.FlatAppearance.BorderSize = 0;
            this.buttonEmployeeSupprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEmployeeSupprimer.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEmployeeSupprimer.Location = new System.Drawing.Point(317, 98);
            this.buttonEmployeeSupprimer.Name = "buttonEmployeeSupprimer";
            this.buttonEmployeeSupprimer.Size = new System.Drawing.Size(107, 30);
            this.buttonEmployeeSupprimer.TabIndex = 66;
            this.buttonEmployeeSupprimer.Text = "Supprimer";
            this.buttonEmployeeSupprimer.UseVisualStyleBackColor = false;
            this.buttonEmployeeSupprimer.Click += new System.EventHandler(this.buttonEmployeeSupprimer_Click);
            // 
            // buttonEmployeeSauvegarder
            // 
            this.buttonEmployeeSauvegarder.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonEmployeeSauvegarder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(146)))), ((int)(((byte)(39)))));
            this.buttonEmployeeSauvegarder.FlatAppearance.BorderSize = 0;
            this.buttonEmployeeSauvegarder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEmployeeSauvegarder.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEmployeeSauvegarder.Location = new System.Drawing.Point(317, 163);
            this.buttonEmployeeSauvegarder.Name = "buttonEmployeeSauvegarder";
            this.buttonEmployeeSauvegarder.Size = new System.Drawing.Size(107, 30);
            this.buttonEmployeeSauvegarder.TabIndex = 64;
            this.buttonEmployeeSauvegarder.Text = "Sauvegarder";
            this.buttonEmployeeSauvegarder.UseVisualStyleBackColor = false;
            this.buttonEmployeeSauvegarder.Click += new System.EventHandler(this.buttonEmployeeSauvegarder_Click);
            // 
            // guna2VSeparator1
            // 
            this.guna2VSeparator1.Location = new System.Drawing.Point(239, 15);
            this.guna2VSeparator1.Name = "guna2VSeparator1";
            this.guna2VSeparator1.Size = new System.Drawing.Size(10, 196);
            this.guna2VSeparator1.TabIndex = 59;
            // 
            // textBoxEditCodeTypSes
            // 
            this.textBoxEditCodeTypSes.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.textBoxEditCodeTypSes.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.typeSessionBindingSource, "CodTypSes", true));
            this.textBoxEditCodeTypSes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEditCodeTypSes.Location = new System.Drawing.Point(46, 63);
            this.textBoxEditCodeTypSes.MaxLength = 6;
            this.textBoxEditCodeTypSes.Name = "textBoxEditCodeTypSes";
            this.textBoxEditCodeTypSes.Size = new System.Drawing.Size(134, 21);
            this.textBoxEditCodeTypSes.TabIndex = 25;
            this.textBoxEditCodeTypSes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxEditCodeTypSes_KeyPress);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(56)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(42, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 15);
            this.label1.TabIndex = 28;
            this.label1.Text = "Designation";
            // 
            // Labelname
            // 
            this.Labelname.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Labelname.AutoSize = true;
            this.Labelname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(56)))));
            this.Labelname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Labelname.ForeColor = System.Drawing.Color.White;
            this.Labelname.Location = new System.Drawing.Point(42, 40);
            this.Labelname.Name = "Labelname";
            this.Labelname.Size = new System.Drawing.Size(123, 15);
            this.Labelname.TabIndex = 27;
            this.Labelname.Text = "Code de type session";
            // 
            // textBoxEditDesignation
            // 
            this.textBoxEditDesignation.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.textBoxEditDesignation.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.typeSessionBindingSource, "Designation", true));
            this.textBoxEditDesignation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEditDesignation.Location = new System.Drawing.Point(46, 163);
            this.textBoxEditDesignation.MaxLength = 30;
            this.textBoxEditDesignation.Name = "textBoxEditDesignation";
            this.textBoxEditDesignation.Size = new System.Drawing.Size(134, 21);
            this.textBoxEditDesignation.TabIndex = 26;
            this.textBoxEditDesignation.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxEditDesignation_KeyPress);
            // 
            // A_TypeDeSessionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(24)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(944, 672);
            this.Controls.Add(this.panelEditEmployee);
            this.Controls.Add(this.dataGridViewAgent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "A_TypeDeSessionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "A_TypeDeSessionForm";
            this.Load += new System.EventHandler(this.A_TypeDeSessionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAgent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sonelgaz_data_baseDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeSessionBindingSource)).EndInit();
            this.panelEditEmployee.ResumeLayout(false);
            this.panelEditEmployee.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewAgent;
        private sonelgaz_data_baseDataSet8 sonelgaz_data_baseDataSet8;
        private System.Windows.Forms.BindingSource typeSessionBindingSource;
        private sonelgaz_data_baseDataSet8TableAdapters.Type_sessionTableAdapter type_sessionTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codTypSesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn designationDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panelEditEmployee;
        private System.Windows.Forms.Button buttonAddAyantDroit;
        private System.Windows.Forms.Button buttonEmployeeSupprimer;
        private System.Windows.Forms.Button buttonEmployeeSauvegarder;
        private Guna.UI2.WinForms.Guna2VSeparator guna2VSeparator1;
        private System.Windows.Forms.TextBox textBoxEditCodeTypSes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Labelname;
        private System.Windows.Forms.TextBox textBoxEditDesignation;
    }
}