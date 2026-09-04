//Skriv en funktion som läser in ett tal och skriver ut om det är jämnt. (Använd modulooperatorn)


//Modulo eller restoperator
Console.WriteLine("Skriv in ett tal");
int even = int.Parse(Console.ReadLine()!);

if (even % 2 == 0)

{
    Console.WriteLine($"Talet är jämt.");
}
else
{
    Console.WriteLine($"Talet är ojämt.");
}