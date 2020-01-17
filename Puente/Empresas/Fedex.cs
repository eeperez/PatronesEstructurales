using Puente.Interfaces;

namespace Puente.Empresas
{
	public class Fedex : IEmpresa
	{
		private IMetodosEnvio metodoEnvio;

		public Fedex(IMetodosEnvio _metodoEnvio)
		{
			metodoEnvio = _metodoEnvio;
		}

		public string EntregarPedidos()
		{
			return $"Fedex entrega pedido {metodoEnvio.EntregarPaquete()}";
		}

		public string EnviarPedidos()
		{
			return $"Fedex envia pedido {metodoEnvio.EnviarPaquete()}";
		}

		public string RecojerPedidos()
		{
			return $"Fedex recoje pedido {metodoEnvio.CargarPaquete()}";
		}
	}
}
