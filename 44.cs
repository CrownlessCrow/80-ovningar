//44. Skriv en funktion som låter användaren bestämma hur många tal han vill summera. Läs in detta antal tal och summera dem Skriv ut summan.


Console.WriteLine("Hur många tal vill du summera?");
int antal = int.Parse(Console.ReadLine()!);


int summa = 0;

for (int i = 1; i <= antal; i++ )

{
    Console.Write($" Ange tal {i}: ");
    summa += int.Parse(Console.ReadLine()!);
}

Console.WriteLine($"Summa är {summa}");