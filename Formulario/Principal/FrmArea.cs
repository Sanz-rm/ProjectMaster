using MySql.Data.MySqlClient;
using ProjectMaster.DAO;
using ProjectMaster.Formulario.Amigos;
using ProjectMaster.Modelo;
using ProjectMaster.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Forms;
using static System.Windows.Forms.MonthCalendar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace ProjectMaster.Formulario.Principal
{
    public partial class FrmArea : Form
    {
        private FrmPrincipal frmPrincipal;
        private UsuarioDAO usuarioDAO;
        private ProyectoDAO proyectoDAO;
        private TareaDAO tareaDAO;
        private Usuario usuario;
        private Modelo.Proyecto proyectoActual;
        private Modelo.Tarea tareaActual;
        private List<Usuario> listaAmigos;
        private List<Modelo.Proyecto> listaProyectos;
        private List<Modelo.Tarea> listaTareas;
        private List<Modelo.Tarea> listaTareasFechas;
        private List<System.Windows.Forms.ListBox> cuadrosTareas;
        private int idProyectoActual;
        private List<int> tareasCaducadas;
        private List<int> tareasACaducar;
        public static bool finalizarHiloNotificaciones;
        public static Thread obtenerNumNotisSinLeerHilo;

        public FrmArea(FrmPrincipal frmP, MySqlConnection conexion2, Usuario user, int idP)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            frmPrincipal = frmP;

            usuarioDAO = new UsuarioDAO(conexion2);
            proyectoDAO = new ProyectoDAO(conexion2);
            tareaDAO = new TareaDAO(conexion2);
            usuario = user;
            proyectoActual = new Modelo.Proyecto();
            tareaActual = new Modelo.Tarea();
            tareasCaducadas = new List<int>();
            tareasACaducar = new List<int>();
            finalizarHiloNotificaciones = false;

            if (idP > 0)
                idProyectoActual = idP;
            rellenarDatos();
        }

        // ----------------------------------------------------------------------------------------------------------------------
        // --------------------------------------- ELEMENTOS DEL ÁREA GENERAL ---------------------------------------------------
        // ----------------------------------------------------------------------------------------------------------------------

        // ------------------------------------------------------------------------------------------------------
        // Método para rellenar todos los datos del Area:
        private void rellenarDatos()
        {
            rellenarAvatarYUsuario();
            rellenarAmigos();
            rellenarProyectos();
        }

        // ------------------------------------------------------------------------------------------------------
        // Método para rellenar el icono del avatar y el nombre de usuario al abrir el formulario:
        private void rellenarAvatarYUsuario()
        {
            PcbAvatar.Image = Usuario.obtenerAvatarArea(usuario.codAvatar);

            LlblPerfil.Text = usuario.nombreUsuario;
        }

        // ------------------------------------------------------------------------------------------------------
        // Método para rellenar la lista de amigos:
        private void rellenarAmigos()
        {
            LstAmigos.Items.Clear();
            listaAmigos = usuarioDAO.obtenerAmigosPorID(usuario.id);
            foreach (Usuario u in listaAmigos)
            {
                LstAmigos.Items.Add(u.nombreUsuario);
            }
        }

        // ------------------------------------------------------------------------------------------------------
        // Método para rellenar la lista de proyectos:
        private void rellenarProyectos()
        {
            LstProyectos.Items.Clear();
            listaProyectos = proyectoDAO.obtenerProyectosOrdenadosPorID(usuario.id);
            foreach (Modelo.Proyecto p in listaProyectos)
            {
                LstProyectos.Items.Add(p.nombre);
                LstProyectosId.Items.Add(p.id);
            }
            if (idProyectoActual > 0)
            {
                mostrarProyecto(listaProyectos.Find(p => p.id == idProyectoActual));
                LstProyectos.SelectedIndex = LstProyectosId.Items.IndexOf(idProyectoActual);
            }
        }

        // ------------------------------------------------------------------------------------------------------
        // Método para abrir el perfil propio:
        private void abrirPerfil()
        {
            frmPrincipal.iniciarPerfil(usuario);
        }
        private void LlblPerfil_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            abrirPerfil();
        }
        private void PcbAvatar_Click(object sender, EventArgs e)
        {
            abrirPerfil();
        }

        // ------------------------------------------------------------------------------------------------------
        // Método para cerrar sesión:
        private void BtnCerrarSesion_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Seguro que quieres cerrar la sesión de " + usuario.nombreUsuario + "?\n Espero que por lo menos antes hayas hecho alguna tarea pendiente...", "¡CUIDADO!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (resultado == DialogResult.Yes)
            {
                frmPrincipal.crearInicio();
                frmPrincipal.cerrarArea();
            }
        }

        // ------------------------------------------------------------------------------------------------------
        // Abrir la pantalla de Agregar Amigo:
        private void BtnAñadirAmigo_Click(object sender, EventArgs e)
        {
            frmPrincipal.iniciarAgregarAmigo(usuario, listaAmigos);
            frmPrincipal.cerrarArea();
        }

        // ------------------------------------------------------------------------------------------------------
        // Abrir la pantalla del Perfil de Amigo:
        private void LstAmigos_DoubleClick(object sender, EventArgs e)
        {
            if (LstAmigos.SelectedItems.Count > 0)
            {
                string amigo = LstAmigos.SelectedItem as string;
                verPerfilUsuario(amigo);
            }
        }

        // ------------------------------------------------------------------------------------------------------
        // metodo para ver el perfil de un usario especifico ya sea amigo o miembro
        private void verPerfilUsuario(string usuario)
        {
            DialogResult resultado = MessageBox.Show("¿Quieres ver el perfil de " + usuario + "?", "¡ATENCION!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (resultado == DialogResult.Yes)
            {
                Usuario amigo = usuarioDAO.buscarUsuarioPorNombreOCorreo(usuario);
                if (amigo != null)
                {
                    frmPrincipal.iniciarVerPerfil(this.usuario, amigo, listaProyectos);
                }
            }
        }

        // ------------------------------------------------------------------------------------------------------
        // Para abrir el cuadro de notificaciones:
        private void BtnVerNotificaciones_Click(object sender, EventArgs e)
        {
            // Si hay notificaciones sin leer mostraremos por defecto todas las notificaciones, si no solo las no leidas
            bool hayNotisSinLeer = false;
            if (usuarioDAO.obtenerNumNotisSinLeer(usuario.id) > 0)
            {
                hayNotisSinLeer = true;
            }
            frmPrincipal.crearNotificacion(usuario, hayNotisSinLeer);
            frmPrincipal.cerrarArea();
        }

        // ------------------------------------------------------------------------------------------------------
        // Hilos para las notificaciones:
        private void FrmArea_Shown(object sender, EventArgs e)
        {
            obtenerNumNotisSinLeerHilo = new Thread(rellenarNumNotificacionesSinLeer);
            obtenerNumNotisSinLeerHilo.IsBackground = true;
            obtenerNumNotisSinLeerHilo.Start();
        }

        // ------------------------------------------------------------------------------------------------------
        // Método para comprobar si hay nuevas notificaciones que ver:
        private void rellenarNumNotificacionesSinLeer()
        {
            while (!finalizarHiloNotificaciones)
            {
                int notificacionesSinLeer = usuarioDAO.obtenerNumNotisSinLeer(usuario.id);

                if (LblNotificaciones.InvokeRequired)
                {
                    // Utilizar el método Invoke para actualizar los controles de la interfaz de usuario desde el hilo principal
                    this.Invoke(new Action(() =>
                    {
                        if (notificacionesSinLeer > 0)
                        {
                            LblNotificaciones.Text = "Tienes " + notificacionesSinLeer + " notificaciones sin leer...";
                        }
                        else
                        {
                            LblNotificaciones.Text = "Sin nuevas notificaciones";
                        }
                    }));
                }
                else
                {
                    // Actualizar directamente si no es necesario Invoke (caso raro pero por seguridad)
                    if (notificacionesSinLeer > 0)
                    {
                        LblNotificaciones.Text = "Tienes " + notificacionesSinLeer + " notificaciones sin leer...";
                    }
                    else
                    {
                        LblNotificaciones.Text = "Sin nuevas notificaciones";
                    }
                }
                Thread.Sleep(2000);
            }
        }

        // ------------------------------------------------------------------------------------------------------
        // Abrir la pantalla de Crear Proyecto:
        private void BtnAñadirProyecto_Click(object sender, EventArgs e)
        {
            frmPrincipal.iniciarCrearProyecto(usuario);
            frmPrincipal.cerrarArea();
        }

        // ------------------------------------------------------------------------------------------------------
        // Cerrar hilos:
        private void FrmArea_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmPrincipal.cerrarHiloNotificaciones();
        }

        // ----------------------------------------------------------------------------------------------------------------------
        // --------------------------------------------- MÉTODOS DE PROYECTOS ---------------------------------------------------
        // ----------------------------------------------------------------------------------------------------------------------

        // ------------------------------------------------------------------------------------------------------
        // Mostrar el área de Proyecto:
        private void LstProyectos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LstProyectos.SelectedItems.Count > 0)
            {
                panelDer.Visible = true;
                ajustarPanelDerecha();
                LstProyectosId.SelectedIndex = LstProyectos.SelectedIndex;
                int id = Convert.ToInt32(LstProyectosId.SelectedItem);
                proyectoActual = listaProyectos.Find(p => p.id == id);
                mostrarProyecto(proyectoActual);
            }
        }

        // ------------------------------------------------------------------------------------------------------
        // Mostrar la información del proyecto:
        private void mostrarProyecto(Modelo.Proyecto p)
        {
            if (p != null)
            {
                // Mostramos los elementos:
                elementosProyecto(true);
                // Info del proyecto:
                LblProyecto.Text = "PROYECTO: "+ p.nombre;
                LblDescripcion.Text = p.descripcion;
                // Mostrar las tareas propias por defecto:
                RdbPropias.Checked = true;
                RdbTodasFecha.Checked = true;
                listaTareas = tareaDAO.obtenerTareasPorProyectoYUsuario(proyectoActual.id, usuario.id);
                listaTareasFechas = new List<Modelo.Tarea>();
                rellenarTareas(listaTareas);
                // Recogemos las tareas con fecha
                tareasFecha();               
                // Mostrar miembros:
                p.miembros = usuarioDAO.obtenerMiembros(p);
                LstMiembros.Items.Clear();
                foreach (Usuario u in p.miembros)
                {
                    if (u.id != usuario.id)
                    {
                        LstMiembros.Items.Add(u.nombreUsuario);
                    }
                }
                cuadrosTareas = new List<System.Windows.Forms.ListBox>();
                cuadrosTareas.Add(LstPendientes);
                cuadrosTareas.Add(LstProceso);
                cuadrosTareas.Add(LstFinalizadas);
                // Marcar porcentaje de progreso:
                PrbProyecto.Value = obtenerProgresoProyecto();
                LblPorcentaje.Text = string.Format("{0}%", PrbProyecto.Value);
                if (PrbProyecto.Value == 100)
                    LblFin.Visible = true;
                else
                    LblFin.Visible = false;
            }
        }

        // ------------------------------------------------------------------------------------------------------
        // Mostrar en el área los elementos de Proyecto:
        private void elementosProyecto(bool accion)
        {
            // Elementos del proyecto:
            LblProyecto.Visible = accion;
            LblDescripcion.Visible = accion;
            LblProgreso.Visible = accion;
            PrbProyecto.Visible = accion;
            LblPorcentaje.Visible = accion;
            LblTareaSeleccionada.Visible = accion;
            LblPendiente.Visible = accion;
            LblProceso.Visible = accion;
            LblFinalizado.Visible = accion;
            LstPendientes.Visible = accion;
            LstProceso.Visible = accion;
            LstFinalizadas.Visible = accion;
            RdbPropias.Visible = accion;
            RdbTodas.Visible = accion;
            RdbTodasFecha.Visible = accion;
            RdbCaducanHoy.Visible = accion;
            RdbCaducadas.Visible = accion;
            LblMiembros.Visible = accion;
            LstMiembros.Visible = accion;
            BtnAbandonar.Visible = accion;

            if (usuarioDAO.esAdmin(proyectoActual.id, usuario.id))
            {
                BtnEditarProyecto.Visible = accion;
                BtnEliminarProyecto.Visible = accion;
                BtnNuevaTarea.Visible = accion;
            }
            else
            {
                BtnEditarProyecto.Visible = !accion;
                BtnEliminarProyecto.Visible = !accion;
                BtnNuevaTarea.Visible = !accion;
            }

            // Elementos de la presentación del área:
            PcbArea.Visible = !accion;
        }

        // ----------------------------------------------------------------------------------------------------------------------
        // Devolveremos el progreso actual en cada proyecto según el número de tareas y en qué estado se encuentran:
        private int obtenerProgresoProyecto()
        {
            int[] tareasSeccion = contarTareasPorSeccion();
            int porcentaje = 0;

            if (tareasSeccion.Sum() > 0)
            {
                // Calcular el peso de cada sección en la contribución total al progreso
                double pesoPendientes = 0.0;
                double pesoProceso = 0.5;
                double pesoFinalizadas = 1.0;

                // Calcular la contribución de cada sección al progreso total
                double contribucionPendientes = tareasSeccion[0] * pesoPendientes;
                double contribucionProceso = tareasSeccion[1] * pesoProceso;
                double contribucionFinalizadas = tareasSeccion[2] * pesoFinalizadas;

                // Sumar las contribuciones de todas las secciones
                double totalContribucion = contribucionPendientes + contribucionProceso + contribucionFinalizadas;

                // Calcular el porcentaje de progreso total
                porcentaje = (int)Math.Round(totalContribucion / tareasSeccion.Sum() * 100);
            }
            return porcentaje;
        }

        // -----------------------------------------------------------------------------
        // Contaremos cuantas tareas hay por cada seccion de proyecto seleccionado
        private int[] contarTareasPorSeccion()
        {
            int[] tareasSeccion = { 0, 0, 0 };
            List<Modelo.Tarea> tareasProyecto = tareaDAO.obtenerTareasPorProyecto(proyectoActual.id);
            foreach (Modelo.Tarea t in tareasProyecto)
            {
                if (t.estado.Equals("pendiente"))
                    tareasSeccion[0]++;
                else if (t.estado.Equals("en_proceso"))
                    tareasSeccion[1]++;
                else
                    tareasSeccion[2]++;
            }
            return tareasSeccion;
        }

        // ------------------------------------------------------------------------------------------------------
        // Abre la pantalla de editar proyecto:
        private void BtnEditarProyecto_Click(object sender, EventArgs e)
        {
            frmPrincipal.crearEditarProyecto(proyectoActual, usuario);
        }

        // -----------------------------------------------------------------------------------------------------------------
        // Si el usuario quiere abandonar el proyecto, si es administrador debera asignar a otro siempre y cuando no hayan
        // Si el usuario es miembro, podra hacerlo libremente.
        private void BtnAbandonar_Click(object sender, EventArgs e)
        {
            bool abandona = false;

            DialogResult resultado = MessageBox.Show("¿Seguro que quieres abandonar el proyecto " + proyectoActual.nombre + "?\nMas te vale que al menos hayas sido útil.", "¡CUIDADO!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (resultado == DialogResult.Yes)
            {
                if (usuarioDAO.esAdmin(proyectoActual.id, usuario.id))
                {
                    if (proyectoDAO.obtenerNumAdmins(proyectoActual.id) > 1)
                    {
                        proyectoDAO.eliminarAdmin(proyectoActual.id, usuario.id);
                        proyectoDAO.eliminarMiembro(proyectoActual.id, usuario.id);
                        abandona = true;
                    }
                    else
                    {
                        MessageBox.Show("No puedes escabullirte del proyecto sin antes agregar a otro administrador...", "¡ATENCION!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        frmPrincipal.crearEditarProyecto(proyectoActual, usuario);
                    }
                }
                else
                {
                    proyectoDAO.eliminarMiembro(proyectoActual.id, usuario.id);
                    abandona = true;
                }

                if (abandona)
                {
                    // Independientemente el usuario sea miembro o administrador enviaremos una notificacion a los administradores
                    frmPrincipal.crearArea(usuario, 0);
                    List<Usuario> administradoresProyecto = usuarioDAO.obtenerAdministradores(proyectoActual.id);
                    string mensaje = "El traidor de " + usuario.nombreUsuario + " ha abandonado el proyecto " + proyectoActual.nombre + " :(";
                    foreach (Usuario admin in administradoresProyecto)
                    {
                        if (admin.id != usuario.id)
                        {
                            usuarioDAO.enviarNotificacion(usuario.id, admin.id, mensaje);
                        }
                    }
                }

            }
        }

        // ------------------------------------------------------------------------------------------------------
        // Eliminaremos el proyecto y todo lo que corresponda a esta siempre y cuando seamos administradores
        private void BtnEliminarProyecto_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Seguro que quieres eliminar el proyecto " + proyectoActual.nombre + "?\nEspero que hayas conseguido todos tus objetivos...", "¡CUIDADO!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (resultado == DialogResult.Yes)
            {
                proyectoDAO.eliminarProyecto(proyectoActual.id);
                string mensaje = usuario.nombreUsuario + " por desgracia eliminó el proyecto " + proyectoActual.nombre + " :(, tendras que buscar otro...";
                foreach (Usuario miembro in proyectoActual.miembros)
                {
                    if (miembro.id != usuario.id)
                    {
                        usuarioDAO.enviarNotificacion(usuario.id, miembro.id, mensaje);
                    }
                }
                frmPrincipal.crearArea(usuario, 0);
            }
        }

        // ------------------------------------------------------------------------------------------------------
        // Método al seleccionar sobre un miembro del proyecto:
        private void LstMiembros_DoubleClick(object sender, EventArgs e)
        {
            if (LstMiembros.SelectedItems.Count > 0)
            {
                string miembro = LstMiembros.SelectedItem as string;
                verPerfilUsuario(miembro);
            }
        }

        // ----------------------------------------------------------------------------------------------------------------------
        // --------------------------------------------- MÉTODOS DE TAREAS ------------------------------------------------------
        // ----------------------------------------------------------------------------------------------------------------------

        // ------------------------------------------------------------------------------------------------------
        // Método para rellenar los cuadros con las tareas:
        private void rellenarTareas(List<Modelo.Tarea> tareas)
        {
            // Limpiamos los elementos:
            LstPendientes.Items.Clear();
            LstIdTareasPendientes.Items.Clear();
            LstProceso.Items.Clear();
            LstIdTareasProceso.Items.Clear();
            LstFinalizadas.Items.Clear();
            LstIdTareasFinalizadas.Items.Clear();

            BtnEditarTarea.Visible = false;
            BtnEmpezarTarea.Visible = false;
            BtnTerminarTarea.Visible = false;

            try
            {
                foreach (Modelo.Tarea t in tareas)
                {
                    if (t.estado.Equals("pendiente"))
                    {
                        LstPendientes.Items.Add(t.nombre);
                        LstIdTareasPendientes.Items.Add(t.id);
                    }
                    else if (t.estado.Equals("en_proceso"))
                    {
                        LstProceso.Items.Add(t.nombre);
                        LstIdTareasProceso.Items.Add(t.id);
                    }
                    else
                    {
                        LstFinalizadas.Items.Add(t.nombre);
                        LstIdTareasFinalizadas.Items.Add(t.id);
                    }
                }
            }
            catch (System.NullReferenceException e)
            {
            }
        }

        // --------------------------------------------------------------------------------
        // Recoge las tareas del proyecto que tienen fecha de caducidad próxima o cercana:
        private void tareasFecha()
        {
            try
            {
                foreach (Modelo.Tarea t in listaTareas)
                {
                    if (caducaTarea(t))
                    {
                        tareasACaducar.Add(t.id);
                    }
                    if (tareaHaCaducado(t))
                    {
                        tareasCaducadas.Add(t.id);
                    }
                }
            }
            catch (System.NullReferenceException e)
            {

            }
        }

        // ------------------------------------------------------------------------------------------------------
        // Método para ver si una tarea caduca en el día actual:
        private bool caducaTarea(Modelo.Tarea tarea)
        {
            // Si la fecha de caducidad es HOY
            return DateTime.Now.Date == tarea.fecha_fin.Date;
        }

        // ------------------------------------------------------------------------------------------------------
        // Método para ver si una tarea está caducada:
        private bool tareaHaCaducado(Modelo.Tarea tarea)
        {
            bool haCaducado = false;
            // Si tiene un límite y esta ya ha pasado:
            if (!tarea.fecha_fin.Date.ToString("yyyy-MM-dd").Equals("0001-01-01") && DateTime.Now.Date > tarea.fecha_fin.Date)
                haCaducado = true;
            return haCaducado;
        }

        // ------------------------------------------------------------------------------------------------------
        // Seleccionar criterio de tarea por fecha y asignación:
        private void RdbCaducadas_CheckedChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.RadioButton b = (System.Windows.Forms.RadioButton)sender;
            // Asignación
            if (b == RdbTodas && b.Checked)
            {
                RdbPropias.Checked = false;
            }
            else if (b == RdbPropias && b.Checked)
            {
                RdbTodas.Checked = false;
            }
            // Fecha:
            if (b == RdbTodasFecha && b.Checked)
            {
                RdbCaducanHoy.Checked = false;
                RdbCaducadas.Checked = false;
            }
            else if (b == RdbCaducanHoy && b.Checked)
            {
                RdbTodasFecha.Checked = false;
                RdbCaducadas.Checked = false;
            }
            else if (b == RdbCaducadas && b.Checked)
            {
                RdbTodasFecha.Checked = false;
                RdbCaducanHoy.Checked = false;
            }
            // aplicamos el filtro para mostrar las tareas:
            filtroTareas();
        }

        // ------------------------------------------------------------------------------------------------------
        // Pasar el filtro seleccionado a las tareas que se muestran:
        private void filtroTareas()
        {
            // Primero obtenemos las tareas en función de si son propias o todas:
            if (RdbTodas.Checked)
            {
                listaTareas = tareaDAO.obtenerTareasPorProyecto(proyectoActual.id);
                PrbProyecto.Value = obtenerProgresoProyecto();
                LblPorcentaje.Text = string.Format("{0}%", PrbProyecto.Value);
            }
            else if (RdbPropias.Checked)
            {
                listaTareas = tareaDAO.obtenerTareasPorProyectoYUsuario(proyectoActual.id, usuario.id);
            }

            // Ahora mostramos estas las tareas con el filtro de la fecha:
            if (listaTareasFechas != null) 
                listaTareasFechas.Clear();

            if (RdbCaducanHoy.Checked)
            {
                foreach (Modelo.Tarea t in listaTareas)
                    if (tareasACaducar.Contains(t.id))
                        listaTareasFechas.Add(t);
                rellenarTareas(listaTareasFechas);
            }
            else if (RdbCaducadas.Checked)
            {
                foreach (Modelo.Tarea t in listaTareas)
                    if (tareasCaducadas.Contains(t.id))
                        listaTareasFechas.Add(t);
                rellenarTareas(listaTareasFechas);
            }
            else if (RdbTodasFecha.Checked)
            {
                rellenarTareas(listaTareas);
            }
        }

        // ------------------------------------------------------------------------------------------------------
        // Ajusta los checks de los RadioButtons:
        private void Rdb_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.RadioButton rdb = (System.Windows.Forms.RadioButton)sender;
            rdb.Checked = true;
        }

        // ------------------------------------------------------------------------------------------------------
        // Al seleccionar una tarea:
        private void LstTareas_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Variables según la lista que es:
            System.Windows.Forms.ListBox lista = (System.Windows.Forms.ListBox)sender;
            System.Windows.Forms.Button boton = new System.Windows.Forms.Button();
            if (lista == LstPendientes)
                boton = BtnEmpezarTarea;
            else if (lista == LstProceso)
                boton = BtnTerminarTarea;
            // Al seleccionar una tarea:
            if (lista.SelectedIndex != -1)
            {
                // Solamente seleccionamos una tarea en total:
                seleccionarTarea(lista);
                if (tareaDAO.perteneceUsuarioATarea(tareaActual.id, usuario.id))
                    boton.Visible = true;
                else
                    boton.Visible = false;
                if (usuarioDAO.esAdmin(proyectoActual.id, usuario.id))
                {
                    BtnEditarTarea.Visible = true;
                }
                LblTareaSeleccionada.Text = "Tarea seleccionada: " + tareaActual.nombre;
            }
            else
            {
                boton.Visible = false;
                BtnEditarTarea.Visible = false;
                LblTareaSeleccionada.Text = "Tarea seleccionada: ";
            }
            if (lista == LstFinalizadas)
                BtnEditarTarea.Visible = false;
        }

        // ------------------------------------------------------------------------------------------------------
        // Deselecciona las otras listas de tareas:
        private void seleccionarTarea(System.Windows.Forms.ListBox lista)
        {
            int cont = 0;
            int index = -1;
            System.Windows.Forms.ListBox[] ids = { LstIdTareasPendientes, LstIdTareasProceso, LstIdTareasFinalizadas };
            foreach (System.Windows.Forms.ListBox l in cuadrosTareas)
            {
                if (l != lista)
                    l.SelectedIndex = -1;
                else
                    index = cont; // index es el valor del índice de la lista que hemos metido
                ids[cont].SelectedIndex = l.SelectedIndex;
                cont++;
            }
            tareaActual = listaTareas.Find(t => t.id == Convert.ToInt32(ids[index].SelectedItem));
        }

        // ------------------------------------------------------------------------------------------------------
        // Crear nueva tarea:
        private void BtnNuevaTarea_Click(object sender, EventArgs e)
        {
            frmPrincipal.crearCrearTarea(usuario, proyectoActual);
            frmPrincipal.cerrarArea();
        }
        
        // ------------------------------------------------------------------------------------------------------
        // Abrir la pantalla de editar tarea:
        private void BtnEditarTarea_Click(object sender, EventArgs e)
        {
            frmPrincipal.crearEditarTarea(usuario, tareaActual);
            frmPrincipal.cerrarArea();
        }

        // ------------------------------------------------------------------------------------------------------
        // Para cambiar el estado de una tarea:
        private void BtnEstadoTarea_Click(object sender, EventArgs e)
        {
            string accion = "empezar";
            if (LstProceso.SelectedIndex != -1)
                accion = "terminar";
            if (LstPendientes.SelectedIndex != -1 || LstProceso.SelectedIndex != -1)
            {
                // Si el usuario pertenece a la tarea:
                if (tareaDAO.perteneceUsuarioATarea(tareaActual.id, usuario.id))
                {
                    DialogResult resultado = MessageBox.Show("¿Quieres " + accion + " la tarea " + tareaActual.nombre + "?", "EMPEZAR TAREA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (resultado == DialogResult.Yes)
                    {
                        tareaDAO.avanzarEstado(tareaActual);

                        if (accion.Equals("terminar"))
                        {
                            List<Usuario> adminisProyecto = usuarioDAO.obtenerAdministradores(proyectoActual.id);
                            foreach (Usuario admin in adminisProyecto)
                            {
                                if (usuario.id != admin.id)
                                {
                                    usuarioDAO.enviarNotificacion(usuario.id, admin.id, usuario.nombreUsuario + " ha terminado la tarea " + tareaActual.nombre + " del proyecto " + proyectoActual.nombre);
                                }
                            }
                        }
                        listaTareas = tareaDAO.obtenerTareasPorProyectoYUsuario(proyectoActual.id, usuario.id);
                        RdbPropias.Checked = true;
                        RdbTodasFecha.Checked = true;
                        rellenarTareas(listaTareas);

                        PrbProyecto.Value = obtenerProgresoProyecto();
                        LblPorcentaje.Text = string.Format("{0}%", PrbProyecto.Value);
                        if (PrbProyecto.Value == 100)
                            LblFin.Visible = true;
                        else
                            LblFin.Visible = false;
                    }
                }
                else
                {
                    MessageBox.Show("No perteneces a la tarea " + tareaActual.nombre + "...", "¡ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        // ------------------------------------------------------------------------------------------------------
        // Muestra el mensaje de información al dar doble click a una tarea:
        private void LstPendientes_DoubleClick(object sender, EventArgs e)
        {
            System.Windows.Forms.ListBox listBox = sender as System.Windows.Forms.ListBox;
            if (listBox.SelectedItems.Count > 0)
            {
                mostrarMensajeTarea();
            }
        }

        // ------------------------------------------------------------------------------------------------------
        // Para mostrar la información de una tarea:
        private void mostrarMensajeTarea()
        {
            List<Usuario> usuariosTarea = usuarioDAO.obtenerUsuariosAsignadosATarea(tareaActual);
            bool sinFechaLimite = false;

            string prioridad = "";
            string infoTarea = "INFORMACIÓN DE LA TAREA:\n\nNombre de la Tarea: " + tareaActual.nombre;
            // Si el usuario pertenece a la tarea:
            if (tareaDAO.perteneceUsuarioATarea(tareaActual.id, usuario.id) || usuarioDAO.esAdmin(proyectoActual.id, usuario.id))
            {
                // Prioridad:
                prioridad = "ALTA";
                if (tareaActual.prioridad == 2)
                    prioridad = "MEDIA";
                else if (tareaActual.prioridad == 3)
                    prioridad = "BAJA";
                // Fecha de fin:
                string fecha = tareaActual.fecha_fin.ToShortDateString();
                if (tareaActual.fecha_fin.Date.ToString("yyyy-MM-dd").Equals("0001-01-01"))
                {
                    fecha = "Sin límite";
                    sinFechaLimite = true;

                }
                infoTarea += "\nDescripción: " + tareaActual.descripcion
                + "\nEstado: " + tareaActual.estado
                + "\nFecha de finalización: " + fecha;

                if (!sinFechaLimite && !tareaActual.estado.Equals("finalizada"))
                {
                    int diasRestantes = obtenerDiasRestantesTarea(tareaActual);
                    infoTarea += "\nTiempo restante: ";

                    if (diasRestantes < 0)
                    {
                        // Tarea caducada
                        int diasCaducado = -diasRestantes;
                        if (diasCaducado < 30)
                        {
                            infoTarea += "Caducó hace " + diasCaducado + (diasCaducado == 1 ? " dia" : " dias");
                        }
                        else if (diasCaducado < 365)
                        {
                            int mesesCaducado = diasCaducado / 30;
                            infoTarea += "Caducó hace mas de " + mesesCaducado + (mesesCaducado == 1 ? " mes" : " meses");
                        }
                        else
                        {
                            int añosCaducado = diasCaducado / 365;
                            infoTarea += "Caducó hace mas de " + añosCaducado + (añosCaducado == 1 ? " año" : " años");
                        }
                    }
                    else
                    {
                        // Tarea no caducada
                        infoTarea += diasRestantes + (diasRestantes == 1 ? " dia" : " dias");
                    }
                }
            }

            infoTarea += "\n\nParticipantes de la tarea:\n" + string.Join(" - ", usuariosTarea.Select(u => u.nombreUsuario));

            MessageBox.Show(infoTarea, "¡PRIORIDAD " + prioridad + "!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // ------------------------------------------------------------------------------------------------------
        // Obtiene los días que faltan para que caduque una tarea:
        private int obtenerDiasRestantesTarea(Modelo.Tarea tarea)
        {
            return (tarea.fecha_fin.Date - DateTime.Now.Date).Days;
        }

        // ----------------------------------------------------------------------------------------------------------------------
        // -------------------------------------------------- DISEÑO ------------------------------------------------------------
        // ----------------------------------------------------------------------------------------------------------------------

        private void FrmArea_Resize(object sender, EventArgs e)
        {
            //-----------------------------------------------------
            //PANEL TOP:
            ajustarPanelTop();

            //-----------------------------------------------------
            //PANEL IZQUIERDA:
            ajustarPanelIzquierda();

            //-----------------------------------------------------
            //PANEL DERECHA
            ajustarPanelDerecha();

            //-----------------------------------------------------
            //PANEL CENTRO:
            ajustarPanelCentral();
        }

        // Ajustamos el panel de arriba:
        private void ajustarPanelTop()
        {
            // Título:
            PcbTitulo.Visible = true;
            LblTitulo.Visible = false;
            PcbTitulo.Left = (panelTop.Width - PcbTitulo.Width) / 2;
            PcbTitulo.Top = (panelTop.Height - PcbTitulo.Height) / 2;
            //LblTitulo.Left = (panelTop.Width - LblTitulo.Width) / 2;
            // LblTitulo.Top = (panelTop.Height - LblTitulo.Height) / 2;


            // Usuario:
            PcbAvatar.Left = 30;
            PcbAvatar.Top = (panelTop.Height - PcbAvatar.Height) / 2;
            LlblPerfil.Left = PcbAvatar.Right + 10;
            LlblPerfil.Top = PcbAvatar.Top + (PcbAvatar.Height - LlblPerfil.Height) / 2;

            // Cerrar sesión:
            BtnCerrarSesion.Left = panelTop.Width - BtnCerrarSesion.Width - 40;
            BtnCerrarSesion.Top = PcbTitulo.Top;
            BtnCerrarSesion.Height = BtnVerNotificaciones.Height;

            // Notificaciones:
            LblNotificaciones.Left = PcbTitulo.Right + 30;
            LblNotificaciones.Top = (panelTop.Height - LblNotificaciones.Height) / 2;
            BtnVerNotificaciones.Left = LblNotificaciones.Right + 10;
            BtnVerNotificaciones.Top = PcbTitulo.Top;
        }

        // Ajustamos el panel de la izquierda:
        private void ajustarPanelIzquierda()
        {
            int margin = 15; // Margen entre controles

            // Proyectos:
            LblProyectos.Left = margin;
            LblProyectos.Top = margin;
            BtnAñadirProyecto.Left = margin;
            BtnAñadirProyecto.Top = LblProyectos.Bottom + margin;
            LstProyectos.Left = margin;
            LstProyectos.Top = BtnAñadirProyecto.Bottom + margin;
            LstProyectos.Height = panelIzq.Height / 2 - LblProyectos.Height - BtnAñadirProyecto.Height - 3 * margin;

            // Amigos:
            LblAmigos.Top = LstProyectos.Bottom + margin;
            LblAmigos.Left = margin;
            BtnAñadirAmigo.Top = LblAmigos.Bottom + margin;
            BtnAñadirAmigo.Left = margin;
            LstAmigos.Top = BtnAñadirAmigo.Bottom + margin;
            LstAmigos.Left = margin;
            LstAmigos.Height = panelIzq.Height / 2 - LblAmigos.Height - BtnAñadirAmigo.Height - 3 * margin;
        }

        // Ajustamos el panel del centro:
        private void ajustarPanelCentral()
        {
            // Panel:
            panelCentro.Width = (this.ClientSize.Width - panelIzq.Width - panelDer.Width - 15);
            panelCentro.Height = (this.ClientSize.Height - panelTop.Height);
            panelCentro.Left = panelIzq.Right + 15;
            panelCentro.Top = panelTop.Bottom;
            // Si solo tenemos el panel central y el izquierdo:
            if (!panelDer.Visible)
            {
                // Imagen:
                PcbArea.Left = 15 + (panelCentro.Width - PcbArea.Width) / 2;
                PcbArea.Top = (panelCentro.Height - PcbArea.Height) / 2;
            }
            else
            {
                // Hay panel derecho:
                panelDer.Left = panelCentro.Right;
                panelDer.Height = panelCentro.Height;
                ajusteDentro();
            }
        }

        // Ajustamos el panel de la derecha:
        private void ajustarPanelDerecha()
        {
            int margin = 15;
            panelDer.Top = panelTop.Bottom + margin;
            panelDer.Width = panelIzq.Width;

            // Miembros:
            LblMiembros.Left = margin;
            LblMiembros.Top = 2*margin;

            LstMiembros.Left = margin;
            LstMiembros.Width = BtnNuevaTarea.Width;
            LstMiembros.Top = LblMiembros.Bottom + margin;

            // Botones
            BtnAbandonar.Top = LstMiembros.Bottom + 2 * margin;
            BtnAbandonar.Left = (panelDer.ClientSize.Width - BtnAbandonar.Width) / 2;

            BtnEditarProyecto.Top = BtnAbandonar.Bottom + margin;
            BtnEditarProyecto.Left = (panelDer.ClientSize.Width - BtnEditarProyecto.Width) / 2;

            BtnNuevaTarea.Top = BtnEditarProyecto.Bottom + margin;
            BtnNuevaTarea.Left = (panelDer.ClientSize.Width - BtnNuevaTarea.Width) / 2;

            BtnEliminarProyecto.Top = BtnNuevaTarea.Bottom;
            BtnEliminarProyecto.Left = (panelDer.ClientSize.Width - BtnEliminarProyecto.Width) / 2;
        }

        
        private void ajusteDentro()
        {
            int margin = 15;

            
        }

    }
}
