﻿using System.Data.SqlClient;

namespace Pjr_Capa_Datos
{
    public class BD_Conexion
    {
        private string connectionString = "Data Source=LAPMASIEL;Initial Catalog=Prestamosdatabase;Integrated Security=true";

        protected SqlConnection conectar()
        {
            return new SqlConnection(connectionString);
        }
    }
}
