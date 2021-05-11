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
        public void AltaAnimal(Animal Animal)
        {
            Logicas.Animales animales = new Logicas.Animales(Animal.Id,Animal.Nombre,Animal.Especie);
            Logicas.Principal.Instance.AltaAnimial(animales);
            
        }

        public void EliminarAnimal(int id)
        {
            Logicas.Principal.Instance.EliminarAnimal(id);
        }

        public List<Animales> ListadoAnimales()
        {
            return Logicas.Principal.Instance.ListadoAnimalesOrdenado();
        }

        public void ModificarAnimal(Animal animal)
        {
            Logicas.Animales animales = new Logicas.Animales(animal.Id, animal.Nombre, animal.Especie);
            Logicas.Principal.Instance.ModificarAnimal(animales);
        }
    }
}
