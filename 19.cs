//En anställd som har timlön får, när arbetstiden överstiger 40 tim en vecka, 
//övertidsbetalning för tiden utöver 40 tim med 1½ tim. 
//Skriv en funktion som läser in en anställds timlön och en veckas arbetstid. 
//Den totala veckolönen ska beräknas och skrivas ut.


Console.WriteLine ("Skriv vad timlönen är");
double timlon = double.Parse(Console.ReadLine()!);

Console.WriteLine ("Skriv hur många timmar du har arbetat");
double timmar = double.Parse(Console.ReadLine()!);

if(timmar >= 40)
{
   double obtimmar = (timmar - 40);
   double oblon = (40 * timlon) + (obtimmar * timlon * 1.5);
   Console.WriteLine($"Din lön med OB blir {oblon}kr");
}
else
{
    double vanligTimLon =  (timlon * timmar);
    Console.WriteLine("Din lön utan OB blir {vanligTimLon}");
}
