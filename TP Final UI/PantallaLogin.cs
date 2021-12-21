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

namespace TP_Final_UI
{
    public partial class PantallaLogin : Form
    {
        private static readonly ILog log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        private Fachada fachada = new Fachada();

        public PantallaLogin()
        {
            InitializeComponent();
        }

        private void BotonAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if ((textBoxUsuario.Text == "admin") && (textBoxContraseña.Text == "admin"))
                {
                    PantallaUsuarioAdministrador pantallaAdministrador = new PantallaUsuarioAdministrador(this);
                    this.Visible = false;
                    pantallaAdministrador.Show();
                }
                else
                {
                    bool permitido = fachada.ComprobarLoginUsuario(textBoxUsuario.Text, textBoxContraseña.Text);
                    if (permitido)
                    {
                        if (fachada.ComprobarAdministradorUsuario(textBoxUsuario.Text))
                        {
                            PantallaUsuarioAdministrador pantallaAdministrador = new PantallaUsuarioAdministrador(this);
                            this.Visible = false;
                            pantallaAdministrador.Show();
                        }

                    }
                }            
            }
            catch (NullReferenceException exc)
            {
                MessageBox.Show(exc.Message);
                log.Error("El usuario " + textBoxUsuario.Text + " no existe en la base de datos",exc);
            } 
            catch (ContraseñaIncorrectaException exc)
            {
                MessageBox.Show(exc.Message);
                log.Error("No se logro la autentificacion del usuario",exc);
            }
        }
    }

}
