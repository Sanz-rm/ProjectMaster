using System.Collections.Generic;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.IO;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Drawing;

namespace ProjectMaster.Modelo
{
    public class Usuario
    {
        public int id;
        public string nombreUsuario;
        public string correo;
        public string password;
        public string nombreReal;
        public int? telefono;
        public bool privacidad;
        public int codAvatar;

        public Usuario()
        {
        }
        public Usuario(int id, string nombreUsuario)
        {
            this.id = id;
            this.nombreUsuario = nombreUsuario;
        }

        public Usuario(int id, string nombreUsuario, string correo)
        {
            this.id = id;
            this.nombreUsuario = nombreUsuario;
            this.correo = correo;
        }

        public Usuario(int id, string nombreUsuario, string correo, string password, string nombreReal, int? telefono, bool privacidad, int codAvatar)
        {
            this.id = id;
            this.nombreUsuario = nombreUsuario;
            this.correo = correo;
            this.password = password;
            this.nombreReal = nombreReal;
            this.telefono = telefono;
            this.privacidad = privacidad;
            this.codAvatar = codAvatar;
        }
        public Usuario(string nombreUsuario, string correo, string password, bool privacidad, int codAvatar)
        {
            this.nombreUsuario = nombreUsuario;
            this.correo = correo;
            this.password = password;
            this.privacidad = privacidad;
            this.codAvatar = codAvatar;
        }

        // --------------------------------------------------------------------------
        // Obtendremos la imagen del avatar en el area:
        public static Image obtenerAvatarArea(int codAvatar)
        {
            switch (codAvatar)
            {
                case 0:
                    return Properties.Resources.avatar0_pequeño;
                case 1:
                    return Properties.Resources.avatar1_pequeño;
                case 2:
                    return Properties.Resources.avatar2_pequeño;
                case 3:
                    return Properties.Resources.avatar3_pequeño;
                case 4:
                    return Properties.Resources.avatar4_pequeño;
                case 5:
                    return Properties.Resources.avatar5_pequeño;
                case 6:
                    return Properties.Resources.avatar6_pequeño;
                default:
                    throw new ArgumentException("Código de avatar inválido");
            }
        }
        // --------------------------------------------------------------------------
        // Obtendremos la imagen del avatar:
        public static Image obtenerAvatar(int codAvatar)
        {
            switch (codAvatar)
            {
                case 0:
                    return Properties.Resources.avatar0_grande;
                case 1:
                    return Properties.Resources.avatar1_grande;
                case 2:
                    return Properties.Resources.avatar2_grande;
                case 3:
                    return Properties.Resources.avatar3_grande;
                case 4:
                    return Properties.Resources.avatar4_grande;
                case 5:
                    return Properties.Resources.avatar5_grande;
                case 6:
                    return Properties.Resources.avatar6_grande;
                default:
                    throw new ArgumentException("Código de avatar inválido");
            }
        }

        public static bool validarCorreo(string correo)
        {
            // Verifica que el correo tenga algun contenido previo y despues @ gmail|hotmail .com
            string patron = @"^.+@(gmail\.com|hotmail\.com)$";
            Regex regex = new Regex(patron);
            return regex.IsMatch(correo);
        }
        public static bool validarPassword(string password)
        {
            // Patrón que verifica al menos 6 caracteres, 1 mayúscula y 1 número
            string patron = @"^(?=.*[A-Z])(?=.*\d).{6,}$";
            Regex regex = new Regex(patron);
            return regex.IsMatch(password);
        }

        public override string ToString()
        {
            string telefonoStr = telefono.HasValue ? telefono.ToString() : "null";
            string nombreRealStr = string.IsNullOrEmpty(nombreReal) ? "" : nombreReal;

            return $"Usuario: [idUsuario={id}, nombreUsuario={nombreUsuario}, correo={correo}, nombreReal={nombreRealStr}, telefono={telefonoStr}, codAvatar={codAvatar}, perfilPrivado={privacidad}, password={password}]";
        }

