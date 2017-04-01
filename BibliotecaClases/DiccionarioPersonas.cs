using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases
{
    public class DiccionarioPersonas
    {
        private SortedDictionary<String, Persona> _padronOrd;

        public SortedDictionary<String, Persona> PadronOrdenado
        {
            get { return _padronOrd; }
            set { _padronOrd = value; }
        }

        public DiccionarioPersonas()
        {
            this.PadronOrdenado = new SortedDictionary<String, Persona>();
        }

        public bool AgregarAPadron(Persona per)
        {
            try
            {
                this.PadronOrdenado.Add(per.Cedula, per);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool EliminarDePadron(Persona per)
        {
            try
            {
                this.PadronOrdenado.Remove(per.Cedula);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
