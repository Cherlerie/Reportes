namespace Pjr_Capa_Entidad
{
    public class CE_Prestamo
    {
        public int PrestamoID { get; set; }
        public int ClienteID { get; set; }
        public decimal MontoPrestamo { get; set; }
        public int TiempoMeses { get; set; }
        public decimal InteresGenerado { get; set; }
        public decimal MontoTotal { get; set; }
        public decimal MontoPendiente { get; set; }
        public System.DateTime FechaInicio { get; set; }
        public System.DateTime ProximaFechaPago { get; set; }
    }
}
