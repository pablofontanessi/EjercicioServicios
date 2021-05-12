using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logicas
{
    public class Principal
    {
        private static Principal _instance = new Principal();

        private Principal()
        {
        }

        public static Principal Instance
        {
            get
            {
                return _instance;
            }
        }
        List<Animales> ListadoAnimales = new List<Animales>();

        public void AltaAnimial(int id, string Nombre, string especie)
        {
            Animales animal = new Animales(id,Nombre,especie);
            ListadoAnimales.Add(animal);
        }
        public void EliminarAnimal(int id)
        {
            ListadoAnimales.Find(x => x.id == id).Eliminado = true;
        }
        public void ModificarAnimal(int id, string Nombre, string especie)
        {
            ListadoAnimales.Find(x => x.id == id).fechaModificacion = DateTime.Today;
            ListadoAnimales.Find(x => x.id == id).Nombre = Nombre;
            ListadoAnimales.Find(x => x.id == id).especie = especie;
        }
        public List<Animales> ListadoAnimalesOrdenado()
        {
            List<Animales> Listado = ListadoAnimales.OrderBy(x => x.especie).ThenBy(x =>x.Nombre).ToList();
            return Listado;
        }
    }
}
