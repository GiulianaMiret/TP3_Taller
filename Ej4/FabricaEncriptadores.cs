using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej4
{
    class FabricaEncriptadores
    {
        // tiene uno o muchos IEncriptadoes por cada tipo de cadena
        private FabricaEncriptadores cintance;
        private static readonly Lazy<FabricaEncriptadores> cinstance = new Lazy<FabricaEncriptadores>(() => new FabricaEncriptadores());
        //private static readonly object cSynch = new object();

        private FabricaEncriptadores() { }

        public IEncriptador GetEncriptador(string nombre)
        {
            return cinstance;
        }


        public static FabricaEncriptadores Instance
        {
            get
            {
                return cinstance;
            }
        }

 

    }
}
