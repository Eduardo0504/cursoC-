var nombre = "Eduardo";

var nombreEnMayusculas = nombre.ToUpper(); // EDUARDO
var nombreEnMinusculas = nombre.ToUpper(); // eduardo

Console.WriteLine($"¿desea terminar el programa? (y/n)");
var entradaUsuario = Console.ReadLine();

if (entradaUsuario?.ToLower().Trim() == "y")
{
	Console.WriteLine("terminando el programa");
}
else
{
	Console.WriteLine("el programa no va a terminar");
}