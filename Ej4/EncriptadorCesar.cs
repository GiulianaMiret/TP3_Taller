using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej4
{
    public class EncriptadorCesar : Encriptador
    {
        static string abc = "abcdefghijklmñnopqrstuvwxyzABCDEFGHIJKLMNÑOPQRSTUVWXYZ1234567890_-+,#$%&/()=¿?¡!|,.;:{}[]";
        private int iDesplazamiento;
        public EncriptadorCesar(int pDesplazamiento) : base("CESAR")
        {
            this.iDesplazamiento = pDesplazamiento;
        }


        public override string Encriptar(string pCadena)
        {
            String frase = "";
            if (this.iDesplazamiento > 0 && this.iDesplazamiento < abc.Length)
            {                        //recorre caracter a caracter el mensaje a cifrar
                for (int i = 0; i < pCadena.Length; i++)
                {
                    int posCaracter = PosABC(pCadena[i]);
                    if (posCaracter != -1) //el caracter existe en la variable abc
                    {
                        int pos = posCaracter + this.iDesplazamiento;
                        while (pos >= abc.Length)
                        {
                            pos = pos - abc.Length;
                        } //concatena al mensaje cifrado
                        frase += abc[pos];
                    }
                    else//si no existe el caracter no se cifra
                    {
                        frase += pCadena[i];
                    }
                }
            }
            return frase;
        }

        public override string Desencriptar(string pCadena)
        {
            String frase = "";
            if (this.iDesplazamiento > 0 && this.iDesplazamiento < abc.Length)
            {
                for (int i = 0; i < pCadena.Length; i++)
                {
                    int posCaracter = PosABC(pCadena[i]);
                    if (posCaracter != -1) //el caracter existe en la variable abc
                    {
                        int pos = posCaracter - this.iDesplazamiento;
                        while (pos < 0)
                        {
                            pos = pos + abc.Length;
                        }
                        frase += abc[pos];
                    }
                    else
                    {
                        frase += pCadena[i];
                    }
                }

            }
            return frase;
        }

        static int PosABC(char caracter)
        {
            for (int i = 0; i < abc.Length; i++)
            {
                if (caracter == abc[i])
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
