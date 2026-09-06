//Konstruera en funktion där ett tal läses in och det skrivs ut om talet är positivt eller negativt.

Console.WriteLine("Skriv in ett tal");
int tal = int.Parse(Console.ReadLine());

sifferTal(tal);

static void sifferTal (int tal)

{
if (tal >= 0)
    {
        Console.WriteLine($"Talet är positiv {tal}");
    }
else if (tal < 0)
    {
        Console.WriteLine($"Talet är negativ {tal}");
    }
}
