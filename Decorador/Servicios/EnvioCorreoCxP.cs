using Decorador.Decoradores;
using Decorador.Entidades;
using Decorador.Interfaces;

namespace Decorador.Servicios
{
	public class EnvioCorreoCxP : DecoradorAccionesCxP
	{
		public EnvioCorreoCxP(IAccionesCxP _accionCxP) : base(_accionCxP)
		{
		}

		public override string EjecutarAccion(CuentaPagar _cuentaPagar)
		{
			string cRespuesta = base.EjecutarAccion(_cuentaPagar);
			cRespuesta += $". {EjecutarAccionEnvioCorreo(_cuentaPagar)}";

			return cRespuesta;
		}

		public string EjecutarAccionEnvioCorreo(CuentaPagar _cuentaPagar)
		{
			return $"Realiza Envio Correo CxP {_cuentaPagar.iId}";
		}
	}
}
