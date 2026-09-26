//47. Beräkna och skriv ut produkten av de ojämna heltalen från 1 till 15. (D v s 135…15)

int produkt = 1;

for (int i = 1; i <= 15; i += 2)

{
    produkt *= i;

}

Console.WriteLine($"Produkten av de udda talen 1-15: {produkt}");