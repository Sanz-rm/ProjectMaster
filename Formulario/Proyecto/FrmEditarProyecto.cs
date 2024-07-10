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

namespace ProjectMaster.Formulario.Proyecto
{

    public partial class FrmEditarProyecto : Form
    {
        private FrmPrincipal frmPrincipal;
        private UsuarioDAO usuarioDAO;
        private ProyectoDAO proyectoDAO;
        private TareaDAO tareaDAO;
        private Usuario usuario;
        Modelo.Proyecto proyecto;
        List<Usuario> amigos;
        bool cambios = false;
        public FrmEditarProyecto(FrmPrincipal frmP, MySqlConnection conexion2, Usuario user, Modelo.Proyecto proyecto)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            frmPrincipal = frmP;
            usuario = user;
            this.proyecto = proyecto;
            usuarioDAO = new UsuarioDAO(conexion2);
            proyectoDAO = new ProyectoDAO(conexion2);
            tareaDAO = new TareaDAO(conexion2);
            rellenarDatos();
            rellenarAdministradores();
            rellenarMiembros();
            rellenarAmigos();

        }

        private void rellenarDatos()
        {
            Modelo.Proyecto proyectoAEditar = proyectoDAO.obtenerProyectoPorId(proyecto.id);
            TxtNombreProyecto.Text = proyectoAEditar.nombre;
            RtxtDescripcion.Text = proyectoAEditar.descripcion;

        }

        private void rellenarAmigos()
        {
            CboAmigos.Items.Clear();
            amigos = usuarioDAO.obtenerAmigosPorID(usuario.id);
            //Verifica si el texto del primer subelemento de cada elemento es igual al valor de nombre de usuario
            //La función Any() devuelve true si al menos un elemento cumple esta condición, y false si ninguno lo hace
            foreach (Usuario amigo in amigos)
            {
                if (!LstMiembro.Items.Cast<ListViewItem>().Any(item => item.SubItems[0].Text.Equals(amigo.nombreUsuario)))
                {
                    CboAmigos.Items.Add(amigo.nombreUsuario);
                }
            }
        }

        private void rellenarMiembros()
        {
            LstMiembro.Items.Clear();

            List<Usuario> listaMiembros = usuarioDAO.obtenerMiembros(proyecto);

            foreach (Usuario u in listaMiembros)
            {

                if (u.id != usuario.id)
                {
                    ListViewItem agregarMiembros = new ListViewItem(u.nombreUsuario);
                    agregarMiembros.SubItems.Add(u.correo);

                    LstMiembro.Items.Add(agregarMiembros);

                    if (!LstAdmins.Items.Cast<ListViewItem>().Any(item => item.SubItems[0].Text.Equals(u.nombreUsuario)))
                    {
                        CboMiembros.Items.Add(u.nombreUsuario);
                    }
                }

            }
        }

        public void rellenarAdministradores()
        {
            CboMiembros.Items.Clear();
            LstAdmins.Items.Clear();    
            List<Usuario> listaAdministradores = usuarioDAO.obtenerAdministradores(proyecto.id);
            foreach (Usuario u in listaAdministradores)
            {

                if (u.id != usuario.id)
                {
                    ListViewItem agregarMiembros = new ListViewItem(u.nombreUsuario);
                    agregarMiembros.SubItems.Add(u.correo);

                    LstAdmins.Items.Add(agregarMiembros);

                }

            }

        }

