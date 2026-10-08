// // 50. Skriv en funktion som skriver ut multiplikationstabellen för ettans till nians tabell.

// Console.WriteLine("Första tal 1 - 9");
// int Första = tryParse(Console.ReadLine);

// Console.WriteLine("Andra tal 1 - 9");
// int Andra = tryParse(Console.ReadLine);

// Första = i;
// Andra = j;

// Summa = (i * j)


SkrivMultiplikationstabell();

static void SkrivMultiplikationstabell()

{
    for (int i = 1; i <= 9; i++)

    {
        for (int j = 1; j <= 9; j++)


        {
            Console.Write($"{i * j,5}");
        } 
        Console.WriteLine();
    }
}