using Adaptador.Interfaces;
using Adaptador.Servicios;
using System;
using System.Collections.Generic;

namespace Adaptador
{
	class Program
	{
		static void Main(string[] args)
		{
			List<Sucursal> lstSucursales = null;
			IBuscadorSucursales buscador = new BuscadorSucursales();
			Cliente cliente = new Cliente(buscador);

			lstSucursales = cliente.ObtenerSucursales();
			cliente.MostrarResultados(lstSucursales);

			Console.WriteLine("Por JSON:");

			buscador = new Adaptador(new BuscadorSucursalesArchivo());
			cliente = new Cliente(buscador);

			lstSucursales = cliente.ObtenerSucursales();
			cliente.MostrarResultados(lstSucursales);

			Console.ReadLine();
		}
	}
}
