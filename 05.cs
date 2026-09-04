//Läs in ett heltal motsvarande svenska kronor och skriv ut motsvarande värde i pund respektive dollar. 
//Antag att kursen är : 1 dollar = 6 kr, 1 pund = 10 kr.

Console.WriteLine("Ange belopp i svenska kronor");
int tal1 = int.Parse(Console.ReadLine()!);




double Dollar = tal1 * (1.0 / 6.0);

double Pund = tal1 * (1.0 / 10.0);


Console.WriteLine($"Dollar är {Dollar}!");

Console.WriteLine($"Pund är {Pund}!");
