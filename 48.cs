// 48. Skriv en funktion som skriver ut n! (fakulteten). n ska läsas in. Ex:
// 3! = 1 * 2 * 3
// 5! = 1 * 2 * 3 * 4 * 5

Console.WriteLine("Skriv in ett tal");       // Be användaren skriva ett tal
int n = int.Parse(Console.ReadLine()!);      // Läs in texten, gör om till tal, spara i n

SkrivUtFakultet(n);                          // Kör funktionen med talet n

static void SkrivUtFakultet(int n)           // Funktionen tar emot talet n
{
    long produkt = 1;                        // Svaret börjar på 1
    List<int> tal = new List<int>();         // Lista som ska hålla 1, 2, 3 ... n

    for (int i = 1; i <= n; i++)             // Räkna i = 1, 2, 3 ... upp till n
    {
        tal.Add(i);                          // Lägg till talet i listan
        produkt *= i;                        // Gångra svaret med i
    }

    string text = string.Join(" * ", tal);   // Gör om listan till "1 * 2 * 3 ..."

    Console.WriteLine($"{n}! = {text} = {produkt}");   // T.ex. "5! = 1 * 2 * 3 * 4 * 5 = 120"
}