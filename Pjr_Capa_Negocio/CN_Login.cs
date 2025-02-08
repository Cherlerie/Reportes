using Pjr_Capa_Datos;
using Pjr_Capa_Entidad;
using System;

namespace Pjr_Capa_Negocio
{
    public class CN_Login
    {
        private CD_Login cdLogin = new CD_Login();

        public (string Rol, int ClienteID) ValidarUsuario(CE_Login usuario)
        {
            if (string.IsNullOrWhiteSpace(usuario.UsuarioNombre) || string.IsNullOrWhiteSpace(usuario.Contraseña))
            {
                throw new Exception("El usuario o la contraseña no pueden estar vacíos.");
            }
            return cdLogin.ValidarUsuario(usuario.UsuarioNombre, usuario.Contraseña);
        }
    }
}

