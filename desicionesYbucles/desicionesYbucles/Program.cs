//while (true)
{
	//Console.WriteLine("Este codigo no se detiene");
}
//for(; ; )
{
	//Console.WriteLine("este codigo tambien no se detiene");
}

while (true)
{
	Console.WriteLine("te damos la bienvenida a la calculadora de sumas");
	Console.Write("Escriba el primer numero ");
	var entradaUsuario = Console.ReadLine();

	if (entradaUsuario is null)
	{
		Console.WriteLine("vuelve a comenzar");
		continue;
	}

	var numero1 = decimal.Parse(entradaUsuario);
	Console.Write(" Escriba el segundo numero: ");
	entradaUsuario = Console.ReadLine();

	if (entradaUsuario is null)
	{
		Console.WriteLine("Error vuelve a comenzar");
		continue;
	}
	var numero2 = decimal.Parse(entradaUsuario);
	Console.WriteLine($"el resultado de sumar {numero1} y {numero2} es {numero1 + numero2}");
	Console.Write("Desea sumar otra vez? (y/n) ");
	entradaUsuario = Console.ReadLine();
	{
		if (entradaUsuario != "y")
		{
			break;
		}

	}
	Console.WriteLine("Adios");
}