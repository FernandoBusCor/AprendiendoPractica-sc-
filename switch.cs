//swiitch
int opciones;
string mensaje;
Console.WriteLine("ingrese el numero de la opcion que quire ver: ");
opciones = Convert.ToInt32(Console.ReadLine());
switch (opciones)
{
    case 1:
        mensaje = $"esta es la opcion {opciones}";
        Console.WriteLine(mensaje);
    break;
    case 2:
        mensaje = $"esta es la opcion {opciones}";
        Console.WriteLine(mensaje);
        break;
    case 3:
        mensaje = $"esta es la opcion {opciones}";
        Console.WriteLine(mensaje);
        break;
    default:
        mensaje = $"la opcion {opciones}no esta displinible";
        Console.WriteLine(mensaje);
        break;
};

