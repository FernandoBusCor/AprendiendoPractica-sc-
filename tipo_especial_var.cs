var ladoA = 0.0; //se inicializo como tipo double
var ladoB = 0.0;
var area = 0.0;

Console.WriteLine("ingrese el lado a: ");
ladoA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("ingrese el lado b: ");
ladoB = Convert.ToDouble(Console.ReadLine());

area = ladoA * ladoB;

Console.WriteLine("el area es de " + area);