using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases
{
    public class Persona
    {

        private int _numID;

        public int ID
        {
            get { return _numID; }
            set { _numID = value; }
        }

        private String _cedula;

        public String Cedula
        {
            get { return _cedula; }
            set { _cedula = value; }
        }

        private String _nombre;

        public String Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public Persona()
        {
            this._cedula = "";
            this._nombre = "";
        }

        public Persona(String ced, String nom)
        {
            this.Cedula = ced;
            this.Nombre = nom;
        }
    }
}
