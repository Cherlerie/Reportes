using System;
using System.Data;
using System.Data.SqlClient;

namespace Pjr_Capa_Datos
{
    public class CD_Moras : BD_Conexion
    {
        public DataTable BuscarMorosos(string criterio)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = conectar())
                {
                    string query = @"
                        SELECT 
                            m.ClienteID, 
                            c.Nombre, 
                            c.Apellido, 
                            m.CantidadMoras
                        FROM Moras m
                        INNER JOIN Cliente c ON m.ClienteID = c.ClienteID
                        WHERE CAST(m.ClienteID AS NVARCHAR(50)) LIKE '%' + @Criterio + '%'
                           OR c.Nombre LIKE '%' + @Criterio + '%'
                           OR c.Apellido LIKE '%' + @Criterio + '%'";

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
                throw new Exception("Error al buscar morosos: " + ex.Message);
            }
            return dt;
        }

        public DataTable ObtenerMorasPorCliente(int clienteID)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection conn = conectar())
                {
                    conn.Open();
                    string query = "SELECT MoraID, ClienteID, CantidadMoras FROM Moras WHERE ClienteID = @ClienteID";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ClienteID", clienteID);
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        da.Fill(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener las moras: " + ex.Message);
            }
            return dt;
        }
    }

}
