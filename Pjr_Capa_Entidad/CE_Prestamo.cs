using System;

namespace Pjr_Capa_Entidad
{
    public class CE_Prestamo
    {
        public int PrestamoID { get; set; }
        public int ClienteID { get; set; }
        public decimal MontoPrestamo { get; set; }    // Capital adquirido
        public int TiempoMeses { get; set; }            // Plazo del préstamo (en meses)
        public decimal InteresGenerado { get; set; }    // Interés calculado para el préstamo
        public decimal MontoTotal { get; set; }         // Suma de capital + interés
        public decimal MontoPendiente { get; set; }     // Monto que aún debe pagarse
        public System.DateTime FechaInicio { get; set; }
        public System.DateTime ProximaFechaPago { get; set; }
    }
}