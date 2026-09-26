//46. En man erbjuds ett ovanligt riskfyllt arbete. Lönesättningen är också ovanlig. För första dagen erbjuds han 1 öre,
//  för andra dagen 2 öre, för tredje dagen 4 öre osv.



Console.WriteLine("Hur många dagar jobbar han?");
int dagar = int.Parse(Console.ReadLine()!);

long lön = 1;
long total = 0;


for (int dag = 1; dag <= dagar; dag++)


{
    total += lön;
    lön *= 2;

}
 
Console.WriteLine($"Efter {dagar} dagar har han tjänat {total / 100.0:F2} kr");