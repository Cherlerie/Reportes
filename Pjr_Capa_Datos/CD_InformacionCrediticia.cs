using System;
using System.Data;
using System.Data.SqlClient;

namespace Pjr_Capa_Datos
{
    public class CD_InformacionCrediticia : BD_Conexion
    {
        public DataTable ObtenerInformacionCrediticia(int clienteID)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = conectar())
                {
                    string query = @"
                        SELECT 
                            c.ClienteID, 
                            c.Nombre, 
                            c.Apellido, 
                            c.Correo, 
                            c.Telefono, 
                            c.Direccion, 
                            c.Usuario, 
                            c.Sueldo, 
                            c.Garantia,
                            COUNT(p.PrestamoID) AS NumeroPrestamos,
                            ISNULL(SUM(p.MontoTotal), 0) AS TotalPrestado,
                            ISNULL((SELECT COUNT(*) FROM Moras m WHERE m.ClienteID = c.ClienteID AND m.CantidadMoras >= 1), 0) AS MorasAcumuladas
                        FROM Cliente c
                        LEFT JOIN Prestamo p ON c.ClienteID = p.ClienteID
                        WHERE c.ClienteID = @ClienteID
                        GROUP BY c.ClienteID, c.Nombre, c.Apellido, c.Correo, c.Telefono, c.Direccion, c.Usuario, c.Sueldo, c.Garantia";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@ClienteID", clienteID);
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            adapter.Fill(dt);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener la información crediticia: " + ex.Message);
            }
            return dt;
        }
    }
}
