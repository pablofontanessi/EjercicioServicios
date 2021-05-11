using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logicas
{
   public class Animales
    {
        public Animales(int id, string nombre, string especie)
        {
            this.id = id;
            Nombre = nombre;
            this.especie = especie;
            fechaCreacion = DateTime.Today;
            Eliminado = false;
        }

        public int id { get; set; }
        public string Nombre { get; set; }
        public string especie { get; set; }
        public DateTime fechaCreacion { get; set; }
        public DateTime fechaModificacion { get; set; }
        public bool Eliminado { get; set; }
        
    }
}
