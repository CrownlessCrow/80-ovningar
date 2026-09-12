//Skriv en funktion som läser in ett pris exkl moms. 
// och skriver ut priset inkl 25 % moms.
//  Inläsningen ska pågå tills 0 anges.



while (true)
{

Console.WriteLine("Skriv in ett pris exkl moms, 0 för att avsluta");
string prisText = Console.ReadLine()!;

if(int.TryParse(prisText, out int exklMoms))

{
    if (exklMoms == 0)

    {
        break;
    }
        else; 
    {
    
    double inklMoms = exklMoms * 1.25;
    Console.WriteLine($"Pris inkl moms: {inklMoms}kr");
    }
}
else
{
    Console.WriteLine("Ogiltigt  pris, du måste skriva siffra");

}
}