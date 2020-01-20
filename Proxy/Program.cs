using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
	class Program
	{
		static void Main(string[] args)
		{
			string cLlave;
			Cliente cliente = new Cliente();

			while (true)
			{
				Console.WriteLine("Introducir la llave del auto:");
				cLlave = Console.ReadLine();

				string cResultado = cliente.EncenderAuto(cLlave);
				Console.WriteLine(cResultado);

				Console.ReadLine();
			}
		}
	}
}
