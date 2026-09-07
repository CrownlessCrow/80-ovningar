//Skriv en funktion som läser in en temperatur. 
// Om temperaturen är mellan 18 och 25 grader ska meddelandet “Lagom temp“ skrivas ut.
//  Om det är varmare än 25

Console.WriteLine("Skriv temperaturen");
int temp = int.Parse(Console.ReadLine()!);

kollaTemp(temp);

static void kollaTemp (int temp)

{
    if (temp <= 25 && temp >= 18)
    {
        Console.WriteLine($"temperaturen {temp} är lagom");
    }   
    else if (temp > 25)
    {
        Console.WriteLine($"Det är varmare än 25");
    }
    else if (temp < 18)
    {
        Console.WriteLine($"temperaturen är lägre än 18");
    }
}
