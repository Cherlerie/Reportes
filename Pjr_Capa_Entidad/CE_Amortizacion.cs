using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pjr_Capa_Entidad
{
    public class CE_Amortizacion
    {
        public int AmortizacionID { get; set; }
        public int PrestamoID { get; set; }
        public int NumeroCuota { get; set; }            // Número de cuota (1, 2, 3, ...)
        public decimal Cuota { get; set; }              // Cuota mensual fija
        public decimal Interes { get; set; }            // Interés correspondiente a esta cuota
        public decimal AmortizacionCapital { get; set; }  // Monto que se abona al capital
        public decimal SaldoPendiente { get; set; }       // Saldo que queda pendiente tras esta cuota
        public System.DateTime FechaCuota { get; set; }   // Fecha de vencimiento de la cuota
    }
}

