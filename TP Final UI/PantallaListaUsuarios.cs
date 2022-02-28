using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TP_Final;
using TP_Final.Domain;
using TP_Final.IO;

namespace TP_Final_UI
{
    public partial class PantallaListaUsuarios : Form
    {
        private Fachada fachada = new Fachada();
        private Form pantallaAnterior;
        public UsuarioDTO usuarioSeleccionado;


        public PantallaListaUsuarios(Form pPantallaAnterior)
        {
            InitializeComponent();
            pantallaAnterior = pPantallaAnterior;
        }

        private void PantallaListaUsuarios_Load(object sender, EventArgs e)
        {
            if ((pantallaAnterior is not PantallaListaEjemplares))
            {
                this.botonAceptar.Visible = false;
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
                    case "Nombre":
                        filtro = 0;
                        break;
                    case "Mail":
                        filtro = 3;
                        break;
                    default:
                        filtro = 2;
                        break;
                }
                foreach (DataGridViewRow fila in listaUsuarios.Rows)
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

        private void PantallaListaUsuarios_FormClosed(object sender, FormClosedEventArgs e)
        {
            pantallaAnterior.Show();
        }

        private void botonAgregarUsuario_Click(object sender, EventArgs e)
        {
            PantallaCrearUsuario pantallaCrearUsuario = new PantallaCrearUsuario(this);
            this.Visible = false;
            pantallaCrearUsuario.Show();
        }

        private void PantallaListaUsuarios_VisibleChanged(object sender, EventArgs e)
        {
            listaUsuarios.Rows.Clear();
            List<UsuarioDTO> listaUsuarioDTO = fachada.ObtenerUsuarios();
            foreach (var UsuarioDTO in listaUsuarioDTO)
            {
                listaUsuarios.Rows.Add(UsuarioDTO.Nombre, UsuarioDTO.Puntos, UsuarioDTO.TipoUsuario, UsuarioDTO.Mail);
            }
            //DataGridViewRow fila = listaUsuarios.SelectedRows[0];
            //UsuarioDTO usuarioDTO = new UsuarioDTO
            //{
            //    Nombre = fila.Cells[0].Value.ToString(),
            //    Puntos = (int)fila.Cells[1].Value,
            //    TipoUsuario = (TipoUsuario)fila.Cells[2].Value,
            //    Mail = fila.Cells[3].Value.ToString()
            //};
            //usuarioSeleccionado = usuarioDTO;
        }

        private void listaUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //DataGridViewRow fila = listaUsuarios.SelectedRows[0];
            //UsuarioDTO usuarioDTO = new UsuarioDTO
            //{
            //    Nombre = fila.Cells[0].Value.ToString(),
            //    Puntos = (int)fila.Cells[1].Value,
            //    TipoUsuario = (TipoUsuario)fila.Cells[2].Value,
            //    Mail = fila.Cells[3].Value.ToString()
            //};
            //usuarioSeleccionado = usuarioDTO;
        }

        private void botonAceptar_Click(object sender, EventArgs e)
        {
            DataGridViewRow fila = listaUsuarios.SelectedRows[0];
            UsuarioDTO usuarioDTO = new UsuarioDTO
            {
                Nombre = fila.Cells[0].Value.ToString(),
                Puntos = (int)fila.Cells[1].Value,
                TipoUsuario = (TipoUsuario)fila.Cells[2].Value,
                Mail = fila.Cells[3].Value.ToString()
            };
            usuarioSeleccionado = usuarioDTO;

            PantallaListaEjemplares pantallaListaEjemplares = (PantallaListaEjemplares)pantallaAnterior;
            pantallaListaEjemplares.usuarioDTO = usuarioSeleccionado;
            this.Close();
            pantallaListaEjemplares.Visible = true;
        }
    }
}
