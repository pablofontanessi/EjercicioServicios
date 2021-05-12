using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RESTcapaServicios.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
     

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }
        public string Get()
        {
            foreach (var item in Models.Animal.ConvertirACapaServicio(Logicas.Principal.Instance.ListadoAnimalesOrdenado()))
            {
                return $"El id animal es {item.id} y la especie y el nombre: {item.NombreYApellido} ";
            }
            return "no hay animales";
            
        }

        // POST api/values
        public void Post([FromBody] string value)
        {
        }
        public void Post(int id, string Nombre, string Especie)
        {
            Logicas.Principal.Instance.AltaAnimial(id,Nombre,Especie);
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
        }
        public void Put(int id, string Nombre, string Especie)
        {
            Logicas.Principal.Instance.ModificarAnimal(id, Nombre, Especie);
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
            Logicas.Principal.Instance.EliminarAnimal(id);
        }
    }
}
