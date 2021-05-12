using Logicas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace CapaServicios
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public void AltaAnimal(int Id, string Nombre, string Especie)
        {
            
            Logicas.Principal.Instance.AltaAnimial(Id, Nombre, Especie);
            
        }

        public void EliminarAnimal(int id)
        {
            Logicas.Principal.Instance.EliminarAnimal(id);
        }

        public List<Animal> ListadoAnimales()
        {
            List<Animal> Listado = new List<Animal>();
            
            foreach (var animales in Logicas.Principal.Instance.ListadoAnimalesOrdenado())
            {
                Animal animal = new Animal(animales.id, animales.Nombre, animales.especie);
                Listado.Add(animal);
            }
            
            
            return Listado;
        }

        public void ModificarAnimal(int Id, string Nombre, string Especie)
        {
            
            Logicas.Principal.Instance.ModificarAnimal(Id, Nombre, Especie);
        }
    }
}
