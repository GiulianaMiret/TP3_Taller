using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej4
{
    // SEALED hace que la clase no pueda ser heredada
    sealed class EncriptadorNulo : Encriptador
    {
        public EncriptadorNulo(string pNombre) : base("Nulo") { }

        public override string Encriptar(string pCadena)
        {
            return pCadena;
        }

        public override string Desencriptar(string pCadena)
        {
            return pCadena;
        }
    }
}
