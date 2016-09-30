using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej4
{
     public class EncriptadorAES : Encriptador
    {
        public EncriptadorAES(string pNombre) : base("AES") { } 
            

        public override string Encriptar(string pCadena)
        {
            string resultado = string.Empty;
            byte[] encryted = System.Text.Encoding.Unicode.GetBytes(pCadena);
            resultado = Convert.ToBase64String(encryted);
            return resultado; //Ver bien eso nose si esta  bien copy-paste.
        } 

        public override string Desencriptar(string pCadena)
        {
            string resultado = string.Empty;
            byte[] decryted = Convert.FromBase64String(pCadena);
            //resultado = System.Text.Encoding.Unicode.GetString(decryted, 0, decryted.ToArray().Length);
            resultado = System.Text.Encoding.Unicode.GetString(decryted);
            return resultado; //Ver bien eso nose si esta bien copy-paste.

        }

    }
}