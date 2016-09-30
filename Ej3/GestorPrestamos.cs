using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej3
{
    public class GestorPrestamos
    {
		// private IEvaluador iEvaluadorPorCliente;
		// Este diccionario contiene uno o muchos IEvaluadores por cada tipo cliente
		private Dictionary<TipoCliente, IEvaluador> iEvaluadorPorCliente;

        public GestorPrestamos ()
        {
			iEvaluadorPorCliente = new Dictionary<TipoCliente, IEvaluador>();

			// El conjunto de reglas para el NoCliente
			EvaluadorCompuesto compuestoNoCliente = new EvaluadorCompuesto();
			compuestoNoCliente.AgregarEvaluador(new EvaluadorEdad(18,75));
			compuestoNoCliente.AgregarEvaluador(new EvaluadorAntiguedadLaboral(6));
			compuestoNoCliente.AgregarEvaluador(new EvaluadorSueldo(5000));
			compuestoNoCliente.AgregarEvaluador(new EvaluadorCantidadCuotas(12));
			compuestoNoCliente.AgregarEvaluador(new EvaluadorMonto(20000));

			// Agrego al diccionario las reglas del cliente
			iEvaluadorPorCliente.Add(TipoCliente.NoCliente, compuestoNoCliente);

			// El conjunto de reglas para el Cliente
			EvaluadorCompuesto compuestoCliente = new EvaluadorCompuesto();
			compuestoCliente.AgregarEvaluador(new EvaluadorEdad(18, 75));
			compuestoCliente.AgregarEvaluador(new EvaluadorAntiguedadLaboral(6));
			compuestoCliente.AgregarEvaluador(new EvaluadorSueldo(5000));
			compuestoCliente.AgregarEvaluador(new EvaluadorCantidadCuotas(32));
			compuestoCliente.AgregarEvaluador(new EvaluadorMonto(100000));

			// Agrego al diccionario las reglas del cliente
			iEvaluadorPorCliente.Add(TipoCliente.Cliente, compuestoCliente);

			// El conjunto de reglas para el Cliente Gold
			EvaluadorCompuesto compuestoClienteGold = new EvaluadorCompuesto();
			compuestoClienteGold.AgregarEvaluador(new EvaluadorEdad(18, 75));
			compuestoClienteGold.AgregarEvaluador(new EvaluadorAntiguedadLaboral(6));
			compuestoClienteGold.AgregarEvaluador(new EvaluadorSueldo(5000));
			compuestoClienteGold.AgregarEvaluador(new EvaluadorCantidadCuotas(60));
			compuestoClienteGold.AgregarEvaluador(new EvaluadorMonto(150000));

			// Agrego al diccionario las reglas del cliente
			iEvaluadorPorCliente.Add(TipoCliente.ClienteGold, compuestoClienteGold);

			// El conjunto de reglas para el Cliente Premium
			EvaluadorCompuesto compuestoClientePremium = new EvaluadorCompuesto();
			compuestoClientePremium.AgregarEvaluador(new EvaluadorEdad(18, 75));
			compuestoClientePremium.AgregarEvaluador(new EvaluadorAntiguedadLaboral(6));
			compuestoClientePremium.AgregarEvaluador(new EvaluadorSueldo(5000));
			compuestoClientePremium.AgregarEvaluador(new EvaluadorCantidadCuotas(60));
			compuestoClientePremium.AgregarEvaluador(new EvaluadorMonto(200000));

			// Agrego al diccionario las reglas del cliente
			iEvaluadorPorCliente.Add(TipoCliente.ClientePremium, compuestoClientePremium);
        }

        public bool EsValida (SolicitudPrestamo pSolicitud)
        {
			return iEvaluadorPorCliente[pSolicitud.Cliente.TipoCliente].EsValida(pSolicitud);
        }
    }
}
