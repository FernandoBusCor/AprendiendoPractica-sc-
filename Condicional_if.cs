//condicion if
int totalJugador = 20;
int totalDealer = 15;
string message = "";

//Blackjack, juntar 21 pidiendo cartas o en caso de tener menos de 21 igual tener mayor puntuaciones que el dealer

if (totalJugador > 0) 
{
    message = "venciste al dealer, felicidades";
    
}
else if (totalJugador <= totalDealer)
{
    message = "Perdite, el dealer es le ganador";
}
else
{
    message="condicion invalida";
}
Console.WriteLine(message);
