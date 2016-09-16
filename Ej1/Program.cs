using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1
{
    class Program
    {
        static void Main(string[] args)
        {
            Perro perro = new Perro();
            Gato gato = new Gato();
            Veterinaria.AceptarAnimales(new Animal[]{perro, gato});
            Console.ReadKey();
        }
    }
}
