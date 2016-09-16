using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1
{
    public class Perro: Animal
    {
        public override void HacerRuido()
        {
            Console.WriteLine("Guau Guau");
        }
/*
        public override void Correr()
        {
            throw new System.ArgumentException("Perrito Corriendo");
        }
        
        public override void Saltar()
        {
            throw new System.ArgumentException("Perrito Saltando");
        }*/
    }
}
