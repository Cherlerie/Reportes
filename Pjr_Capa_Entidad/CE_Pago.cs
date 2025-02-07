using System;

public class Pago
{
    public int PagoID { get; set; }
    public int ClienteID { get; set; }
    public int PrestamoID { get; set; }
    public decimal MontoAnterior { get; set; }
    public decimal InteresPagado { get; set; }
    public decimal InteresAPagar { get; set; }
    public decimal MontoAbonado { get; set; }
    public decimal MontoPendiente { get; set; }
    public DateTime FechaPago { get; set; }
}

