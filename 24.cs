//Skriv en funktion som läser in kroppstemperaturen och skriver ut ett lämpligt meddelande om temperaturen är mindre än 35 grader eller större än 42 grader.

Console.WriteLine("Skriv in din kroppstemperatur");
int temp = int.Parse(Console.ReadLine()!);

kroppsTemp (temp);

static void kroppsTemp(int temp)

{

if (temp >= 35 && temp <= 42)

{
    Console.WriteLine($"Du har vanlig kroppstemperatur");
}
else
{
    Console.WriteLine($"Du har olämplig kroppstemperatur {temp}");
}

}  