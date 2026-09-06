//Skriv en funktion som läser in två tal 
// och skriver ut det största talet följt av orden “är störst “. 
// Om talen är lika ska “Talen är lika“ skrivas ut.

Console.WriteLine("Skriv in tal 1");
int tal1 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Skriv in tal 2");
int tal2 = int.Parse(Console.ReadLine()!);

StorstEllerLika (tal1, tal2);

static void StorstEllerLika (int tal1, int tal2)

{
if (tal1 > tal2)
{
    Console.WriteLine($"{tal1} är störst"); //Om det är så här, så stämmer det
}
else if (tal1 < tal2)
{
    Console.WriteLine($"{tal2} är störst");   //Om inte det första stämmer, men är såhär istället.
}
else 
    {
    Console.WriteLine($"Talen är lika"); // Om inget av det ovanstående stämde alls.
    }
}