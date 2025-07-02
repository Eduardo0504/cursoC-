//Ejemplo 1 arreglo de chars

char[]vocales = new char[5];

vocales[1] = 'e';
vocales[2] = 'i';
vocales[3] = 'o';
vocales[4] = 'u';

//var segundaVocal = vocales[2];

//Console.WriteLine(segundaVocal);

//var unaVocalMagica = vocales[5]; // no hay sexto elemento

//foreach (var vocal in vocales) ;

//Console.WriteLine(vocales);

var primeros6Elementos = new int[] { 1, 2, 3, 4, 5, 6 };

foreach (var numero in primeros6Elementos) ;
{
	Console.Write($"{numero} ");
}