using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej3
{
    class EvaluadorCompuesto : IEvaluador
    {
        private IEvaluador iEvaluadores;

        public EvaluadorCompuesto()
        {
            
        }

        public bool EsValida(SolicitudPrestamo pSolicitud)
        {
            return true;    //falta el metodo
        }

        public void AgregarEvaluador (IEvaluador pEvaluador)
        {
            //Falta el metodo
        }
    }
}
