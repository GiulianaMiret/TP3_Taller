using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej3
{
    class EvaluadorCompuesto : IEvaluador
    {
        private readonly List<IEvaluador> iEvaluadores;

        public EvaluadorCompuesto()
        {
			iEvaluadores = new List<IEvaluador>();
        }

        public bool EsValida(SolicitudPrestamo pSolicitud)
        {
            bool esValida = true;
            IEnumerator<IEvaluador> enumerador = this.iEvaluadores.GetEnumerator();
            while (esValida && enumerador.MoveNext())
            {
                esValida = enumerador.Current.EsValida(pSolicitud);
            }
            return esValida;

            /*foreach (IEvaluador evaluador in iEvaluadores)
			{
				if (!evaluador.EsValida(pSolicitud))
				{
					return false;
				}
			}
			return true;*/

            //Otra opcion:
            //return this.iEvaluadores.All((pEvaluador) => pEvaluador.EsValida(pSolicitud));
        }

        public void AgregarEvaluador(IEvaluador pEvaluador)
        {
            this.iEvaluadores.Add(pEvaluador);
        }
    }
}
