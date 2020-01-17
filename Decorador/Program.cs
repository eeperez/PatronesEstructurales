using System;

namespace Decorador
{
	class Program
	{
		static void Main(string[] args)
		{
			string cRespuesta = string.Empty;
			Cliente cliente = new Cliente();

			cRespuesta = cliente.EjecutarAccion();

			Console.WriteLine(cRespuesta);
			Console.ReadLine();
		}
	}
}
