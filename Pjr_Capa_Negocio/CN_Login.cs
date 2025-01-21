using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pjr_Capa_Datos;
using Pjr_Capa_Entidad;

namespace Pjr_Capa_Negocio
{
    public class CN_Login
    {
        private CD_Login loginDAL = new CD_Login();

        public (string, int) ValidarUsuario(CE_Login usuario)
        {
            if (string.IsNullOrWhiteSpace(usuario.UsuarioNombre) || string.IsNullOrWhiteSpace(usuario.Contraseña))
            {
                throw new Exception("El usuario o la contraseña no pueden estar vacíos.");
            }

            return loginDAL.ValidarUsuario(usuario.UsuarioNombre, usuario.Contraseña);
        }
    }
}

