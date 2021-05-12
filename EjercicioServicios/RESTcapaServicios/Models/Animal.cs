using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RESTcapaServicios.Models
{
    public class Animal
    {
        public int id { get; set; }
        public string NombreYApellido { get; set; }


        public static List<Animal> ConvertirACapaServicio(List<Logicas.Animales> animales)
        {
            List<Animal> listado = new List<Animal>();
            Animal animal = new Animal();
            foreach (var item in animales)
            {
                animal.id = item.id;
                animal.NombreYApellido = item.Nombre + " " + item.especie;
                listado.Add(animal);
            }
            return listado;
        }
    }
}