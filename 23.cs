//Skriv en funktion som testar om ett inläst tal är jämnt delbart med 3 men inte med 30. I så fall ska talet divideras med 3.

Console.WriteLine("Skriv in ett tal som är delbart med 3 och får inte dela med 30");
int tal = int.Parse(Console.ReadLine()!);


delaMed3(tal);

static void delaMed3 (int tal)
{

if (tal % 3 == 0 && tal % 30 !=0)
{
    tal = tal / 3;
    Console.WriteLine($"Det nya talet blir {tal}");
}
else
{
    Console.WriteLine($"Det går inte dela med 3 eller skriva numret (30)");
}

}