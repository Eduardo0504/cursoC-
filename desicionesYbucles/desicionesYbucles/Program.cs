var cantidad = 6;
var estaEntre5y10 = cantidad > 5 && cantidad < 10; // true

Console.WriteLine($"esta el {cantidad} entre 5 y 10 {estaEntre5y10}");

var cantida1Es5o6 = cantidad == 5 || cantidad == 6;

Console.WriteLine($"¿es {cantidad} igual a 5 o 6? {cantida1Es5o6}");

string? apellido = null;

var estaElApellidoEnMayusculas =apellido is not null && apellido == apellido.ToUpper();
Console.WriteLine("¿esta el string en mayusculas? " + estaElApellidoEnMayusculas);

