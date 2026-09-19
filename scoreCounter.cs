
List<int> Listan = [];

while(true)

{
    Console.WriteLine("Skriv in ett hel tal");
    string heltal = Console.ReadLine()!;

    if (!int.TryParse(heltal, out int number))
    
    {
        Console.WriteLine("Du skrev inte ett heltal");
        continue;
    }
        if(number == 0)
    {
            if (Listan.Count == 0)
        {
            Console.WriteLine("Det finns inget mer att ta bort");
            continue;
        }
            else
        {
            Listan.RemoveAt(Listan.Count - 1);
            Console.WriteLine("Den senaste inmatningen har tagits bort");

            if (Listan.Count == 0)
            {
                Console.WriteLine("Listan är tom");
                continue;
            }

        }
    }

    else
    {
        Listan.Add(number);  
    }

    int sum = Listan.Sum();
    int max = Listan.Max();

    string uttryck = string.Join( " + ", Listan);


    Console.WriteLine($" {uttryck} = {sum}");
    Console.WriteLine($" Total summan är {Listan.Count}");
     Console.WriteLine($" Hösta talet är {max}");


}