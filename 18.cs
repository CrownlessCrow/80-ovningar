//Konstruera en funktion där värden på variablerna X och Y läses in. 
// Tilldela variabel A värdet 2 om X är större än 5 + Y, annars tilldela A värdet 5. Skriv ut variabeln A.

Console.WriteLine("Skriv in X värde");
int talx = int.Parse(Console.ReadLine()!);

Console.WriteLine("Skriv in Y värde");
int taly = int.Parse(Console.ReadLine()!);


formula (talx,taly);
static void formula (double talx, double taly)

{
   if(talx >= 5 + taly)
    {
        double a = 2;
        Console.WriteLine($" A är {a}");
    }
    else
    {
        double a = 5;
        Console.WriteLine($" A är {a}");
    }
}
