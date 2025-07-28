using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilidades
{
	internal class ClienteDentroDeLibreria
	{
		public void Prueba()
		{
			var clasePublicaDePrueba = new ClasePublicaDePrueba();
			clasePublicaDePrueba.PropiedadInterna = 3;
			clasePublicaDePrueba.PropoeidadProtectedInternal = 4;		
		}
	}
}
