//Fruktuppgift

int numberOfDrinks = 0;

static void sugarpop()

{
    Console.WriteLine("Varsågod, här har du din sockerdricka");
}
static void fruitPunch()
{
    Console.WriteLine("Varsågod, här har du din fruktsoda");
}

while(true)

{
    Console.WriteLine("Välj dryck:");
    Console.WriteLine("1. Sockerdricka");
    Console.WriteLine("2, Fruktsoda");
    Console.WriteLine("3, Avsluta");

    int.TryParse(Console.ReadLine(), out int choice);

    bool quit = false;

    switch (choice)

{
    case 1:
    numberOfDrinks++;
    sugarpop();
    break;

    case 2:
    numberOfDrinks++;
    fruitPunch();
    break;

    case 3:
    quit = true;
    Console.WriteLine("Avslutar, tack! Du drack " + numberOfDrinks + "drycker.");
    break;

    default:
    break;
}

 if(quit)
{
    break;
}

}




