using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Parcial2.UI.GUI;

namespace Parcial2.UI.GUI
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void gRolesChildMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                General.GUI.frmClientes f = new General.GUI.frmClientes();
                f.ShowDialog();

            }
            catch (Exception)
            {
                throw;
            }
        }

        private void gMovimientosChildMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                General.GUI.frmMovimientos f = new General.GUI.frmMovimientos();
                f.ShowDialog();

            }
            catch (Exception)
            {
                throw;
            }
        }

        private void salirDelSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
