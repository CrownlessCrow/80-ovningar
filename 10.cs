//Sambandet mellan Fahrenheit och Celsius grader ges av formeln F=9C / 5 + 32.
//Konstruera en funktion där en temperatur i Fahrenheit läses in och motsvarande temperatur i Celsius skrivs ut.

Console.WriteLine("Skriv in Fahrenheit för att räkna ut Celsious");
double fahrenheit = double.Parse(Console.ReadLine()!);

double celsious = (fahrenheit - 32) * 5/9;

Console.WriteLine($"Då blir det {celsious} celsious");