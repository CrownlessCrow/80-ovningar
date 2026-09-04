//Skriv en funktion där en cirkels radie läses in. Cirkelns diameter, omkrets och area skall beräknas och skrivas ut. (pi = 3.14).
Console.WriteLine("Vi ska räkna ut Cirkelns Diameter, Omkrets, Area");
Console.WriteLine("Skriv in radien på cirkeln");
double radie = double.Parse(Console.ReadLine()!);



double diameter = radie * 2;
double omkrets = 3.14 * diameter;
double area = 3.14 * Math.Pow(radie, 2);



Console.WriteLine($"Cirkelns diametern blir {diameter}cm");

Console.WriteLine($"Cirkelns omkrets {omkrets}cm");

Console.WriteLine($"Cirkelns area {area}cm");

