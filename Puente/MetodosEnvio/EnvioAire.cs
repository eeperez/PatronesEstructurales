using Puente.Interfaces;

namespace Puente.MetodosEnvio
{
	public class EnvioAire : IMetodosEnvio
	{
		public string CargarPaquete()
		{
			return "Subir paquete al Avion";
		}

		public string EntregarPaquete()
		{
			return "del Avion";
		}

		public string EnviarPaquete()
		{
			return "Despegando";
		}
	}
}
