﻿using System;
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
            Veterinaria.AceptarAnimales(new Animal[]{ new Perro(), new Gato() });
            Console.ReadKey();
        }
    }
}
