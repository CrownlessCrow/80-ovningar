//Skriv en funktion som läser in tre tal och avgör vilket tal som är minst. Resultatet ska skrivas ut.

Console.WriteLine("Skriv in tal 1");
int tal1 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Skriv in tal 2");
int tal2 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Skriv in tal 3");
int tal3 = int.Parse(Console.ReadLine()!);


hittaMinsta(tal1, tal2, tal3);

static void hittaMinsta(int tal1, int tal2, int tal3)

{


int minstaTalet = Math.Min(Math.Min(tal1, tal2), tal3);
Console.WriteLine($"Det minsta talet är: {minstaTalet}");
}
