using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej3
{
    class EvaluadorCompuesto : IEvaluador
    {
        private List<IEvaluador> iEvaluadores;

        public EvaluadorCompuesto()
        {
			iEvaluadores = new List<IEvaluador>();
        }

        public bool EsValida(SolicitudPrestamo pSolicitud)
        {
			foreach (IEvaluador evaluador in iEvaluadores)
			{
				if (!evaluador.EsValida(pSolicitud))
				{
					return false;
				}
			}
			return true;
        }

        public void AgregarEvaluador (IEvaluador pEvaluador)
        {
			iEvaluadores.Add(pEvaluador);
        }
    }
}
