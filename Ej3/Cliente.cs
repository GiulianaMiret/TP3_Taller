using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej3
{
    public enum TipoCliente { NoCliente, Cliente, ClienteGold, ClientePremium}
    public class Cliente
    {
        private string iNombre;
        private string iApellido;
		private Empleo iEmpleo;
		private TipoCliente iTipoCliente;
        private DateTime iFechaNacimiento;

		public Cliente(string pNombre, string pApellido, DateTime pFechaNacimiento, Empleo pEmpleo)
		{
			this.iNombre = pNombre;
			this.iApellido = pApellido;
			this.iFechaNacimiento = pFechaNacimiento;
			this.iEmpleo = pEmpleo;
		}

		public string Nombre
		{
			get { return this.iNombre; }
		}

		public string Apellido
		{
			get { return this.iApellido; }
		}

		public DateTime FechaNacimiento
		{
			get { return this.iFechaNacimiento; }
		}

		public Empleo Empleo
		{
			get { return this.iEmpleo; }
		}

        public TipoCliente TipoCliente
        {
            get { return this.iTipoCliente; }
        }
    }
}
