using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pjr_Capa_Datos
{
    public class BD_Conexion
    {
        public string conectar()
        {
            return "Data Source=LAPMASIEL;Initial Catalog=PrestamosDB;Integrated Security=true";
        }
    }
}
