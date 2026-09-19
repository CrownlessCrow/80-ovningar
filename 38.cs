//En kommun har gjort följande prognos för befolkningsutvecklingen de närmaste åren:
//Vid början av 2016 hade kommunen 26000 invånare.
//Antalet födda och avlidna under ett år uppskattas var 0.7% resp 0.6% av befolkningen vid årets början.
//Antalet inflyttade och antalet utflyttade uppskattas till 300 resp 325 varje år.
//Skriv en funktion som beräknar kommunens uppskattade invånarantal i början av ett visst år. Vilket år det gäller ska läsas in som indata till funktionen.

{
Console.WriteLine("Vilket år vill du veta befolkningen för? ");
int ar = int.Parse(Console.ReadLine()!);


double befolkning = 26000;

for (int i = 2016; i < ar; i += 1)

{

double born = befolkning * 0.007;
double death = befolkning * 0.006;

double moveIn = 300;
double moveOut = 325;

befolkning = befolkning + born - death + moveIn  - moveOut;


}
 Console.WriteLine($"{befolkning}");   
}
