// operadores relaciones

/*
== es igual a 
!= es diferente a 
< es menor a
> es mayuor a
<= es menor igual a 
>= es mayor igua a
 */


using System.Xml.XPath;

var (valor1, valor2, valor3) = (10, 1, 2);

Console.WriteLine($"los valores son: {valor1} , {valor2} , {valor3}");

bool result;

result = valor1 == valor2;
Console.WriteLine($"el valor1 {valor1} es igual al valor 2 {valor2}:  {result}");

result = valor1 != valor2;
Console.WriteLine($"el valor1 {valor1} es diferente al valor 2 {valor2}: {result}");

result = valor1 < valor2;
Console.WriteLine($"el valor1 {valor1} es menor al valor 2 {valor2}: {result}");

result = valor1 > valor2;
Console.WriteLine($"el valor1 {valor1} es mayor al valor 2 {valor2}: {result}");

result = valor1 <= valor2;
Console.WriteLine($"el valor1 {valor1} es menor o igual al valor 2 {valor2}: {result}");

result = valor1 >= valor2;
Console.WriteLine($"el valor1 {valor1} es mayor o igual al valor 2 {valor2}: {result}");