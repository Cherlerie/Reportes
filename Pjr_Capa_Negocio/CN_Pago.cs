using System;
using System.Data;
using Pjr_Capa_Datos;

namespace Pjr_Capa_Negocio
{
    public class CN_Pagos
    {
        private CD_Pagos cdPagos = new CD_Pagos();

        public bool RegistrarPago(int clienteID, int prestamoID, decimal montoPago)
        {
            return cdPagos.RegistrarPago(clienteID, prestamoID, montoPago);
        }

        public DataTable ObtenerHistorialPagos(int prestamoID)
        {
            return cdPagos.ObtenerHistorialPagos(prestamoID);
        }

        public DataTable ObtenerPagos(int clienteID)
        {
            return cdPagos.ObtenerPagos(clienteID);
        }

        public void RegistrarPago1(Pago pago)
        {
            if (pago.MontoAbonado <= 0)
                throw new Exception("El monto abonado debe ser mayor a 0.");

            cdPagos.RegistrarPago1(pago);
        }
    }
}
