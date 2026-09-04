//Skriv en funktion som beräknar och skriver ut arean och omkretsen av en rektangel. Rektangelns sidor ska läsas in.
//Omkrets Bredd + Höjd
Console.Write("Skriv rektangelns bredd: ");
int bredd = int.Parse(Console.ReadLine()!);

Console.Write("Skriv rektangelns höjd: ");
int höjd = int.Parse(Console.ReadLine()!);

int omkrets = (bredd + höjd) * 2;
int area = bredd * höjd;

Console.WriteLine($"Omkretsen på rektangeln är {omkrets}cm.");
Console.WriteLine($"Arean på rektangeln är {area}cm.");