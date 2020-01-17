using System;

namespace Puente
{
	class Program
	{
		static void Main(string[] args)
		{
			Cliente cliente = new Cliente();

			var lstAcciones = cliente.Enviar();

			foreach (string cMensaje in lstAcciones)
				Console.WriteLine(cMensaje);

			Console.ReadLine();
		}
	}
}
