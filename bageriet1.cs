List<string> queNumber = [];

while (true)
{
    Console.WriteLine("--- Bagerikön ---");
    
    // 1. VISA KÖN FÖRST
    if (queNumber.Count == 0)
    {
        Console.WriteLine("Kön är tom just nu.");
    }
    else
    {
    int counter = 1;
    foreach (string addName in queNumber)
             
        {
            Console.WriteLine($" {counter}. {addName}");
            counter++;
        }

    }
    Console.WriteLine("Skriv in ett namn så får du ett kö nummer:");
    string input = Console.ReadLine();

if (input == "nästa")
    {
        if (queNumber.Count == 0)
        {
        Console.WriteLine("Kön är tom, inget att kalla på!");
        }
        else
        {
        string removeName = queNumber[0];
        queNumber.RemoveAt(0);
        Console.WriteLine($"Nu är det {removeName}s tur!");
        }
    }
else if (int.TryParse(input, out int number))

    {
        if (number >= 1 && number <= queNumber.Count)
        {
            string removeName1 = queNumber[number - 1];
            queNumber.RemoveAt(number -1);
            Console.WriteLine($"{removeName1} lämnade kön.");
        
        }
        else
        {
            Console.WriteLine("Det numret finns inte i kö");
        }

    }
else
    {
    queNumber.Add(input!);
    }

}