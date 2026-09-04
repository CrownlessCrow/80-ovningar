//En försäljare har delvis prestationslön. Han får 8000 kr per månad i grundlön och 9% av försäljningssumman. 
// Skriv en funktion som beräknar lönesumman under en period. Försäljningssumman ska läsas in.
Console.Write("Ange försäljningsumma: ");
int forsaljning = int.Parse(Console.ReadLine()!);

double lon = 8000 + (forsaljning * 0.09);
Console.WriteLine(lon);
