using System;
using System.Data;
using Pjr_Capa_Datos;
using Pjr_Capa_Entidad;

namespace Pjr_Capa_Negocio
{
    public class CN_Prestamo
    {
        private CD_Prestamo cdPrestamo = new CD_Prestamo();

        public bool InsertarPrestamo(CE_Prestamo prestamo, decimal sueldo, string garantia)
        {
            if (prestamo.MontoPrestamo > sueldo * 4)
            {
                throw new Exception("El monto del préstamo no puede ser mayor a 4 veces el sueldo.");
            }
            if (string.IsNullOrEmpty(garantia))
            {
                throw new Exception("Debe proporcionar una garantía para el préstamo.");
            }

            decimal tasaAnual = 0;
            if (prestamo.TiempoMeses >= 1 && prestamo.TiempoMeses <= 3)
                tasaAnual = 0.10m;
            else if (prestamo.TiempoMeses >= 4 && prestamo.TiempoMeses <= 6)
                tasaAnual = 0.08m;
            else if (prestamo.TiempoMeses >= 7 && prestamo.TiempoMeses <= 12)
                tasaAnual = 0.07m;
            else if (prestamo.TiempoMeses > 12)
                tasaAnual = 0.05m;


            decimal tiempoAnios = prestamo.TiempoMeses / 12.0m;
            prestamo.InteresGenerado = prestamo.MontoPrestamo * tasaAnual * tiempoAnios;
            prestamo.MontoTotal = prestamo.MontoPrestamo + prestamo.InteresGenerado;
            prestamo.MontoPendiente = prestamo.MontoTotal;
            prestamo.FechaInicio = DateTime.Now;
            prestamo.ProximaFechaPago = DateTime.Now.AddDays(30);

            return cdPrestamo.InsertarPrestamo(prestamo);
        }

        public DataTable ObtenerPrestamosPorCliente(int clienteID)
        {
            return cdPrestamo.ObtenerPrestamosPorCliente(clienteID);
        }

        public DataRow ObtenerDetallePrestamo(int prestamoID)
        {
            return cdPrestamo.ObtenerDetallePrestamo(prestamoID);
        }
        public DataTable ObtenerTodosLosPrestamos()
        {
            return cdPrestamo.ObtenerTodosLosPrestamos();
        }

    }
}

