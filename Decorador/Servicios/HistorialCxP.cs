using Decorador.Decoradores;
using Decorador.Entidades;
using Decorador.Interfaces;

namespace Decorador.Servicios
{
	public class HistorialCxP : DecoradorAccionesCxP
	{
		public HistorialCxP(IAccionesCxP _accionCxP) : base(_accionCxP)
		{
		}

		public override string EjecutarAccion(CuentaPagar _cuentaPagar)
		{
			string cRespuesta = base.EjecutarAccion(_cuentaPagar);
			cRespuesta += $". {EjecutarAccionHistorial(_cuentaPagar)}";

			return cRespuesta;
		}

		public string EjecutarAccionHistorial(CuentaPagar _cuentaPagar)
		{
			return $"Realiza Historial CxP {_cuentaPagar.iId}";
		}
	}
}
