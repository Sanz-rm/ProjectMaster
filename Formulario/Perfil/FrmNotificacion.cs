using MySql.Data.MySqlClient;
using ProjectMaster.DAO;
using ProjectMaster.Formulario.Principal;
using ProjectMaster.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectMaster.Formulario.Perfil
{
    public partial class FrmNotificacion : Form
    {
        private FrmPrincipal frmPrincipal;
        private UsuarioDAO usuarioDAO;
        private ProyectoDAO proyectoDAO;
        private Usuario usuario;
        public FrmNotificacion(FrmPrincipal frmP, MySqlConnection conexion2, Usuario user, bool hayNotisSinLeer)
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.None;
            frmPrincipal = frmP;

            usuarioDAO = new UsuarioDAO(conexion2);
            proyectoDAO = new ProyectoDAO(conexion2);
            usuario = user;

           // LblTitulo.Text += usuario.nombreUsuario;
            if (hayNotisSinLeer)
            {
                RdbNoLeidas.Checked = true;
            }
            else
            {
                RdbTodas.Checked = true;
            }

        }
        // ------------------------------------------------------------------------------------------------------
        // Método para rellenar todos los datos de Notificacion:
        private void rellenarDatos(List<(string mensaje, DateTime fecha)> notificaciones)
        {
            foreach (var notificacion in notificaciones)
            {
                ListViewItem notificacionNueva = new ListViewItem(notificacion.mensaje);
                notificacionNueva.SubItems.Add(notificacion.fecha.ToString());
                LstNotificaciones.Items.Add(notificacionNueva);
            }
        }


        private void RdbTodas_CheckedChanged(object sender, EventArgs e)
        {
            LstNotificaciones.Items.Clear();
            rellenarDatos(usuarioDAO.obtenerNotificaciones(usuario.id));
        }

        private void RdbLeidas_CheckedChanged(object sender, EventArgs e)
        {
            LstNotificaciones.Items.Clear();
            rellenarDatos(usuarioDAO.obtenerNotificacionesLeido(usuario.id, true));
        }

        private void RdbNoLeidas_CheckedChanged(object sender, EventArgs e)
        {
            LstNotificaciones.Items.Clear();
            rellenarDatos(usuarioDAO.obtenerNotificacionesLeido(usuario.id, false));
        }
     
        // ------------------------------------------------------------------------------------------------------
        // Método para marcar como leidas todas las notificaciones del usuario:
        private void leerNotificaciones()
        {
            usuarioDAO.leerNotificaciones(usuario.id);
        }
        private void IcbVolverInicio_Click(object sender, EventArgs e)
        {
            leerNotificaciones();
            frmPrincipal.crearArea(usuario,0);
            frmPrincipal.cerrarNotificacion();
        }

        private void BtnEliminarNotificaciones_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Seguro que quieres eliminar todas las notificaciones?", "¡CUIDADO!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (resultado == DialogResult.Yes)
            {
                usuarioDAO.eliminarNotificaciones(usuario.id);
                frmPrincipal.crearArea(usuario,0);
                frmPrincipal.cerrarNotificacion();
            }
        }

        private void BtnEliminarNotificacion_Click(object sender, EventArgs e)
        {
            if (LstNotificaciones.SelectedItems.Count > 0)
            {

                string itemSeleccionado = LstNotificaciones.SelectedItems[0].Text;
                
                    // Obtener el ID de la notificación
                    int idNoti = usuarioDAO.obtenerIdNotificaciones(usuario.id, itemSeleccionado);
                    // Eliminar la notificación de la base de datos
                    usuarioDAO.eliminarNotificacion(usuario.id, idNoti);
                    // Eliminar el elemento seleccionado del ListView
                    LstNotificaciones.SelectedItems[0].Remove();

            }
            else
            {
                MessageBox.Show("No se que notifiacion quieres eliminar.\n Estaria bien si lo seleccionaras primero...", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FrmNotificacion_Resize(object sender, EventArgs e)
        {
            // Center LblTitulo
            LblTitulo.Left = (panelTop.Width - LblTitulo.Width) / 2;
            LblTitulo.Top = (panelTop.Height - LblTitulo.Height) / 2;

            // Align IconButton to the left with margin
            IcbVolverInicio.Left = 40;
            IcbVolverInicio.Top = (panelTop.Height - IcbVolverInicio.Height) / 2;

            // Center RadioButtons in the left panel
            int radioButtonSpacing = 5; // Space between RadioButtons
            int totalRadioButtonHeight = RdbTodas.Height + RdbLeidas.Height + RdbNoLeidas.Height + (2 * radioButtonSpacing);
            int startRadioButtonY = (panelIzq.Height - totalRadioButtonHeight) / 2;

            RdbTodas.Left = 50;
            RdbTodas.Top = startRadioButtonY;

            RdbLeidas.Left = 50;
            RdbLeidas.Top = RdbTodas.Bottom + radioButtonSpacing;

            RdbNoLeidas.Left = 50;
            RdbNoLeidas.Top = RdbLeidas.Bottom + radioButtonSpacing;

            // Adjust the ListView to occupy the maximum space
            int margin = 30;
            LstNotificaciones.Left = panelIzq.Right + margin;
            LstNotificaciones.Top = panelTop.Bottom + margin;
            LstNotificaciones.Width = panelDer.Left - panelIzq.Right - (2 * margin);
            LstNotificaciones.Height = this.Height - panelTop.Height - margin - margin;

            // Center buttons in the right panel
            int buttonSpacing = 20; // Space between buttons
            int totalButtonHeight = BtnEliminarNotificacion.Height + buttonSpacing + BtnEliminarNotifiaciones.Height;
            int startButtonY = (panelDer.Height - totalButtonHeight) / 2;

            BtnEliminarNotificacion.Left = 5;
            BtnEliminarNotificacion.Top = startButtonY;

            BtnEliminarNotifiaciones.Left = 5;
            BtnEliminarNotifiaciones.Top = BtnEliminarNotificacion.Bottom + buttonSpacing;
        }

    }
}
