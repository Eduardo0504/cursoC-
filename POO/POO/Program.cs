using POO;

var carro = new Carro("Toyota");
var carroString = carro.ToString();
Console.WriteLine("carro tostring: " + carroString);

AceptoCualquierParametro(carro);

//AceptoCualquierParametro(42);

//AceptoCualquierParametro("Eduardo");

AceptoCualquierParametro(new Camion());

void AceptoCualquierParametro(object objeto)
{
	Console.WriteLine("--- Inicio del Metodo--- ");


	if (objeto is Carro carro)
	{
		Console.WriteLine("El objeto es un carro");
		carro.SonarClaxon();
	}
	else if(objeto is Camion camion) 
	{
		Console.WriteLine("El objeto es un camion ");
		camion.DarReversa();
	}

	Console.WriteLine("---Fin del Metodo--- ");
}

