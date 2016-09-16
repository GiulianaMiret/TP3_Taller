using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej2
{
    public abstract class Animal
    {
        public abstract void HacerRuido();

        public void Correr()
        {
            Console.WriteLine("Corriendo");
        }

        public void Saltar()
        {
            Console.WriteLine("Saltando");
        }
    }

}
