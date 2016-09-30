using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej4
{
     public class EncriptadorCesar : Encriptador
    {
        public int iDesplazamiento;
        public EncriptadorCesar (int pDesplazamiento)
        {

        }

        public static string Encriptar(string pCadena)
        {
            string caracter = string.Empty;
            for (int i = 0; i < pCadena.Length; i++)
            {
                string Letra = pCadena.Substring(i, 1);
                int Codigo = Convert.ToInt16(Letra);
                string codcaracter = (string)EncriptadorCesar;
                caracter = caracter + codcaracter;
            }
            return caracter;
        }

    }
}
