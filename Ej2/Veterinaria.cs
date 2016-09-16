using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej2
{
    class Veterinaria
    {

        public static void AceptarAnimales(Animal[] pAnimales)
        {
            foreach (Animal animal in pAnimales)
            {
                animal.HacerRuido();
            }
        }

    }
}
