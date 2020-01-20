using Proxy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy.Servicios
{
	public class EncendidoAuto : IEncendidoAuto
	{
		public string EncerderMotor(string _cLlave)
		{
			string cMensaje = string.Empty;

			cMensaje = $"Se encendió el motor con la llave {_cLlave}";

			return cMensaje;
		}
	}
}
