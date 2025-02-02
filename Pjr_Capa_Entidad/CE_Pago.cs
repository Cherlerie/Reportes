using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pjr_Capa_Entidad
{
    public class CE_Pago
    {

        public int PagoID { get; set; }
        public int ClienteID { get; set; }
        public int PrestamoID { get; set; }
        public decimal MontoAnterior { get; set; }    // Saldo del préstamo antes del pago
        public decimal InteresPagado { get; set; }      // Interés pagado en este abono
        public decimal InteresAPagar { get; set; }      // Interés que se debía pagar
        public decimal MontoAbonado { get; set; }       // Monto abonado (puede incluir mora)
        public decimal MontoPendiente { get; set; }     // Nuevo saldo pendiente tras el pago
        public System.DateTime FechaPago { get; set; }

    }
}
