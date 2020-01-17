using Decorador.Entidades;
using Decorador.Interfaces;

namespace Decorador
{
	public class GuardadoCxP : IAccionesCxP
	{
		public string EjecutarAccion(CuentaPagar _cuentaPagar)
		{
			return $"Guardar CxP {_cuentaPagar.iId}, importe {_cuentaPagar.dImporte}";
		}
	}
}
