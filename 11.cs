//Skriv en funktion där två tal läses in och det första talet skrivs ut om det är störst.

Console.WriteLine("Skriv in ett tal för A");
int tal1 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Skriv in ett tal för B, då den ska vara mindre");
int tal2 = int.Parse(Console.ReadLine()!);

if (tal1 > tal2)
{
    Console.WriteLine("Det första talet är störst: " + tal1);
}
