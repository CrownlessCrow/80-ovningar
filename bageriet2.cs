List<string> queNumber = [];

while (true)

{
    Console.WriteLine("---Bagerikön---"); 
    

if (queNumber.Count == 0)

    {
    Console.WriteLine("Bageri kön är tom");
    }
else
    {
    int counter = 1;
    foreach (string addName in queNumber)

        {
        Console.WriteLine($"{counter}. {addName}");
        counter++;   
        }
    }



Console.WriteLine("Skriv in ett (namn) så får du ett kö nummer");
string input = Console.ReadLine();

if (input == "next")

    {

    if (queNumber.Count == 0) 
        {
        Console.WriteLine("Nu är det slut på kö");
        }
    else
        {
        string removeQue = queNumber[0];
        queNumber.RemoveAt(0);
        Console.WriteLine($"Nu försvinner {removeQue} från kön");
        }
    }


else  if (int.TryParse(input, out int number))
    {
    if(number >= 1 && number <= queNumber.Count)
        {
        string removeName = queNumber[number - 1];
        queNumber.RemoveAt(number - 1);
        Console.WriteLine($"Har lämnat {removeName} kö");
        }
    else
        {
        Console.WriteLine($"Det finns ingen som har nummer {number} i kön");
        }

    }
else
    {
    queNumber.Add(input!);
    }
}