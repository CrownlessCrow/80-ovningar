//Skriv en funktion som läser in ett pris exkl moms och skriver ut priset inkl 25 % moms. 
//Inläsningen ska pågå tills 0 anges.






while(true)

{
Console.Clear();
Console.WriteLine("Skriv in pris eller tryck 0 för att avsluta");
int input  = int.Parse(Console.ReadLine()!);

    {
    if (input == 0)
        {
        break;
        }
    else
        {
        double inklMoms = input * 1.25;
        Console.WriteLine($"Med inklusive moms blir det {inklMoms}");
        }

    }
}