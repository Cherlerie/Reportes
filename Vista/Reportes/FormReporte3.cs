using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista.Reportes
{
    public partial class FormReporte3 : Form
    {
        public FormReporte3()
        {
            InitializeComponent();
        }

        private void FormReporte3_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
