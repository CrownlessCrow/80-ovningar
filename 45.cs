//45. Skriv en funktion där det undersöks hur många termer som behövs för att summan ska bli större än 100 000. Termen ska läsas in.


Console.Write("Ange en term: ");
int term = int.Parse(Console.ReadLine()!);

AntalTermer(term);

static void AntalTermer(int term)
{
    int summa = 0;
    int antal;

    for (antal = 0; summa <= 100000; antal++)
    {
        summa += term;
    }

    Console.WriteLine($"Det behövs {antal} termer");

}