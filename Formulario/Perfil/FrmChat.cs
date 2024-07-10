using MySql.Data.MySqlClient;
using ProjectMaster.DAO;
using ProjectMaster.Formulario.Principal;
using ProjectMaster.Modelo;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;

namespace ProjectMaster.Formulario.Amigos
{
    public partial class FrmChat : Form
    {

        private FrmPrincipal frmPrincipal;
        private UsuarioDAO usuarioDAO;
        private Usuario emisor;
        private Usuario receptor;
        private const int maxCaracteres = 40;
        private int ultimoTopOtro;
        private int ultimoTopUsuario;
        public static bool finalizarHilo;
        public static Thread mostrarNoLeidosHilo;
        public FrmChat(FrmPrincipal frmP, MySqlConnection conexion2, Usuario user1, Usuario user2)
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.None;
            frmPrincipal = frmP;

            usuarioDAO = new UsuarioDAO(conexion2);
            emisor = user1;
            receptor = user2;
            finalizarHilo = false;

            rellenarChat();

        }

        private void agregarNoLeidos()
        {
            while (!finalizarHilo)
            {
                List<(string mensaje, DateTime fecha)> mensajesNoLeidos = usuarioDAO.obtenerMensajesNoLeidos(emisor.id, receptor.id);
                if (mensajesNoLeidos.Count > 0)
                {

                    foreach (var mensaje in mensajesNoLeidos)
                    {
                        // Comprobar si se requiere invocación 
                        if (LstChatOtro.InvokeRequired)
                        {
                            // Utilizar el método Invoke para actualizar los controles de la interfaz de usuario desde el hilo principal
                            this.Invoke(new Action(() =>
                            {
                                LstChatOtro.Items.Add(mensaje.fecha + " - " + mensaje.mensaje);
                                LstChatUsuario.Items.Add("");
                                LstChatOtro.TopIndex = LstChatOtro.Items.Count - 1;
                                LstChatUsuario.TopIndex = LstChatUsuario.Items.Count - 1;
                                usuarioDAO.leerMensajes(emisor.id, receptor.id);
                            }));
                        }
                        else
                        {
                            // Si no se requiere invocación, actualizar los controles directamente
                            LstChatOtro.Items.Add(mensaje.fecha + " - " + mensaje.mensaje);
                            LstChatUsuario.Items.Add("");
                            LstChatOtro.TopIndex = LstChatOtro.Items.Count - 1;
                            LstChatUsuario.TopIndex = LstChatUsuario.Items.Count - 1;
                            usuarioDAO.leerMensajes(emisor.id, receptor.id);
                        }
                    }
                }


                Thread.Sleep(2000);
            }
        }

        private void rellenarChat()
        {
            LblTitulo.Text += receptor.nombreUsuario.ToUpper();
            LblOtro.Text = receptor.nombreUsuario.ToUpper();
            LblUsuario.Text = emisor.nombreUsuario.ToUpper();

            List<(int id, string mensaje, DateTime fecha)> mensajes = usuarioDAO.obtenerMensajesChat(emisor.id, receptor.id);

            foreach (var mensaje in mensajes)
            {
                if (mensaje.id == emisor.id)
                {
                    LstChatUsuario.Items.Add(mensaje.mensaje + " - " + mensaje.fecha);
                    LstChatOtro.Items.Add("");
                }
                else
                {
                    LstChatOtro.Items.Add(mensaje.fecha + " - " + mensaje.mensaje);
                    LstChatUsuario.Items.Add("");
                }
            }
            LstChatOtro.TopIndex = LstChatOtro.Items.Count - 1;
            LstChatUsuario.TopIndex = LstChatUsuario.Items.Count - 1;

            usuarioDAO.leerMensajes(emisor.id, receptor.id);
        }
        private void BtnEnviar_Click(object sender, EventArgs e)
        {
            if (TxtMensaje.Text.Replace("\r\n", "").Length > 0)
            {
                DateTime fecha = DateTime.Now;
                usuarioDAO.enviarMensaje(emisor.id, receptor.id, TxtMensaje.Text.Trim(), fecha);
                LstChatUsuario.Items.Add(TxtMensaje.Text.Trim() + " - " + fecha.ToString("yyyy-MM-dd HH:mm:ss"));
                LstChatOtro.Items.Add("");

                TxtMensaje.Text = "";
                LstChatUsuario.TopIndex = LstChatUsuario.Items.Count - 1;
                LstChatOtro.TopIndex = LstChatOtro.Items.Count - 1;

                BtnEnviar.Enabled = false;
                Thread.Sleep(500);
                BtnEnviar.Enabled = true;

                if (usuarioDAO.obtenerNumMensajesNoLeidos(receptor.id, emisor.id) == 1)
                {
                    usuarioDAO.enviarNotificacion(emisor.id, receptor.id, "Tienes mensajes sin leer de " + emisor.nombreUsuario);
                }

            }
        }

