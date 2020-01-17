using Puente.Interfaces;

namespace Puente.Empresas
{
	public class Estafeta : IEmpresa
	{
		private IMetodosEnvio metodoEnvio;

		public Estafeta(IMetodosEnvio _metodoEnvio)
		{
			metodoEnvio = _metodoEnvio;
		}

		public string EntregarPedidos()
		{
			return $"Estafeta entrega pedido {metodoEnvio.EntregarPaquete()}";
		}

		public string EnviarPedidos()
		{
			return $"Estafeta enviar el pedido {metodoEnvio.EnviarPaquete()}";
		}

		public string RecojerPedidos()
		{
			return $"Estafeta recoje el pedido {metodoEnvio.CargarPaquete()}";
		}
	}
}
