//Skriv en funktion som läser in och skriver ut ett tecken i taget tills en * skrivs in.

readCharacter();

static void readCharacter()



{
    Console.WriteLine("Skriv tecken förutom (*)");
    char character =  ';';
    while (character != '*')

    {
        string input = Console.ReadLine();
        character = input[0];
        Console.WriteLine($"{character}");
    }

}
