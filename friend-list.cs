List<int> prices = [10, 30, 20, 75, 1];

Console.Write("Unsorted");
Console.WriteLine(string.Join(",", prices));

prices.Sort();
Console.Write("Sorted");
Console.WriteLine(string.Join(",", prices));



prices.Sort();
prices.Reverse();
Console.Write("Sorted");
Console.WriteLine(string.Join(",", prices));

List <string> pets = 