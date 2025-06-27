var usuarioEstaLogueado = true;

string mensajeBienvenida;

if (usuarioEstaLogueado)
{
	mensajeBienvenida = "que bueno que has vuelto";
}
else
{
	mensajeBienvenida = "logueate para comenzar";
}
string mensajeBienvenda = usuarioEstaLogueado ? "que bueno que has vuelto¡" : "logueate para comenzar";

Console.WriteLine(mensajeBienvenda);