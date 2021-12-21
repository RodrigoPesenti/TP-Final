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
using TP_Final.Domain;
using TP_Final.Excepciones;

namespace TP_Final_UI
{
    public partial class PantallaCrearUsuario : Form
    {
        private static readonly ILog log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        private Fachada fachada = new Fachada();
        private Form pantallaAnterior;

        public PantallaCrearUsuario(Form pPantallaAnterior)
        {
            pantallaAnterior = pPantallaAnterior;
            InitializeComponent();
        }

        private void botonAceptar_Click(object sender, EventArgs e)
        {
            if ((textBoxNombre.Text == "") || (textBoxContraseña.Text == "") || (textBoxMail.Text == ""))
            {
                MessageBox.Show("Debe completar todos los campos");
                log.Info("No se completaron todos los campos al crear un usuario");
            }
            else
            {
                TipoNotificacion tipoNotificacion;
                if (checkBoxMail.Checked)
                {
                    tipoNotificacion = TipoNotificacion.Mail;
                }
                else
                {
                    tipoNotificacion = TipoNotificacion.NoRecibir;
                }
                TipoUsuario tipoUsuario;
                if (checkBoxEsAdmin.Checked)
                {
                    tipoUsuario = TipoUsuario.Administrador;
                }
                else
                {
                    tipoUsuario = TipoUsuario.Simple;
                }
                try
                {
                    fachada.AltaUsuario(textBoxNombre.Text, textBoxContraseña.Text, textBoxMail.Text, tipoUsuario, tipoNotificacion);
                    MessageBox.Show("Se creo el usuario con exito");
                    this.Close();
                    pantallaAnterior.Visible = true;
                }
                catch (EFDatabaseUpdateException exc)
                {
                    MessageBox.Show("Nombre de usuario ya utilizado");
                    log.Error(exc);
                }
            }
        }

        private void PantallaCrearUsuario_FormClosed(object sender, FormClosedEventArgs e)
        {
            pantallaAnterior.Visible = true;
        }

        private void botonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
