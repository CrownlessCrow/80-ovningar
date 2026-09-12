using System.ComponentModel;

Console.WriteLine("Välkommen till inköpslistan");


List<string> inkopslista = [];
List<int> pris = [];

while (true)


{
if (inkopslista.Count == 0)
    {
        Console.WriteLine("Inköpslistan är tom");
    }
else
    {
    int summa = 0;
    for (int i = 0; i < inkopslista.Count; i +=1)
    
        {
            Console.WriteLine($"{i + 1}. {inkopslista[i]}: {pris[i]} kr");
                summa += pris[i];
        }
                Console.WriteLine($"Totalasumma: {summa}");
    }

Console.WriteLine("Skriv in matvara eller ett nummer för att ta bort en vara");
string inputMat = Console.ReadLine();
    
if (int.TryParse(inputMat, out int remove))
    {
     if (remove >= 1 && remove <= inkopslista.Count)
        {
           Console.WriteLine($"Tar bort {inkopslista[remove - 1]} ({pris[remove - 1]})");     
           inkopslista.RemoveAt(remove - 1);
           pris.RemoveAt(remove - 1); 
        }
    else
        {
            Console.WriteLine($"Det finns ingen {remove} i listan. ");
        }
    }

else
    {
    Console.WriteLine("Skriv in pris");
    string inputPrisTransform = Console.ReadLine();
    
    if (int.TryParse(inputPrisTransform, out int inputPris))

    {
    inkopslista.Add(inputMat);
    pris.Add(inputPris);   
    }
    else
        {
            Console.WriteLine("Priset måste vara ett heltal, va vänlig försök igen");
        }
    }
}

