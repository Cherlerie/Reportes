using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Vista
{
    public partial class Administrador : Form
    {
        private int ClienteID;
        public Administrador(int clienteID)
        {
            InitializeComponent();
            this.ClienteID = clienteID;
        } 

        private void Administrador_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            pictureBox3.Visible = false;
           btnRestaurar.Visible = true;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            pictureBox3.Visible=true;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.WindowState= FormWindowState.Minimized;
        }

        private void MenuVertical_Paint(object sender, PaintEventArgs e)
        {

        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            SubmenuReporte.Visible = true;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            SubmenuReporte.Visible= false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            SubmenuReporte.Visible = false;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            SubmenuReporte.Visible = false;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Login LoginForm = new Login();
            LoginForm.Show();
            this.Hide();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            Perfil PerfilForm = new Perfil(ClienteID);
            PerfilForm.Show();

            PanelContenedor.Controls.Clear();

            PerfilForm.TopLevel = false;

            PerfilForm.Dock = DockStyle.Fill;

            PanelContenedor.Controls.Add(PerfilForm);


            PerfilForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            BuscarCliente BuscarClienteForm = new BuscarCliente();
            BuscarClienteForm.Show();

            PanelContenedor.Controls.Clear();

            BuscarClienteForm.TopLevel = false;

            BuscarClienteForm.Dock = DockStyle.Fill;

            PanelContenedor.Controls.Add(BuscarClienteForm);


            BuscarClienteForm.Show();

        }

        private void btnClientesMorosos_Click(object sender, EventArgs e)
        {

            BuscarMorosos BuscarMorososForm = new BuscarMorosos();
            BuscarMorososForm.Show();

            PanelContenedor.Controls.Clear();

            BuscarMorososForm.TopLevel = false;

            BuscarMorososForm.Dock = DockStyle.Fill;

            PanelContenedor.Controls.Add(BuscarMorososForm);


            BuscarMorososForm.Show();
        }

        private void btnAmortizaciones_Click(object sender, EventArgs e)
        {
            AmortizacionAdmin AmortizacionForm = new AmortizacionAdmin();
            AmortizacionForm.Show();

            PanelContenedor.Controls.Clear();

            AmortizacionForm.TopLevel = false;

            AmortizacionForm.Dock = DockStyle.Fill;

            PanelContenedor.Controls.Add(AmortizacionForm);


            AmortizacionForm.Show();
        }

        private void btnPrestamos_Click(object sender, EventArgs e)
        {
            GestionPrestamos GestionPrestamosForm = new GestionPrestamos();
            GestionPrestamosForm.Show();

            PanelContenedor.Controls.Clear();

            GestionPrestamosForm.TopLevel = false;

            GestionPrestamosForm.Dock = DockStyle.Fill;

            PanelContenedor.Controls.Add(GestionPrestamosForm);


            GestionPrestamosForm.Show();
        }

        private void btnDetallesCliente_Click(object sender, EventArgs e)
        {
            InformacionCrediticiaAdmin InformacionCrediticiaAdminForm = new InformacionCrediticiaAdmin();
            InformacionCrediticiaAdminForm.Show();

            PanelContenedor.Controls.Clear();

            InformacionCrediticiaAdminForm.TopLevel = false;

            InformacionCrediticiaAdminForm.Dock = DockStyle.Fill;

            PanelContenedor.Controls.Add(InformacionCrediticiaAdminForm);


            InformacionCrediticiaAdminForm.Show();

        }

        private void BarraTitulo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            SubmenuReporte.Visible = true;
        }

        private void PanelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Reportes.FormReporte4 oRpt1 = new Reportes.FormReporte4();
            oRpt1.Show();
        }
    }
}
