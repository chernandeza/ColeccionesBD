namespace EjemploSortedDictionary
{
    partial class FormCapturaDatos
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCedula = new System.Windows.Forms.MaskedTextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnObservarDatos = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAgregar);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.txtCedula);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(302, 164);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de la persona";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cedula";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre Completo";
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(174, 36);
            this.txtCedula.Mask = "0-0000-0000";
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(122, 20);
            this.txtCedula.TabIndex = 2;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(107, 70);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(189, 20);
            this.txtNombre.TabIndex = 3;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(90, 120);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(118, 23);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Agregar Persona";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnObservarDatos
            // 
            this.btnObservarDatos.Location = new System.Drawing.Point(83, 199);
            this.btnObservarDatos.Name = "btnObservarDatos";
            this.btnObservarDatos.Size = new System.Drawing.Size(157, 23);
            this.btnObservarDatos.TabIndex = 1;
            this.btnObservarDatos.Text = "Observar Datos";
            this.btnObservarDatos.UseVisualStyleBackColor = true;
            this.btnObservarDatos.Click += new System.EventHandler(this.btnObservarDatos_Click);
            // 
            // FormCapturaDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 234);
            this.Controls.Add(this.btnObservarDatos);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormCapturaDatos";
            this.Text = "Captura datos de personas";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.MaskedTextBox txtCedula;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnObservarDatos;
    }
}

