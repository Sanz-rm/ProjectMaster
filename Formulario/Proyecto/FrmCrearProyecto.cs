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
    public partial class FrmCrearProyecto : Form
    {

        private FrmPrincipal frmPrincipal;
        private UsuarioDAO usuarioDAO;
        private ProyectoDAO proyectoDAO;
        private Usuario usuario;
        Modelo.Proyecto proyecto;
        List<Usuario> amigos;


        public FrmCrearProyecto(FrmPrincipal frmP, MySqlConnection conexion2, Usuario user)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            frmPrincipal = frmP;
            usuario = user;
            usuarioDAO = new UsuarioDAO(conexion2);
            proyectoDAO = new ProyectoDAO(conexion2);
            rellenarAmigos();
        }
        private void rellenarAmigos()
        {
            CboAmigos.Items.Clear();
            amigos = usuarioDAO.obtenerAmigosPorID(usuario.id);
            // Buscamos todos los usuarios que tengamos como amigos y los añadimos a nuestra lista de amigos
            foreach (Usuario amigo in amigos)
            {
                CboAmigos.Items.Add(amigo.nombreUsuario);
            }

        }


        public void añadirListaMiembros(Usuario u)
        {
            // Añadir el miembro a la lista
            ListViewItem nuevoMiembro = new ListViewItem(u.nombreUsuario);
            nuevoMiembro.SubItems.Add(u.correo);
            LstMiembros.Items.Add(nuevoMiembro);
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
            bool existe = false;
            string correoIntroducido = TxtCorreo.Text.Trim();
            //verificamos que el correo introducido exista
            if (usuarioDAO.existeUsuarioPorCorreo(correoIntroducido))
            {
                Usuario u = usuarioDAO.buscarUsuarioPorNombreOCorreo(correoIntroducido);
                // Nos descartamos a nosotros:
                if (!u.nombreUsuario.Equals(usuario.nombreUsuario))
                {
                    if (LstMiembros.Items.Count != 0)
                    {
                        foreach (ListViewItem i in LstMiembros.Items)
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

        //Añadir miembro desde la lista de amigos
        private void CboAmigos_SelectedIndexChanged(object sender, EventArgs e)
        {
            //al seleccionar un amigo que se elimine de cbo y se añada a la listview (el nombre de usuario y el correo)
            string itemSeleccionado = CboAmigos.SelectedItem.ToString();
            ListViewItem datosIngreso = new ListViewItem(itemSeleccionado);
            // Una vez seleccionamos un amigo de la lista lo agregaremos a la tabla y lo eliminaremos de la lista
            CboAmigos.Items.Remove(itemSeleccionado);
            Usuario amigo = usuarioDAO.buscarUsuarioPorNombreOCorreo(itemSeleccionado);
            datosIngreso.SubItems.Add(amigo.correo);
            LstMiembros.Items.Add(datosIngreso);

        }

        //Eliminar un usuario de la lista de posibles miembros
        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (LstMiembros.SelectedItems.Count > 0)
            {
                string itemSeleccionado = LstMiembros.SelectedItems[0].Text;

                // Usuario usuarioAeliminar = usuarioDAO.buscarUsuarioPorNombreOCorreo(itemSeleccionado);

                //ver si el item seleccionado pertenece a tu lista de amigos y si pertenece volver a agregarlo
                foreach (Usuario s in amigos)
                {
                    if (s.nombreUsuario.Equals(itemSeleccionado))
                    {
                        CboAmigos.Items.Add(itemSeleccionado);
                    }
                }
                //eliminarlo de la list view
                LstMiembros.SelectedItems[0].Remove();

            }
            else
            {
                MessageBox.Show("No se a que posible miembro quieres eliminar.\n Estaria bien si lo seleccionaras primero...", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
            rellenarAmigos();
        }

        private void limpiar()
        {
            TxtNombreProyecto.Clear();
            TxtCorreo.Clear();
            RtxtDescripcion.Clear();
            LstMiembros.Items.Clear();
        }

        // Crearemos el proyecto con sus datos y rellenaremos los miembros que participan en el
        private void BtnCrear_Click(object sender, EventArgs e)
        {
            string nombre = TxtNombreProyecto.Text;
            string descripcion ="El creador del proyecto es: "+usuario.nombreUsuario+".\n" + RtxtDescripcion.Text;

            if (!string.IsNullOrEmpty(nombre) && !string.IsNullOrEmpty(descripcion))
            {
                List<string> nombresUsuarios = new List<string>();

                // Recoger todos los nombres de los usuarios que van a ser miembros
                foreach (ListViewItem item in LstMiembros.Items)
                {
                    nombresUsuarios.Add(item.Text);
                }

                List<Usuario> miembros = new List<Usuario>();

                // Convertir los nombres de usuarios en objetos Usuario y agregarlos a la lista miembros
                foreach (string nombreU in nombresUsuarios)
                {
                    Usuario usuario1 = usuarioDAO.buscarUsuarioPorNombreOCorreo(nombreU);
                    if (usuario1 != null)
                    {
                        miembros.Add(usuario1);
                    }
                }
                //Agregar a la lista de miembros al creador
                miembros.Add(usuario);

                // Inicializar el proyecto con los datos de nombre, descripción y lista de miembros
                proyecto = new Modelo.Proyecto(nombre, descripcion, miembros);


                // Se crea un proyecto y se inserta en la base de datos
                proyectoDAO.insertarProyecto(proyecto);

                // Insercción en la relación del proyecto y usuario
                proyectoDAO.insertarMiembrosProyectoNuevo(proyecto);

                //Enviar notificacion a cada uno de los miembros del proyecto
                foreach (Usuario miembro in miembros)
                {
                    if(miembro.id != usuario.id){
                        string mensaje = usuario.nombreUsuario + " te ha agregado al proyecto " + proyecto.nombre;
                        usuarioDAO.enviarNotificacion(usuario.id, miembro.id, mensaje);
                    }
                }
                proyectoDAO.insertarAdminProyectoNuevo(usuario);

                MessageBox.Show("El proyecto '" + TxtNombreProyecto.Text + "' se ha creado correctamente", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiar();
                frmPrincipal.crearArea(usuario,proyecto.id);
                frmPrincipal.cerrarCrearProyecto();
            }
            else
            {
                MessageBox.Show("Primera tarea del proyecto: ponle nombre y descripcion", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void IcbVolverInicio_Click(object sender, EventArgs e)
        {
            // Aviso si se ha empezado a rellenar:
            if (camposRellenados())
            {
                DialogResult resultado = MessageBox.Show("¿Seguro que quieres volver? Se perderá la información no guardada", "ATENCIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (resultado == DialogResult.Yes)
                {

                    // rellenarAmigos();
                    frmPrincipal.crearArea(usuario,0);
                    frmPrincipal.cerrarCrearProyecto();
                }
            }
            else
            {
                // Si no ha rellenado ningun dato, redirigiremos directamente al area
                frmPrincipal.crearArea(usuario, 0);
                frmPrincipal.cerrarCrearProyecto();
            }
        }

        // Comprobamos si ha introducido algun dato
        private bool camposRellenados()
        {
            bool rellenado = false;
            if (TxtNombreProyecto.Text.Length > 0 || RtxtDescripcion.Text.Length > 0 || TxtCorreo.Text.Length > 0 || LstMiembros.SelectedItems.Count > 0)
                rellenado = true;

            return rellenado;
        }

        private void FrmCrearProyecto_Resize(object sender, EventArgs e)
        {
            // Center LblTitulo
            LblNuevoProyecto.Left = (panelTop.Width - LblNuevoProyecto.Width) / 2;
            LblNuevoProyecto.Top = (panelTop.Height - LblNuevoProyecto.Height) / 2;

            // Align IconButton to the left with margin
            IcbVolverInicio.Left = 40;
            IcbVolverInicio.Top = (panelTop.Height - IcbVolverInicio.Height) / 2;

            int panelSpacing = 50; // Espacio entre los paneles
            int totalWidth = panelDatos.Width + panelMiembros.Width + panelSpacing;

            // Calcular la posición inicial para centrar los paneles horizontalmente
            int startX = (PanelCrearProyecto.ClientSize.Width - totalWidth) / 2;

            // Ajustar la posición de los paneles
            panelDatos.Left = startX;
            panelDatos.Top = (PanelCrearProyecto.ClientSize.Height - panelDatos.Height) / 2;

            panelMiembros.Left = startX + panelDatos.Width + panelSpacing;
            panelMiembros.Top = (PanelCrearProyecto.ClientSize.Height - panelMiembros.Height) / 2;

            // Ajustar la posición de los botones debajo de los paneles
            int btnSpacing = 20; // Espacio entre los botones
            int btnTotalWidth = BtnCrear.Width + btnSpacing + BtnLimpiar.Width;

            int btnStartX = (PanelCrearProyecto.ClientSize.Width - btnTotalWidth) / 2;
            int btnStartY = Math.Max(panelDatos.Bottom, panelMiembros.Bottom) + 40; // Espacio entre los paneles y los botones

            BtnCrear.Left = btnStartX;
            BtnCrear.Top = btnStartY;

            BtnLimpiar.Left = BtnCrear.Right + btnSpacing;
            BtnLimpiar.Top = btnStartY;
        }

    }
}
