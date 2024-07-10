using MySql.Data.MySqlClient;
using ProjectMaster.Conection;
using ProjectMaster.Modelo;
using System;
using System.Collections.Generic;

namespace ProjectMaster.DAO
{

    internal class TareaDAO
    {
        private Conexion conexion;
        private MySqlDataReader reader;
        private MySqlConnection con;

        public TareaDAO(MySqlConnection c)
        {
            conexion = new Conexion();
            con = c;
        }

        // ----------------------------------------------------------------------------------------------------
        // ----------------------------------------------------------------------------------------------------
        // MÉTODOS DML: MANIPULACIÓN DE DATOS

        // ----------------------------------------------------------------------------------------------------
        // Eliminar participante de tarea - REALIZA
        public void eliminarUsuarioTarea(int idTarea, int idUsuario)
        {
            conexion.realizarSentenciaBD("DELETE FROM realiza WHERE tarea_id=" + idTarea + " AND usuario_id=" + idUsuario, con);
        }

        // ----------------------------------------------------------------------------------------------------
        // Insertar una tarea en la base de datos
        public void insertarTarea(Tarea tarea)
        {
            string fecha = "'" + tarea.fecha_fin.Year.ToString() + "-" + tarea.fecha_fin.Month.ToString() + "-" + tarea.fecha_fin.Day.ToString() + "'";
            conexion.realizarSentenciaBD("INSERT INTO tarea VALUES (0," + tarea.proyecto_id + ",'" + tarea.nombre + "','" + tarea.descripcion + "'," + fecha + "," + tarea.prioridad + ",'pendiente')", con);
        }

