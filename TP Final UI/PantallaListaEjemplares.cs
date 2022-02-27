using System;
using System.Windows.Forms;
using TP_Final;
using TP_Final.Excepciones;
using TP_Final.IO;

namespace TP_Final_UI
{
    public partial class PantallaListaEjemplares : Form
    {

        private Fachada fachada = new Fachada();
        private Form pantallaAnterior;
        private LibroDTO libroDTO;
        public UsuarioDTO usuarioDTO;

        public PantallaListaEjemplares(Form pPantallaAnterior, LibroDTO pLibroDTO)
        {
            InitializeComponent();
            pantallaAnterior = pPantallaAnterior;
            libroDTO = pLibroDTO;
        }

        private void PantallaListaEjemplares_Load(object sender, EventArgs e)
        {
            foreach (var ejemplarDTO in libroDTO.Ejemplares)
            {
                if (ejemplarDTO.Disponible)
                {
                    listaEjemplares.Rows.Add(ejemplarDTO.ID);
                }
            }
        }

        private void PantallaListaEjemplares_FormClosed(object sender, FormClosedEventArgs e)
        {
            pantallaAnterior.Show();
        }

        private void botonPrestar_Click(object sender, EventArgs e)
        {
            PantallaListaUsuarios pantallaListaUsuarios = new PantallaListaUsuarios(this);
            this.Visible = false;
            pantallaListaUsuarios.Show();
        }

        private void PantallaListaEjemplares_VisibleChanged(object sender, EventArgs e)
        {
            if (usuarioDTO != null)
            {
                try
                {
                    DataGridViewRow fila = listaEjemplares.SelectedRows[0];
                    int ejemplarID = Int32.Parse(fila.Cells[0].Value.ToString());
                    fachada.NuevoPrestamo(usuarioDTO.Nombre, ejemplarID);
                    MessageBox.Show("Se realizo el prestamo del ejemplar " + ejemplarID + " a el usuario " + usuarioDTO.Nombre + " con exito");
                    this.usuarioDTO = null; //Para que no vuelva a entrar a este bucle
                    this.libroDTO = null;
                    this.Close();
                }
                catch (EjemplarNoDisponibleException exc)
                {
                    MessageBox.Show(exc.Message);
                }
            }
        }

        private void botonFiltrar_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow fila in listaEjemplares.Rows)
            {
                fila.Visible = true;
                if (textBoxFiltro.Text != "")
                {
                    if (!fila.Cells[0].Value.ToString().ToLower().Contains(textBoxFiltro.Text.ToLower()))
                    {
                        fila.Visible = false;
                    }
                }
                else
                {
                    fila.Visible = true;
                }
            }
        }

    }
}

