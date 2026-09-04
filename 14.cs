//Skriv en funktion som läser in ett tal och skriver ut om det är udda eller jämnt.

KollaUddaJamnt();

static void KollaUddaJamnt()

{
Console.WriteLine("Skriv in ett tal");
double tal = double.Parse(Console.ReadLine()!);

if (tal % 2 == 0)
    {
        Console.WriteLine("Talet är jämnt.");
    }
    else
    {
        Console.WriteLine("Talet är udda.");
    }
}

