namespace EjemploBD
{
    partial class FormDatosBD
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.dBPersonasT3DataSet = new EjemploBD.DBPersonasT3DataSet();
            this.personaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personaTableAdapter = new EjemploBD.DBPersonasT3DataSetTableAdapters.PersonaTableAdapter();
            this.cedulaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBPersonasT3DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cedulaDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.personaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(468, 177);
            this.dataGridView1.TabIndex = 0;
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Location = new System.Drawing.Point(179, 196);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(126, 47);
            this.btn_Guardar.TabIndex = 1;
            this.btn_Guardar.Text = "Guardar Datos";
            this.btn_Guardar.UseVisualStyleBackColor = true;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // dBPersonasT3DataSet
            // 
            this.dBPersonasT3DataSet.DataSetName = "DBPersonasT3DataSet";
            this.dBPersonasT3DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // personaBindingSource
            // 
            this.personaBindingSource.DataMember = "Persona";
            this.personaBindingSource.DataSource = this.dBPersonasT3DataSet;
            // 
            // personaTableAdapter
            // 
            this.personaTableAdapter.ClearBeforeFill = true;
            // 
            // cedulaDataGridViewTextBoxColumn
            // 
            this.cedulaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cedulaDataGridViewTextBoxColumn.DataPropertyName = "Cedula";
            this.cedulaDataGridViewTextBoxColumn.HeaderText = "Numero de Cedula";
            this.cedulaDataGridViewTextBoxColumn.Name = "cedulaDataGridViewTextBoxColumn";
            this.cedulaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre Completo";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // FormDatosBD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 248);
            this.Controls.Add(this.btn_Guardar);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormDatosBD";
            this.Text = "ADO .NET en Visual Studio";
            this.Load += new System.EventHandler(this.FormDatosBD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBPersonasT3DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_Guardar;
        private DBPersonasT3DataSet dBPersonasT3DataSet;
        private System.Windows.Forms.BindingSource personaBindingSource;
        private DBPersonasT3DataSetTableAdapters.PersonaTableAdapter personaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cedulaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
    }
}

