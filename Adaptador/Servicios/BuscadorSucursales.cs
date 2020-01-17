using Adaptador.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adaptador.Servicios
{
	public class BuscadorSucursales : IBuscadorSucursales
	{
		public List<Sucursal> ObtenerSucursales()
		{
			List<Sucursal> lstSucursales = new List<Sucursal>();

			lstSucursales.Add(new Sucursal { cNombre = "Sucursal1", iIdSucursal = 1, dTotalVentasDia = 150M });
			lstSucursales.Add(new Sucursal { cNombre = "Sucursal2", iIdSucursal = 2, dTotalVentasDia = 200M });
			//lstSucursales.Add(new Sucursal { cNombre = "Sucursal 3", iIdSucursal = 3, dTotalVentasDia = 300M });

			return lstSucursales;
		}
	}
}
