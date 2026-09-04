//Skriv en funktion som läser in två tal och avgör och skriver ut om det första talet är jämnt delbart med det andra talet.




{

Console.WriteLine("Skriv in tal 1");
int tal1 = int.Parse(Console.ReadLine());

Console.WriteLine("Skriv in tal 2");
int tal2 = int.Parse(Console.ReadLine());

KontrolleraDelbarhet(tal1, tal2);
}
static void KontrolleraDelbarhet(int tal1, int tal2)

{
    if(tal1 % tal2 == 0)

    {
        Console.WriteLine("Det första talet är jämnt delbart med det andra!");
    
    }
    else
    {
        Console.WriteLine("Det är inte jämnt delbart.");
    }
}
