//Skriv en funktion som räknar ut hur mycket man har på banken under vart och ett av de följande 10 åren om man sätter in 1000 kr. 
// Räntan ska läsas in och är densamma för alla åren.

bankRantan();

static void bankRantan()

{
Console.WriteLine("Skriv in räntan");
double rantan = double.Parse(Console.ReadLine()!);

double saldo = 1000;



for(int year = 1; year <= 10; year += 1)

    {
        /*double summa = saldo * (rantan/100);

        saldo = saldo + summa;*/

        saldo = saldo + (saldo * (rantan/100));



        Console.WriteLine($"Då har du sparat {saldo} på {year} år ");

    }
}

