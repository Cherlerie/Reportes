using System;
using System.Data;
using System.Data.SqlClient;
using Pjr_Capa_Entidad;

namespace Pjr_Capa_Datos
{
    public class CD_Prestamo : BD_Conexion
    {
        
        public bool InsertarPrestamo(CE_Prestamo prestamo)
        {
            try
            {
                using (SqlConnection connection = conectar())
                {
                    connection.Open();
                    string query = @"
                        INSERT INTO Prestamo 
                        (ClienteID, MontoPrestamo, TiempoMeses, InteresGenerado, MontoTotal, MontoPendiente, FechaInicio, ProximaFechaPago)
                        VALUES 
                        (@ClienteID, @MontoPrestamo, @TiempoMeses, @InteresGenerado, @MontoTotal, @MontoPendiente, @FechaInicio, @ProximaFechaPago)";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@ClienteID", prestamo.ClienteID);
                        cmd.Parameters.AddWithValue("@MontoPrestamo", prestamo.MontoPrestamo);
                        cmd.Parameters.AddWithValue("@TiempoMeses", prestamo.TiempoMeses);
                        cmd.Parameters.AddWithValue("@InteresGenerado", prestamo.InteresGenerado);
                        cmd.Parameters.AddWithValue("@MontoTotal", prestamo.MontoTotal);
                        cmd.Parameters.AddWithValue("@MontoPendiente", prestamo.MontoPendiente);
                        cmd.Parameters.AddWithValue("@FechaInicio", prestamo.FechaInicio);
                        cmd.Parameters.AddWithValue("@ProximaFechaPago", prestamo.ProximaFechaPago);
                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar el préstamo: " + ex.Message);
            }
        }

        public DataTable ObtenerPrestamosPorCliente(int clienteID)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = conectar())
                {
                    string query = @"
                        SELECT 
                            PrestamoID, 
                            MontoPrestamo, 
                            TiempoMeses, 
                            InteresGenerado, 
                            MontoTotal, 
                            MontoPendiente, 
                            FechaInicio, 
                            ProximaFechaPago,
                            CAST(PrestamoID AS NVARCHAR(50)) + ' - Monto: ' + CONVERT(NVARCHAR(50), MontoPrestamo) AS Descripcion
                        FROM Prestamo 
                        WHERE ClienteID = @ClienteID";

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
                throw new Exception("Error al obtener préstamos por cliente: " + ex.Message);
            }
            return dt;
        }
        public DataTable ObtenerTodosLosPrestamos()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = conectar())
                {
                    string query = @"
                        SELECT 
                            PrestamoID, 
                            ClienteID,
                            MontoPrestamo, 
                            TiempoMeses, 
                            InteresGenerado, 
                            MontoTotal, 
                            MontoPendiente, 
                            FechaInicio, 
                            ProximaFechaPago
                        FROM Prestamo";

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
                throw new Exception("Error al obtener todos los préstamos: " + ex.Message);
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
