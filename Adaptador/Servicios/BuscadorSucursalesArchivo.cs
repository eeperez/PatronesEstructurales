using Adaptador.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adaptador.Servicios
{
	public class BuscadorSucursalesArchivo : IBuscadorSucursalesArchivo
	{
		public string ObtenerSucursalesJSON()
		{
			return "{'Sucursales':[{'cNombre':'Sucursal1','iIdSucursal':1,'dTotalVentasDia':150},{'cNombre':'Sucursal2','iIdSucursal':2,'dTotalVentasDia':200}]}";
		}
	}
}
