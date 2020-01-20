using Proxy.Proxy;
using Proxy.Servicios;

namespace Proxy
{
	public class Cliente
	{
		public string EncenderAuto(string _cLlave)
		{
			EncendidoAuto encendidoAuto = new EncendidoAuto();
			ProxyEncendido proxyEncendidoAuto = new ProxyEncendido(encendidoAuto);

			string cRespuesta = proxyEncendidoAuto.EncerderMotor(_cLlave);

			return cRespuesta;
		}
	}
}
