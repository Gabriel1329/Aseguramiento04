using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;

namespace ServicioCorreo
{
    class Correo
    {



        public void EnviarCorreo()
        {
            using (SmtpClient cliente = new SmtpClient("smtp.live.com", 25))
            {
                cliente.EnableSsl = true;
                cliente.Credentials = new NetworkCredential("gabriel14_cr@hotmail.com", "contrasena");
                MailMessage mensaje = new MailMessage("gabriel14_cr@hotmail.com", "gabrielpizarro14@gmail.com", "asuntirijillo", "contenido papu :v");
                try
                {
                    cliente.Send(mensaje);
                }
                catch (Exception ex)
                {
                }
            }
        }
    }
}
