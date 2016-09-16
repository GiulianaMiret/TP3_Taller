using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1
{
    public class Gato: Animal
    {
        public override void HacerRuido()
        {
            throw new System.ArgumentException("Miau Miau");
        }
/*
        public override void Correr()
        {
            throw new System.ArgumentException("Gatito Corriendo");
        }

        public override void Saltar()
        {
            throw new System.ArgumentException("Gatito Saltando");
        }*/
    }
}
