using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using TP_Final.DAL;
using TP_Final.DAL.EntityFramework;

namespace TP_Final.Domain
{
    class EstrategiaEmail : iEstrategiaNotificacion
    {
        public void notificarUsuario(Usuario pUsuario)
        {
            var smtpClient = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new NetworkCredential("bibliotecaTaller2021@gmail.com", "Rodale@2021"),
                EnableSsl = true,
            };
            smtpClient.Send("bibliotecaTaller2021@gmail.com", pUsuario.Mail, "Notificación de vencimiento de préstamo", "Su prestamo se encuentra a 2 dias a ser vencido");
            Console.WriteLine("Se notifico a "+pUsuario.Nombre);
        }
    }
}
