using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows;

namespace CapaPresentacion.Clases
{
    class CConexion
    {
        private string Base;
        private string Servidor;
        private static CConexion Con = null;

        private CConexion() {

            this.Servidor = "(localdb)\\MSSQLLocalDB";
            this.Base = "CREDARIS";
        }
 
    
        public SqlConnection crearConexion()
        {
            SqlConnection cadena = new SqlConnection();

            try
            {
                cadena.ConnectionString = "Server=" + this.Servidor +
                                          ";DataBase=" + this.Base;

            }
            catch (Exception e)
            { 
                cadena = null;
                throw e;
            }


            return cadena;
        }

        public static CConexion getInstancia()
        {
            if (Con == null) { 
                Con = new CConexion();
            }
            return Con;
        }
    }
}
