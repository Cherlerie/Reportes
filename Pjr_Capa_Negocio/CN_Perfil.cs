using Pjr_Capa_Datos;
using Pjr_Capa_Entidad;

namespace Pjr_Capa_Negocio
{
    public class CN_Perfil
    {
        public CD_Perfil cdPerfil = new CD_Perfil();

        public bool EditarPerfil(CE_perfil perfil)
        {
            return cdPerfil.EditarPerfil(perfil.ClienteID1, perfil.Nombre1, perfil.Apellido1, perfil.Contraseña1, perfil.Correo, perfil.Direccion1, perfil.Telefono1);
        }

        public CE_perfil ObtenerPerfil(int id)
        {
            return cdPerfil.ObtenerPerfil(id);
        }
    }
}
