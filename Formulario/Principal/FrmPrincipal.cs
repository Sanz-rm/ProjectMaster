using MySql.Data.MySqlClient;
using ProjectMaster.Conection;
using ProjectMaster.Formulario.Amigos;
using ProjectMaster.Formulario.Loggin;
using ProjectMaster.Formulario.Perfil;
using ProjectMaster.Formulario.Proyecto;
using ProjectMaster.Formulario.Tarea;
using ProjectMaster.Modelo;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;

namespace ProjectMaster.Formulario.Principal
{
    public partial class FrmPrincipal : Form
    {
        
        private Conexion conexion;
        private MySqlConnection conexion2;

        private FrmRegistro frmRegistro;
        private FrmInicio frmInicio;
        private FrmArea frmArea;
        private FrmPerfil frmPerfil;
        private FrmCrearProyecto frmCrearProyecto;
        private FrmAgregarAmigo frmAgregarAmigo;
        private FrmVerPerfil frmVerPerfil;
        private FrmEditarProyecto frmEditarProyecto;
        private FrmNotificacion frmNotificacion;
        private FrmCrearTarea frmCrearTarea;
        private FrmEditarTarea frmEditarTarea;
        private FrmChat frmChat;



        public FrmPrincipal()
        {
            InitializeComponent();

            conexion = new Conexion();
            conexion.crearConexion();
            conexion2 = conexion.obtenerConexion();

            crearInicio();
        }

        // Verificamos si esta el hilo de ver el numero de notificaciones esta abierto y si esta abierto lo finalizaremos y esperamos a que termine
        public void cerrarHiloNotificaciones()
        {
            Cursor.Current = Cursors.WaitCursor; // Cambiar el cursor a espera

            FrmArea.finalizarHiloNotificaciones = true;
            if (FrmArea.obtenerNumNotisSinLeerHilo != null && FrmArea.obtenerNumNotisSinLeerHilo.IsAlive)
            {
                try
                {
                    FrmArea.obtenerNumNotisSinLeerHilo.Abort();
                }
                catch (ThreadAbortException ex)
                {
                    // Manejo de excepción si es necesario
                }
            }

            Cursor.Current = Cursors.Default; // Volver al cursor predeterminado

        }


        // Verificamos si esta el hilo de ver mensajes no leidos de nuestro chat esta abierto y si esta abierto lo finalizaremos y esperamos a que termine
        public void cerrarHiloChat()
        {
            // Cambiar el cursor a espera
            Cursor.Current = Cursors.WaitCursor;

            FrmChat.finalizarHilo = true;
            if (FrmChat.mostrarNoLeidosHilo != null && FrmChat.mostrarNoLeidosHilo.IsAlive)
            {
                try { 
                FrmChat.mostrarNoLeidosHilo.Abort();
                }
                catch (ThreadAbortException ex)
                {
                    // Manejo de excepción si es necesario
                }

            }
            // Volver al cursor predeterminado
            Cursor.Current = Cursors.Default;

        }


        // ---------------------------------------------------------------------------
        // PANTALLA DE REGISTRO:
        public void crearRegistro()
        {
            frmRegistro = new FrmRegistro(this, conexion2);
            frmRegistro.MdiParent = this;
            frmRegistro.Dock = DockStyle.Fill;
            frmRegistro.Show();
            frmRegistro.BringToFront();
        }

        public void cerrarRegistro()
        {
            if (frmRegistro != null && !frmRegistro.IsDisposed)
            {
                frmRegistro.Close();
            }
        }

        // ---------------------------------------------------------------------------
        // PANTALLA INICIO DE SESION:
        public void crearInicio()
        {
            frmInicio = new FrmInicio(this,conexion2);
            frmInicio.MdiParent = this;
            frmInicio.Dock = DockStyle.Fill;
            frmInicio.Show();
            frmInicio.BringToFront();
            frmInicio.FormBorderStyle = FormBorderStyle.None;
        }

        public void cerrarInicio()
        {
            if (frmInicio != null && !frmInicio.IsDisposed)
            {
                frmInicio.Close();
            }
        }

        // ---------------------------------------------------------------------------
        // PANTALLA ÁREA PRINCIPAL DE USUARIO:

        public void crearArea(Usuario usuario, int idP) 
        {
            cerrarArea();

            frmArea = new FrmArea(this, conexion2, usuario, idP);
            frmArea.MdiParent = this;
            frmArea.Dock = DockStyle.Fill;
            frmArea.Show();
            frmArea.BringToFront();
        }

        public void cerrarArea()
        {
            if (frmArea != null && !frmArea.IsDisposed)
            {
                frmArea.Close();
            }
        }

        public void iniciarArea()
        {
            frmArea.BringToFront();
        }


        // ---------------------------------------------------------------------------
        // PANTALLA DE LA CONFIGURACIÓN DE PERFIL:
        public void iniciarPerfil(Usuario usuario)
        {
            frmPerfil = new FrmPerfil(this, conexion2, usuario);
            frmPerfil.MdiParent = this;
            frmPerfil.Dock = DockStyle.Fill;
            frmPerfil.Show();
            frmPerfil.BringToFront();

        }
        public void cerrarPerfil()
        {
            if (frmPerfil != null && !frmPerfil.IsDisposed)
            {
                frmPerfil.Close();
            }
        }


