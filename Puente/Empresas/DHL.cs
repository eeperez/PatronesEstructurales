using Puente.Interfaces;

namespace Puente.Empresas
{
	public class DHL : IEmpresa
	{
		private IMetodosEnvio metodoEnvio;

		public DHL(IMetodosEnvio _metodoEnvio)
		{
			metodoEnvio = _metodoEnvio;
		}

		public string EntregarPedidos()
		{
			return $"DHL Entregar por {metodoEnvio.EntregarPaquete()}";
		}

		public string EnviarPedidos()
		{
			return $"DHL Enviar: {metodoEnvio.EnviarPaquete()}";
		}

		public string RecojerPedidos()
		{
			return $"DHL Recojer pedido {metodoEnvio.CargarPaquete()}";
		}
	}
}
