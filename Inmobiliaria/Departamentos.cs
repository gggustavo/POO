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
    public partial class Departamentos : Form
    {
        private Inmobiliaria _inmobiliaria;

        public Departamentos(Inmobiliaria inmobiliaria)
        {
            InitializeComponent();

            _inmobiliaria = inmobiliaria;
        }

        private void Departamentos_Load(object sender, EventArgs e)
        {
            dgDepartamentos.DataSource = _inmobiliaria.ListarDepartamentos();
        }
    }
}
