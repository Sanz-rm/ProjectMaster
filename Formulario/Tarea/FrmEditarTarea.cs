using MySql.Data.MySqlClient;
using Mysqlx.Cursor;
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

namespace ProjectMaster.Formulario.Tarea
{
    public partial class FrmEditarTarea : Form
    {
        private FrmPrincipal frmPrincipal;
        private Usuario usuario;
        private UsuarioDAO usuarioDAO;
        private TareaDAO tareaDAO;
        private Modelo.Tarea tareaActual;
        private List<Usuario> miembrosProyecto;
        public FrmEditarTarea(FrmPrincipal frmP, MySqlConnection conexion2, Usuario user, Modelo.Tarea tarea)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            frmPrincipal = frmP;
            usuario = user;
            tareaActual = tarea;
            tareaDAO = new TareaDAO(conexion2);
            usuarioDAO = new UsuarioDAO(conexion2);
            LblFechaLimite.Text = DateTime.Today.ToShortDateString();
            rellenarInfoTarea();
        }

        // ----------------------------------------------------------------------------------------------------
        // Rellenar la información de la tarea:
        private void rellenarInfoTarea()
        {
            CboMiembros.Items.Clear();
            LstAsignados.Items.Clear();

            LblTituloTarea.Text = "EDITAR TAREA: " + tareaActual.nombre.ToUpper();
            TxtNombreTarea.Text = tareaActual.nombre;
            RtxtDescripcion.Text = tareaActual.descripcion;
            numericUpDown1.Value = tareaActual.prioridad;
            string fecha = tareaActual.fecha_fin.Date.ToShortDateString();
            if (fecha.Equals("01/01/0001") || fecha.Equals(null))
            {
                ChkFecha.Checked = true;
                LblFechaLimite.Text = "No hay fecha límite";
                CdrFecha.Enabled = false;
            }
            else
            {
                ChkFecha.Checked = false;
                CdrFecha.Enabled = true;
                CdrFecha.SelectionStart = tareaActual.fecha_fin;
                LblFechaLimite.Text = tareaActual.fecha_fin.ToShortDateString();
            }

            // Usuarios que realizan la tarea:
            tareaActual.usuariosAsignados = usuarioDAO.obtenerUsuariosAsignadosATarea(tareaActual);
            foreach (Usuario u in tareaActual.usuariosAsignados)
            {
                System.Windows.Forms.ListViewItem usuarioCompleto = new System.Windows.Forms.ListViewItem(u.nombreUsuario);
                usuarioCompleto.SubItems.Add(u.correo);
                LstAsignados.Items.Add(usuarioCompleto);
            }

            // Miembros del proyecto:
            miembrosProyecto = usuarioDAO.obtenerMiembros(tareaActual.proyecto_id);
            foreach (Usuario u in miembrosProyecto)
            {
                // Si el miembro no está asignado a la tarea:
                if (tareaActual.usuariosAsignados.Find(us => us.id == u.id) == null)
                {
                    CboMiembros.Items.Add(u.nombreUsuario);
                }
            }
        }

