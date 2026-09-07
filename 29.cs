//Skriv en funktion som beräknar ankomsttiden för ett tåg. I inmatningsrutan finns följande:
//tidpunkt i timma och minut för avgången (t ex 12 41) körtid i timma och minut (t ex 3 47)

Console.WriteLine("Skriv avgångstimme");
int avgangstimme = int.Parse(Console.ReadLine()!);

Console.WriteLine("Skriv avgångminut");
int avgangsminut = int.Parse(Console.ReadLine()!);

Console.WriteLine("Skriv körtids timme");
int  kortidstimme = int.Parse(Console.ReadLine()!);

Console.WriteLine("Skriv körtids minut");
int kortidsminut = int.Parse(Console.ReadLine()!);

int timResultat = (avgangstimme + kortidstimme);

int minResultat = (avgangsminut + kortidsminut);

while (minResultat >= 60)

{
    timResultat = timResultat + 1;
    minResultat = minResultat - 60;
}

    Console.WriteLine($" Tåget är framme {timResultat}:{minResultat:D2}");

