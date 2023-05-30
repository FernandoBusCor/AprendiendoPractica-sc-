using System.Timers;

int totalJugador;
int totalDealer;
int num = 0;
string message = "";
string switchControl = "menu";
string controlcarta;
double dineroapuesta=0;
double resultadoapuestas=0;
string apuestapregunta;
bool auxganarPerder=true;
System.Random random = new System.Random();
//Blackjack, Juntar 21 pidiendo, en casa de pasarte de 21 pierdes.
//cartas o en caso de tener menos
//de 21 igual tener mayor puntuación que el dealer
int coin;
int aux;


Console.WriteLine("Welcome al c a s i n o");
Console.WriteLine("Cuantos coins necesitas \n. cada coin vale a un juego ");
coin = int.Parse(Console.ReadLine());//parseo
Console.WriteLine("\n Deseas apostar: si/no");
apuestapregunta = Console.ReadLine();//parseo

if (apuestapregunta=="si"||apuestapregunta=="Si"||apuestapregunta=="SI")
{
    Console.WriteLine("Cuanto dinero deseas apostar $:");
    dineroapuesta = Convert.ToDouble(Console.ReadLine());//parseo
}
else
{
    Console.WriteLine("muy bien, juegas por diversion");
}


aux = coin;
for(int i=0; i<coin;i++)
{
    totalDealer = 0;
    totalJugador = 0;

    switch (switchControl)
    {
        case "menu":
            Console.WriteLine("Escriba ‘21’ para jugar al 21");
            switchControl = Console.ReadLine();
            i -= 1;
            Console.WriteLine("intentos restantes: " + aux);
            aux--;
            break;

        case "21":
            do
            {
                num = random.Next(1, 12);
                totalJugador = totalJugador + num;
                Console.WriteLine("Toma tu carta, jugador,");
                Console.WriteLine($"Te salió el número: {num} ");
                Console.WriteLine("¿Deseas otra carta ?");
                controlcarta = Console.ReadLine();
            } while (controlcarta == "Si" || controlcarta == "si" || controlcarta == "yes");// condicion para iniciar o detener el ciclo

            totalDealer = random.Next(14, 23);
            Console.WriteLine($"el dealer tiene {totalDealer}");
            if (totalJugador==21 && totalDealer < 21 && totalDealer > 21)
            {
                message = "Venciste al dealer, felicidades";
                resultadoapuestas = dineroapuesta * 2;
                switchControl = "menu";
                auxganarPerder = true;
            }

            else if (totalJugador > totalDealer && totalJugador < 22)
            {
                message = "Venciste al dealer, felicidades";
                resultadoapuestas = dineroapuesta * 2;
                switchControl = "menu";
                auxganarPerder = true;
            }

            else if (totalJugador >= 22)
            {
                resultadoapuestas = 0 * dineroapuesta;
                message = "Perdiste vs el dealer, te pasaste de 21";
                switchControl = "menu";
                auxganarPerder = false;
            }
            else if (totalJugador <= totalDealer)
            {
                resultadoapuestas = 0 * dineroapuesta;
                message = "Perdiste vs el dealer, lo siento";
                switchControl = "menu";
                auxganarPerder = false;
            }
            else
            {
                message = "condición no válida";
            }

            if (apuestapregunta == "si" && auxganarPerder == true || apuestapregunta == "Si" && auxganarPerder == true || apuestapregunta == "SI" && auxganarPerder == true)
            {
                Console.WriteLine(message);
                Console.WriteLine($"Ganaste ${resultadoapuestas}");
            }
            else if (apuestapregunta == "si" && auxganarPerder == false || apuestapregunta == "Si" && auxganarPerder == false || apuestapregunta == "SI" && auxganarPerder == false)
            {
                Console.WriteLine(message);
                Console.WriteLine($"Perdiste ${dineroapuesta}");
            }
            else
            {
                Console.WriteLine(message);
            }
            break;
        default:
            Console.WriteLine("Valor ingresa no válido en el  C A S I N O");
            break;
    }
}
