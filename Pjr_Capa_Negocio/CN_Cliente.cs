using System.Data;
using Pjr_Capa_Datos;

namespace Pjr_Capa_Negocio
{
    public class CN_Cliente
    {
        private CD_Cliente cdCliente = new CD_Cliente();

        public DataTable BuscarCliente(string criterio)
        {
            return cdCliente.BuscarCliente(criterio);
        }

        public DataTable ObtenerClientes()
        {
            return cdCliente.ObtenerClientes();
        }
    }
}
