using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej3
{
    class EvaluadorMonto : IEvaluador
    {
        private double iMontoMaximo;

        public EvaluadorMonto (double pMontoMaximo)
        {
            this.iMontoMaximo = pMontoMaximo;
        }

        public bool EsValida(SolicitudPrestamo pSolicitud)
        {
            switch (pSolicitud.Cliente.TipoCliente)
            {
                case TipoCliente.NoCliente:
                    if (pSolicitud.Monto <= 20000) { return true; }
                    else return false;
                case TipoCliente.Cliente:
                    if (pSolicitud.CantidadCuotas <= 100000) { return true; }
                    else return false;
                case TipoCliente.ClienteGold:
                    if (pSolicitud.CantidadCuotas <= 150000) { return true; }
                    else return false;
                case TipoCliente.ClientePremium:
                    if (pSolicitud.CantidadCuotas <= 200000) { return true; }
                    else return false;
                default: return false;
            }
        }
    }
}
