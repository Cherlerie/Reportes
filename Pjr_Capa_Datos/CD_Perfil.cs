using System;
using System.Data;
using System.Data.SqlClient;
using Pjr_Capa_Entidad;

namespace Pjr_Capa_Datos
{
    public class CD_Perfil : BD_Conexion
    {
        public bool EditarPerfil(int id, string usuarioPerfil, string contraseñaPerfil, string nombrePerfil, string apellidoPerfil, string mail, string direccionPerfil, string telefonoPerfil)
        {
            try
            {
                using (var connection = conectar())
                {
                    connection.Open();
                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "UPDATE Cliente SET " +
    "Usuario=@Usuario, Contraseña=@Contraseña, Nombre=@Nombre, Apellido=@Apellido, Correo=@Correo, Direccion=@Direccion, Telefono=@Telefono " +
    "WHERE ClienteID=@ClienteID";

                        command.Parameters.AddWithValue("@Usuario", usuarioPerfil);
                        command.Parameters.AddWithValue("@Contraseña", contraseñaPerfil);
                        command.Parameters.AddWithValue("@Nombre", nombrePerfil);
                        command.Parameters.AddWithValue("@Apellido", apellidoPerfil);
                        command.Parameters.AddWithValue("@Correo", mail);
                        command.Parameters.AddWithValue("@Direccion", direccionPerfil);
                        command.Parameters.AddWithValue("@Telefono", telefonoPerfil);
                        command.Parameters.AddWithValue("@ClienteID", id);

                        command.CommandType = CommandType.Text;
                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0; 
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al actualizar el perfil: " + ex.Message);
                return false;
            }
        }

        public CE_perfil ObtenerPerfil(int id)
        {
            CE_perfil perfil = null;
            try
            {
                using (var connection = conectar())
                {
                    connection.Open();
                    using (var command = new SqlCommand("SELECT ClienteID, Nombre, Apellido, Contraseña, Telefono, Direccion, Correo FROM CLiente WHERE ClienteID = @ClienteID", connection))
                    {
                        command.Parameters.AddWithValue("@ClienteID", id);
                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                perfil = new CE_perfil
                                {
                                    ClienteID1 = reader.GetInt32(0),
                                    Nombre1 = reader.GetString(1),
                                    Apellido1 = reader.GetString(2),
                                    Contraseña1 = reader.GetString(3),
                                    Telefono1 = reader.GetString(4),
                                    Direccion1 = reader.GetString(5),
                                    Correo = reader.GetString(6)
                                };
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener el perfil: " + ex.Message);
            }
            return perfil;
        }
    }
}

