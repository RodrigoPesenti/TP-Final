using System;
using System.Net;
using System.Net.Mail;

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
            Console.WriteLine("Se notifico a " + pUsuario.Nombre);
        }
    }
}
