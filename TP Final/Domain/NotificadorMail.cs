using System.Net;
using System.Net.Mail;

namespace TP_Final.Domain
{
    class NotificadorMail : INotificador
    {
        public void Notificar(Notificacion pNotificacion)
        {
            var smtpClient = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new NetworkCredential("bibliotecaTaller2021@gmail.com", "Rodale@2021"),
                EnableSsl = true,
            };
            smtpClient.Send("bibliotecaTaller2021@gmail.com", pNotificacion.Usuario.Mail, "Notificación de vencimiento de préstamo", "El prestamo de su libro ´´" + pNotificacion.Prestamo.Ejemplar.Libro.Titulo + "´´ se encuentra a 2 dias de ser vencido");
        }
    }
}
