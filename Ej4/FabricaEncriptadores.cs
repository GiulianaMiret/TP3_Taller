using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej4
{
    class FabricaEncriptadores : Singleton
    {
        // tiene uno o muchos IEncriptadoes por cada tipo de cadena
        private Dictionary<cadena, IEncriptador> iEncroptadores = new Dictionary<cadena, IEncriptador>();

        public FabricaEncriptadores()
        {
           
        }

        public bool EsValida(SolicitudPrestamo pSolicitud)
        {
            return iEvaluadorPorCliente[pSolicitud.Cliente.TipoCliente].EsValida(pSolicitud);
        }

    }
}
