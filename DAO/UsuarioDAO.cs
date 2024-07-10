using MySql.Data.MySqlClient;
using ProjectMaster.Conection;
using ProjectMaster.Modelo;
using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace ProjectMaster.DAO
{
    internal class UsuarioDAO
    {
        private Conexion conexion;
        private MySqlDataReader reader;
        private MySqlConnection con;
        public UsuarioDAO(MySqlConnection c)
        {
            conexion = new Conexion();
            con = c;
        }

        // ----------------------------------------------------------------------------------------------------
        // ----------------------------------------------------------------------------------------------------
        // MÉTODOS DML: MANIPULACIÓN DE DATOS

        // ----------------------------------------------------------------------------------------------------
        // Actualizar password usuario
        public void actualizarPasswordUsuario(int idUsuario, string password)
        {
            conexion.realizarSentenciaBD("UPDATE usuario SET password = '" + password + "' WHERE id = " + idUsuario, con);
        }

        // ----------------------------------------------------------------------------------------------------
        // Eliminar un usuario en la BD y notificamos a sus administradores de todos los proyectos de ello:
        public void eliminarUsuario(Usuario usuario)
        {
            conexion.realizarSentenciaBD("DELETE FROM usuario WHERE id = " + usuario.id, con);
        }

        // ----------------------------------------------------------------------------------------------------
        // Insertar un usuario en la BD:
        public void insertarUsuario(Usuario usuario)
        {
            string valorNombreReal = !string.IsNullOrEmpty(usuario.nombreReal) ? "'" + usuario.nombreReal + "'" : "NULL";
            conexion.realizarSentenciaBD("INSERT INTO usuario (`nombre_usuario`, `correo`, `password`, `nombre_real`, `telefono`, `privacidad`, `cod_avatar`) VALUES ('" +
                usuario.nombreUsuario + "','" +
                usuario.correo + "','" +
                usuario.password + "'," +
                valorNombreReal + "," +
                (usuario.telefono != null ? usuario.telefono.ToString() : "NULL") + "," +
                usuario.privacidad + "," +
                usuario.codAvatar + ")", con);
        }

        // ----------------------------------------------------------------------------------------------------
        // Actualizar un usuario de la BD:
        public void actualizarUsuario(Usuario usuario)
        {
            string valorNombreReal = !string.IsNullOrEmpty(usuario.nombreReal) ? "'" + usuario.nombreReal + "'" : "NULL";
            conexion.realizarSentenciaBD("UPDATE usuario SET nombre_usuario='" + usuario.nombreUsuario +
                "', correo='" + usuario.correo +
                "', password = '" + usuario.password +
                "', telefono = " + (usuario.telefono != null ? "'" + usuario.telefono.ToString() + "'" : "NULL") +
                ", nombre_real = " + (!string.IsNullOrEmpty(usuario.nombreReal) ? "'" + usuario.nombreReal + "'" : "NULL") +
                ", privacidad =" + usuario.privacidad +
                ", cod_avatar = " + usuario.codAvatar +
                " WHERE id = " + usuario.id, con);
        }

        // ----------------------------------------------------------------------------------------------------
        // Agregar un amigo:
        public void agregarAmigo(int idUser, int idAmigo)
        {
            conexion.realizarSentenciaBD("INSERT INTO es_amigo_de VALUES (" + idUser + "," + idAmigo + ")", con);


            enviarNotificacion(idUser, idAmigo, "¡" + obtenerUsuarioPorId(idUser).nombreUsuario + " te ha agregado a sus amigos :)");
            MessageBox.Show("¡" + obtenerUsuarioPorId(idAmigo).nombreUsuario + " y tú ahora sois amigos!\n Popularidad++ ;)", "Amigo agregado con éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // ----------------------------------------------------------------------------------------------------
        // Generar notificacion:
        public void enviarNotificacion(int idUserEmisor, int idUserReceptor, string mensaje)
        {
            if (idUserEmisor != idUserReceptor)
                conexion.realizarSentenciaBD("INSERT INTO notificacion VALUES (0," + idUserEmisor + "," + idUserReceptor + ",'" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "','" + mensaje + "', 0)", con);
        }
        // ----------------------------------------------------------------------------------------------------
        // ----------------------------------------------------------------------------------------------------
        // METODOS DE ELIMINAR

        // ----------------------------------------------------------------------------------------------------
        // Eliminar a un amigo:
        public void eliminarAmigo(int idUsuario, int idAmigo)
        {
            conexion.realizarSentenciaBD("delete from es_amigo_de where usuario1_id = " + idUsuario + " and usuario2_id = " + idAmigo + " or usuario2_id = " + idUsuario + " and usuario1_id = " + idAmigo, con);
            enviarNotificacion(idUsuario, idAmigo, obtenerUsuarioPorId(idUsuario).nombreUsuario + " ya no te quiere y ha dejado de ser tu amigo, espero que tengas mas amigos :(");

        }

        // ----------------------------------------------------------------------------------------------------
        // Eliminar notificacion especifica de un usuario especifico:

        public void eliminarNotificacion(int idUsuario, int idNotificacion)
        {
            conexion.realizarSentenciaBD("delete from notificacion where usuario_receptor_id = " + idUsuario + " and id = " + idNotificacion, con);
        }

        // ----------------------------------------------------------------------------------------------------
        // Eliminar todas las notificaciones de un usuario especifico:
        public void eliminarNotificaciones(int idUsuario)
        {
            conexion.realizarSentenciaBD("delete from notificacion where usuario_receptor_id = " + idUsuario, con);
        }

        // ----------------------------------------------------------------------------------------------------
        // Enviar nuevo mensaje a usuario
        public void enviarMensaje(int idEmisor, int idReceptor, string mensaje, DateTime fecha)
        {
            conexion.realizarSentenciaBD("INSERT INTO chat_usuario VALUES (" + idEmisor + "," + idReceptor + ",'" + fecha.ToString("yyyy-MM-dd HH:mm:ss") + "','" + mensaje + "', false)", con);
        }

        // ----------------------------------------------------------------------------------------------------
        // Actualizar los mensajes no leidos a leidos
        public void leerMensajes(int idEmisor, int idReceptor)
        {
            conexion.realizarSentenciaBD("UPDATE chat_usuario SET leido = true WHERE usuario_emisor_id = " + idReceptor + " AND usuario_receptor_id = " + idEmisor + " AND leido = false", con);
        }

        // ----------------------------------------------------------------------------------------------------
        // Actualizar a leidas las notificaciones del usuario
        public void leerNotificaciones(int idUsuario)
        {
            conexion.realizarSentenciaBD("UPDATE notificacion SET leido = true WHERE usuario_receptor_id = " + idUsuario, con);
        }

        // ----------------------------------------------------------------------------------------------------
        // ----------------------------------------------------------------------------------------------------
        // MÉTODOS DE CONSULTA: 

        // ----------------------------------------------------------------------------------------------------
        // Comprobamos si los siguientes usuarios son amigos o no
        public bool esAmigo(int idUsuario, int idAmigo)
        {
            bool amigos = false;

            try
            {
                reader = conexion.realizarConsulta("SELECT COUNT(*) FROM es_amigo_de WHERE (usuario1_id = " + idUsuario + " AND usuario2_id = " + idAmigo + ") OR (usuario1_id = " + idAmigo + " AND usuario2_id = " + idUsuario + ")", con);

                if (reader != null)
                {
                    if (reader.Read())
                    {
                        amigos = reader.GetInt32(0) > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                if (reader != null && !reader.IsClosed)
                {
                    reader.Close();
                }
            }
            return amigos;
        }



        // ----------------------------------------------------------------------------------------------------
        // Obtenemos todos los usuarios de la BD:
        public List<Usuario> obtenerTodosUsuarios()
        {
            List<Usuario> usuarios = new List<Usuario>();

            try
            {
                reader = conexion.realizarConsulta("SELECT * FROM usuario", con);

                if (reader != null)
                {
                    while (reader.Read())
                    {
                        usuarios.Add(new Usuario(
                            reader.GetInt32(0), // id
                            reader.GetString(1), // nombre_usuario
                            reader.GetString(2), // correo
                            reader.GetString(3), // password
                            reader.IsDBNull(4) ? null : reader.GetString(4), // nombre_real
                            reader.IsDBNull(5) ? (int?)null : reader.GetInt32(5), // telefono
                            reader.GetBoolean(6), // privacidad
                            reader.GetInt32(7) // cod_avatar
                        ));
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener todos los usuarios: " + ex.Message);
            }
            finally
            {
                if (reader != null && !reader.IsClosed)
                {
                    reader.Close();
                }
            }

            return usuarios;
        }


        // ----------------------------------------------------------------------------------------------------
        // Busca si existe un usuario por nombre:
        public bool existeUsuarioPorNombre(string nombre)
        {
            bool existe = false;

            try
            {
                reader = conexion.realizarConsulta("SELECT id FROM usuario WHERE nombre_usuario LIKE '" + nombre + "'", con);

                if (reader != null)
                {
                    if (reader.Read())
                    {
                        existe = true;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al verificar si el usuario existe por nombre: " + ex.Message);
            }
            finally
            {
                if (reader != null && !reader.IsClosed)
                {
                    reader.Close();
                }
            }

            return existe;
        }


        // ----------------------------------------------------------------------------------------------------
        // Busca si existe un usuario por correo:
        public bool existeUsuarioPorCorreo(string correo)
        {
            bool existe = false;

            try
            {
                reader = conexion.realizarConsulta("SELECT id FROM usuario WHERE correo LIKE '" + correo + "'", con);
                if (reader != null)
                {
                    if (reader.Read())
                    {
                        existe = true;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al verificar si el usuario existe por correo: " + ex.Message);
            }
            finally
            {
                if (reader != null && !reader.IsClosed)
                {
                    reader.Close();
                }
            }

            return existe;
        }


        // ----------------------------------------------------------------------------------------------------
        // Obtine un usuario por el id
        public Usuario obtenerUsuarioPorId(int idUsuario)
        {
            Usuario u = null;

            try
            {
                reader = conexion.realizarConsulta("SELECT * FROM usuario WHERE id = " + idUsuario, con);
                if (reader != null)
                {
                    if (reader.Read())
                    {
                        u = new Usuario(
                            reader.GetInt32(0), // id
                            reader.GetString(1), // nombre_usuario
                            reader.GetString(2), // correo
                            reader.GetString(3), // password
                            reader.IsDBNull(4) ? null : reader.GetString(4), // nombre_real
                            reader.IsDBNull(5) ? (int?)null : reader.GetInt32(5), // telefono
                            reader.GetBoolean(6), // privacidad
                            reader.GetInt32(7) // cod_avatar
                        );
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener usuario por ID: " + ex.Message);
            }
            finally
            {
                if (reader != null && !reader.IsClosed)
                {
                    reader.Close();
                }
            }

            return u;
        }


        // ----------------------------------------------------------------------------------------------------
        // Busca un usuario con el nombre o el correo indicados:
        public Usuario buscarUsuarioPorNombreOCorreo(string usuario)
        {
            Usuario u = null;

            try
            {
                reader = conexion.realizarConsulta("SELECT * FROM usuario WHERE nombre_usuario LIKE '" + usuario + "' OR correo LIKE '" + usuario + "'", con);
                if (reader != null)
                {
                    if (reader.Read())
                    {
                        u = new Usuario(
                            reader.GetInt32(0), // id
                            reader.GetString(1), // nombre_usuario
                            reader.GetString(2), // correo
                            reader.GetString(3), // password
                            reader.IsDBNull(4) ? null : reader.GetString(4), // nombre_real
                            reader.IsDBNull(5) ? (int?)null : reader.GetInt32(5), // telefono
                            reader.GetBoolean(6), // privacidad
                            reader.GetInt32(7) // cod_avatar
                        );
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al buscar usuario por nombre o correo: " + ex.Message);
            }
            finally
            {
                if (reader != null && !reader.IsClosed)
                {
                    reader.Close();
                }
            }

            return u;
        }


        // ----------------------------------------------------------------------------------------------------
        // Busca si existe un usuario por nombre o correo que no sea el propio:
        public bool coincideNombreOCorreo(string nombre, int id)
        {
            bool coincide = false;

            try
            {
                reader = conexion.realizarConsulta("SELECT id FROM usuario WHERE (nombre_usuario LIKE '" + nombre + "' OR correo LIKE '" + nombre + "') AND id <> " + id, con);
                if (reader != null)
                {
                    if (reader.Read())
                    {
                        coincide = true;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al verificar si el nombre o correo coinciden: " + ex.Message);
            }
            finally
            {
                if (reader != null && !reader.IsClosed)
                {
                    reader.Close();
                }
            }

            return coincide;
        }



        // ---------------------------------------------------------------
        // Obtener los amigos (id, nombre_usuario) de un usuario:
        public List<Usuario> obtenerAmigosPorID(int id)
        {
            List<Usuario> listaAmigos = new List<Usuario>();

            try
            {
                reader = conexion.realizarConsulta("SELECT id, nombre_usuario FROM usuario, es_amigo_de WHERE id = usuario2_id AND usuario1_id = " + id + " " +
                    "OR id = usuario1_id AND usuario2_id = " + id, con);
                if (reader != null)
                {
                    while (reader.Read())
                    {
                        listaAmigos.Add(new Usuario(reader.GetInt32("id"), reader.GetString("nombre_usuario")));
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener amigos por ID: " + ex.Message);
            }
            finally
            {
                if (reader != null && !reader.IsClosed)
                {
                    reader.Close();
                }
            }

            return listaAmigos;
        }

        // ----------------------------------------------------------------------------------------------------
        // Obtener miembros de un proyecto:
        public List<Usuario> obtenerMiembros(Proyecto p)
        {
            List<Usuario> usuariosProyecto = new List<Usuario>();

            try
            {
                reader = conexion.realizarConsulta("SELECT u.* FROM usuario u, participa_en pa WHERE u.id = pa.usuario_id AND pa.proyecto_id = " + p.id, con);
                if (reader != null)
                {
                    while (reader.Read())
                    {
                        usuariosProyecto.Add(new Usuario(
                            reader.GetInt32(0), // id
                            reader.GetString(1), // nombre_usuario
                            reader.GetString(2), // correo
                            reader.GetString(3), // password
                            reader.IsDBNull(4) ? null : reader.GetString(4), // nombre_real
                            reader.IsDBNull(5) ? (int?)null : reader.GetInt32(5), // telefono
                            reader.GetBoolean(6), // privacidad
                            reader.GetInt32(7) // cod_avatar
                        ));
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener los miembros del proyecto: " + ex.Message);
            }
            finally
            {
                if (reader != null && !reader.IsClosed)
                {
                    reader.Close();
                }
            }

            return usuariosProyecto;
        }


        // ----------------------------------------------------------------------------------------------------
        // Obtener miembros de un proyecto:
        public List<Usuario> obtenerMiembros(int idP)
        {
            List<Usuario> usuariosProyecto = new List<Usuario>();

            try
            {
                reader = conexion.realizarConsulta("SELECT u.* FROM usuario u, participa_en pa WHERE u.id = pa.usuario_id AND pa.proyecto_id = " + idP, con);
                if (reader != null)
                {
                    while (reader.Read())
                    {
                        usuariosProyecto.Add(new Usuario(
                            reader.GetInt32(0), // id
                            reader.GetString(1), // nombre_usuario
                            reader.GetString(2), // correo
                            reader.GetString(3), // password
                            reader.IsDBNull(4) ? null : reader.GetString(4), // nombre_real
                            reader.IsDBNull(5) ? (int?)null : reader.GetInt32(5), // telefono
                            reader.GetBoolean(6), // privacidad
                            reader.GetInt32(7) // cod_avatar
                        ));
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener los miembros del proyecto: " + ex.Message);
            }
            finally
            {
                if (reader != null && !reader.IsClosed)
                {
                    reader.Close();
                }
            }

            return usuariosProyecto;
        }

        // ----------------------------------------------------------------------------------------------------
        // Obtener todos los usuarios de una tarea:
        public List<Usuario> obtenerUsuariosAsignadosATarea(Modelo.Tarea t)
        {
            List<Usuario> usuariosTarea = new List<Usuario>();

            try
            {
                reader = conexion.realizarConsulta("SELECT u.* FROM usuario u, realiza r WHERE u.id = r.usuario_id AND r.tarea_id = " + t.id, con);
                if (reader != null)
                {
                    while (reader.Read())
                    {
                        usuariosTarea.Add(new Usuario(
                            reader.GetInt32(0), // id
                            reader.GetString(1), // nombre_usuario
                            reader.GetString(2), // correo
                            reader.GetString(3), // password
                            reader.IsDBNull(4) ? null : reader.GetString(4), // nombre_real
                            reader.IsDBNull(5) ? (int?)null : reader.GetInt32(5), // telefono
                            reader.GetBoolean(6), // privacidad
                            reader.GetInt32(7) // cod_avatar
                        ));
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener los usuarios asignados a la tarea: " + ex.Message);
            }
            finally
            {
                if (reader != null && !reader.IsClosed)
                {
                    reader.Close();
                }
            }

            return usuariosTarea;
        }


        // ----------------------------------------------------------------------------------------------------
        // Obtener administradores de un proyecto en especifico:
        public List<Usuario> obtenerAdministradores(int id)
        {
            List<Usuario> administradores = new List<Usuario>();

            try
            {
                reader = conexion.realizarConsulta("SELECT u.* FROM es_admin_de ea, usuario u WHERE u.id = ea.usuario_id AND ea.proyecto_id = " + id, con);
                if (reader != null)
                {
                    while (reader.Read())
                    {
                        administradores.Add(new Usuario(
                            reader.GetInt32(0), // id
                            reader.GetString(1), // nombre_usuario
                            reader.GetString(2), // correo
                            reader.GetString(3), // password
                            reader.IsDBNull(4) ? null : reader.GetString(4), // nombre_real
                            reader.IsDBNull(5) ? (int?)null : reader.GetInt32(5), // telefono
                            reader.GetBoolean(6), // privacidad
                            reader.GetInt32(7) // cod_avatar
                        ));
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener los administradores del proyecto: " + ex.Message);
            }
            finally
            {
                if (reader != null && !reader.IsClosed)
                {
                    reader.Close();
                }
            }

            return administradores;
        }


        // ---------------------------------------------------------------
        // Obtener usuarios que contengan en el nombre de usuario o el correo la cadena introducida:
        public List<Usuario> obtenerUsuariosPorCoincidencia(string cadena, List<int> listaAmigos, int idUser)
        {
            List<Usuario> usuarios = new List<Usuario>();

            try
            {
                // Primero obtenemos las coincidencias descartando al propio usuario:
                reader = conexion.realizarConsulta("SELECT id, nombre_usuario, correo FROM usuario WHERE id <> " + idUser + " AND (nombre_usuario LIKE '%" + cadena + "%' OR correo LIKE '%" + cadena + "%')", con);
                if (reader != null)
                {
                    while (reader.Read())
                    {
                        int userId = reader.GetInt32("id");
                        // Descartamos los resultados que ya son amigos:
                        if (!listaAmigos.Contains(userId))
                        {
                            usuarios.Add(new Usuario(
                                userId,
                                reader.GetString("nombre_usuario"),
                                reader.GetString("correo")
                            ));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener usuarios por coincidencia: " + ex.Message);
            }
            finally
            {
                if (reader != null && !reader.IsClosed)
                {
                    reader.Close();
                }
            }

            return usuarios;
        }


        // ----------------------------------------------------------------------------------------------------
        // Obtener los mensajes no leidos de un usuario

        public int obtenerNumMensajesNoLeidos(int user1, int user2)
        {
            int numMensajesNoLeidos = 0;

            try
            {
                reader = conexion.realizarConsulta("SELECT COUNT(*) FROM chat_usuario WHERE usuario_emisor_id = " + user2 + " AND usuario_receptor_id = " + user1 + " AND leido = false", con);
                if (reader != null)
                {
                    if (reader.Read())
                    {
                        numMensajesNoLeidos = reader.GetInt32(0);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener número de mensajes no leídos: " + ex.Message);
            }
            finally
            {
                if (reader != null && !reader.IsClosed)
                {
                    reader.Close();
                }
            }

            return numMensajesNoLeidos;
        }


        // ----------------------------------------------------------------------------------------------------
        // Obtener los mensajes no leidos de un usuario

        public List<(string mensaje, DateTime fecha)> obtenerMensajesNoLeidos(int user1, int user2)
        {
            List<(string mensaje, DateTime fecha)> mensajesNoLeidos = new List<(string mensaje, DateTime fecha)>();

            try
            {
                reader = conexion.realizarConsulta("SELECT mensaje, fecha FROM chat_usuario WHERE usuario_emisor_id = " + user2 + " AND usuario_receptor_id = " + user1 + " AND leido = false ORDER BY fecha", con);
                if (reader != null)
                {
                    while (reader.Read())
                    {
                        mensajesNoLeidos.Add((reader.GetString(0), reader.GetDateTime(1)));
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener mensajes no leídos: " + ex.Message);
            }
            finally
            {
                if (reader != null && !reader.IsClosed)
                {
                    reader.Close();
                }
            }

            return mensajesNoLeidos;
        }


        // ----------------------------------------------------------------------------------------------------
        // Obtener todos los mensajes entre dos usuarios

        public List<(int id, string mensaje, DateTime fecha)> obtenerMensajesChat(int user1, int user2)
        {
            List<(int id, string mensaje, DateTime fecha)> mensajes = new List<(int id, string mensaje, DateTime fecha)>();

            try
            {
                reader = conexion.realizarConsulta("SELECT usuario_emisor_id, mensaje, fecha FROM chat_usuario WHERE (usuario_emisor_id = " + user1 + " AND usuario_receptor_id = " + user2 + ") OR (usuario_emisor_id = " + user2 + " AND usuario_receptor_id = " + user1 + ") ORDER BY fecha", con);
                if (reader != null)
                {
                    while (reader.Read())
                    {
                        mensajes.Add((reader.GetInt32(0), reader.GetString(1), reader.GetDateTime(2)));
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener mensajes del chat: " + ex.Message);
            }
            finally
            {
                if (reader != null && !reader.IsClosed)
                {
                    reader.Close();
                }
            }

            return mensajes;
        }



        // ----------------------------------------------------------------------------------------------------
        // Obtener las notificaciones del usuario dependiendo si han sido leidas o no 
        public List<(string mensaje, DateTime fecha)> obtenerNotificacionesLeido(int idUsuario, bool leido)
        {
            List<(string mensaje, DateTime fecha)> notificaciones = new List<(string mensaje, DateTime fecha)>();

            try
            {
                reader = conexion.realizarConsulta("SELECT mensaje, fecha FROM notificacion WHERE usuario_receptor_id = " + idUsuario + " AND leido = " + (leido ? "1" : "0") + " ORDER BY fecha DESC", con);

                if (reader != null)
                {
                    while (reader.Read())
                    {
                        notificaciones.Add((reader.GetString(0), reader.GetDateTime(1)));
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener notificaciones: " + ex.Message);
            }
            finally
            {
                if (reader != null && !reader.IsClosed)
                {
                    reader.Close();
                }
            }

            return notificaciones;
        }


        // ----------------------------------------------------------------------------------------------------
        // Obtener todas las notificaciones del usuario
        public List<(string mensaje, DateTime fecha)> obtenerNotificaciones(int idUsuario)
        {
            List<(string mensaje, DateTime fecha)> notificaciones = new List<(string mensaje, DateTime fecha)>();

            try
            {
                reader = conexion.realizarConsulta("SELECT mensaje, fecha FROM notificacion WHERE usuario_receptor_id = " + idUsuario + " ORDER BY fecha DESC", con);
                if (reader != null)
                {
                    while (reader.Read())
                    {
                        notificaciones.Add((reader.GetString(0), reader.GetDateTime(1)));
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener notificaciones: " + ex.Message);
            }
            finally
            {
                if (reader != null && !reader.IsClosed)
                {
                    reader.Close();
                }
            }

            return notificaciones;
        }


        // ----------------------------------------------------------------------------------------------------
        // Obtener id de las notificaciones del usuario
        public int obtenerIdNotificaciones(int idUsuario, string mensaje)
        {
            int idNotificacion = 0;

            try
            {
                reader = conexion.realizarConsulta("SELECT id FROM notificacion WHERE usuario_receptor_id = " + idUsuario + " AND mensaje LIKE '" + mensaje + "'", con);
                if (reader != null)
                {
                    if (reader.Read())
                    {
                        idNotificacion = reader.GetInt32(0);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener el ID de la notificación: " + ex.Message);
            }
            finally
            {
                if (reader != null && !reader.IsClosed)
                {
                    reader.Close();
                }
            }

            return idNotificacion;
        }


        // ----------------------------------------------------------------------------------------------------
        // Obtener numero de notificaciones no leidas
        public int obtenerNumNotisSinLeer(int idUsuario)
        {
            int notificacionesSinLeer = 0;

            try
            {
                reader = conexion.realizarConsulta("SELECT COUNT(*) FROM notificacion WHERE usuario_receptor_id = " + idUsuario + " AND leido = false", con);
                if (reader != null)
                {
                    if (reader.Read())
                    {
                        notificacionesSinLeer = reader.GetInt32(0);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener el número de notificaciones sin leer: " + ex.Message);
            }
            finally
            {
                if (reader != null && !reader.IsClosed)
                {
                    reader.Close();
                }
            }

            return notificacionesSinLeer;
        }




        // ----------------------------------------------------------------------------------------------------
        // Comprobar si el usuario es admin o no en el proyecto indicado:
        public bool esAdmin(int idProyecto, int idUsuario)
        {
            bool admin = false;

            try
            {
                reader = conexion.realizarConsulta("SELECT usuario_id FROM es_admin_de WHERE proyecto_id = " + idProyecto + " AND usuario_id = " + idUsuario, con);
                if (reader != null)
                {
                    if (reader.Read())
                    {
                        admin = true;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al verificar si el usuario es administrador: " + ex.Message);
            }
            finally
            {
                if (reader != null && !reader.IsClosed)
                {
                    reader.Close();
                }
            }

            return admin;
        }
    }
}
