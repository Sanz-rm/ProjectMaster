using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace ProjectMaster.Modelo
{
    public class Proyecto
    {
        public int id;
        public string nombre;
        public string descripcion;
        public List<Usuario> miembros;

        public Proyecto()
        {
        }
        public Proyecto(int id, string nombre, string descripcion)
        {
            this.id = id;
            this.nombre = nombre;
            this.descripcion = descripcion;
        }
        public Proyecto(string nombre, string descripcion, List<Usuario> miembros)
        {
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.miembros = miembros;
        }
        public Proyecto(int id, string nombre)
        {
            this.id = id;
            this.nombre = nombre;
        }

        public void agregarMiembros(Usuario u)
        {
            miembros.Add(u);
        }

    }

}
