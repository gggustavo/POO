using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inmobiliaria
{
    public partial class Localidades : Form
    {
        private Inmobiliaria _inmobiliaria;

        public Localidades(Inmobiliaria inmobiliaria)
        {
            InitializeComponent();

            _inmobiliaria = inmobiliaria;
        }

        private void Localidades_Load(object sender, EventArgs e)
        {
            dgLocalidades.DataSource = _inmobiliaria.ListarLocalidades();
        }
    }
}
