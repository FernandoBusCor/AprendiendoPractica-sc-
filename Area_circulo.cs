// calcula el area de un circulo
//por convencion las constantes siempre inician en mayusculas. 

var radio =0d;// od = 0decimales. forma correcta de inicializarlo
var resultado = 0d;

//las constantes se declaran : const tipo_de_dato nombre = 0;  ejemplo es si fuera pi. const double = 0d;
Console.WriteLine("Ingrese el radio del circulo: ");
radio = Convert.ToDouble(Console.ReadLine());

/* operadores aritmeticos
variable++ = suma uno al valor de la varible
variable-- = resta uno al valor de la varible

+ sima
- resta
* multplicaciones
/ divicion
% restante de una divicion NO ES EL RESULTADO DE LA DIVICION


*/

resultado = Math.PI * radio * radio;
Console.WriteLine($"El area del circulo es {resultado}");
