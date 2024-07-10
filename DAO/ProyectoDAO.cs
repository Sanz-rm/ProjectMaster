using MySql.Data.MySqlClient;
using ProjectMaster.Conection;
using ProjectMaster.Modelo;
using System;
using System.Collections.Generic;


namespace ProjectMaster.DAO
{
    internal class ProyectoDAO
    {
        private Conexion conexion;
        private MySqlDataReader reader;
        private MySqlConnection con;
        private UsuarioDAO usuarioDAO;
        public ProyectoDAO(MySqlConnection c)
        {
            conexion = new Conexion();
            con = c;
            usuarioDAO = new UsuarioDAO(c);
        }

        // ----------------------------------------------------------------------------------------------------
        // ----------------------------------------------------------------------------------------------------
        // MÉTODOS DML: MANIPULACIÓN DE DATOS

        // ----------------------------------------------------------------------------------------------------
        // Insertar un proyecto en la BD:
        public void insertarProyecto(Proyecto proyecto)
        {
            conexion.realizarSentenciaBD("INSERT INTO proyecto (`nombre`, `descripcion`) VALUES ('" + proyecto.nombre + "','" + proyecto.descripcion + "')", con);
        }

        // ----------------------------------------------------------------------------------------------------
        // Insertar relacion usuario-proyecto en la BD:
        public void insertarMiembrosProyectoNuevo(Proyecto proyecto)
        {
            int max = 0;
            reader = conexion.realizarConsulta("select max(id) from proyecto", con);
            if (reader != null)
            {
                if (reader.Read())
                {
                    max = reader.GetInt32(0);
                    proyecto.id = max;
                }
                reader.Close();
                foreach (Usuario miembro in proyecto.miembros)
                {
                    //añadir todos los de la lista miembros
                    conexion.realizarSentenciaBD("INSERT INTO participa_en (`usuario_id`, `proyecto_id`) VALUES ('" + miembro.id + "','" + max + "')", con);
                }
            }
        }

        //inserta en la relacion usuario-proyecto como administrador en la BD:
        public void insertarAdminProyectoNuevo(Usuario usuario)
        {
            int max = 0;
            reader = conexion.realizarConsulta("select max(id) from proyecto", con);
            if (reader != null)
            {
                if (reader.Read())
                {
                    max = reader.GetInt32(0);
                }
                reader.Close();
                //añadir como administrador al creador del proyecto
                conexion.realizarSentenciaBD("INSERT INTO es_admin_de (`usuario_id`, `proyecto_id`) VALUES ('" + usuario.id + "','" + max + "')", con);
            }
        }

        // ----------------------------------------------------------------------------------------------------
        // Insertar relacion usuario-proyecto en la BD:
        public void insertarMiembrosProyecto(int idP, int idU)
        {
            //añadir todos los de la lista miembros
            conexion.realizarSentenciaBD("INSERT INTO participa_en (`usuario_id`, `proyecto_id`) VALUES ('" + idU + "','" + idP + "')", con);
        }

        //inserta en la relacion usuario-proyecto como administrador en la BD:
        public void insertarAdminProyecto(int idP, int idU)
        {

            conexion.realizarSentenciaBD("INSERT INTO es_admin_de (`usuario_id`, `proyecto_id`) VALUES ('" + idU + "','" + idP + "')", con);
        }


        // ----------------------------------------------------------------------------------------------------
        // ----------------------------------------------------------------------------------------------------
        // MÉTODOS DE CONSULTA: 

