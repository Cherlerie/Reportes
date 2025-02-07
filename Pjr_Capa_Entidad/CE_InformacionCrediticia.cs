namespace Pjr_Capa_Entidad
{
    public class CE_InformacionCrediticia
    {
        public int ClienteID { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public string Usuario { get; set; }
        public decimal Sueldo { get; set; }
        public string Garantia { get; set; }
        public int NumeroPrestamos { get; set; }
        public decimal TotalPrestado { get; set; }
        public int MorasAcumuladas { get; set; }
    }
}

