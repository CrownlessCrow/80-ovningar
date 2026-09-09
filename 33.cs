//Skriv ut talen 100 till 0, dvs 100, 99, 98, …, 0.

countdown();

static void countdown()

    {
        for(int index = 100; index > 0; index-=2)
    {
        Console.WriteLine(index);
    }
    }
