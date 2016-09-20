using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej3
{
    class EvaluadorSueldo : IEvaluador
    {
        private double iSueldoMinimo;

        public EvaluadorSueldo (double pSueldoMinimo)
        {
            this.iSueldoMinimo = pSueldoMinimo;
        }

        public bool EsValida (SolicitudPrestamo pSolicitud)
        {
            if (pSolicitud.Cliente.Empleo.Sueldo >= 5000) { return true; }
            else return false;
        }
    }
}
