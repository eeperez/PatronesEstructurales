using Puente.Interfaces;

namespace Puente.MetodosEnvio
{
	public class EnvioTren : IMetodosEnvio
	{
		public string CargarPaquete()
		{
			return "Subir paquete al Tren";
		}

		public string EntregarPaquete()
		{
			return "Bajar paquete del Tren";
		}

		public string EnviarPaquete()
		{
			return "Encendiendo locomotara";
		}
	}
}