        private void CboAmigos_SelectedIndexChanged(object sender, EventArgs e)
        {
            cambios = true;
            //al seleccionar un amigo que se elimine de cbo y se añada a la listview (el nombre de usuario y el correo)
            string itemSeleccionado = CboAmigos.SelectedItem.ToString();
            ListViewItem datosIngreso = new ListViewItem(itemSeleccionado);
            // Una vez seleccionamos un amigo de la lista lo agregaremos a la tabla y lo eliminaremos de la lista
            CboAmigos.Items.Remove(itemSeleccionado);
            Usuario amigo = usuarioDAO.buscarUsuarioPorNombreOCorreo(itemSeleccionado);
            datosIngreso.SubItems.Add(amigo.correo);
            LstMiembro.Items.Add(datosIngreso);
            CboMiembros.Items.Add(itemSeleccionado);

        }
        private void CboMiembros_SelectedIndexChanged(object sender, EventArgs e)
        {
            cambios = true;
            //al seleccionar un miembro que se elimine de cbo y se añada a la listview (el nombre de usuario y el correo)
            string itemSeleccionado = CboMiembros.SelectedItem.ToString();
            ListViewItem datosIngreso = new ListViewItem(itemSeleccionado);
            // Una vez seleccionamos un miembro de la lista lo agregaremos a la tabla y lo eliminaremos de la lista
            CboMiembros.Items.Remove(itemSeleccionado);
            Usuario miembro = usuarioDAO.buscarUsuarioPorNombreOCorreo(itemSeleccionado);
            datosIngreso.SubItems.Add(miembro.correo);
            LstAdmins.Items.Add(datosIngreso);
        }

        public void añadirListaMiembros(Usuario u)
        {
            // Añadir el miembro a la lista
            ListViewItem nuevoMiembro = new ListViewItem(u.nombreUsuario);
            nuevoMiembro.SubItems.Add(u.correo);
            LstMiembro.Items.Add(nuevoMiembro);
            TxtCorreo.Clear();

            // Quitar al miembro de la lista de amigos si es un amigo
            if (CboAmigos.Items.Contains(u.nombreUsuario))
            {
                CboAmigos.Items.Remove(u.nombreUsuario);
            }
        }

