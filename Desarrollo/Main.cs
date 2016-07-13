using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desarrollo
{
    public partial class Main : Form
    {
        private Empresa _empresa;
        public Main()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            _empresa = new Empresa();
            CargarDatos();
        }

        private void gestionarDesarrolladoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var desarrolladores = new Desarrolladores(_empresa);
            desarrolladores.ShowDialog();
        }

        private void gestionarProyectosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var proyectos = new Proyectos(_empresa);
            proyectos.ShowDialog();
        }

        private void CargarDatos()
        {
            var desarrollador = new Desarrollador
            {
                Nombre = "Developer 1",
                Email = "poo@uai.com",
                Documento = "50112589",
                CostoHora = 300
            };
            
            _empresa.AgregarDesarrollador(desarrollador);

            var desarrollador2 = new Desarrollador
            {
                Nombre = "Developer 2",
                Email = "poo@uai.com",
                Documento = "50112588",
                CostoHora = 250
            };

            _empresa.AgregarDesarrollador(desarrollador2);

            var proyecto = new Local
            {
                CantidadHoras = 10,
                Nombre = "Proyecto Local Nuevo",
                Desarrollador = desarrollador
            };

            proyecto.CalcularCosto();
            _empresa.AgregarProyecto(proyecto);

            var _proyecto = new Internacional
            {
                CantidadHoras = 10,
                Nombre = "Proyecto Int. Nuevo",
                Desarrollador = desarrollador2
            };
            _proyecto.CalcularCosto();
            _empresa.AgregarProyecto(_proyecto);
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
