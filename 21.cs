//Skriv en funktion som testar om ett tal är mindre än -10 eller större än +10. I så fall ska ett lämpligt meddelande ges.

Console.WriteLine("Skriv in ett tal mellan -10 och + 10");
int tal = int.Parse(Console.ReadLine()!);

mellanTal(tal);

static void mellanTal(int tal)

{
if(-10 >= tal || 10 <= tal)

    {
        Console.WriteLine($"Du har skrivit {tal}");
    }
else
    {
        Console.WriteLine($"Du har inte skrivet ett tal mellan -10 och + 10 ");
    }
}

