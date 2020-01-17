using Adaptador.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adaptador
{
	public class Cliente
	{
		private IBuscadorSucursales buscadorSucursales { get; set; }

		public Cliente(IBuscadorSucursales _buscadorSucursales)
		{
			buscadorSucursales = _buscadorSucursales;
		}

		public List<Sucursal> ObtenerSucursales()
		{
			List<Sucursal> lstSucursales = new List<Sucursal>();

			lstSucursales = buscadorSucursales.ObtenerSucursales();

			return lstSucursales;
		}

		public void MostrarResultados(List<Sucursal> _lstSucursales)
		{
			foreach (Sucursal sucursal in _lstSucursales)
			{
				Console.WriteLine($"Id: {sucursal.iIdSucursal} Nombre: {sucursal.cNombre} Monto: {sucursal.dTotalVentasDia}");
			}
		}
	}
}
