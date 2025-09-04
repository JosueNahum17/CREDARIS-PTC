using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CapaPresentacion.Clases
{
    class conexion
    {
        SqlConnection connexion = new SqlConnection("Data Source=DESKTOP-4H1J6KQ;Initial Catalog=bd_sistema;Integrated Security=True");
    }
}
