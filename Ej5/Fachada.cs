using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej5
{
    class Fachada
    {

        public string EncriptarAES(string palabra)
        {
            EncriptadorAES encriptador = new EncriptadorAES();
            return (encriptador.Encriptar(palabra));
        }

        public string DesencriptarAES(string palabra)
        {
            EncriptadorAES encriptador = new EncriptadorAES();
            return (encriptador.Desencriptar(palabra));
        }

        public string EncriptarCesar(string palabra, int desplazamiento)
        {
            EncriptadorCesar encriptador = new EncriptadorCesar(desplazamiento);
            return (encriptador.Encriptar(palabra));
        }

        public string DesencriptarCesar(string palabra, int desplazamiento)
        {
            EncriptadorCesar encriptador = new EncriptadorCesar(desplazamiento);
            return (encriptador.Desencriptar(palabra));
        }

        public string EncriptarNulo(string palabra)
        {
            EncriptadorNulo encriptador = new EncriptadorNulo();
            return (encriptador.Encriptar(palabra));
        }

        public string DesencriptarNulo(string palabra)
        {
            EncriptadorNulo encriptador = new EncriptadorNulo();
            return (encriptador.Desencriptar(palabra));
        }

        public string EncriptarTranspuesto(string palabra)
        {
            EncriptadorTransposicion encriptador = new EncriptadorTransposicion();
            return (encriptador.Encriptar(palabra));
        }

        public string DesencriptarTranspuesto(string palabra)
        {
            EncriptadorTransposicion encriptador = new EncriptadorTransposicion();
            return (encriptador.Desencriptar(palabra));
        }
    }
}
