using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_Final_UI
{
    public partial class PantallaUsuarioAdministrador : Form
    {
        Form pantallaAnterior;

        public PantallaUsuarioAdministrador(Form pPantallaAnterior)
        {
            pantallaAnterior = pPantallaAnterior;
            InitializeComponent();
        }

        private void PantallaUsuarioAdministrador_FormClosed(object sender, FormClosedEventArgs e)
        {
            pantallaAnterior.Visible = true;
        }

        private void botonNuevoLibro_Click(object sender, EventArgs e)
        {
            PantallaAltaLibros pantallaAltaLibros = new PantallaAltaLibros(this);
            this.Visible = false;
            pantallaAltaLibros.Show();
        }

        private void botonListaLibros_Click(object sender, EventArgs e)
        {
            PantallaListaLibros pantallaAltaEjemplares = new PantallaListaLibros(this);
            this.Visible = false;
            pantallaAltaEjemplares.Show();
        }

        private void botonListaUsuarios_Click(object sender, EventArgs e)
        {
            PantallaListaUsuarios pantallaListaUsuarios = new PantallaListaUsuarios(this);
            this.Visible = false;
            pantallaListaUsuarios.Show();
        }

        private void botonCerrarSesion_Click(object sender, EventArgs e)
        {
            DialogResult confirmacion = MessageBox.Show("Seguro que quieres cerrar sesion?", "Confirmar", MessageBoxButtons.YesNo);
            if (confirmacion == DialogResult.Yes)
            {
                this.Close();           
            }
        }

        private void botonListaPrestamos_Click(object sender, EventArgs e)
        {
            PantallaListaPrestamos pantallaListaPrestamos = new PantallaListaPrestamos(this);
            this.Visible = false;
            pantallaListaPrestamos.Show();
        }
    }
}
