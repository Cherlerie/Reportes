using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pjr_Capa_Negocio;

namespace Vista
{
    public partial class Moras : Form
    {
        private CN_Perfil cnPerfil = new CN_Perfil();
        private int clienteID;
        public Moras()
        {
            InitializeComponent();
            this.clienteID = clienteID;

        }
    }
}