        // ----------------------------------------------------------------------------------------------------
        // obtener cantidad de administradores de un proyecto:
        public int obtenerNumAdmins(int idProyecto)
        {
            int numAdmins = 0;

            try
            {
                reader = conexion.realizarConsulta("SELECT COUNT(*) FROM es_admin_de WHERE proyecto_id = " + idProyecto, con);
                if (reader != null)
                {
                    if (reader.Read())
                    {
                        numAdmins = reader.GetInt32(0);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener el número de administradores del proyecto: " + ex.Message);
            }
            finally
            {
                if (reader != null && !reader.IsClosed)
                {
                    reader.Close();
                }
            }

            return numAdmins;
        }


        // ----------------------------------------------------------------------------------------------------
        // Obtener proyecto por id:
        public Proyecto obtenerProyectoPorId(int id)
        {
            Proyecto p = null;

            try
            {
                reader = conexion.realizarConsulta("SELECT * FROM proyecto WHERE id = " + id, con);
                if (reader != null)
                {
                    if (reader.Read())
                    {
                        p = new Proyecto(
                            reader.GetInt32(0), // id
                            reader.GetString("nombre"),
                            reader.GetString("descripcion")
                        );
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener el proyecto por ID: " + ex.Message);
            }
            finally
            {
                if (reader != null && !reader.IsClosed)
                {
                    reader.Close();
                }
            }

            // Asignar los miembros del proyecto usando usuarioDAO
            if (p != null)
            {
                p.miembros = usuarioDAO.obtenerMiembros(p);
            }

            return p;
        }


        // ---------------------------------------------------------------
        // Obtener los proyectos (id,nombre) de un usuario:


        public List<Proyecto> obtenerProyectosOrdenadosPorID(int id)
        {
            List<Proyecto> listaProyectos = new List<Proyecto>();
            try
            {
                // Primero los proyectos de los que se es administrador, por orden alfabético:
                reader = conexion.realizarConsulta("select pr.id, pr.nombre, pr.descripcion from proyecto pr, usuario u, es_admin_de ea where ea.usuario_id = u.id and ea.proyecto_id = pr.id and u.id = " + id + " order by pr.nombre", con);
                string condicion = "";
                if (reader != null)
                {
                    while (reader.Read())
                    {
                        listaProyectos.Add(new Proyecto(reader.GetInt32(0), reader.GetString(1), reader.GetString(2)));
                        condicion += " and pr.id not like " + reader.GetInt32(0);
                    }
                    reader.Close();
                }

                // Después el resto de proyectos:
                reader = conexion.realizarConsulta("select pr.id, pr.nombre, pr.descripcion from proyecto pr, usuario u, participa_en pa where pa.usuario_id = u.id and pa.proyecto_id = pr.id and u.id = " + id + condicion, con);
                if (reader != null)
                {
                    while (reader.Read())
                    {
                        listaProyectos.Add(new Proyecto(reader.GetInt32(0), reader.GetString(1), reader.GetString(2)));
                    }
                    reader.Close();
                }

                // Añadimos los miembros de cada proyecto a sus objetos
                foreach (Proyecto proyecto in listaProyectos)
                {
                    proyecto.miembros = usuarioDAO.obtenerMiembros(proyecto);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener proyectos ordenados por ID: " + ex.Message);
            }
            finally
            {
                if (reader != null && !reader.IsClosed)
                {
                    reader.Close();
                }
            }
            return listaProyectos;
        }



        // ----------------------------------------------------------------------------------------------------
        // ----------------------------------------------------------------------------------------------------
        // MÉTODOS DE ACTUALIZAR:

        // ---------------------------------------------------------------
        // Actualizar los datos de un proyecto especifico:
        public void actualizarDatosProyecto(Modelo.Proyecto proyectoData, int idP)
        {
            conexion.realizarSentenciaBD("UPDATE proyecto set nombre = '" + proyectoData.nombre + "', descripcion = '" + proyectoData.descripcion + "' where id= " + idP, con);
        }

        // ----------------------------------------------------------------------------------------------------
        // ----------------------------------------------------------------------------------------------------
        // MÉTODOS DE ELIMINAR:

        // ----------------------------------------------------------------------------------------------------
        // Eliminar a un miembro de un proyecto especifico:
        public void eliminarMiembro(int idProyecto, int idMiembro)
        {
            conexion.realizarSentenciaBD("delete from participa_en where usuario_id = " + idMiembro + " and proyecto_id = " + idProyecto, con);
        }

        // ----------------------------------------------------------------------------------------------------
        // Eliminar a un admin de un proyecto especifico:
        public void eliminarAdmin(int idProyecto, int idAdmin)
        {
            conexion.realizarSentenciaBD("delete from es_admin_de where usuario_id = " + idAdmin + " and proyecto_id = " + idProyecto, con);
        }

        // ----------------------------------------------------------------------------------------------------
        // Eliminar un proyecto de la BD:
        public void eliminarProyecto(int idProyecto)
        {
            conexion.realizarSentenciaBD("DELETE FROM proyecto WHERE id = " + idProyecto, con);
        }

    }
}
