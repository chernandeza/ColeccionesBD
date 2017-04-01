using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BibliotecaClases;

namespace EjemploSortedDictionary
{
    public partial class FormCapturaDatos : Form
    {
        ListaPersonas miLista;
        DiccionarioPersonas miDiccionario;

        public FormCapturaDatos()
        {
            InitializeComponent();
            miDiccionario = new DiccionarioPersonas();
            miLista = new ListaPersonas();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtCedula.Text == "" || txtNombre.Text == "")
            {
                MessageBox.Show("Debe llenar todos los datos", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Persona nueva = new Persona(txtCedula.Text, txtNombre.Text);
                miLista.AgregarAPadron(nueva);
                miDiccionario.AgregarAPadron(nueva);
                txtNombre.Text = "";
                txtCedula.Text = "";
                MessageBox.Show("Se agrego la informacion de la persona", "Padron", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnObservarDatos_Click(object sender, EventArgs e)
        {
            FormMostrarDatos formMostrar = new FormMostrarDatos(miLista, miDiccionario);
            formMostrar.ShowDialog();
            if (formMostrar.DialogResult == DialogResult.OK)
            {
                MessageBox.Show("Datos Mostrados Correctamente", "Captura Datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
