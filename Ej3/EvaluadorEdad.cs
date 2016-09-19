using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej3
{
    class EvaluadorEdad : IEvaluador
    {
        private int iEdadMinima;
        private int iEdadMaxima;

        public EvaluadorEdad (int pEdadMinima, int pEdadMaxima)
        {
            this.iEdadMaxima = pEdadMaxima;
            this.iEdadMinima = pEdadMinima;
        }

        public bool EsValida (SolicitudPrestamo pSolicitud)
        {
            int año = DateTime.Today.Year - pSolicitud.Cliente.FechaNacimiento.Year;
            if (año > 17 && año < 76) { return true; }
            else return false;
        }
    }
}
