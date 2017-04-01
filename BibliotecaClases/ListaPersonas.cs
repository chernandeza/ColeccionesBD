using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases
{
    public class ListaPersonas
    {
        private List<Persona> _padron;

        public List<Persona> Padron
        {
            get { return _padron; }
            set { _padron = value; }
        }

        public ListaPersonas()
        {
            this.Padron = new List<Persona>();
        }

        public bool AgregarAPadron(Persona per)
        {
            try
            {
                this.Padron.Add(per);
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
                this.Padron.Remove(per);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool EliminarEspacioPadron(int x)
        {
            try
            {
                this.Padron.RemoveAt(x);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
