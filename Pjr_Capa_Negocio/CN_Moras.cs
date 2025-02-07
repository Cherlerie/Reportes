using System.Data;
using Pjr_Capa_Datos;

namespace Pjr_Capa_Negocio
{
    public class CN_Moras
    {
        private CD_Moras cdMoras = new CD_Moras();

        public DataTable BuscarMorosos(string criterio)
        {
            return cdMoras.BuscarMorosos(criterio);
        }

        public DataTable ObtenerMoras(int clienteID)
        {
            return cdMoras.ObtenerMorasPorCliente(clienteID);
        }
    }
}
