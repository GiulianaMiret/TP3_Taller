using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej4
{
    public interface IEncriptador
    {
         string Encriptar(string pcadena);
         string Desencriptar(string pcadena);
    }
}
