using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej3
{
    class EvaluadorCantidadCuotas : IEvaluador
    {
        private int iCantidadMaximaCuotas;

        public EvaluadorCantidadCuotas(int pCantidadMaximaCuotas)
        {
            this.iCantidadMaximaCuotas = pCantidadMaximaCuotas;
        }

        public bool EsValida(SolicitudPrestamo pSolicitud)
        {
            switch (pSolicitud.Cliente.TipoCliente)
            {
                case TipoCliente.NoCliente:
                    if (pSolicitud.CantidadCuotas < 13) { return true; }
                    else return false;
                case TipoCliente.Cliente:
                    if (pSolicitud.CantidadCuotas < 33) { return true; }
                    else return false;
                case TipoCliente.ClienteGold:
                    if (pSolicitud.CantidadCuotas < 61) { return true; }
                    else return false;
                case TipoCliente.ClientePremium:
                    if (pSolicitud.CantidadCuotas < 61) { return true; }
                    else return false;
                default: return false;
            }
        }
    }
}