using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pjr_Capa_Entidad
{
    public class CE_perfil
    {
        private int ClienteID;
        private string Nombre;
        private string Apellido;
        private string Contraseña;
        private string Telefono;
        private string Direccion;
        private string correo;

        public int ClienteID1 { get => ClienteID; set => ClienteID = value; }
        public string Nombre1 { get => Nombre; set => Nombre = value; }
        public string Apellido1 { get => Apellido; set => Apellido = value; }
        public string Contraseña1 { get => Contraseña; set => Contraseña = value; }
        public string Telefono1 { get => Telefono; set => Telefono = value; }
        public string Direccion1 { get => Direccion; set => Direccion = value; }
        public string Correo { get => correo; set => correo = value; }
    }
}
