using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej5
{
    public class EncriptadorTransposicion : Encriptador
    {
        public EncriptadorTransposicion() : base("Transposicion") { }

        public override string Encriptar(string palabra)
        {
            int j = 0;
            char[] aux = new char[palabra.Length];
            for (int i = 0; i < palabra.Length; i++)
            {
                j = palabra.Length - i;
                aux[i] = palabra[j - 1];
            }
            return (new string(aux));
        }

        public override string Desencriptar(string palabra)
        {
            int j = 0;
            char[] aux = new char[palabra.Length];
            for (int i = 0; i < palabra.Length; i++)
            {
                j = palabra.Length - i;
                aux[i] = palabra[j - 1];
            }
            return (new string(aux));
        }
    }
}
