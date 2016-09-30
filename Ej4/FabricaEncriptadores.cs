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
        private FabricaEncriptadores cIntance;
        private static readonly Lazy<FabricaEncriptadores> cInstance = new Lazy<FabricaEncriptadores>(() => new FabricaEncriptadores());
        //private static readonly object cSynch = new object();

        private FabricaEncriptadores() { }

        public IEncriptador GetEncriptador(string nombre)
        {
            return cInstance;
        }


        public static FabricaEncriptadores Instance
        {
            get
            {
                return cInstance;
            }
        }

 

    }
}
