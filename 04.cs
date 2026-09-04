//Skriv en funktion som läser in tre tal och beräknar och skriver ut summan samt medelvärdet av de tre talen.

Console.Write("Ange tal 1: ");
int tal1 = int.Parse(Console.ReadLine()!);

Console.Write("Ange tal 2: ");
int tal2 = int.Parse(Console.ReadLine()!);

Console.Write("Ange tal 3: ");
int tal3 = int.Parse(Console.ReadLine()!);

int summa = tal1 + tal2 + tal3; 

double medel = (double)summa / 3;

Console.WriteLine($"Summa är: {summa}");
Console.WriteLine($"Summa är: {medel}");