        //Añadir un miembro mediante el correo electronico del usuario
        private void BtnAñadir_Click(object sender, EventArgs e)
        {
            cambios = true;
            bool existe = false;
            string correoIntroducido = TxtCorreo.Text.Trim();
            //verificamos que el correo introducido exista
            if (usuarioDAO.existeUsuarioPorCorreo(correoIntroducido))
            {
                Usuario u = usuarioDAO.buscarUsuarioPorNombreOCorreo(correoIntroducido);
                // Nos descartamos a nosotros:
                if (!u.nombreUsuario.Equals(usuario.nombreUsuario))
                {
                    if (LstMiembro.Items.Count != 0)
                    {
                        foreach (ListViewItem i in LstMiembro.Items)
                        {
                            // Descartamos si ya lo hemos seleccionado:
                            if (i.SubItems[0].Text.Equals(u.nombreUsuario))
                            {
                                existe = true;
                            }
                        }

                        if (!existe)
                        {
                            añadirListaMiembros(u);
                        }
                        else
                        {
                            MessageBox.Show("No puedes agregar dos veces a " + u.nombreUsuario + " - " + u.correo + " acaso pretendes darle el doble de trabajo?.", "¡CUIDADO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        añadirListaMiembros(u);
                    }
                }
                else
                {
                    MessageBox.Show("¡Cuidado! Exceso de ego intentando agregarte a ti mismo. \n¡No te preocupes, ya eres tu mejor amigo!", "¡Advertencia!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("El correo no esta disponible en esta aplicacion", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void IcbVolverInicio_Click(object sender, EventArgs e)
        {
            if (cambios || TxtNombreProyecto.Text != proyecto.nombre || RtxtDescripcion.Text != proyecto.descripcion)
            {
                DialogResult resultado = MessageBox.Show("¿Seguro que quieres volver al area?. Perderas todos los cambios", "¡CUIDADO!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (resultado == DialogResult.Yes)
                {
                    frmPrincipal.iniciarArea();
                }
            }
            else
            {
                frmPrincipal.iniciarArea();
            }

        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            cambios = false;
            // Datos Proyecto
            TxtNombreProyecto.Text = proyecto.nombre;
            RtxtDescripcion.Text = proyecto.descripcion;
            // Miembros
           
            rellenarAdministradores();
            rellenarMiembros();
            rellenarAmigos();
            TxtCorreo.Clear();
        }

        private void BtnEliminarMiembro_Click(object sender, EventArgs e)
        {
            if (LstMiembro.SelectedItems.Count > 0)
            {
                cambios = true;
                string itemSeleccionado = LstMiembro.SelectedItems[0].Text;

                //ver si el item seleccionado pertenece a tu lista de amigos y si pertenece volver a agregarlo
                foreach (Usuario u in amigos)
                {
                    if (u.nombreUsuario.Equals(itemSeleccionado))
                    {
                        CboAmigos.Items.Add(itemSeleccionado);
                    }
                }

                var itemAEliminar = LstAdmins.Items.Cast<ListViewItem>().FirstOrDefault(item => item.SubItems[0].Text.Equals(itemSeleccionado));

                // Si el miembro esta como admin eliminarlo de la lista
                if (itemAEliminar != null)
                {
                    LstAdmins.Items.Remove(itemAEliminar);
                }
                else
                {
                    CboMiembros.Items.Remove(itemSeleccionado);

                }

                LstMiembro.SelectedItems[0].Remove();
            }
            else
            {
                MessageBox.Show("No se a que posible miembro quieres eliminar.\n Estaria bien si lo seleccionaras primero...", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnEliminarAdmin_Click(object sender, EventArgs e)
        {
            if (LstAdmins.SelectedItems.Count > 0)
            {
                cambios = true;
                string itemSeleccionado = LstAdmins.SelectedItems[0].Text;

                CboMiembros.Items.Add(itemSeleccionado);

                LstAdmins.SelectedItems[0].Remove();

            }
            else
            {
                MessageBox.Show("Selecciona un administrador para eliminar", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private List<int> obtenerIdsUsuarios(List<Usuario> listaUsuarios)
        {
            List<int> listaIds = new List<int>();

            foreach (Usuario usuario in listaUsuarios)
            {
                listaIds.Add(usuario.id);
            }
            return listaIds;
        }
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (cambios || TxtNombreProyecto.Text != proyecto.nombre || RtxtDescripcion.Text != proyecto.descripcion)
            {

                List<Usuario> miembros = new List<Usuario>();
                // Recoger todos los nombres de los usuarios que van a ser miembros
                foreach (ListViewItem item in LstMiembro.Items)
                {
                    miembros.Add(usuarioDAO.buscarUsuarioPorNombreOCorreo(item.SubItems[0].Text));
                }


                Modelo.Proyecto p = new Modelo.Proyecto(TxtNombreProyecto.Text, RtxtDescripcion.Text, miembros);

                // Cambios datos del proyecto
                proyectoDAO.actualizarDatosProyecto(p, proyecto.id);



                // Cambios miembros del proyecto
                List<int> idAntiguos = obtenerIdsUsuarios(proyecto.miembros);
                List<int> idActuales = obtenerIdsUsuarios(miembros);

                foreach (int id in idActuales)
                {
                    if (!idAntiguos.Contains(id))
                    {
                        proyectoDAO.insertarMiembrosProyecto(proyecto.id, id);
                        string mensaje = usuario.nombreUsuario + " te ha agregado al proyecto " + proyecto.nombre;
                        usuarioDAO.enviarNotificacion(usuario.id, id, mensaje);
                    }
                    // Si el nombre del proyecto ha cambiado mandaremos un mensaje a todos sus miembros para que sean conscientes de ellos
                    if (!TxtNombreProyecto.Text.Equals(proyecto.nombre))
                    {
                        string mensaje = usuario.nombreUsuario + " ha cambiado el nombre del proyecto de { " + proyecto.nombre + " - " + TxtNombreProyecto.Text + " }";

                        usuarioDAO.enviarNotificacion(usuario.id, id, mensaje);
                    }
                }
                foreach (int id in idAntiguos)
                {
                    if (!idActuales.Contains(id) && id != usuario.id)
                    {
                        proyectoDAO.eliminarMiembro(proyecto.id, id);

                        MessageBox.Show(" " + id + proyecto.id);

                        List<Modelo.Tarea> tareasUsuario = tareaDAO.obtenerTareasPorProyectoYUsuario(proyecto.id,id);
                        MessageBox.Show(" " + id + tareasUsuario.Count);
                        foreach (Modelo.Tarea tarea in tareasUsuario)
                        {
                            tareaDAO.eliminarUsuarioTarea(tarea.id, id);
                            usuarioDAO.enviarNotificacion(usuario.id, id, "Se te ha eliminado de la tarea " + tarea.nombre + " en el proyecto " + tareaDAO.obtenerNombreProyecto(tarea));
                        }

                        string mensaje = usuario.nombreUsuario + " te ha eliminado del proyecto " + proyecto.nombre;
                        usuarioDAO.enviarNotificacion(usuario.id, id, mensaje);
                    }

                }


                // Cambios administradores de proyecto
                List<Usuario> administradoresAntiguos = usuarioDAO.obtenerAdministradores(proyecto.id);
                List<Usuario> administradoresActuales = new List<Usuario>();


                foreach (ListViewItem admin in LstAdmins.Items)
                {
                    administradoresActuales.Add(usuarioDAO.buscarUsuarioPorNombreOCorreo(admin.SubItems[0].Text));
                }
                List<int> idAdminActuales = obtenerIdsUsuarios(administradoresActuales);
                List<int> idAdminAntiguos = obtenerIdsUsuarios(administradoresAntiguos);

                foreach (int id in idAdminActuales)
                {
                    if (!idAdminAntiguos.Contains(id))
                    {
                        proyectoDAO.insertarAdminProyecto(proyecto.id, id);
                        string mensaje = usuario.nombreUsuario + " te ha asignado administrador del proyecto " + proyecto.nombre;
                        usuarioDAO.enviarNotificacion(usuario.id, id, mensaje);
                    }
                }
                foreach (int id in idAdminAntiguos)
                {
                    if (!idAdminActuales.Contains(id) && id != usuario.id)
                    {
                        proyectoDAO.eliminarAdmin(proyecto.id, id);
                        string mensaje = usuario.nombreUsuario + " te ha eliminado de los administradores del proyecto " + proyecto.nombre;
                        usuarioDAO.enviarNotificacion(usuario.id, id, mensaje);
                    }
                }

                MessageBox.Show("!Se han actualizado correctamente los datos del proyecto " + TxtNombreProyecto.Text + "!", "¡ATENCION!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmPrincipal.crearArea(usuario,proyecto.id);
                frmPrincipal.cerrarEditarProyecto();
            }
            else
            {
                MessageBox.Show("No se ha realizado ningun cambio...", "¡ATENCION!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmPrincipal.crearArea(usuario, proyecto.id);
                frmPrincipal.cerrarEditarProyecto();
            }
        }

        private void FrmEditarProyecto_Resize(object sender, EventArgs e)
        {
            // TOP - Titulo y volver atrás:
            LblEditarProyecto.Left = (panelTop.Width - LblEditarProyecto.Width) / 2;
            LblEditarProyecto.Top = (panelTop.Height - LblEditarProyecto.Height) / 2;
            IcbVolverInicio.Left = 40;
            IcbVolverInicio.Top = (panelTop.Height - IcbVolverInicio.Height) / 2;

            int panelSpacing = 15; // Espacio entre los paneles
            int totalWidth = panelDatos.Width + panelModMiembros.Width + panelSpacing;

            // Calcular la posición inicial para centrar los paneles horizontalmente
            int startX = (PanelEditarProyecto.ClientSize.Width - totalWidth) / 2;

            // Ajustar la posición de los paneles
            panelDatos.Left = panelSpacing;
            panelDatos.Top = panelTop.Height + 20;

            panelModMiembros.Left = panelDatos.Right + panelSpacing;
            panelModMiembros.Top = panelTop.Height + 20;

            // Ajustar la posición de los botones debajo de los paneles
            int btnSpacing = 20; // Espacio entre los botones
            int btnTotalWidth = BtnGuardar.Width + btnSpacing + BtnLimpiar.Width;

            int btnStartX = (PanelEditarProyecto.ClientSize.Width - btnTotalWidth) / 2;
            int btnStartY = Math.Max(panelDatos.Bottom, panelModMiembros.Bottom) + 40; // Espacio entre los paneles y los botones

            BtnGuardar.Left = btnStartX;
            BtnGuardar.Top = btnStartY;

            BtnLimpiar.Left = BtnGuardar.Right + btnSpacing;
            BtnLimpiar.Top = btnStartY;

        }
    }
}
