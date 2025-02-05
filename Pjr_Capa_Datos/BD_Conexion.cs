using System;
using System.Data.SqlClient;

namespace Pjr_Capa_Datos
{
    public class BD_Conexion
    {
        
        private string connectionString = "Data Source=localhost;Initial Catalog=Prestamosdatabase;Integrated Security=true";
       // private string connectionString2 = "Data Source = NayelisNin\\SQLEXPRESS;Initial Catalog = Prestamosdatabase; Integrated Security = True;";
        protected SqlConnection conectar()
        {
            return new SqlConnection(connectionString);
        }
    }
}
