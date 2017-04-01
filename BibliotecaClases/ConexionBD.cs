using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace BibliotecaClases
{
    public class ConexionBD
    {
        private SqlConnectionStringBuilder ConnectionStr;
        private SqlConnection DBConnection;
        private SqlCommand SQLcmdSP;

        public ConexionBD()
        {
            ConnectionStr = new SqlConnectionStringBuilder();
            ConnectionStr.DataSource = ".\\SQLEXPRESS";
            ConnectionStr.InitialCatalog = "DBPersonasT3";
            ConnectionStr.IntegratedSecurity = true;
            DBConnection = new SqlConnection(ConnectionStr.ConnectionString);
        }

        public DiccionarioPersonas RetornarDicPersonas()
        {
            DiccionarioPersonas resultado = new DiccionarioPersonas();
            SqlDataReader lectorDatos;
            try
            {
                SQLcmdSP = new SqlCommand();
                SQLcmdSP.CommandText = "sp_ObtenerPersonas";
                SQLcmdSP.CommandType = CommandType.StoredProcedure;
                SQLcmdSP.Connection = DBConnection;
                DBConnection.Open();

                lectorDatos = SQLcmdSP.ExecuteReader();

                if (lectorDatos.HasRows)
                {
                    while (lectorDatos.Read())
                    {
                        Persona p = new Persona();
                        p.ID = lectorDatos.GetInt32(0);
                        p.Cedula = lectorDatos.GetString(1);
                        p.Nombre = lectorDatos.GetString(2);
                        resultado.AgregarAPadron(p);
                    }
                }
                return resultado;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
