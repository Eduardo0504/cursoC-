var cantidad1 = 5;
var cantidad2 = 5;

var cantidad1EsIgualACantidad2 = true;
var cantidad2EsDiferenteACantidad2 = false;

Console.WriteLine($"son {cantidad1} y {cantidad2} iguales? {cantidad1EsIgualACantidad2}");
Console.WriteLine($"son {cantidad1} y {cantidad2} diferentes? {cantidad2EsDiferenteACantidad2}");

var esCantidad1MayorQue10 = cantidad1 > 10;
var esCantidad1MenorQue10 = cantidad1 < 10;

var esCantidad1MenorOIgualque10 = cantidad1 <= 10;
var esCantidad1MayorOIgualque10 = cantidad1 >= 10;

string? nombre1 = "carlos";
var nombre2 = "Juan";

var sonlosNombres1IgualANombre2 = nombre1 == nombre2;

var sonNombre1Nulo = nombre1 is null;
var sonNombre1NoNulo = nombre1 is not null;

Console.WriteLine("es nombre1 igual a nulo?" + sonNombre1Nulo );
Console.WriteLine("es nombre1 igual a nulo?" + sonNombre1NoNulo);



