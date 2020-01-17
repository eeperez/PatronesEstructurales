using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorador.Entidades
{
	public class CuentaPagar
	{
		public int iId { get; set; }

		public decimal dImporte { get; set; }

		public bool lNaturaleza { get; set; }

		public CuentaPagar()
		{
			dImporte = 0m;
			lNaturaleza = false;
		}
	}
}
