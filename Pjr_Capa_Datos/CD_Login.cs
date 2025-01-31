﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pjr_Capa_Datos
{
    public class CD_Login : BD_Conexion
    {
        public (string, int) ValidarUsuario(string usuario, string contraseña)
        {
            string rol = null;
            int clienteID = 0;

            try
            {
                using (SqlConnection conexion = conectar())
                {
                    using (SqlCommand cmd = new SqlCommand("sp_login", conexion))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Usuario", usuario);
                        cmd.Parameters.AddWithValue("@Contraseña", contraseña);

                        conexion.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                rol = reader["Rol"].ToString();
                                clienteID = Convert.ToInt32(reader["ClienteID"]);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al validar el usuario: " + ex.Message);
            }

            return (rol, clienteID);
        }

    }
}