        // Copia en el usuario pasado por parámetro la información de este usuario:
        public Usuario copiarInfo(Usuario u)
        {
            u.nombreUsuario = this.nombreUsuario;
            u.correo = this.correo;
            u.nombreReal = this.nombreReal;
            u.password = this.password;
            u.telefono = this.telefono;
            u.privacidad = this.privacidad;
            u.codAvatar = this.codAvatar;
            u.id = this.id;


            return u;
        }

        // --------------------------------------------------------------------------
        // Verificar coindidencia codigos alfanumericos:
        public static bool confirmarCodigoAlfanumericoPassword(string codigoCorrecto, string codigoUsuario)
        {
            return codigoCorrecto.Equals(codigoUsuario);
        }

        // --------------------------------------------------------------------------
        // Generaremos un codigo alfanumerico de 8 digitos de forma aleatoria:
        public static string generarCodigoAlfanumericoAleatorio()
        {
            string caracteres = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            StringBuilder codigo = new StringBuilder();
            Random random = new Random();

            for (int i = 0; i < 8; i++)
            {
                codigo.Append(caracteres[random.Next(caracteres.Length)]);
            }

            return codigo.ToString();
        }

        // --------------------------------------------------------------------------
        // Enviar correo con codigo alfanumerico para iniciar sesion:
        public static void enviarCorreoVerificacionOlvidarPassword(Usuario usuario, string codigo)
        {

            string correoEmisor = "project.master.meb@gmail.com";
            string password = "h f o x z s k f s e r j c b l f\r\n";
            string nombreMostrar = !string.IsNullOrEmpty(usuario.nombreReal) ? usuario.nombreReal : usuario.nombreUsuario;

            try
            {
                // Configuración del mensaje
                MailMessage correo = new MailMessage();
                correo.From = new MailAddress(correoEmisor); // Correo del emisor
                correo.To.Add(usuario.correo); // El destinatario
                correo.Subject = "Nueva contraseña para iniciar sesión en ProjectMaster"; // Asunto del correo

                // Cuerpo del correo en formato HTML
                string cuerpoCorreo = @"
<html>
<head>
    <style>
        body{font-family: Arial, sans-serif; color: black; margin: 0; padding: 0;}
        .container{max-width: 600px; margin: auto; padding: 20px; border: 1px solid #ddd; border-radius: 10px;}
        h2{text-align: center; color: #007bff; background-color: #f9f9f9; padding: 10px; border-radius: 5px;}
        p{margin-bottom: 15px;}
        ul{list-style-type: disc; padding: 0;}
        ul li{margin-bottom: 5px;}
        footer{text-align: center; font-size: 12px; color: #777; margin-top: 20px;}
        footer p{margin: 5px 0;}
        hr{border: none; border-top: 1px solid #eee; margin: 20px 0;}
        .codigo-verificacion {
            text-align: center;
            font-size: 28px;
            font-family: Arial, sans-serif;
            background-color: #f0f0f0;
            padding: 12px;
            border-radius: 8px;
            box-shadow: 0 4px 8px rgba(0, 0, 0, 0.1);
        }
    </style>
</head>
<body>
    <div class='container'>
        <h2 style='text-align: center; color: white; background-color: #007bff; padding: 20px; border-radius: 10px; font-size: 24px; font-weight: bold;'>Nueva contraseña para iniciar sesión en ProjectMaster</h2>
        <p>Estimado/a " + nombreMostrar + @",</p>
        <p>Hemos recibido una solicitud para restablecer su contraseña. Se te ha actualizado la contraseña de tu usuario " + usuario.nombreUsuario + @" en <strong>ProjectMaster</strong>: con el código siguiente:</p>
        <div class='codigo-verificacion'>" + codigo + @"</div>
        <p>Una vez haya iniciado sesión, podrá cambiar esta contraseña en la configuración de su perfil.</p>
        <p>Si usted no solicitó este cambio, ignore este mensaje.</p>
        <hr>
        <footer>
            <p>ProjectMaster - Gestiona tus proyectos de manera eficiente</p>
        </footer>
    </div>
</body>
</html>";

                correo.Body = cuerpoCorreo;
                correo.IsBodyHtml = true; // El cuerpo del correo es HTML

                // Configuración del cliente SMTP
                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                smtp.Credentials = new NetworkCredential(correoEmisor, password);
                smtp.EnableSsl = true; // El servidor SMTP de Gmail requiere SSL

                // Enviar el correo
                smtp.Send(correo);

                MessageBox.Show("Se ha enviado un correo de verificación al correo " + usuario.correo + " con una contraseña temporal para iniciar sesión.\nRevisa tu bandeja de entrada.", "Correo enviado", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al enviar el correo de verificación: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // --------------------------------------------------------------------------
        // Enviar correo con codigo numerico para eliminar la cuenta:
        public static void enviarCorreoVerificacionEliminarCuenta(Usuario usuario, string codigo)
        {


            string correoEmisor = "project.master.meb@gmail.com";
            string password = "h f o x z s k f s e r j c b l f\r\n";
            string nombreMostrar = !string.IsNullOrEmpty(usuario.nombreReal) ? usuario.nombreReal : usuario.nombreUsuario;


            try
            {
                // Configuración del mensaje
                MailMessage correo = new MailMessage();
                correo.From = new MailAddress(correoEmisor); // Correo del emisor
                correo.To.Add(usuario.correo); // El destinatario
                correo.Subject = "Verificación para eliminar tu cuenta en ProjectMaster"; // Asunto del correo

                // Cuerpo del correo en formato HTML
                string cuerpoCorreo = @"
        <html>
        <head>
            <style>
                body{font-family: Arial, sans-serif; color: black; margin: 0; padding: 0;}
                .container{max-width: 600px; margin: auto; padding: 20px; border: 1px solid #ddd; border-radius: 10px;}
                h2{text-align: center; color: #007bff; background-color: #f9f9f9; padding: 10px; border-radius: 5px;}
                p{margin-bottom: 15px;}
                ul{list-style-type: disc; padding: 0;}
                ul li{margin-bottom: 5px;}
                footer{text-align: center; font-size: 12px; color: #777; margin-top: 20px;}
                footer p{margin: 5px 0;}
                hr{border: none; border-top: 1px solid #eee; margin: 20px 0;}
                .codigo-verificacion {
                    text-align: center;
                    font-size: 28px;
                    font-family: Arial, sans-serif;
                    background-color: #f0f0f0;
                    padding: 12px;
                    border-radius: 8px;
                    box-shadow: 0 4px 8px rgba(0, 0, 0, 0.1);
                }
            </style>
        </head>
        <body>
            <div class='container'>
                <h2 style='text-align: center; color: white; background-color: #007bff; padding: 20px; border-radius: 10px; font-size: 24px; font-weight: bold;'>Verificación para eliminar tu cuenta en ProjectMaster</h2>
                <p>Estimado/a " + nombreMostrar + @",</p>
                <p>Has solicitado eliminar tu cuenta en <strong>ProjectMaster</strong>.</p>
                <p>Para completar este proceso, por favor utiliza el siguiente código de verificación:</p>
                <div class='codigo-verificacion'>" + codigo + @"</div>
                <p>Ingresa este código en la aplicación para confirmar la eliminación de tu cuenta.</p>
                <p>Si no has solicitado esta acción, por favor ignora este mensaje.</p>
                <hr>
                <footer>
                    <p>ProjectMaster - Gestiona tus proyectos de manera eficiente</p>
                </footer>
            </div>
        </body>
        </html>";

                correo.Body = cuerpoCorreo;
                correo.IsBodyHtml = true; // El cuerpo del correo es HTML

                // Configuración del cliente SMTP
                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                smtp.Credentials = new NetworkCredential(correoEmisor, password);
                smtp.EnableSsl = true; // El servidor SMTP de Gmail requiere SSL

                // Enviar el correo
                smtp.Send(correo);

                MessageBox.Show("Se ha enviado un correo de verificacion al correo " + usuario.correo + " para poder eliminar tu cuenta.\nRevisa tu bandeja de entrada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al enviar el correo de verificación: " + ex.Message);
            }
        }
        // --------------------------------------------------------------------------
        // Enviar correo con codigo numerico para eliminar la cuenta:
        public static void enviarCorreoBienvenida(Usuario usuario)
        {
            string correoEmisor = "project.master.meb@gmail.com";
            string password = "h f o x z s k f s e r j c b l f\r\n";

            string nombreMostrar = !string.IsNullOrEmpty(usuario.nombreReal) ? usuario.nombreReal : usuario.nombreUsuario;

            try
            {
                // Configuración del mensaje
                MailMessage correo = new MailMessage();
                correo.From = new MailAddress(correoEmisor); // Correo del emisor
                correo.To.Add(usuario.correo); // El destinatario
                correo.Subject = "¡Bienvenido a ProjectMaster!"; // Asunto del correo

                // Cuerpo del correo en formato HTML
                string cuerpoCorreo = @"
                <html>
                <head>
                    <style>
                        body{font-family: Arial, sans-serif; color: black; margin: 0; padding: 0;}
                        .container{max-width: 600px; margin: auto; padding: 20px; border: 1px solid #ddd; border-radius: 10px;}
                            h2{text-align: center; color: #007bff; background-color: #f9f9f9; padding: 10px; border-radius: 5px;}
                            p{margin-bottom: 15px;}
                            ul{list-style-type: disc; padding: 0;}
                            ul li{margin-bottom: 5px;}
                            footer{text-align: center; font-size: 12px; color: #777; margin-top: 20px;}
                            footer p{margin: 5px 0;}
                            hr{border: none; border-top: 1px solid #eee; margin: 20px 0;}
                    </style>
                </head>
                <body>
                    <div class='container'>
                        <h2 style='text-align: center; color: white; background-color: #007bff; padding: 20px; border-radius: 10px; font-size: 24px; font-weight: bold;'>¡Bienvenido a ProjectMaster!</h2>
                        <p>Estimado/a " + nombreMostrar + @",</p>
                        <p>Nos complace darte la bienvenida a <strong>ProjectMaster</strong>, tu nueva herramienta para la gestión de proyectos y tareas.</p>
                        <p>A partir de ahora podrás disfrutar de todas las funcionalidades ofrecidas para obtener una mayor organización y eficiencia en tus proyectos.</p>
                        <p>ProjectMaster ha sido desarrollado con dedicación por:</p>
                        <ul>
                            <li>Manuel Sanz</li>
                            <li>Esther Morely</li>
                            <li>Blanca Nuñez</li>
                        </ul>
                        <p>Esperamos que ProjectMaster te sea de gran ayuda.</p>
                        <p>Atentamente,<br>El equipo de ProjectMaster</p>
                        <hr>
                        <footer>
                            <p>ProjectMaster - Gestiona tus proyectos de manera eficiente</p>
                        </footer>
                    </div>
                </body>
                </html>";

                correo.Body = cuerpoCorreo;
                correo.IsBodyHtml = true; // El cuerpo del correo es HTML

                // Configuración del cliente SMTP
                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                smtp.Credentials = new NetworkCredential(correoEmisor, password);
                smtp.EnableSsl = true; // El servidor SMTP de Gmail requiere SSL

                // Enviar el correo
                smtp.Send(correo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al enviar el correo: " + ex.Message);
            }

        }
    }
}
