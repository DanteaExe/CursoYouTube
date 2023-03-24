using static System.Console;

/*
Tipos de datos:
int
long
short
//numeros decimales
double 
float
decimal
//texto
string
char

var
object

conts
*/

int num1 = 8;
WriteLine($"El valor de la variable 1 es:{num1}");

double num2 = 18.967;
WriteLine(num1 + num2);

string? nombre = "perdro";
WriteLine("Hola " + nombre);

char primeraletraabcc = 'a';
WriteLine(primeraletraabcc);

var hola = 4686765765765647456754645m;
WriteLine(hola);

WriteLine(sizeof(int));
WriteLine(int.MaxValue);
WriteLine(int.MinValue);

WriteLine(num1 % num2);

num1 = 66;
WriteLine(num1);

const double pi = 3.141592;
WriteLine(pi * 2);

WriteLine(Math.PI);

WriteLine(Math.Max(2,3));

WriteLine(short.MaxValue);