using log4net;
using Microsoft.VisualBasic;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_Final;
using TP_Final.Excepciones;
using TP_Final.IO;

namespace TP_Final_UI
{
    public partial class PantallaListaPrestamos : Form
    {
        private Fachada fachada = new Fachada();
        private Form pantallaAnterior;
        private static readonly ILog log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public PantallaListaPrestamos(Form pPantallaAnterior)
        {
            InitializeComponent();
            pantallaAnterior = pPantallaAnterior;
        }

        private void PantallaListaPrestamos_Load(object sender, EventArgs e)
        {
            botonDevolver.Enabled = false;
            botonExtenderPrestamo.Enabled = false;

            List<PrestamoDTO> listaPrestamoNoDevueltosDTO = fachada.ObtenerPrestamosNoDevueltos();
            foreach (var prestamoDTO in listaPrestamoNoDevueltosDTO)
            {
                listaPrestamos.Rows.Add(prestamoDTO.ID , prestamoDTO.IDEjemplar, prestamoDTO.Libro, prestamoDTO.Usuario, prestamoDTO.FechaPrestamo, prestamoDTO.FechaDevolucion);
            }
        }

        private void checkedListBoxFiltro_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            for (int ix = 0; ix < checkedListBoxFiltro.Items.Count; ++ix)
                if (ix != e.Index) checkedListBoxFiltro.SetItemChecked(ix, false);
        }

        private void botonFiltrar_Click(object sender, EventArgs e)
        {
            if (checkedListBoxFiltro.CheckedItems.Count != 0)
            {
                var check = checkedListBoxFiltro.CheckedItems[0];
                int filtro;
                switch (check)
                {
                    case "ID":
                        filtro = 0;
                        break;
                    case "Libro":
                        filtro = 1;
                        break;
                    default:
                        filtro = 2;
                        break;
                }
                foreach (DataGridViewRow fila in listaPrestamos.Rows)
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

        private void PantallaListaPrestamos_FormClosed(object sender, FormClosedEventArgs e)
        {
            pantallaAnterior.Visible = true;
        }

        private void botonDevolver_Click(object sender, EventArgs e)
        {
            DataGridViewRow fila = listaPrestamos.SelectedRows[0];
            Int64 prestamoID = Int64.Parse(fila.Cells[0].Value.ToString());
            bool buenEstado = false;
            DialogResult respuesta = MessageBox.Show("El libro se devolvio en buen estado?", "Estado?", MessageBoxButtons.YesNo);
            if (respuesta == DialogResult.Yes)
            {
                buenEstado = true;
            }
            fachada.registrarDevolucion(prestamoID, buenEstado);
            MessageBox.Show("Se realizo la devolucion con exito");
            log.Info("Se devolvio el prestamo de ID: " + prestamoID);

            listaPrestamos.Rows.Clear();
            List<PrestamoDTO> listaPrstamosDTO = fachada.ObtenerPrestamosNoDevueltos();
            foreach (var prestamoDTO in listaPrstamosDTO)
            {
                listaPrestamos.Rows.Add(prestamoDTO.ID, prestamoDTO.IDEjemplar, prestamoDTO.Libro, prestamoDTO.Usuario, prestamoDTO.FechaPrestamo, prestamoDTO.FechaDevolucion);
            }
        }

        private void botonExtenderPrestamo_Click(object sender, EventArgs e)
        {
            DataGridViewRow fila = listaPrestamos.SelectedRows[0];
            Int64 prestamoID = Int64.Parse(fila.Cells[0].Value.ToString());
            var input = Interaction.InputBox("Cuantos dias se quiere extender el prestamo?", "Extender prestamo", "");           
            try
            {
                if (input != "")
                {
                    int cantidad = Int32.Parse(input);
                    fachada.ExtenderPrestamo(prestamoID, cantidad);
                    MessageBox.Show("Se extendio el prestamo de forma correcta");
                    log.Info("Se extendio " + cantidad + " dias el prestamo de ID: " + prestamoID);

                    listaPrestamos.Rows.Clear();
                    List<PrestamoDTO> listaPrstamosDTO = fachada.ObtenerPrestamosNoDevueltos();
                    foreach (var prestamoDTO in listaPrstamosDTO)
                    {
                        listaPrestamos.Rows.Add(prestamoDTO.ID, prestamoDTO.IDEjemplar, prestamoDTO.Libro, prestamoDTO.Usuario, prestamoDTO.FechaPrestamo, prestamoDTO.FechaDevolucion);
                    }
                }
                
            }
            catch (FormatException exc)
            {
                MessageBox.Show("Formato ingresado incorrecto, por favor ingrese un numero");
                log.Error(exc);
            }
            catch (PuntosInsuficientesException exc)
            {               
                MessageBox.Show(exc.Message);
                log.Error(exc);
            }
            catch (SuperasteLaExtensionAdmitidaException exc)
            {               
                MessageBox.Show(exc.Message);
                log.Error(exc);
            }
            
        }

        private void listaPrestamos_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            botonDevolver.Enabled = true;
            botonExtenderPrestamo.Enabled = true;
        }

  
    }
}
