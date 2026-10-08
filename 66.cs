// I en array finns ett personnummer. Skriv en funktion som kontrollerar att födelsedatum och de fyra sista siffrorna åtskiljs av ett bindestreck.
// Skriv ut ett felmeddelande om så ej är fallet.

string[] personnummer = { "19900101-1234" };

KollaBindestreck(personnummer);

void KollaBindestreck(string[] pnr)
{
    if (pnr[0][8] != '-')
        Console.WriteLine("Fel: Bindestreck saknas mellan födelsedatum och de fyra sista siffrorna.");
    else
        Console.WriteLine("Du skrev rätt");
}