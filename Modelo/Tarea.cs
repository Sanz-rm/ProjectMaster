using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMaster.Modelo
{
    public class Tarea
    {
        public int proyecto_id;
        public int id;
        public string nombre;
        public string descripcion;
        public int prioridad;
        public string estado;
        public DateTime fecha_fin;
        public List<Usuario> usuariosAsignados;

        public Tarea()
        {

        }
        public Tarea(int idProyecto, int idTarea, string nombre, string descripcion, int prioridad, DateTime fechaFin)
        {
            this.proyecto_id = idProyecto;
            this.id = idTarea;
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.prioridad = prioridad;
            this.fecha_fin = fechaFin;
            usuariosAsignados = new List<Usuario>();
        }
        public Tarea(int idProyecto, int idTarea, string nombre, string descripcion, int prioridad)
        {
            this.proyecto_id = idProyecto;
            this.id = idTarea;
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.prioridad = prioridad;
            usuariosAsignados = new List<Usuario>();
        }

        public Tarea(int idProyecto, int idTarea, string nombre, string descripcion, int prioridad, string estado, DateTime fechaFin)
        {
            this.proyecto_id = idProyecto;
            this.id = idTarea;
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.prioridad = prioridad;
            this.estado = estado;
            this.fecha_fin = fechaFin;
            usuariosAsignados = new List<Usuario>();
        }

        public void asignarUsuario(Usuario u)
        {
            usuariosAsignados.Add(u);
        }
    }
}
