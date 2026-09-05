//Skriv en funktion som läser in två tal och dividerar det första talet med det andra talet. 
//Om det andra talet (nämnaren) är 0 ska ett felmeddelande ges, annars ska kvoten skrivas ut.

    Console.WriteLine("Skriv in tal1");
    double tal1 = int.Parse(Console.ReadLine()!);

    Console.WriteLine("Skriv in tal2");
    double tal2 = int.Parse(Console.ReadLine()!);

 
 
 divideratalen(tal1, tal2);

static void divideratalen (double tal1, double tal2)

{
    double summa = tal1 / tal2;

    Console.WriteLine($"Summan blir {summa}");
}