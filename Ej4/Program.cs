using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej4
{
    class Program
    {
        static void Main(string[] args)
        {
            EncriptadorCesar en = new EncriptadorCesar("Cesar", 2);
            
            Console.WriteLine(en.Encriptar("Hola"));
            
            Console.WriteLine(en.Desencriptar("Jqñc"));
            Console.ReadKey();
        }
    }
}
