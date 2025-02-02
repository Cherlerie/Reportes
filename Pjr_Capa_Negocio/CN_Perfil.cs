using Pjr_Capa_Datos;
using Pjr_Capa_Entidad;

namespace Pjr_Capa_Negocio
{
    public class CN_Perfil
    {
        private CD_Perfil cdPerfil = new CD_Perfil();

        public CE_perfil ObtenerPerfil(int id)
        {
            return cdPerfil.ObtenerPerfil(id);
        }

        public bool EditarPerfil(CE_perfil perfil)
        {
            // Se envían 8 parámetros: id, usuario, contraseña, nombre, apellido, correo, dirección y teléfono.
            return cdPerfil.EditarPerfil(
                perfil.ClienteID1,
                perfil.Usuario1,          // Ahora se incluye el valor del usuario
                perfil.Contraseña1,
                perfil.Nombre1,
                perfil.Apellido1,
                perfil.Correo,
                perfil.Direccion1,
                perfil.Telefono1
            );
        }
    }
}



