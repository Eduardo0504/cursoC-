using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
	internal abstract class Vehiculo
	{
		public Vehiculo()
		{

		}
		public Vehiculo(string marca)
		{
			Marca = marca;
		}
		public string? Marca { get; set; }
		public int AñoCreacion { get; set; }
		public int velocidad { get; private set; }
		public abstract int velocidadMaxima { get; }

		public virtual void DarReversa()
		{
			Console.WriteLine("Dando reversa-Implementacion por Defecto");
		}
		public abstract void SonarClaxon();

		internal void Acelerar(int incremento = 1)
		{
			if (velocidad>= velocidadMaxima)
			{
				Console.WriteLine("La velocidad Maxima ya ah sido Alcanzada");
				return;
			}else if (velocidad + incremento > velocidadMaxima)
			{
				incremento = velocidadMaxima - velocidad;
			}

			velocidad += incremento;
		}
	}

	internal class	Carro: Vehiculo
	{
		public Carro(string marca) : base(marca)
		{
		}

		public override int velocidadMaxima => 80;

		public void EncenderRadio()
		{
			Console.WriteLine("Encendiendo la radio");
		}

		public sealed override void SonarClaxon()
		{
			Console.WriteLine("BEEP!,BEEP!,BEEP!");
		}
		public override string ToString()
		{
			return "Carro con Marca: " + Marca;		
		}
	}

	internal class SonataGris : Carro
	{
		//public override void SonarClaxon()
		//{
		//	base.SonarClaxon();
		//}
		public SonataGris(string marca) : base(marca)
		{
		}
	}

	internal class Camion: Vehiculo
	{
		public override int velocidadMaxima =>70;

		public override void DarReversa()
		{
			base.DarReversa();
			Console.WriteLine("BEEP!,BEEP!,BEEP!");
		}

		public override void SonarClaxon()
		{
			Console.WriteLine("pon pooooon");
		}
	}

	internal class Bicicleta : Vehiculo
	{
		public override int velocidadMaxima => 20;

		public override void SonarClaxon()
		{
			Console.WriteLine("BIP BIP");
		}
	}
}
