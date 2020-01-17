using Composicion.Entidades;
using Composicion.Interfaces;

namespace Composicion
{
	public class ClavePresup : ISaldo
	{
		public ClavePresupDTO cvePresupDTO { get; set; }

		public decimal ObtenerSaldo()
		{
			decimal dSaldoTotal = cvePresupDTO.dSaldoEnero + cvePresupDTO.dSaldoFebrero + cvePresupDTO.dSaldoMarzo;

			return dSaldoTotal;
		}
	}
}
