using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pjr_Capa_Datos
{
    public class BD_Conexion
    {
        
        public SqlConnection conectar()
        {
            return new SqlConnection("Data Source=LAPMASIEL;Initial Catalog=PrestamosDB;Integrated Security=true");
        }
    }
}
