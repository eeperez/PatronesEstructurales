using Decorador.Entidades;
using Decorador.Interfaces;

namespace Decorador.Decoradores
{
	public class DecoradorAccionesCxP : IAccionesCxP
	{
		private IAccionesCxP accionCxP;

		public DecoradorAccionesCxP(IAccionesCxP _accionCxP)
		{
			accionCxP = _accionCxP;
		}

		public virtual string EjecutarAccion(CuentaPagar _cuentaPagar)
		{
			return accionCxP.EjecutarAccion(_cuentaPagar);
		}
	}
}