        private void TxtMensaje_TextChanged(object sender, EventArgs e)
        {
            int caracteresRestantes = maxCaracteres - TxtMensaje.Text.Replace("\r\n", "").Length;
            LblContadorCar.Text = caracteresRestantes.ToString();

            if (caracteresRestantes < 0)
            {
                // Si el mensaje supera el maximo de 40 caracteres eliminaremos su ultimo caracter
                TxtMensaje.Text = TxtMensaje.Text.Substring(0, maxCaracteres);

                // Ponemos el cursor al final del texto
                TxtMensaje.SelectionStart = TxtMensaje.Text.Length;
            }
        }

        private void TxtMensaje_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtnEnviar_Click(sender, e);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void IcbVolverInicio_Click(object sender, EventArgs e)
        {
            frmPrincipal.crearArea(emisor, 0);
            frmPrincipal.cerrarChat();
        }

        private void FrmChat_Shown(object sender, EventArgs e)
        {
            LstChatUsuario.TopIndex = LstChatUsuario.Items.Count - 1;
            LstChatOtro.TopIndex = LstChatOtro.Items.Count - 1;

            mostrarNoLeidosHilo = new Thread(agregarNoLeidos);
            mostrarNoLeidosHilo.IsBackground = true;
            mostrarNoLeidosHilo.Start();
            timer1.Start();
        }

        private void FrmChat_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmPrincipal.cerrarHiloChat();
            timer1.Stop();
            timer1.Dispose();
        }

        private void FrmChat_Resize(object sender, EventArgs e)
        {
            // TOP - Titulo y volver atrás:
            LblTitulo.Left = (panelTop.Width - LblTitulo.Width) / 2;
            LblTitulo.Top = (panelTop.Height - LblTitulo.Height) / 2;

            IcbVolverInicio.Left = 40;
            IcbVolverInicio.Top = (panelTop.Height - IcbVolverInicio.Height) / 2;

            // Panel de chat:
            int margin = 15;
            panelCentr.Left = (PanelChat.ClientSize.Width - panelCentr.Width) / 2;
            panelCentr.Top = panelTop.Height + 10;
            LstChatOtro.Left = margin;
            LstChatOtro.Width = (panelCentr.Width / 2) - margin;
            LstChatUsuario.Left = (panelCentr.Width / 2);
            LstChatUsuario.Width = (panelCentr.Width / 2) - margin;


            // BOTTOM - Barra de mensaje y enviar:
            margin = 20;
            TxtMensaje.Width = 2 * panelCentr.Width / 3;
            int totalWidth = TxtMensaje.Width + BtnEnviar.Width + LblContadorCar.Width + 2 * margin;

            TxtMensaje.Left = margin + LblContadorCar.Right;
            TxtMensaje.Top = margin;

            BtnEnviar.Left = TxtMensaje.Right + margin;
            BtnEnviar.Top = margin;

            LblContadorCar.Left = (panelBottom.Width - totalWidth) / 2;
            LblContadorCar.Top = margin + (TxtMensaje.Height - LblContadorCar.Height) / 2;

            panelBottom.Height = margin * 2 + TxtMensaje.Height;
        }

        private void LstChatOtro_SelectedIndexChanged(object sender, EventArgs e)
        {
            LstChatUsuario.TopIndex = LstChatOtro.TopIndex;
            LstChatUsuario.SelectedIndex = LstChatOtro.SelectedIndex;
        }

        private void LstChatUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            LstChatOtro.TopIndex = LstChatUsuario.TopIndex;
            LstChatOtro.SelectedIndex = LstChatUsuario.SelectedIndex;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Verificar si el TopIndex de LstChatUsuario ha cambiado
            if (LstChatUsuario.TopIndex != ultimoTopUsuario)
            {
                // Actualizar el TopIndex del otro ListBox si ha cambiado
                if (LstChatOtro.TopIndex != LstChatUsuario.TopIndex)
                {
                    LstChatOtro.TopIndex = LstChatUsuario.TopIndex;
                }

                // Actualizar el registro del último TopIndex de LstChatUsuario
                ultimoTopUsuario = LstChatUsuario.TopIndex;
            }

            // Verificar si el TopIndex de LstChatOtro ha cambiado
            if (LstChatOtro.TopIndex != ultimoTopOtro)
            {
                // Actualizar el TopIndex del otro ListBox si ha cambiado
                if (LstChatUsuario.TopIndex != LstChatOtro.TopIndex)
                {
                    LstChatUsuario.TopIndex = LstChatOtro.TopIndex;
                }

                // Actualizar el registro del último TopIndex de LstChatOtro
                ultimoTopOtro = LstChatOtro.TopIndex;
            }
        }
    }
}
