//42. Skriv en funktion som läser in och adderar tjugo heltal. Summan ska skrivas ut.

List<int> tal = [];

while (tal.Count < 20)

{
    Console.Write($"Tal {tal.Count + 1} av 20: ");

    if (int.TryParse(Console.ReadLine()!, out int number))

    {
        tal.Add(number);
    }
    else
    {
        Console.WriteLine("Inte ett heltal, försök igen");
    }

Console.WriteLine($"{string.Join(" + ", tal)} = {tal.Sum()}");
}
