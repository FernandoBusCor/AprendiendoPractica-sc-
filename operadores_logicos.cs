dores logicos

/*
 && comparacion de dos valores. si a y b son iguales entonces el resultado es v pero si a y b no son iguales el resultados es falso
|| comparador or
! comparador not
 comparador xor diferente a 
 */

bool valor1=true;
bool valor2=true;
bool result;

result = valor1 && valor2;

Console.WriteLine($"el resultado es {result}");



result = valor1 || valor2;

Console.WriteLine($"el resultado es {result}");

result = !valor2;

Console.WriteLine($"el resultado es {result}");