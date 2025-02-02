using System.Data;
using Pjr_Capa_Datos;

namespace Pjr_Capa_Negocio
{
    public class CN_Pagos
    {
        private CD_Pagos cdPagos = new CD_Pagos();

        public bool RegistrarPago(int clienteID, int prestamoID, decimal montoPago)
        {
            // Aquí podrías agregar lógica adicional, por ejemplo, validar que el monto no sea negativo.
            return cdPagos.RegistrarPago(clienteID, prestamoID, montoPago);
        }

        public DataTable ObtenerHistorialPagos(int prestamoID)
        {
            return cdPagos.ObtenerHistorialPagos(prestamoID);
        }
    }
}
