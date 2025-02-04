using System;
using System.Data;
using System.Data.SqlClient;

namespace Pjr_Capa_Datos
{
    public class CD_Amortizacion : BD_Conexion
    {
        public DataTable ObtenerAmortizacion(int prestamoID)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = conectar())
                {
                    using (SqlCommand cmd = new SqlCommand("sp_ObtenerAmortizacion", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
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
                throw new Exception("Error al obtener la amortización: " + ex.Message);
            }
            return dt;
        }
    }
}
