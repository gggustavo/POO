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
    public partial class Proyectos : Form
    {
        private Empresa _empresa;

        public Proyectos(Empresa empresa)
        {
            InitializeComponent();

            _empresa = empresa;
            
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            CargarDesarrolladores();
            CargarProyectos();
        }

        private void CargarDesarrolladores()
        {
            desarrolladorBindingSource.DataSource = null;
            desarrolladorBindingSource.DataSource = _empresa.ObtenerDesarrolladores();
        }

        private void agregar_Click(object sender, EventArgs e)
        {
            try 
	        {
                if (string.IsNullOrEmpty(nombre.Text)) throw new Exception("Nombre vacio");
                if (string.IsNullOrEmpty(cantidadhora.Text)) throw new Exception("Cantidad horas vacio");

                Proyecto value = locales.Checked ? value = new Local() : new Internacional();

                value.Nombre = nombre.Text;
                value.CantidadHoras = Convert.ToInt32(cantidadhora.Text);
                value.Desarrollador = (Desarrollador)desarrolladorBindingSource.Current;

                value.CalcularCosto();

                _empresa.AgregarProyecto(value);
                CargarProyectos();

	        }
	        catch (Exception ex)
	        {
                MessageBox.Show(ex.Message);
	        }
        }

        private void CargarProyectos()
        {
            proyectoBindingSource.DataSource = null;
            proyectoBindingSource.DataSource = _empresa.ObtenerProyectos();
        }

        private void eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (proyectoBindingSource.Current == null) throw new Exception("Debe seleccionar un proyecto");

                var proyecto = (Proyecto)proyectoBindingSource.Current;

                _empresa.EliminarProyecto(proyecto);

                CargarProyectos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void modificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (proyectoBindingSource.Current == null) throw new Exception("Debe seleccionar un proyecto");

                var proyecto = (Proyecto)proyectoBindingSource.Current;

                nombre.Text = proyecto.Nombre;
                nombre.Enabled = false;
                cantidadhora.Text = proyecto.CantidadHoras.ToString();

                if (proyecto.Tipo == typeof(Local).Name) locales.Checked = true;                    
                if (proyecto.Tipo == typeof(Internacional).Name) internacionales.Checked = true;
                   
                CargarDesarrolladores();

                desarrolladores.SelectedValue = proyecto.Desarrollador.Documento;

                EstadoModificar();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void EstadoModificar()
        {
            confirmar.Enabled = true;

            agregar.Enabled = false;
            eliminar.Enabled = false;

            locales.Enabled = false;
            internacionales.Enabled = false;

            modificar.Enabled = false;
        }

        private void confirmar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(nombre.Text)) throw new Exception("Nombre vacio");
                if (string.IsNullOrEmpty(cantidadhora.Text)) throw new Exception("Cantidad horas vacio");

                var proyecto = (Proyecto)proyectoBindingSource.Current;

                proyecto.Nombre = nombre.Text;
                proyecto.CantidadHoras = Convert.ToInt32(cantidadhora.Text);
                proyecto.Desarrollador = (Desarrollador)desarrolladorBindingSource.Current;

                proyecto.CalcularCosto();

                _empresa.ModificarProyecto(proyecto);

                CargarProyectos();

                EstadoConfirmar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void EstadoConfirmar()
        {
            nombre.Enabled = true;
            confirmar.Enabled = false;
            agregar.Enabled = true;
            eliminar.Enabled = true;

            locales.Enabled = true;
            internacionales.Enabled = true;

            modificar.Enabled = true;
        }

    }
}
