using System;
using System.Data;
using System.Data.SqlClient;

namespace Pjr_Capa_Datos
{
    public class CD_Clientes : BD_Conexion
    {
        public DataTable ObtenerClientes()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = conectar())
                {
                    string query = "SELECT ClienteID, Nombre, Apellido FROM Cliente";
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            adapter.Fill(dt);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener los clientes: " + ex.Message);
            }
            return dt;
        }
    }
}

