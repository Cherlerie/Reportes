using System.Data;
using Pjr_Capa_Datos;

namespace Pjr_Capa_Negocio
{
    public class CN_Prestamo
    {
        private CD_Prestamo cdPrestamo = new CD_Prestamo();

        public DataTable ObtenerPrestamosPorCliente(int clienteID)
        {
            return cdPrestamo.ObtenerPrestamosPorCliente(clienteID);
        }

        public DataRow ObtenerDetallePrestamo(int prestamoID)
        {
            return cdPrestamo.ObtenerDetallePrestamo(prestamoID);
        }
    }
}
