//Skriv en funktion som testar om ett tal är 0-9 men inte 5. Skriv ut lämplig text.

Console.WriteLine("Skriv ett tal mellan 0 - 9, men du får inte skriva 5");
int tal = int.Parse(Console.ReadLine()!);


inteTal5 (tal);

static void inteTal5(int tal)
{

if(0 <= tal && 10 >= tal && tal != 5)

{
    Console.WriteLine($" Du har skrivit tal {tal}");
}
else
{
    Console.WriteLine($" Du får inte skriva tal 5");
}

}