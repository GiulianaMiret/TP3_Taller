﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej3
{
    class EvaluadorAntiguedadLaboral : IEvaluador
    {
        private int iAntiguedadMinima;

        public EvaluadorAntiguedadLaboral (int pAntiguedadMinima)
        {
            this.iAntiguedadMinima = pAntiguedadMinima;
        }

        public bool EsValida (SolicitudPrestamo pSolicitud)
        {
            // 6 meses minimo
            //DateTime fechaActual = DateTime.Today;
            //TimeSpan antiguedad = pSolicitud.Cliente.FechaNacimiento.Subtract(DateTime.Today);
            //System.TimeSpan antiguedad = fechaActual.Subtract(pSolicitud.Cliente.Empleo.FechaIngreso);
            int año = DateTime.Today.Year - pSolicitud.Cliente.Empleo.FechaIngreso.Year;
            int mes = DateTime.Today.Month - pSolicitud.Cliente.Empleo.FechaIngreso.Month;
            if (mes > 5 || año > 0) { return true; }
            else return false;
            //return true;
        }
    }
}
