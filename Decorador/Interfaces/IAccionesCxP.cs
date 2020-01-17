using Decorador.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorador.Interfaces
{
	public interface IAccionesCxP
	{
		string EjecutarAccion(CuentaPagar _cuentaPagar);
	}
}
