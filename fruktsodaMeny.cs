menu();

static void sugarPop()

{
  Console.WriteLine("Varsågod, här har du din sockerdricka");
}
 static void fruitPunch()
{
 Console.WriteLine("Varsågod, här har du din fruktsoda");   
}
static void menu()

{
    int numbersOfDrinks = 0;

    while(true)
    {
        Console.WriteLine("Välj dryck:");
        Console.WriteLine("1. Sockerdricka");
        Console.WriteLine("2. Fruktsoda");
        Console.WriteLine("3. Avsluta");

    int.TryParse(Console.ReadLine(), out int choice);

    switch (choice)

        {
        case 1:
            numbersOfDrinks++;
            sugarPop();
            break;
        
        case 2:
            numbersOfDrinks++;
            fruitPunch();
            break;

    
        case 3:
            Console.WriteLine($"Avslutar, tack! Du drack  {numbersOfDrinks} drycker.");
            return;
            break;

        default:
        break;

        }
    }

}