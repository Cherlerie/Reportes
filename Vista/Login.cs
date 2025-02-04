using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Pjr_Capa_Entidad;
using Pjr_Capa_Negocio;



namespace Vista
{
    public partial class Login : Form
    {
        private CN_Login loginNegocio = new CN_Login();

        public Login()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        public static class Sesion
        {
            public static int ClienteID { get; set; }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "USUARIO") 
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.Black;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text=="")
            {
                txtUsuario.Text = "USUARIO";
                txtUsuario.ForeColor = Color.LightGray;
            }
        }

        private void txtContrase_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "CONTRASEÑA")
            {
                txtContrase.Text = "";
                txtContrase.ForeColor = Color.Black;
                txtContrase.UseSystemPasswordChar = true;
            }

        }

        private void txtContrase_Leave(object sender, EventArgs e)
        {
            if (txtContrase.Text == "")
            {
                txtContrase.Text = "CONTRASEÑA";
                txtContrase.ForeColor = Color.LightGray;
                txtContrase.UseSystemPasswordChar = false;
            }

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    CE_Login usuario = new CE_Login
                    {
                        UsuarioNombre = txtUsuario.Text,
                        Contraseña = txtContrase.Text
                    };


                    (string rol, int clienteID) = loginNegocio.ValidarUsuario(usuario);


                    if (!string.IsNullOrEmpty(rol))
                    {
                        MessageBox.Show($"Bienvenido. Rol: {rol}", "Acceso permitido", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        if (rol == "Administrador")
                        {
                            Sesion.ClienteID = clienteID;

                            Administrador adminForm = new Administrador(clienteID);
                            adminForm.Show();
                        }
                        else if (rol == "Cliente")
                        {
                            Sesion.ClienteID = clienteID;
                            Cliente clienteForm = new Cliente(clienteID);
                            clienteForm.Show();
                        }
                        else
                        {
                            MessageBox.Show("Rol no reconocido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }

                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Usuario o contraseña incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
    
}
