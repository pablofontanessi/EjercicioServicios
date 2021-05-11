﻿using System;
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
        public void AltaAnimal(int id, string Nombre, string especie)
        {
            Logicas.Principal.Instance.AltaAnimial(id,Nombre,especie);
            
        }

        public void EliminarAnimal(int id)
        {
            Logicas.Principal.Instance.EliminarAnimal(id);
        }

        public string GetData(int value)
        {
            throw new NotImplementedException();
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            throw new NotImplementedException();
        }

        public void ModificarAnimal(int id, string Nombre, string especie)
        {
            Logicas.Principal.Instance.ModificarAnimal(id,Nombre,especie);
        }
    }
}