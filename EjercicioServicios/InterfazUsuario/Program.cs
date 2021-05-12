using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfazUsuario
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
            int id = 1;
            string nombre = "asda";
            string especie = "asda";
            
            client.AltaAnimal(id, nombre, especie);
            client.ModificarAnimal(id, "xxdd", "jsjs");

            foreach (var item in client.ListadoAnimales())
            {
                Console.WriteLine($"El id es {item.Id}, la especie y el nombre es: {item.EspecieYNombre}");
            }
            Console.ReadKey();
            
        }
    }
}
