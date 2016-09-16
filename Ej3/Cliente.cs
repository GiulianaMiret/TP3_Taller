﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej3
{
    enum TipoCliente { NoCliente, Cliente, ClienteGold, ClientePremium}
    class Cliente
    {
        private string iNombre;
        private string iApellido;
		private Empleo iEmpleo;
		private int iTipoCliente;
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
    }
}
