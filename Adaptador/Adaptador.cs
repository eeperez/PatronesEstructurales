using Adaptador.Interfaces;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Adaptador
{
	public class Adaptador : IBuscadorSucursales
	{
		private IBuscadorSucursalesArchivo buscadorSucArchivo { get; set; }

		public Adaptador(IBuscadorSucursalesArchivo _buscadorSucArchivo)
		{
			buscadorSucArchivo = _buscadorSucArchivo;
		}

		public List<Sucursal> ObtenerSucursales()
		{
			List<Sucursal> lstSucursales = new List<Sucursal>();

			string cSucursales = buscadorSucArchivo.ObtenerSucursalesJSON();

			AdaptadorSucursal adaptadorSucursal = JsonConvert.DeserializeObject<AdaptadorSucursal>(cSucursales);
			lstSucursales = adaptadorSucursal.Sucursales;

			return lstSucursales;
		}
	}
}
