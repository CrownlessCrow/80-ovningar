//Skriv en funktion som läser in ett tal. 
//Om talet är mellan 0 och 9 ska kvadraten på talet skrivas ut. 
//Annars ska lämpligt felmeddelande ges.

Console.WriteLine("Skriv in ett tal mellan 0 - 9");
int tal = int.Parse(Console.ReadLine()!);

kvadraten(tal);

static void kvadraten (int tal)

{
    if (0 <= tal && 9 >= tal)
{
int resultat = tal * tal;
Console.WriteLine($"Kvadraten för {tal} blir {resultat}");
}
else
    {
        Console.WriteLine("Det måste vara ett tal mellan 0 - 9");
    }
}
