using System;
using System.Data;
using System.Data.SqlClient;
using Pjr_Capa_Entidad;

namespace Pjr_Capa_Datos
{
    public class CD_Pagos : BD_Conexion
    {
        public bool RegistrarPago(int clienteID, int prestamoID, decimal montoPago)
        {
            try
            {
                using (SqlConnection connection = conectar())
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand("sp_RegistrarPago", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@ClienteID", clienteID);
                        cmd.Parameters.AddWithValue("@PrestamoID", prestamoID);
                        cmd.Parameters.AddWithValue("@MontoPago", montoPago);
                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al registrar el pago: " + ex.Message);
            }
        }

        public DataTable ObtenerHistorialPagos(int prestamoID)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = conectar())
                {
                    string query = "SELECT * FROM Pagos WHERE PrestamoID = @PrestamoID ORDER BY FechaPago";
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@PrestamoID", prestamoID);
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            adapter.Fill(dt);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener historial de pagos: " + ex.Message);
            }
            return dt;
        }
    }
}
