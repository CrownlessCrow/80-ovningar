//Om den näst sista siffran är jämn i personnumret är det en kvinna, om den är ojämn är det en man. 
// Avgör om personen i föregående uppgift är man eller kvinna.ut

string[] personnummer = { "19910101-1274" };

KollaKon(personnummer);

void KollaKon(string[] pnr)

{
    int siffra = int.Parse(pnr[0][11].ToString());

    if (siffra % 2 == 0)

    {
        Console.WriteLine("Personen är en kvinna");
    }

    else

    {
        Console.WriteLine("Personen är en man");
    }

}