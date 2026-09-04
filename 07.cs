//Skriv en funktion som beräknar vad du ska betala för en tank bensin. Indata är antal liter, pris per liter och eventuell rabatt i procent. 
//Utdata är priset som du ska betala.

Console.Write("Skriv in hur mycket du har tankat: ");
double bensin = double.Parse(Console.ReadLine()!);
double liter = bensin * 15.94;

Console.WriteLine("Skriv in rabatt i procent");

double rabattKod = double.Parse(Console.ReadLine()!);

double reduceratPris = liter * 0.2;

double nyaPriset = liter - reduceratPris;

Console.WriteLine($"Du har tankar för {liter} kr totalt kr, du har fått rabatt på {rabattKod}%. Du ska betalar {nyaPriset}kr");