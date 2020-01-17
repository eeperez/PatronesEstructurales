using Composicion.Entidades;
using Composicion.Interfaces;
using System.Collections.Generic;

namespace Composicion
{
	public class Cliente
	{
		ClavePresup clavePresup111;
		ClavePresup clavePresup121;
		ClavePresup clavePresup212;
		ClavePresup clavePresup31;
		ClavePresup clavePresup4;

		public void CrearNodosCP()
		{
			var lstClaves = ObtenerClaves();

			clavePresup111 = new ClavePresup();
			clavePresup111.cvePresupDTO = lstClaves[0];

			clavePresup121 = new ClavePresup();
			clavePresup121.cvePresupDTO = lstClaves[1];

			clavePresup212 = new ClavePresup();
			clavePresup212.cvePresupDTO = lstClaves[2];

			clavePresup31 = new ClavePresup();
			clavePresup31.cvePresupDTO = lstClaves[3];

			clavePresup4 = new ClavePresup();
			clavePresup4.cvePresupDTO = lstClaves[4];
		}

		public ISaldo ObtenerEstructuraArbol()
		{
			var unidadAdmin111 = new UnidadAdmin("1.1.1");
			unidadAdmin111.AgregarNodo(clavePresup111);

			var unidaAdmin121 = new UnidadAdmin("1.2.1");
			unidaAdmin121.AgregarNodo(clavePresup121);

			var unidadAmin212 = new UnidadAdmin("2.1.2");
			unidadAmin212.AgregarNodo(clavePresup212);

			var unidaAdmin31 = new UnidadAdmin("3.1");
			unidaAdmin31.AgregarNodo(clavePresup31);

			var unidadAdmin4 = new UnidadAdmin("4");
			unidadAdmin4.AgregarNodo(clavePresup4);

			var unidadAdmin11 = new UnidadAdmin("1.1");
			unidadAdmin11.AgregarNodo(unidadAdmin111);

			var unidaAdmin12 = new UnidadAdmin("1.2");
			unidaAdmin12.AgregarNodo(unidaAdmin121);

			var unidadAmin21 = new UnidadAdmin("2.1");
			unidadAmin21.AgregarNodo(unidadAmin212);

			var unidadAdmin1 = new UnidadAdmin("1");
			unidadAdmin1.AgregarNodo(unidadAdmin11);
			unidadAdmin1.AgregarNodo(unidaAdmin12);

			var unidadAdmin2 = new UnidadAdmin("2");
			unidadAdmin2.AgregarNodo(unidadAmin21);

			var unidaAdmin3 = new UnidadAdmin("3");
			unidaAdmin3.AgregarNodo(unidaAdmin31);

			var unidadAdminUAX = new UnidadAdmin("Total");
			unidadAdminUAX.AgregarNodo(unidadAdmin1);
			unidadAdminUAX.AgregarNodo(unidadAdmin2);
			unidadAdminUAX.AgregarNodo(unidaAdmin3);
			unidadAdminUAX.AgregarNodo(unidadAdmin4);

			return unidadAdminUAX;
		}

		public decimal ObtenerSaldoTotal(ISaldo _unidadAdminArbol)
		{
			decimal dTotal = _unidadAdminArbol.ObtenerSaldo();

			return dTotal;
		}

		private List<ClavePresupDTO> ObtenerClaves()
		{
			List<ClavePresupDTO> lstClaves = new List<ClavePresupDTO>();

			lstClaves.Add(new ClavePresupDTO { cId = "21111.01.1.01.2201", dSaldoEnero = 10m, dSaldoFebrero = 20m, dSaldoMarzo = 30m });
			lstClaves.Add(new ClavePresupDTO { cId = "21111.01.1.01.2202", dSaldoEnero = 11m, dSaldoFebrero = 21m, dSaldoMarzo = 31m });
			lstClaves.Add(new ClavePresupDTO { cId = "21111.01.1.01.2203", dSaldoEnero = 12m, dSaldoFebrero = 22m, dSaldoMarzo = 32m });
			lstClaves.Add(new ClavePresupDTO { cId = "21111.01.1.01.2204", dSaldoEnero = 13m, dSaldoFebrero = 23m, dSaldoMarzo = 33m });
			lstClaves.Add(new ClavePresupDTO { cId = "21111.01.1.01.2205", dSaldoEnero = 14m, dSaldoFebrero = 24m, dSaldoMarzo = 34m });

			return lstClaves;
		}
	}
}
