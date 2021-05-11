using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace CapaServicios
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        List<Logicas.Animales> ListadoAnimales();
        
        // TODO: Add your service operations here
        [OperationContract]
        void AltaAnimal(Animal animal);

        [OperationContract]
        void ModificarAnimal(Animal animal);
        [OperationContract]
        void EliminarAnimal(int id);
        
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class Animal
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Especie{ get; set; }
        [DataMember]
        public string Nombre { get; set; }

    }
}
