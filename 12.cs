//Läs in två tal. Testa om det första talet är mer än dubbelt så stort som det andra talet. 
//I så fall ska meddelandet “För stort“ skrivas ut.
Console.WriteLine("Skriv in tal A");
int talA = int.Parse(Console.ReadLine()!);

Console.WriteLine("Skriv in tal B");
int talB = int.Parse(Console.ReadLine()!);

if (talA  > 2 * talB)

{
    Console.WriteLine("För stort");
}