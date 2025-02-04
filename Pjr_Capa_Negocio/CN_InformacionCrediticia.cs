using System.Data;
using Pjr_Capa_Datos;

namespace Pjr_Capa_Negocio
{
    public class CN_InformacionCrediticia
    {
        private CD_InformacionCrediticia cdInfo = new CD_InformacionCrediticia();

        public DataTable ObtenerInformacionCrediticia(int clienteID)
        {
            return cdInfo.ObtenerInformacionCrediticia(clienteID);
        }
    }
}

