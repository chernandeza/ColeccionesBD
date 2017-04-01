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
    public partial class FormMostrarDatos : Form
    {
        public ListaPersonas miListaDesplegar;
        public DiccionarioPersonas miDiccionarioDesplegar;
        public ConexionBD cnx;

        public FormMostrarDatos()
        {
            InitializeComponent();
            miDiccionarioDesplegar = new DiccionarioPersonas();
            miListaDesplegar = new ListaPersonas();
        }

        public FormMostrarDatos(ListaPersonas lp, DiccionarioPersonas dp)
        {
            InitializeComponent();
            miDiccionarioDesplegar = new DiccionarioPersonas();
            cnx = new ConexionBD();
            miListaDesplegar = new ListaPersonas();
            miListaDesplegar = lp;
            miDiccionarioDesplegar = cnx.RetornarDicPersonas();
        }

        private void FormMostrarDatos_Load(object sender, EventArgs e)
        {
            dgvLista.DataSource = null;
            dgvLista.DataSource = this.miListaDesplegar.Padron;
            LoadTVData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        //Cargar en el treeview la lista de contactos del usuario
        private void LoadTVData()
        {
            try
            {
                List<TreeNode> Personas = new List<TreeNode>();
                
                TreeNode tnAdd;
                foreach (String fr in this.miDiccionarioDesplegar.PadronOrdenado.Keys)
                {
                    List<TreeNode> DatosPersona = new List<TreeNode>();
                    TreeNode nombre = new TreeNode(miDiccionarioDesplegar.PadronOrdenado[fr].Nombre, 1, 1);
                    TreeNode ID = new TreeNode(miDiccionarioDesplegar.PadronOrdenado[fr].ID.ToString(), 1, 1);
                    DatosPersona.Add(nombre);
                    DatosPersona.Add(ID);
                    tnAdd = new TreeNode(fr,DatosPersona.ToArray());
                    Personas.Add(tnAdd);
                }
                TreeNode mainNode = new TreeNode("Mis personas", Personas.ToArray());
                mainNode.ImageIndex = 0;
                tvContacts.Nodes.Clear();
                tvContacts.Nodes.Add(mainNode);
                tvContacts.TopNode.Expand();
                tvContacts.TopNode.ImageIndex = 0;
                tvContacts.SelectedNode = tvContacts.TopNode;
            }
            catch (Exception exc)
            {
                MessageBox.Show("ERROR: " + exc.Message);
            }
        }

    }
}
