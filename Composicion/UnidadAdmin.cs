using Composicion.Interfaces;
using System;
using System.Collections.Generic;

namespace Composicion
{
	public class UnidadAdmin : ISaldo
	{
		private List<ISaldo> lstSaldo { get; set; }

		private string cIdUA { get; set; }

		public UnidadAdmin(string _cIdUA)
		{
			cIdUA = _cIdUA;
			lstSaldo = new List<ISaldo>();
		}

		public void AgregarNodo(ISaldo _saldo)
		{
			lstSaldo.Add(_saldo);
		}

		public decimal ObtenerSaldo()
		{
			decimal dSaldo = 0m;

			foreach (var saldo in lstSaldo)
			{
				dSaldo += saldo.ObtenerSaldo();
			}

			Console.WriteLine($"{cIdUA} saldo: {dSaldo}");

			return dSaldo;
		}
	}
}
