//funktion definition

/*static int add(int a, int b)
{
    return a + b;
}
int resultat = add(3, 4);
Console.WriteLine(resultat); */


/*
int resultat = add3and4();
Console.WriteLine(resultat);

static int add3and4()

{
    return 7;
}
*/

/*
int resultat = add5and6();
Console.WriteLine(resultat);

static int add5and6()

{
    return 11;
}
*/

/*
int resultat = add3and6();
Console.WriteLine(resultat);

static int add3and6()

{
    return 9;
}
*/

static int calc(int a, int b, string calculation)

{
if (calculation == "add")
    {
        return a + b;
    }
else if (calculation == "substract")
    {
        return a - b;
    }
else if (calculation == "multiply")
    {
        return a * b;
    }
else if (calculation == "divide")
    {
        return a / b;
    }
    return 0;
}

int svar = calc(5, 5, "substract");
Console.WriteLine(svar);