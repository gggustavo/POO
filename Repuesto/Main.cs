using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Repuesto
{
    public partial class Main : Form
    {
        private CasaRepuestos _casaRepuesto;

        public Main()
        {
            InitializeComponent();
            _casaRepuesto = new CasaRepuestos();
        }

        private void articulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var articulos = new ArticulosForm(_casaRepuesto);
            articulos.ShowDialog();            
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
