using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej4
{
    class Fachada
    {

        public string EncriptarAES (string palabra)
        {
            EncriptadorAES encriptador = new EncriptadorAES("AES");
            return (encriptador.Encriptar(palabra));
        }

        public string DesencriptarAES(string palabra)
        {
            EncriptadorAES encriptador = new EncriptadorAES("AES");
            return (encriptador.Desencriptar(palabra));
        }

        public string EncriptarCesar(string palabra, int desplazamiento)
        {
            EncriptadorCesar encriptador = new EncriptadorCesar("Cesar", desplazamiento);
            return (encriptador.Encriptar(palabra));
        }

        public string DesencriptarCesar(string palabra, int desplazamiento)
        {
            EncriptadorCesar encriptador = new EncriptadorCesar("Cesar", desplazamiento);
            return (encriptador.Desencriptar(palabra));
        }

        public string EncriptarNulo(string palabra)
        {
            EncriptadorNulo encriptador = new EncriptadorNulo("Nulo");
            return (encriptador.Encriptar(palabra));
        }

        public string DesencriptarNulo(string palabra)
        {
            EncriptadorNulo encriptador = new EncriptadorNulo("Nulo");
            return (encriptador.Desencriptar(palabra));
        }
    }
}
