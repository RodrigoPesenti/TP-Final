using log4net;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_Final;
using TP_Final.Excepciones;
using TP_Final.IO;

namespace TP_Final_UI
{
    public partial class PantallaAltaLibros : Form
    {
        private static readonly ILog log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        private Fachada fachada = new Fachada();
        private PantallaUsuarioAdministrador pantallaUsuarioAdministrador;

        public PantallaAltaLibros(PantallaUsuarioAdministrador pPantallaUsuarioAdministrador)
        {
            InitializeComponent();
            pantallaUsuarioAdministrador = pPantallaUsuarioAdministrador;
        }

        private void botonBuscar_Click(object sender, EventArgs e)
        {
            if (textBoxTituloLibro.Text != "")
            {
                
                listaLibros.Rows.Clear();
                List<LibroDTO> listaLibrosDTO = fachada.BuscarLibroEnAPI(textBoxTituloLibro.Text);
                foreach (var libroDTO in listaLibrosDTO)
                {
                    listaLibros.Rows.Add(libroDTO.Titulo, libroDTO.Autor, libroDTO.ISBN);
                }
                botonAgregarSeleccion.Enabled = true;
            }           
        }

        private void PantallaAltaLibros_FormClosed(object sender, FormClosedEventArgs e)
        {
            pantallaUsuarioAdministrador.Show();
        }

        private void botonAgregarSeleccion_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewSelectedRowCollection fila = listaLibros.SelectedRows;
                DataGridViewCellCollection columnas = fila[0].Cells;
                LibroDTO libroDTO = new LibroDTO
                {
                    Titulo = columnas[0].Value.ToString(),
                    Autor = columnas[1].Value.ToString(),
                    ISBN = Int64.Parse(columnas[2].Value.ToString())
                };
                fachada.AltaLibro(libroDTO);
                MessageBox.Show("Su libro se agrego con exito");
                
            }
            catch (EFDatabaseUpdateException exc)
            {
                log.Error(exc);
                MessageBox.Show("Libro existente");
            }
            
        }
    }
}
