using Decorador.Entidades;
using Decorador.Interfaces;
using Decorador.Servicios;
using System.Collections.Generic;

namespace Decorador
{
	public class Cliente
	{
		public string EjecutarAccion()
		{
			List<string> lstModificaciones = new List<string>();
			string cRespuesta = string.Empty;

			IAccionesCxP guardadoCxP = new GuardadoCxP();
			var cxp = ObtenerCxP();

			cRespuesta = guardadoCxP.EjecutarAccion(cxp);

			//Modificación 1
			lstModificaciones.Add("\nModificación 1:\n");
			IAccionesCxP historialCxP = new HistorialCxP(guardadoCxP);
			lstModificaciones.Add(historialCxP.EjecutarAccion(cxp));
			//-------

			//Modificación 2
			lstModificaciones.Add("\nModificación 2\n");
			IAccionesCxP envioCorreoCxP = new EnvioCorreoCxP(guardadoCxP);
			lstModificaciones.Add(envioCorreoCxP.EjecutarAccion(cxp));
			//-------

			//Modificación 3
			lstModificaciones.Add("\nModificación 3\n");
			IAccionesCxP historialCxP3 = new HistorialCxP(guardadoCxP);
			IAccionesCxP envioCorreoCxP3 = new EnvioCorreoCxP(historialCxP);
			lstModificaciones.Add(envioCorreoCxP3.EjecutarAccion(cxp));
			//-------

			cRespuesta += string.Join("", lstModificaciones);

			return cRespuesta;
		}

		private CuentaPagar ObtenerCxP()
		{
			CuentaPagar cxp = new CuentaPagar
			{
				iId = 23,
				dImporte = 10m,
				lNaturaleza = true
			};

			return cxp;
		}
	}
}
