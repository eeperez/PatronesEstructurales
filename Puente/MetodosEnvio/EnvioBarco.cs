using Puente.Interfaces;

namespace Puente.MetodosEnvio
{
	public class EnvioBarco : IMetodosEnvio
	{
		public string CargarPaquete()
		{
			return "Subir paquete al Barco";
		}

		public string EntregarPaquete()
		{
			return "Bajar paquete del Barco";
		}

		public string EnviarPaquete()
		{
			return "Navegando";
		}
	}
}
