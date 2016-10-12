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
        //private FabricaEncriptadores cIntance;
        //private static readonly Lazy<FabricaEncriptadores> cInstance = new Lazy<FabricaEncriptadores>(() => { return new FabricaEncriptadores(); });
        //private static readonly object cSynch = new object();

        private Dictionary<string, IEncriptador> iEncriptadores;
        private static readonly Lazy<FabricaEncriptadores> cInstancia;
        
        static FabricaEncriptadores()
        {
            cInstancia = new Lazy<FabricaEncriptadores>(() => { return new FabricaEncriptadores(); });
        }


        private FabricaEncriptadores() { }


        public IEncriptador GetEncriptador(string nombre)
        {
            IEncriptador cInstancia = iEncriptadores[nombre];
            if (cInstancia == null) { cInstancia = new EncriptadorNulo(); }
            return cInstancia;
        }
        

        public static FabricaEncriptadores Instancia
        {
            get { return cInstancia.Value; }
        }

        //public object FabricanteEncriptadores { get; private set; }
    }
}
