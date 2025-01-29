using Pjr_Capa_Datos;
using Pjr_Capa_Entidad;

namespace Pjr_Capa_Negocio
{
    public class CN_Perfil
    {
        public CD_Perfil cdPerfil = new CD_Perfil();

       

        public CE_perfil ObtenerPerfil(int id)
        {
            return cdPerfil.ObtenerPerfil(id);
        }
    }
}
