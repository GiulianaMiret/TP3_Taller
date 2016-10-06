using System;
using System.Collections.Generic;
namespace Ej3
{
	public class Fachada
	{
		private List<Cliente> clientes = new List<Cliente>();
		private GestorPrestamos gPrestamos = new GestorPrestamos();

		public Fachada()
		{
			// Cliente 1 tipo No Cliente
			this.clientes.Add(new Cliente("Juan", "Perez", new DateTime(1995, 5, 12),
									 new Empleo(5500.50, new DateTime(2014, 5, 3))));
			this.clientes[clientes.Count - 1].TipoCliente = TipoCliente.NoCliente;

			// Cliente 2 tipo Cliente
			this.clientes.Add(new Cliente("Juana", "Perez", new DateTime(1993, 5, 12),
									 new Empleo(8000.0, new DateTime(2015, 5, 4))));
			this.clientes[clientes.Count - 1].TipoCliente = TipoCliente.Cliente;

			// Cliente 3 tipo ClienteGold
			this.clientes.Add(new Cliente("Harry", "Potter", new DateTime(1990, 2, 2),
									 new Empleo(13000.00, new DateTime(2010, 5, 6))));
			this.clientes[clientes.Count - 1].TipoCliente = TipoCliente.ClienteGold;

			// Cliente 4 tipo ClientePremium
			this.clientes.Add(new Cliente("Clark", "Kent", new DateTime(1945, 5, 1),
									 new Empleo(25500.50, new DateTime(1985, 5, 3))));
			this.clientes[clientes.Count - 1].TipoCliente = TipoCliente.ClientePremium;
		}

		public bool existeCliente(int cliente)
		{
			return cliente >= 0 && cliente < this.clientes.Count;
		}

		public double getMaximoMonto(int idCliente)
		{
			if(existeCliente(idCliente)){
				switch (this.clientes[idCliente].TipoCliente)
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
			if (existeCliente(idCliente)){
				switch (this.clientes[idCliente].TipoCliente)
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
			SolicitudPrestamo solicitud = new SolicitudPrestamo(this.clientes[idCliente], pMonto, pCuotas);
			return gPrestamos.EsValida(solicitud);
		}
	}
}
