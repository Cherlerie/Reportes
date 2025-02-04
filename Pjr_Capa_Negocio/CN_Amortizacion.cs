using System.Data;
using Pjr_Capa_Datos;

namespace Pjr_Capa_Negocio
{
    public class CN_Amortizacion
    {
        private CD_Amortizacion cdAmortizacion = new CD_Amortizacion();

        public DataTable ObtenerAmortizacion(int prestamoID)
        {
            return cdAmortizacion.ObtenerAmortizacion(prestamoID);
        }
    }
}
