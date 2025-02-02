using System;
using System.Data;
using System.Data.SqlClient;
using Pjr_Capa_Entidad;

namespace Pjr_Capa_Datos
{
    public class CD_Perfil : BD_Conexion
    {
        public CE_perfil ObtenerPerfil(int id)
        {
            CE_perfil perfil = null;
            try
            {
                using (SqlConnection connection = conectar())
                {
                    string query = "SELECT ClienteID, Nombre, Apellido, Contraseña, Telefono, Direccion, Correo, Usuario FROM Cliente WHERE ClienteID = @ClienteID";
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@ClienteID", id);
                        connection.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                perfil = new CE_perfil
                                {
                                    ClienteID1 = reader.GetInt32(reader.GetOrdinal("ClienteID")),
                                    Nombre1 = reader.GetString(reader.GetOrdinal("Nombre")),
                                    Apellido1 = reader.GetString(reader.GetOrdinal("Apellido")),
                                    Contraseña1 = reader.GetString(reader.GetOrdinal("Contraseña")),
                                    Telefono1 = reader.GetString(reader.GetOrdinal("Telefono")),
                                    Direccion1 = reader.GetString(reader.GetOrdinal("Direccion")),
                                    Correo = reader.GetString(reader.GetOrdinal("Correo")),
                                    Usuario1 = reader.GetString(reader.GetOrdinal("Usuario"))
                                };
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el perfil: " + ex.Message);
            }
            return perfil;
        }

        public bool EditarPerfil(int id, string usuarioPerfil, string contraseñaPerfil, string nombrePerfil, string apellidoPerfil, string mail, string direccionPerfil, string telefonoPerfil)
        {
            try
            {
                using (SqlConnection connection = conectar())
                {
                    connection.Open();
                    string query = "UPDATE Cliente SET Usuario = @Usuario, Contraseña = @Contraseña, Nombre = @Nombre, Apellido = @Apellido, Correo = @Correo, Direccion = @Direccion, Telefono = @Telefono WHERE ClienteID = @ClienteID";
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@Usuario", usuarioPerfil);
                        cmd.Parameters.AddWithValue("@Contraseña", contraseñaPerfil);
                        cmd.Parameters.AddWithValue("@Nombre", nombrePerfil);
                        cmd.Parameters.AddWithValue("@Apellido", apellidoPerfil);
                        cmd.Parameters.AddWithValue("@Correo", mail);
                        cmd.Parameters.AddWithValue("@Direccion", direccionPerfil);
                        cmd.Parameters.AddWithValue("@Telefono", telefonoPerfil);
                        cmd.Parameters.AddWithValue("@ClienteID", id);
                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al editar el perfil: " + ex.Message);
            }
        }
    }
}
