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
        public int NumeroCuota { get; set; }            
        public decimal Cuota { get; set; }              
        public decimal Interes { get; set; }            
        public decimal AmortizacionCapital { get; set; }  
        public decimal SaldoPendiente { get; set; }       
        public System.DateTime FechaCuota { get; set; }   
    }
}

