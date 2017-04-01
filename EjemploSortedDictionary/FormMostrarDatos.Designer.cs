namespace EjemploSortedDictionary
{
    partial class FormMostrarDatos
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.dgvLista = new System.Windows.Forms.DataGridView();
            this.tvContacts = new System.Windows.Forms.TreeView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvLista);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(270, 233);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informacion de Lista";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tvContacts);
            this.groupBox2.Location = new System.Drawing.Point(299, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(276, 233);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informacion de Diccionario";
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(222, 252);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(137, 40);
            this.btnVolver.TabIndex = 2;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvLista
            // 
            this.dgvLista.AllowUserToAddRows = false;
            this.dgvLista.AllowUserToDeleteRows = false;
            this.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLista.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLista.Location = new System.Drawing.Point(3, 16);
            this.dgvLista.Name = "dgvLista";
            this.dgvLista.ReadOnly = true;
            this.dgvLista.Size = new System.Drawing.Size(264, 214);
            this.dgvLista.TabIndex = 0;
            // 
            // tvContacts
            // 
            this.tvContacts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvContacts.Location = new System.Drawing.Point(3, 16);
            this.tvContacts.Name = "tvContacts";
            this.tvContacts.Size = new System.Drawing.Size(270, 214);
            this.tvContacts.TabIndex = 0;
            // 
            // FormMostrarDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 304);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormMostrarDatos";
            this.Text = "Mostrar Datos";
            this.Load += new System.EventHandler(this.FormMostrarDatos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.DataGridView dgvLista;
        private System.Windows.Forms.TreeView tvContacts;
    }
}