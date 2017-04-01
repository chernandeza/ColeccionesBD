using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploBD
{
    public partial class FormDatosBD : Form
    {
        public FormDatosBD()
        {
            InitializeComponent();
        }

        private void FormDatosBD_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBPersonasT3DataSet.Persona' table. You can move, or remove it, as needed.
            this.personaTableAdapter.Fill(this.dBPersonasT3DataSet.Persona);

        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            this.personaBindingSource.EndEdit();
            this.personaTableAdapter.Update(this.dBPersonasT3DataSet.Persona);
            MessageBox.Show("Actualizacion Exitosa!", "Ejemplo T3", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
