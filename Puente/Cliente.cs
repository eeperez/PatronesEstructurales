using Puente.Empresas;
using Puente.Interfaces;
using Puente.MetodosEnvio;
using System.Collections.Generic;

namespace Puente
{
	public class Cliente
	{
		private List<IEmpresa> RealizarProceso()
		{
			List<IEmpresa> lstEmpresas = new List<IEmpresa>();
			IEmpresa fedex = new Fedex(new EnvioBarco());
			IEmpresa dhlAire = new DHL(new EnvioAire());
			IEmpresa dhlBarco = new DHL(new EnvioBarco());
			IEmpresa estafeta = new Estafeta(new EnvioTren());

			lstEmpresas.Add(fedex);
			lstEmpresas.Add(dhlAire);
			lstEmpresas.Add(dhlBarco);
			lstEmpresas.Add(estafeta);

			return lstEmpresas;
		}

		public List<string> Enviar()
		{
			List<IEmpresa> _lstEmpresas = RealizarProceso();
			List<string> lstAcciones = new List<string>();

			foreach (var empresa in _lstEmpresas)
			{
				lstAcciones.Add(empresa.RecojerPedidos());
				lstAcciones.Add(empresa.EnviarPedidos());
				lstAcciones.Add(empresa.EntregarPedidos());
			}

			return lstAcciones;
		}
	}
}
