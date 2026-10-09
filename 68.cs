//En array med 50 inlästa tal finns. Fördubbla värdet på talen på varje plats i arrayen.

int[] tal = new int[50]; // Skapar en array som heter tal med 50 platser (index 0–49)

// Fyll arrayen med slumptal
Random rnd = new Random(); // Skapar en slumpgenerator som heter rnd
for (int i = 0; i < tal.Length; i++) // Går igenom alla lådor från 0 till 49, i ökar med 1 varje varv
{
    tal[i] = rnd.Next(1, 101); // Slumpar ett tal mellan 1 och 100 och lägger det i låda i
}

// Fördubbla varje tal
for (int i = 0; i < tal.Length; i++) // Går igenom alla lådor igen, nu innehåller de slumptal
{
    tal[i] = tal[i] * 2; // Tar talet i lådan, gångar med 2 och lägger tillbaka det i samma låda
}

// Skriv ut resultatet
for (int i = 0; i < tal.Length; i++) // Går igenom alla lådor en sista gång, nu med fördubblade tal
{
    Console.WriteLine(tal[i]); // Skriver ut talet i låda i
}