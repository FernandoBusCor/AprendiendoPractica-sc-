// c# es un leguaje fuertemente tipado
/*los tipos de datos en c# con practicamente los mimos que en java
String = cadena de texto
chat = caracter
bool = boleano v o d
float = numeros decimales de 6 a 7 digitos
var= numeros enteros de -2147483648 a 2147483647 
double = nuemeros decimales de 15 digitos
long = numeros enteros con un rango mañor a var-9223372036854775808 a 9223372036854775808
unit = numeros enteros positivos SOLO POSITIVOS

var = se usa para declarar de forma implicita variables 
pero se deben inicializa para que c# sepa cual es tipo de dato.
*/

//calcular el area de un rectangulo

int ladoA;
int ladoB;
int area;

Console.WriteLine("ingrese el lado a: ");
ladoA = Convert.ToInt32(Console.ReadLine());//se debe de hacer un cast por que lo lee como texto
Console.WriteLine("ingrese el lado b: ");
ladoB = Convert.ToInt32(Console.ReadLine());

area = ladoA * ladoB;

Console.WriteLine("el area es de " + area);