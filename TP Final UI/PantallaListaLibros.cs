using log4net;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TP_Final;
using TP_Final.IO;

namespace TP_Final_UI
{
    public partial class PantallaListaLibros : Form
    {
        private static readonly ILog log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        private Fachada fachada = new Fachada();
        private PantallaUsuarioAdministrador pantallaUsuarioAdministrador;

        public PantallaListaLibros(PantallaUsuarioAdministrador pPantallaUsuarioAdministrador)
        {
            InitializeComponent();
            pantallaUsuarioAdministrador = pPantallaUsuarioAdministrador;
        }

        private void PantallaListaLibros_Load(object sender, EventArgs e)
        {
            buttonAgregarEjemplar.Enabled = false;
            buttonMostrarEjemplares.Enabled = false;

            List<LibroDTO> listaLibrosDTO = fachada.ObtenerLibrosDisponibles();
            foreach (var libroDTO in listaLibrosDTO)
            {
                listaLibros.Rows.Add(libroDTO.Titulo, libroDTO.Autor, libroDTO.ISBN, libroDTO.CantEjem);
            }
        }

        private void botonFiltrar_Click(object sender, EventArgs e)
        {
            if (checkedListBoxFiltro.CheckedItems.Count != 0)
            {
                var check = checkedListBoxFiltro.CheckedItems[0];
                int filtro;
                switch (check)
                {
                    case "Titulo":
                        filtro = 0;
                        break;
                    case "Autor":
                        filtro = 1;
                        break;
                    default:
                        filtro = 2;
                        break;
                }
                foreach (DataGridViewRow fila in listaLibros.Rows)
                {
                    fila.Visible = true;
                    if (textBoxFiltro.Text != "")
                    {
                        if (!fila.Cells[filtro].Value.ToString().ToLower().Contains(textBoxFiltro.Text.ToLower()))
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
            else
            {
                MessageBox.Show("Seleccione un filtro");
            }
        }

        private void checkedListBoxFiltro_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            for (int ix = 0; ix < checkedListBoxFiltro.Items.Count; ++ix)
                if (ix != e.Index) checkedListBoxFiltro.SetItemChecked(ix, false);
        }

        private void buttonAgregarEjemplar_Click(object sender, EventArgs e)
        {
            var input = Interaction.InputBox("Ingrese cuantos ejemplares quiere agregar", "Cantidad de ejemplares", "");
            try
            {
                if (input != "")
                {
                    int cant = Int32.Parse(input);
                    DataGridViewRow fila = listaLibros.SelectedRows[0];
                    fachada.AltaEjemplar(Int64.Parse(fila.Cells[2].Value.ToString()), cant);
                    fila.Cells[3].Value = (int)fila.Cells[3].Value + cant;
                }
            }
            catch (FormatException exc)
            {
                MessageBox.Show("Formato ingresado incorrecto, por favor ingrese un numero");
                log.Error(exc);
            }
        }


        private void PantallaListaLibros_FormClosed(object sender, FormClosedEventArgs e)
        {
            pantallaUsuarioAdministrador.Show();
        }

        private void buttonMostrarEjemplares_Click(object sender, EventArgs e)
        {
            DataGridViewRow fila = listaLibros.SelectedRows[0];
            if (!(Int32.Parse(fila.Cells[3].Value.ToString()) == 0))
            {
                LibroDTO libroDTO = fachada.ObtenerLibro(Int64.Parse(fila.Cells[2].Value.ToString()));
                PantallaListaEjemplares pantallaListaEjemplares = new PantallaListaEjemplares(this, libroDTO);
                this.Visible = false;
                pantallaListaEjemplares.Show();
            }
            else
            {
                MessageBox.Show("El libro seleccionado no posee ejemplares disponibles");
                log.Info("Se intento mostrar los ejmplares de un libro que no poseia ejemplares");
            }
        }

        private void PantallaListaLibros_VisibleChanged(object sender, EventArgs e)
        {
            listaLibros.Rows.Clear();
            List<LibroDTO> listaLibrosDTO = fachada.ObtenerLibrosDisponibles();
            foreach (var libroDTO in listaLibrosDTO)
            {
                listaLibros.Rows.Add(libroDTO.Titulo, libroDTO.Autor, libroDTO.ISBN, libroDTO.CantEjem);
            }
        }

        private void listaLibros_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            buttonAgregarEjemplar.Enabled = true;
            buttonMostrarEjemplares.Enabled = true;
        }

        private void botonAdevolveren7dias_Click(object sender, EventArgs e)
        {
            PantallaReporte pantallaReporte = new PantallaReporte(this);
            this.Visible = false;
            pantallaReporte.Show();
        }
    }
}
