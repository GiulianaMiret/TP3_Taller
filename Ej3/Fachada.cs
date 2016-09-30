using System;
using System.Collections.Generic;
namespace Ej3
{
	public class Fachada
	{
		List<Cliente> clientes = new List<Cliente>();
		GestorPrestamos gPrestamos = new GestorPrestamos();

		public Fachada()
		{
			// Cliente 1 tipo No Cliente
			clientes.Add(new Cliente("Juan", "Perez", new DateTime(1995, 5, 12),
									 new Empleo(5500.50, new DateTime(2014, 5, 3))));
			clientes[clientes.Count - 1].TipoCliente = TipoCliente.NoCliente;
		}

		public bool existeCliente(int cliente)
		{
			return cliente >= 0 && cliente < clientes.Count;
		}

		public double getMaximoMonto(int idCliente)
		{
			if(existeCliente(idCliente)){
				switch (clientes[idCliente].TipoCliente)
				{
					case TipoCliente.NoCliente:
						return 20000;
					case TipoCliente.Cliente:
						return 100000;
					case TipoCliente.ClienteGold:
						return 150000;
					case TipoCliente.ClientePremium:
						return 200000;
				}
			}
			return -1;
		}

		public int getMaximasCuotas(int idCliente)
		{
			if (existeCliente(idCliente){
				switch (clientes[idCliente].TipoCliente)
				{
					case TipoCliente.NoCliente:
						return 12;
					case TipoCliente.Cliente:
						return 32;
					case TipoCliente.ClienteGold:
						return 60;
					case TipoCliente.ClientePremium:
						return 60;
				}
			}
			return -1;
		}

		public bool SolicitudPrestamo(int idCliente, double pMonto, int pCuotas)
		{
			SolicitudPrestamo solicitud = new SolicitudPrestamo(clientes[idCliente], pMonto, pCuotas);
			return gPrestamos.EsValida(solicitud);
		}
	}
}