        // ----------------------------------------------------------------------------------------------------
        // Insertar relacion usuario-tarea en la BD:
        public void insertarUsuariosAsignados(Tarea tarea)
        {
            try
            {
                // Obtener el máximo ID de tarea existente
                int max = 0;
                reader = conexion.realizarConsulta("SELECT MAX(id) FROM tarea", con);
                if (reader != null)
                {
                    if (reader.Read())
                    {
                        max = reader.GetInt32(0);
                    }
                    reader.Close();

                    // Insertar usuarios asignados a la tarea
                    foreach (Usuario u in tarea.usuariosAsignados)
                    {
                        conexion.realizarSentenciaBD("INSERT INTO realiza VALUES (" + u.id + "," + max + ")", con);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al insertar usuarios asignados a la tarea: " + ex.Message);
            }
            finally
            {
                if (reader != null && !reader.IsClosed)
                {
                    reader.Close();
                }
            }
        }


        // ----------------------------------------------------------------------------------------------------
        // Cambiar estado de una tarea:
        public void avanzarEstado(Tarea tarea)
        {
            string estadoNuevo = "finalizada";
            if (tarea.estado.Equals("pendiente"))
                estadoNuevo = "en_proceso";

            conexion.realizarSentenciaBD("UPDATE tarea SET estado='" + estadoNuevo + "' WHERE id=" + tarea.id, con);

        }

        // ----------------------------------------------------------------------------------------------------
        // Eliminar una tarea:
        public void eliminarTarea(Tarea t, UsuarioDAO usDAO, int idUsuario)
        {
            // Eliminamos en la relación usuario-tarea:
            conexion.realizarSentenciaBD("DELETE FROM realiza WHERE tarea_id=" + t.id, con);
            conexion.realizarSentenciaBD("DELETE FROM tarea WHERE id=" + t.id, con);
            foreach (Usuario u in t.usuariosAsignados)
                usDAO.enviarNotificacion(idUsuario, u.id, "La tarea " + t.nombre + " del proyecto " + obtenerNombreProyecto(t) + " ha sido eliminada.");
        }

        // ----------------------------------------------------------------------------------------------------
        // Actualizar una tarea:
        public void actualizarTarea(Tarea t)
        {
            string fecha = "'" + t.fecha_fin.Year.ToString() + "-" + t.fecha_fin.Month.ToString() + "-" + t.fecha_fin.Day.ToString() + "'";
            conexion.realizarSentenciaBD("UPDATE tarea SET nombre='" + t.nombre + "', descripcion='" + t.descripcion + "'," +
                    "fecha_fin=" + fecha + ", prioridad=" + t.prioridad + " WHERE id=" + t.id, con);
        }

        public void actualizarUsuariosTarea(Tarea t, List<int> listaIdsActualizados, int idUsuario, UsuarioDAO usDAO)
        {
            // Miramos si ya estaba el usuario "i" asignado:
            foreach (int i in listaIdsActualizados)
            {
                // Si no estaba, lo añadimos
                if (t.usuariosAsignados.Find(u => u.id == i) == null)
                {
                    conexion.realizarSentenciaBD("INSERT INTO realiza VALUES (" + i + "," + t.id + ")", con);
                    //Añadimos la notificación
                    usDAO.enviarNotificacion(idUsuario, i, "Se te ha asignado una tarea nueva (" + t.nombre + ") en el proyecto " + obtenerNombreProyecto(t));
                }
            }
            // Miramos si se ha eliminado alguno:
            foreach (Usuario u in t.usuariosAsignados)
            {
                // Si el usuario "u" no está en la lista pero sí en la antigua, es que se ha eliminado de la tarea. 
                if (listaIdsActualizados.Find(i => i == u.id) == 0)
                {
                    eliminarUsuarioTarea(t.id, u.id);
                    //conexion.realizarSentenciaBD("DELETE FROM realiza WHERE tarea_id=" + t.id + " AND usuario_id=" + u.id, con);
                    usDAO.enviarNotificacion(idUsuario, u.id, "Se te ha eliminado de la tarea " + t.nombre + " en el proyecto " + obtenerNombreProyecto(t));
                }
            }

        }

        // ----------------------------------------------------------------------------------------------------
        // ----------------------------------------------------------------------------------------------------
        // MÉTODOS DE CONSULTA:

        // Obtener todas las tareas de cada proyecto:
        public List<Tarea> obtenerTareasPorProyecto(int idProyecto)
        {
            List<Tarea> listaTareas = new List<Tarea>();

            try
            {
                reader = conexion.realizarConsulta("SELECT * FROM tarea WHERE proyecto_id = " + idProyecto + " ORDER BY FIELD(prioridad, 'ALTA', 'MEDIA', 'BAJA'), fecha_fin", con);
                if (reader != null)
                {
                    while (reader.Read())
                    {
                        int prioridad;
                        string prioridadStr = reader.GetString("prioridad");

                        if (prioridadStr.Equals("ALTA"))
                            prioridad = 1;
                        else if (prioridadStr.Equals("MEDIA"))
                            prioridad = 2;
                        else // Suponiendo que los valores posibles son "ALTA", "MEDIA" y "BAJA"
                            prioridad = 3;

                        DateTime fecha = reader.GetDateTime("fecha_fin");
                        listaTareas.Add(new Tarea(
                            idProyecto,
                            reader.GetInt32("id"),
                            reader.GetString("nombre"),
                            reader.GetString("descripcion"),
                            prioridad,
                            reader.GetString("estado"),
                            fecha
                        ));
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener tareas por proyecto: " + ex.Message);
            }
            finally
            {
                if (reader != null && !reader.IsClosed)
                {
                    reader.Close();
                }
            }

            return listaTareas;
        }


        // Obtener las tareas de cada proyecto de un usuario:
        public List<Tarea> obtenerTareasPorProyectoYUsuario(int idProyecto, int idUsuario)
        {
            List<Tarea> listaTareas = new List<Tarea>();

            try
            {
                reader = conexion.realizarConsulta("SELECT t.* FROM tarea t, realiza r WHERE t.id = r.tarea_id AND t.proyecto_id = " + idProyecto + " AND r.usuario_id = " + idUsuario + " ORDER BY FIELD(t.prioridad, 'ALTA', 'MEDIA', 'BAJA'), t.fecha_fin", con);
                if (reader != null)
                {
                    while (reader.Read())
                    {
                        int prioridad;
                        string prioridadStr = reader.GetString("prioridad");

                        if (prioridadStr.Equals("ALTA"))
                            prioridad = 1;
                        else if (prioridadStr.Equals("MEDIA"))
                            prioridad = 2;
                        else // Suponiendo que los valores posibles son "ALTA", "MEDIA" y "BAJA"
                            prioridad = 3;

                        DateTime fecha = reader.GetDateTime("fecha_fin");
                        listaTareas.Add(new Tarea(
                            idProyecto,
                            reader.GetInt32("id"),
                            reader.GetString("nombre"),
                            reader.GetString("descripcion"),
                            prioridad,
                            reader.GetString("estado"),
                            fecha
                        ));
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener tareas por proyecto y usuario: " + ex.Message);
            }
            finally
            {
                if (reader != null && !reader.IsClosed)
                {
                    reader.Close();
                }
            }
            return listaTareas;
        }


        public bool perteneceUsuarioATarea(int idTarea, int idUsuario)
        {
            bool pertenece = false;

            try
            {
                reader = conexion.realizarConsulta("SELECT usuario_id FROM realiza WHERE tarea_id = " + idTarea + " AND usuario_id = " + idUsuario, con);
                if (reader != null)
                {
                    if (reader.Read())
                    {
                        pertenece = true;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al verificar pertenencia de usuario a tarea: " + ex.Message);
            }
            finally
            {
                if (reader != null && !reader.IsClosed)
                {
                    reader.Close();
                }
            }

            return pertenece;
        }


        // ----------------------------------------------------------------------------------------------------
        // Obtener el nombre del proyecto al que pertenece la tarea:
        public string obtenerNombreProyecto(Tarea t)
        {
            string nombre = "";

            try
            {
                reader = conexion.realizarConsulta("SELECT nombre FROM proyecto WHERE id = " + t.proyecto_id, con);
                if (reader != null)
                {
                    if (reader.Read())
                    {
                        nombre = reader.GetString("nombre");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener nombre de proyecto: " + ex.Message);
            }
            finally
            {
                if (reader != null && !reader.IsClosed)
                {
                    reader.Close();
                }
            }
            return nombre;
        }
    }
}

