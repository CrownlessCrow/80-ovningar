// 49. Skriv en funktion som beräknar
// f(x) = xⁿ
// x och n ska läsas in.

Console.WriteLine("Skriv in tal x");
int x = int.Parse(Console.ReadLine()!);

Console.WriteLine("Skriv in tal n");
int n = int.Parse(Console.ReadLine()!);


double svar = F(x, n);

Console.WriteLine($"Svar blir {svar}");






static double F(int x, int n)

{
    return Math.Pow(x, n);
}