        private void IcbVolverInicio_Click(object sender, EventArgs e)
        {
            if (camposRellenados())
            {
                DialogResult resultado = MessageBox.Show("¿Seguro que quieres volver? Se perderá la información no guardada", "ATENCIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (resultado == DialogResult.Yes)
                {
                    frmPrincipal.crearArea(usuario, tareaActual.proyecto_id);
                    frmPrincipal.cerrarEditarTarea();
                }
            }
            else
            {
                // Si no ha rellenado ningun dato, redirigiremos directamente al area
                frmPrincipal.crearArea(usuario, tareaActual.proyecto_id);
                frmPrincipal.cerrarEditarTarea();
            }
        }

        private bool camposRellenados()
        {
            bool modificado = false;
            // Si cambia cualquier campo, se ha modificado la tarea:
            // Cambio fecha:
            if ((ChkFecha.Checked && tareaActual.fecha_fin != DateTime.MinValue) ||
            (!ChkFecha.Checked && !tareaActual.fecha_fin.ToShortDateString().Equals(CdrFecha.SelectionStart.ToShortDateString())))
            {
                modificado = true;
            }
            // Si cambian los usuarios:
            foreach (ListViewItem s in LstAsignados.Items)
            {
                if (tareaActual.usuariosAsignados.Find(u => u.nombreUsuario.Equals(s.Text)) == null)
                    modificado = true;
            }

            if (!TxtNombreTarea.Text.Equals(tareaActual.nombre) || !RtxtDescripcion.Text.Equals(tareaActual.descripcion)
                || LstAsignados.Items.Count != tareaActual.usuariosAsignados.Count || numericUpDown1.Value != tareaActual.prioridad)
                modificado = true;

            return modificado;
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (LstAsignados.SelectedItems.Count > 0)
            {
                string itemSeleccionado = LstAsignados.SelectedItems[0].Text;
                CboMiembros.Items.Add(itemSeleccionado);
                LstAsignados.SelectedItems[0].Remove();

            }
            else
            {
                MessageBox.Show("No se a que posible miembro quieres eliminar.\n Estaria bien si lo seleccionaras primero...", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            rellenarInfoTarea();
        }

        private void CboMiembros_SelectedIndexChanged(object sender, EventArgs e)
        {
            string itemSeleccionado = CboMiembros.SelectedItem.ToString();
            System.Windows.Forms.ListViewItem datosIngreso = new System.Windows.Forms.ListViewItem(itemSeleccionado);

            // Una vez seleccionamos un amigo de la lista lo agregaremos a la tabla y lo eliminaremos de la lista
            CboMiembros.Items.Remove(itemSeleccionado);
            datosIngreso.SubItems.Add(miembrosProyecto.Find(us => us.nombreUsuario.Equals(itemSeleccionado)).correo);
            LstAsignados.Items.Add(datosIngreso);
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            DateTime fechaLímite = CdrFecha.SelectionStart;
            LblFechaLimite.Text = fechaLímite.ToShortDateString();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkFecha.Checked)
            {
                // Se ha seleccionado, no hay fecha límite:
                LblFechaLimite.Text = "No hay fecha límite";
                CdrFecha.Enabled = false;
            }
            else
            {
                // Se ha deseleccionado, hay fecha:
                CdrFecha.Enabled = true;
                LblFechaLimite.Text = DateTime.Today.ToShortDateString();
            }
        }

        private void BtnEliminarTarea_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Seguro que quieres eliminar esta tarea? Se borrará toda la información de la tarea para todos los usuarios del proyecto.", "ATENCIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (resultado == DialogResult.Yes)
            {
                tareaDAO.eliminarTarea(tareaActual, usuarioDAO, usuario.id);
                frmPrincipal.crearArea(usuario, tareaActual.proyecto_id);
                frmPrincipal.cerrarEditarTarea();
            }

        }

        private void BtnEditarTarea_Click(object sender, EventArgs e)
        {
            actualizarTarea();
            frmPrincipal.crearArea(usuario, tareaActual.proyecto_id);
            frmPrincipal.cerrarEditarTarea();
        }

        private void actualizarTarea()
        {
            if (camposRellenados())
            {
                // Recogemos los datos:
                DateTime fecha = new DateTime();
                if (!ChkFecha.Checked && CdrFecha.SelectionStart.Date != null)
                {
                    fecha = CdrFecha.SelectionStart.Date;
                }
                int prioridad = (int)numericUpDown1.Value;
                Modelo.Tarea tarea = new Modelo.Tarea(tareaActual.proyecto_id, tareaActual.id, TxtNombreTarea.Text, RtxtDescripcion.Text, Convert.ToInt32(numericUpDown1.Value), fecha);
                tareaDAO.actualizarTarea(tarea);

                // Usuarios finales de la lista:
                List<int> idUsuariosLista = new List<int>();
                foreach (System.Windows.Forms.ListViewItem s in LstAsignados.Items)
                    idUsuariosLista.Add(miembrosProyecto.Find(u => u.nombreUsuario == s.Text).id);
                tareaDAO.actualizarUsuariosTarea(tareaActual, idUsuariosLista, usuario.id, usuarioDAO);
                // Enviamos la notificación a los usuarios:
                foreach (int i in idUsuariosLista)
                {
                    usuarioDAO.enviarNotificacion(usuario.id, i, "Se ha editado información de la tarea " + tareaActual.nombre + " del proyecto " + tareaDAO.obtenerNombreProyecto(tareaActual));
                }
                MessageBox.Show("Se han actualizado correctamente los datos de la tarea " + tarea.nombre, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("No cambiaste nada...", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void FrmEditarTarea_Resize(object sender, EventArgs e)
        {
            // Center LblTituloTarea
            LblTituloTarea.Left = (panelTop.Width - LblTituloTarea.Width) / 2;
            LblTituloTarea.Top = (panelTop.Height - LblTituloTarea.Height) / 2;

            // Align IconButton to the left with margin
            IcbVolverInicio.Left = 40;
            IcbVolverInicio.Top = (panelTop.Height - IcbVolverInicio.Height) / 2;

            // Center panelDatosTarea
            panelDatosTarea.Left = (PanelEditarTarea.ClientSize.Width - panelDatosTarea.Width) / 2;
            panelDatosTarea.Top = panelTop.Bottom + 20;

            // Ajustar la posición de los botones debajo de los paneles
            int btnSpacing = 20; // Espacio entre los botones

            // Calcular el ancho total de los botones y el espacio entre ellos
            int btnTotalWidth = BtnEditarTarea.Width + btnSpacing + BtnLimpiar.Width + btnSpacing + BtnEliminarTarea.Width;

            // Calcular la posición inicial horizontal para los botones
            int btnStartX = (PanelEditarTarea.ClientSize.Width - btnTotalWidth) / 2;

            // Calcular la posición vertical debajo del panelDatosTarea
            int btnStartY = panelDatosTarea.Bottom + 20; // Espacio entre el panel y los botones

            // Ajustar la posición de cada botón
            BtnEditarTarea.Left = btnStartX;
            BtnEditarTarea.Top = btnStartY;

            BtnLimpiar.Left = BtnEditarTarea.Right + btnSpacing;
            BtnLimpiar.Top = btnStartY;

            // Ajustar BtnEliminar a la derecha de BtnLimpiar
            BtnEliminarTarea.Left = BtnLimpiar.Right + btnSpacing;
            BtnEliminarTarea.Top = btnStartY;
        }
    }
}

