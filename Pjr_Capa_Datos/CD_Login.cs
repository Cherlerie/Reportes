using System;
using System.Data;
using System.Data.SqlClient;
using Pjr_Capa_Entidad;

namespace Pjr_Capa_Datos
{
    public class CD_Login : BD_Conexion
    {
        
        public (string Rol, int ClienteID) ValidarUsuario(string usuario, string contraseña)
        {
            int clienteID = 0;
            string rol = null;
            try
            {
                using (SqlConnection connection = conectar())
                {
                    using (SqlCommand cmd = new SqlCommand("sp_login", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Usuario", usuario);
                        cmd.Parameters.AddWithValue("@Contraseña", contraseña);
                        connection.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                clienteID = reader.GetInt32(reader.GetOrdinal("ClienteID"));
                                rol = reader.GetString(reader.GetOrdinal("Rol"));
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al validar el usuario: " + ex.Message);
            }
            return (rol, clienteID);
        }
    }
}

