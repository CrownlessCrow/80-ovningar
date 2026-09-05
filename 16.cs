//En firma erbjuder sina kunder 10 procents rabatt om man vid ett inköpstillfälle handlar för minst 1000 kr. 
// Antag för enkelhetens skull att man bara handlar varor av ett visst slag.
//  Skriv en funktion som beräknar vad en kund ska betala. 
// Indata till funktionen ska vara antalet köpta enheter och priset per enhet.

Console.WriteLine("Skriv hur mycket du har betalat för din produkt");
int pris = int.Parse(Console.ReadLine()!);


Console.WriteLine("Skriv hur många antal du köpte av produkten");
int antal = int.Parse(Console.ReadLine()!);

int totalPris = pris * antal;

if(totalPris >= 1000)

{
    double prisMedRabatt = totalPris * 0.9;
    Console.WriteLine($"Totala summan med avdragen rabatt blir {prisMedRabatt}kr");
}
else
{
    Console.WriteLine($"Du ska bara för {totalPris}kr");
}
