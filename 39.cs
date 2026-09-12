//Konstruera en funktion som beräknar och skriver ut svaret för funktionen:
//f(x) = 3x³ - 5x² + 2x - 20
//Funktionen ska skriva ut alla värden när x är ett heltal mellan -10 och 10. Dvs x antar värdet -10 och ökar med ett till värdet blir 10.




for(int i = -10; i <= 10; i += 1)

    {
double summa = Math.Pow(i, 3) - Math.Pow(i, i) + (2 * i) - 20;

Console.WriteLine($"f({i}) = {summa}");




    }
   
   
   
   
   