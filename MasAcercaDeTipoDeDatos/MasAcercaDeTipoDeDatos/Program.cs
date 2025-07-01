//var cantidad1 = "5";

//int cantidad = int.Parse(cantidad1);

//cantidad++;

//Console.WriteLine(cantidad); // esto da 6

var supuestoNumero = "6";

int numero;

var pudoParsear = int.TryParse(supuestoNumero, out numero);

if (pudoParsear)
{
	//lugar donde no puede usar la variable numero
	numero++;
	Console.WriteLine(numero);
}
else
{
	Console.WriteLine($"el valor {supuestoNumero} no tiene el formato correcto. ");
}