        // ---------------------------------------------------------------------------
        // PANTALLA DE CREAR UN NUEVO PROYECTO:
        public void iniciarCrearProyecto(Usuario usuario)
        {
            frmCrearProyecto = new FrmCrearProyecto(this, conexion2, usuario);
            frmCrearProyecto.MdiParent = this;
            frmCrearProyecto.Dock = DockStyle.Fill;
            frmCrearProyecto.Show();
            frmCrearProyecto.BringToFront();

        }
        public void cerrarCrearProyecto()
        {
            if (frmCrearProyecto != null && !frmCrearProyecto.IsDisposed)
            {
                frmCrearProyecto.Close();
            }
        }

        // ---------------------------------------------------------------------------
        // PANTALLA DE AGREGAR UN NUEVO AMIGO:

        public void iniciarAgregarAmigo(Usuario usuario, List<Usuario> listaAmigos)
        {
            frmAgregarAmigo = new FrmAgregarAmigo(this, conexion2, usuario, listaAmigos);
            frmAgregarAmigo.MdiParent = this;
            frmAgregarAmigo.Dock = DockStyle.Fill;
            frmAgregarAmigo.Show();
            frmAgregarAmigo.BringToFront();

        }
        public void cerrarAgregarAmigo()
        {
            if (frmAgregarAmigo != null && !frmAgregarAmigo.IsDisposed)
            {
                frmAgregarAmigo.Close();
            }
        }

        // ---------------------------------------------------------------------------
        // PANTALLA PARA VER PERFIL DE AMIGO/MIEMBRO:

        public void iniciarVerPerfil(Usuario usuario,Usuario amigo, List<Modelo.Proyecto> listaProyectosUsuario)
        {
            frmVerPerfil = new FrmVerPerfil(this, conexion2, usuario, amigo, listaProyectosUsuario);
            frmVerPerfil.MdiParent = this;
            frmVerPerfil.Dock = DockStyle.Fill;
            frmVerPerfil.Show();
            frmVerPerfil.BringToFront();

        }
        public void cerrarVerPerfil()
        {
            if (frmVerPerfil != null && !frmVerPerfil.IsDisposed)
            {
                frmVerPerfil.Close();
            }
        }

        // ---------------------------------------------------------------------------
        // PANTALLA DE EDITAR UN PROYECTO:
        public void crearEditarProyecto(Modelo.Proyecto proyecto, Usuario usuario)
        {
            frmEditarProyecto = new FrmEditarProyecto(this, conexion2, usuario, proyecto);
            frmEditarProyecto.MdiParent = this;
            frmEditarProyecto.Dock = DockStyle.Fill;
            frmEditarProyecto.Show();
            frmEditarProyecto.BringToFront();

        }
        public void cerrarEditarProyecto()
        {
            if (frmEditarProyecto != null && !frmEditarProyecto.IsDisposed)
            {
                frmEditarProyecto.Close();
            }
        }
        // ---------------------------------------------------------------------------
        // PANTALLA DE EDITAR UN PROYECTO:
        public void crearCrearTarea(Usuario usuario, Modelo.Proyecto proyecto)
        {
            frmCrearTarea = new FrmCrearTarea(this, conexion2, usuario, proyecto);
            frmCrearTarea.MdiParent = this;
            frmCrearTarea.Dock = DockStyle.Fill;
            frmCrearTarea.Show();
            frmCrearTarea.BringToFront();
        }
        public void cerrarCrearTarea()
        {
            if (frmCrearTarea != null && !frmCrearTarea.IsDisposed)
            {
                frmCrearTarea.Close();
            }
        }

        // ---------------------------------------------------------------------------
        // PANTALLA DE EDITAR UN PROYECTO:
        public void crearEditarTarea(Usuario usuario, Modelo.Tarea tarea)
        {
            frmEditarTarea = new FrmEditarTarea(this, conexion2, usuario, tarea);
            frmEditarTarea.MdiParent = this;
            frmEditarTarea.Dock = DockStyle.Fill;
            frmEditarTarea.Show();
            frmEditarTarea.BringToFront();
        }
        public void cerrarEditarTarea()
        {
            if (frmEditarTarea != null && !frmEditarTarea.IsDisposed)
            {
                frmEditarTarea.Close();
            }
        }

        // ---------------------------------------------------------------------------
        // PANTALLA DE VER LAS NOTIFICACIONES
        public void crearNotificacion(Usuario usuario, bool hayNotisSinLeer)
        {
            frmNotificacion = new FrmNotificacion(this, conexion2, usuario, hayNotisSinLeer);
            frmNotificacion.MdiParent = this;
            frmNotificacion.Dock = DockStyle.Fill;
            frmNotificacion.Show();
            frmNotificacion.BringToFront();

        }
        public void cerrarNotificacion()
        {
            if (frmNotificacion != null && !frmNotificacion.IsDisposed)
            {
                frmNotificacion.Close();
            }
        }

        // ---------------------------------------------------------------------------
        // PANTALLA DE CHAT
        public void crearChat(Usuario usuario1,Usuario usuario2)
        {
            frmChat = new FrmChat(this, conexion2, usuario1, usuario2);
            frmChat.MdiParent = this;
            frmChat.Dock = DockStyle.Fill;
            frmChat.Show();
            frmChat.BringToFront();

        }
        public void cerrarChat()
        {
            if (frmChat != null && !frmChat.IsDisposed)
            {
                frmChat.Close();
            }
        }  
    }
}
