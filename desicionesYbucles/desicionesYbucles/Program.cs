var temperatura = 39;

var mensaje = temperatura switch
{
	37 => " no tienes fiebre",
	> 37 => " tienes fiebre ",
	< 37 => " puede que tengas baja el azucar "
};
Console.WriteLine(mensaje);