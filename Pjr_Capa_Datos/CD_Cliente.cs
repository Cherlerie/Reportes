using System;
using System.Data;
using System.Data.SqlClient;

namespace Pjr_Capa_Datos
{
    public class CD_Cliente : BD_Conexion
    {
        public DataTable BuscarCliente(string criterio)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = conectar())
                {
                    string query = @"
                        SELECT ClienteID, Nombre, Apellido, Correo, Telefono, Direccion, Usuario, Sueldo, Garantia
                        FROM Cliente
                        WHERE CAST(ClienteID AS NVARCHAR(50)) LIKE '%' + @Criterio + '%'
                           OR Nombre LIKE '%' + @Criterio + '%'
                           OR Apellido LIKE '%' + @Criterio + '%'";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@Criterio", criterio);
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            adapter.Fill(dt);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al buscar clientes: " + ex.Message);
            }
            return dt;
        }
    }
}
