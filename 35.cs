//Skriv en funktion som beräknar och skriver ut kvadraterna för talen 1 till 9.

kvadrater ();

static void kvadrater ()

{
    for(int i = 1; i <= 9; i += 1 )

    {
        double kvadrat = Math.Pow(i, 2);
        Console.WriteLine($"{kvadrat}");
    }

}