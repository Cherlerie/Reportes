using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pjr_Capa_Datos
{
    public class CD_Perfil : BD_Conexion
    {
        public void EditarPerfil(int id, string usuarioPerfil, string contraseñaPerfil, string nombrePerfil, string apellidoPerfil, string mail, string direccionPerfil, string telefonoPerfil)
        {
            using (var connection = conectar()) 
            {
             connection.Open();
                using (var command = new SqlCommand()) 
                {
                    command.Connection = connection;
                    command.CommandText = "update user set" +
                        " Usuario=@usuarioPerfil , Contraseña=@contraseñaPerfil , Nombre=@nombrePerfil, Apellido=@apellidoPerfil, Correo=@mail, Direccion=@direccionPerfil, Telefono=@telefonoPerfil where ClienteID=@id";
                    command.Parameters.AddWithValues("@Usuario",usuarioPerfil);
                    command.Parameters.AddWithValues("@UContraseña", contraseñaPerfil);
                    command.Parameters.AddWithValues("@Nombre", nombrePerfil);
                    command.Parameters.AddWithValues("@Apellido",apellidoPerfil);
                    command.Parameters.AddWithValues("@Correo", mail);
                    command.Parameters.AddWithValues("@Direccion", direccionPerfil);
                    command.Parameters.AddWithValues("@Telefono", telefonoPerfil);
                    command.Parameters.AddWithValues("@ClienteID", id);
                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
