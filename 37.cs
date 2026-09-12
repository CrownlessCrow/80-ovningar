//Skriv en funktion som läser in hur många tal användaren vill ange. funktionen ska sedan läsa in detta antal tal och skriva ut dem.


Console.WriteLine(" Hur många tal vill du ange");
string antalText = Console.ReadLine()!;

int antal = int.Parse(antalText);


List<int> tal = [];

for (int i = 0; i <antal; i++)

{
   Console.WriteLine($"Ange tal {i + 1}");
   string talText = Console.ReadLine()!;
   
   int nyttTal = int.Parse(talText);
   tal.Add(nyttTal);

}

Console.WriteLine("Du angav dessa tal: ");


for (int i = 0; i <tal.Count; i++)

{
    Console.WriteLine(tal[i]);
}




