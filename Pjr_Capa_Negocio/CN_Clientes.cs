using System.Data;
using Pjr_Capa_Datos;

namespace Pjr_Capa_Negocio
{
    public class CN_Clientes
    {
        private CD_Clientes cdCliente = new CD_Clientes();

        public DataTable ObtenerClientes()
        {
            return cdCliente.ObtenerClientes();
        }
    }
}
