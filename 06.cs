//Skriv en funktion som beräknar funktionen ax3 + 7 och skriver ut resultatet. Variablerna a och x ska läsas in.

Console.WriteLine("Skriv in tal a");
int tal1 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Skriv in tal x");
int tal2 = int.Parse(Console.ReadLine()!);

int summa = tal1 * (int)Math.Pow(tal2, 3) + 7;

Console.WriteLine($"Summa är: {summa}");