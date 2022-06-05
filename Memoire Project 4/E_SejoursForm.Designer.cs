
namespace Memoire_Project_4
{
    partial class E_SejoursForm
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
            this.dataGridViewSejour = new System.Windows.Forms.DataGridView();
            this.codSejourDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.libSejourDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datDebSejourDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datFinSejourDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mtVersDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sejourBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sonelgaz_data_baseDataSet1 = new Memoire_Project_4.sonelgaz_data_baseDataSet1();
            this.sonelgaz_data_baseDataSet = new Memoire_Project_4.sonelgaz_data_baseDataSet();
            this.sonelgazdatabaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sejourTableAdapter = new Memoire_Project_4.sonelgaz_data_baseDataSet1TableAdapters.SejourTableAdapter();
            this.buttonSignUpSejour = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSejour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sejourBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sonelgaz_data_baseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sonelgaz_data_baseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sonelgazdatabaseDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewSejour
            // 
            this.dataGridViewSejour.AllowUserToAddRows = false;
            this.dataGridViewSejour.AllowUserToDeleteRows = false;
            this.dataGridViewSejour.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewSejour.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewSejour.AutoGenerateColumns = false;
            this.dataGridViewSejour.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSejour.BackgroundColor = System.Drawing.Color.Silver;
            this.dataGridViewSejour.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(68)))), ((int)(((byte)(120)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(34)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSejour.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewSejour.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSejour.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codSejourDataGridViewTextBoxColumn,
            this.libSejourDataGridViewTextBoxColumn,
            this.datDebSejourDataGridViewTextBoxColumn,
            this.datFinSejourDataGridViewTextBoxColumn,
            this.mtVersDataGridViewTextBoxColumn});
            this.dataGridViewSejour.DataSource = this.sejourBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(24)))), ((int)(((byte)(36)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewSejour.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewSejour.EnableHeadersVisualStyles = false;
            this.dataGridViewSejour.Location = new System.Drawing.Point(27, 57);
            this.dataGridViewSejour.Name = "dataGridViewSejour";
            this.dataGridViewSejour.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSejour.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewSejour.RowHeadersVisible = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewSejour.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewSejour.Size = new System.Drawing.Size(891, 340);
            this.dataGridViewSejour.TabIndex = 1;
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
            this.libSejourDataGridViewTextBoxColumn.HeaderText = "Label de séjour";
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
            // sejourBindingSource
            // 
            this.sejourBindingSource.DataMember = "Sejour";
            this.sejourBindingSource.DataSource = this.sonelgaz_data_baseDataSet1;
            // 
            // sonelgaz_data_baseDataSet1
            // 
            this.sonelgaz_data_baseDataSet1.DataSetName = "sonelgaz_data_baseDataSet1";
            this.sonelgaz_data_baseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sonelgaz_data_baseDataSet
            // 
            this.sonelgaz_data_baseDataSet.DataSetName = "sonelgaz_data_baseDataSet";
            this.sonelgaz_data_baseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sonelgazdatabaseDataSetBindingSource
            // 
            this.sonelgazdatabaseDataSetBindingSource.DataSource = this.sonelgaz_data_baseDataSet;
            this.sonelgazdatabaseDataSetBindingSource.Position = 0;
            // 
            // sejourTableAdapter
            // 
            this.sejourTableAdapter.ClearBeforeFill = true;
            // 
            // buttonSignUpSejour
            // 
            this.buttonSignUpSejour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(146)))), ((int)(((byte)(39)))));
            this.buttonSignUpSejour.FlatAppearance.BorderSize = 0;
            this.buttonSignUpSejour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSignUpSejour.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSignUpSejour.Location = new System.Drawing.Point(821, 13);
            this.buttonSignUpSejour.Name = "buttonSignUpSejour";
            this.buttonSignUpSejour.Size = new System.Drawing.Size(97, 30);
            this.buttonSignUpSejour.TabIndex = 5;
            this.buttonSignUpSejour.Text = "S\'inscrire";
            this.buttonSignUpSejour.UseVisualStyleBackColor = false;
            this.buttonSignUpSejour.Click += new System.EventHandler(this.buttonSignUpSejour_Click);
            // 
            // E_SejoursForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(24)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(944, 672);
            this.Controls.Add(this.buttonSignUpSejour);
            this.Controls.Add(this.dataGridViewSejour);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "E_SejoursForm";
            this.Text = "EmployeeSejoursListeForm";
            this.Load += new System.EventHandler(this.EmployeeSejoursListeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSejour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sejourBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sonelgaz_data_baseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sonelgaz_data_baseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sonelgazdatabaseDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewSejour;
        private System.Windows.Forms.BindingSource sonelgazdatabaseDataSetBindingSource;
        private sonelgaz_data_baseDataSet sonelgaz_data_baseDataSet;
        private sonelgaz_data_baseDataSet1 sonelgaz_data_baseDataSet1;
        private System.Windows.Forms.BindingSource sejourBindingSource;
        private sonelgaz_data_baseDataSet1TableAdapters.SejourTableAdapter sejourTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codSejourDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn libSejourDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datDebSejourDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datFinSejourDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mtVersDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button buttonSignUpSejour;
    }
}