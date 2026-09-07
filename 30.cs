//Läs in ett tal. Skriv ut om talet är mindre än 10, mindre än 100 eller större än 100.

Console.WriteLine("Skriv in ett tal");
if(int.TryParse(Console.ReadLine(), out int tal))
{
hittaTal (tal);
}
else
{
    Console.WriteLine("Du behöver skriva en siffra");
}


static void hittaTal (int tal)

{
if (tal < 10)
{
    Console.WriteLine($"Talet {tal} är mindre än 10");
}
else if (tal < 100)
{
    Console.WriteLine($"Talet {tal} är mindre än 100");
}
else if (tal > 100)
{ 
    Console.WriteLine($"Talet {tal} är större än 100");
}
else
    {
        Console.WriteLine($"Du har skrivit talet 100");
    }
    
    
}
