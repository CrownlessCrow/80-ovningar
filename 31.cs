//Skriv en funktion som läser in ett antal tal och skriver ut dem. Talföljdens slut markeras med 0.


LasInTal();

static void LasInTal()

{

Console.WriteLine("Skriv in ett tal");
int tal = int.Parse(Console.ReadLine()!);

while(tal !=0)

{
    Console.WriteLine($"Du skrev tal {tal}. Skriv annat tal eller");
    

    Console.WriteLine("Skriv in tal (0) för att avsluta:");
    tal = int.Parse(Console.ReadLine()!);

}
Console.WriteLine("Programmet avslutat!");
}
