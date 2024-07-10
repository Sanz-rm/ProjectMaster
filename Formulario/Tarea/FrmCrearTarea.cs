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

namespace ProjectMaster.Formulario.Tarea
{
    public partial class FrmCrearTarea : Form
    {
        private FrmPrincipal frmPrincipal;
        private UsuarioDAO usuarioDAO;
        private TareaDAO tareaDAO;
        private Usuario usuario;
        Modelo.Proyecto proyecto;

        public FrmCrearTarea(FrmPrincipal frmP, MySqlConnection conexion2, Usuario user, Modelo.Proyecto p)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            frmPrincipal = frmP;
            usuario = user;
            proyecto = p;
            usuarioDAO = new UsuarioDAO(conexion2);
            tareaDAO = new TareaDAO(conexion2);
            LblFechaLimite.Text = DateTime.Today.ToShortDateString();
            rellenarMiembros();
        }

        public void rellenarMiembros()
        {
            CboMiembros.Items.Clear();
            foreach (Usuario u in proyecto.miembros)
                CboMiembros.Items.Add(u.nombreUsuario);
        }

        private void IcbVolverInicio_Click(object sender, EventArgs e)
        {
            // Aviso si se ha empezado a rellenar:
            if (camposRellenados())
            {
                DialogResult resultado = MessageBox.Show("¿Seguro que quieres volver? Se perderá la información no guardada...", "CUIDADO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (resultado == DialogResult.Yes)
                {
                    volverProyecto();
                }
            }
            else
            {
                volverProyecto();
            }
        }

        private bool camposRellenados()
        {
            bool rellenado = false;
            // Obligatorio rellenar el nombre y la descripción:
            if (TxtNombreTarea.Text.Length > 0 && RtxtDescripcion.Text.Length > 0 )
                rellenado = true;

            return rellenado;
        }

        private void CboMiembros_SelectedIndexChanged(object sender, EventArgs e)
        {
            string itemSeleccionado = CboMiembros.SelectedItem.ToString();

            System.Windows.Forms.ListViewItem datosIngreso = new System.Windows.Forms.ListViewItem(itemSeleccionado);


            // Una vez seleccionamos un amigo de la lista lo agregaremos a la tabla y lo eliminaremos de la lista
            CboMiembros.Items.Remove(itemSeleccionado);
            datosIngreso.SubItems.Add(proyecto.miembros.Find(u => u.nombreUsuario.Equals(itemSeleccionado)).correo);
            LstAsignados.Items.Add(datosIngreso);
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

        private void CdrFecha_DateSelected(object sender, DateRangeEventArgs e)
        {
            DateTime fechaLímite = CdrFecha.SelectionStart;
            LblFechaLimite.Text = fechaLímite.ToShortDateString();
        }

        private void BtnCrear_Click(object sender, EventArgs e)
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
                Modelo.Tarea tarea = new Modelo.Tarea(proyecto.id, 0, TxtNombreTarea.Text, RtxtDescripcion.Text, Convert.ToInt32(numericUpDown1.Value), fecha);
                tareaDAO.insertarTarea(tarea);
                foreach (ListViewItem i in LstAsignados.Items)
                {
                    Usuario u = proyecto.miembros.Find(us => us.nombreUsuario.Equals(i.Text));
                    tarea.asignarUsuario(u);
                   if(usuario.id != u.id)
                    {
                        usuarioDAO.enviarNotificacion(usuario.id, u.id, usuario.nombreUsuario + " te ha asignado a la tarea  " + tarea.nombre + "  en el proyecto " + proyecto.nombre + " Es momento de seguir trabajando...");
                    }

                }
                tareaDAO.insertarUsuariosAsignados(tarea);
                MessageBox.Show("Genial! Tarea creada con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                volverProyecto();
            }
            else
            {
                MessageBox.Show("TAREA IMPORTANTE: no te olvides de ponerle nombre y descripción a la tarea", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void volverProyecto()
        {
            frmPrincipal.crearArea(usuario, proyecto.id);
            frmPrincipal.cerrarCrearTarea();
        }

        private void FrmCrearTarea_Resize(object sender, EventArgs e)
        {
            // Center LblTitulo
            LblNuevaTarea.Left = (panelTop.Width - LblNuevaTarea.Width) / 2;
            LblNuevaTarea.Top = (panelTop.Height - LblNuevaTarea.Height) / 2;

            // Align IconButton to the left with margin
            IcbVolverInicio.Left = 40;
            IcbVolverInicio.Top = (panelTop.Height - IcbVolverInicio.Height) / 2;

            panelTarea.Left = (PanelCrearTarea.ClientSize.Width - panelTarea.Width) / 2;
            panelTarea.Top = (PanelCrearTarea.ClientSize.Height - panelTarea.Height) / 2;

            // Ajustar la posición de los botones debajo de los paneles
            int btnSpacing = 20; // Espacio entre los botones
            int btnTotalWidth = BtnCrear.Width + btnSpacing + BtnLimpiar.Width;

            int btnStartX = (PanelCrearTarea.ClientSize.Width - btnTotalWidth) / 2;
            int btnStartY = panelTarea.Bottom + 40; // Espacio entre el panel y los botones

            BtnCrear.Left = btnStartX;
            BtnCrear.Top = btnStartY;

            BtnLimpiar.Left = BtnCrear.Right + btnSpacing;
            BtnLimpiar.Top = btnStartY;

        }
    }
}
