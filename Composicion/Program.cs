using Composicion.Interfaces;
using System;

namespace Composicion
{
	class Program
	{
		static void Main(string[] args)
		{
			Cliente cliente = new Cliente();

			cliente.CrearNodosCP();
			ISaldo arbol = cliente.ObtenerEstructuraArbol();
			decimal dSaldoTotal = cliente.ObtenerSaldoTotal(arbol);

			//Console.WriteLine($"El saldo total obtenido: {dSaldoTotal}");
			Console.ReadLine();
		}
	}
}
