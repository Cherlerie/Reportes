using System;
using System.Data;
using System.Data.SqlClient;
using Pjr_Capa_Entidad;

namespace Pjr_Capa_Datos
{
    public class CD_Prestamo : BD_Conexion
    {
        public DataTable ObtenerPrestamosPorCliente(int clienteID)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = conectar())
                {
                    string query = "SELECT PrestamoID, MontoPrestamo, TiempoMeses, InteresGenerado, MontoTotal, MontoPendiente, FechaInicio, ProximaFechaPago FROM Prestamo WHERE ClienteID = @ClienteID";
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
                throw new Exception("Error al obtener los préstamos: " + ex.Message);
            }
            return dt;
        }

        public DataRow ObtenerDetallePrestamo(int prestamoID)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = conectar())
                {
                    string query = "SELECT * FROM Prestamo WHERE PrestamoID = @PrestamoID";
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
                throw new Exception("Error al obtener el detalle del préstamo: " + ex.Message);
            }
            if (dt.Rows.Count > 0)
                return dt.Rows[0];
            else
                return null;
        }
    }
}
