using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej4
{
    class Singleton
    {
        private static readonly Lazy <Singleton> cinstance = new Lazy<Singleton>(() => new Singleton());
        //private static readonly object cSynch = new object();

        private Singleton() { }

        public static Singleton Instance
        {
            get
            {
                return cinstance;
            }
        }
    }
}
