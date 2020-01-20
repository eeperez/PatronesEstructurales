using Proxy.Interfaces;
using Proxy.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy.Proxy
{
	public class ProxyEncendido : IEncendidoAuto
	{
		private EncendidoAuto encendidoAuto { get; set; }

		public ProxyEncendido(EncendidoAuto _encendidoAuto)
		{
			encendidoAuto = _encendidoAuto;
		}

		public bool VerificarAcceso(string _cLlave)
		{
			return _cLlave == "3323";
		}

		public string EncerderMotor(string _cLlave)
		{
			string cMensaje = string.Empty;

			if (VerificarAcceso(_cLlave))
				cMensaje = encendidoAuto.EncerderMotor(_cLlave);
			else
				cMensaje = $"Llave no valida: {_cLlave}";

			return cMensaje;
		}
	}
}
