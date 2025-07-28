namespace Utilidades
{
	public class ClasePublicaDePrueba
	{
		public int PropiedadPublica { get; set; }
		internal int PropiedadInterna { get; set; }
		protected int PropiedadProtegida { get; set; }
		protected internal int PropoeidadProtectedInternal { get; set; }

		public void MetodoPublico()
		{
			PropiedadInterna= 1;
			PropiedadProtegida= 2;
			PropoeidadProtectedInternal= 3;
			Console.WriteLine("Soy un metodo publico de otro proyecto");
		}

		private void MetodoPrivado()
		{
			var claseinterna = new ClaseInterna();
		}
		private class claseInterna
		{

		}
	}
}