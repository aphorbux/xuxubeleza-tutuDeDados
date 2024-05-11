List<int> notas = [5, 6, 3, 8, 5, 3, 4, 5, 7, 5, 3, 10, 2, 8, 2, 5, 8, 8, 9, 4];
int maiores  = 0, menores = 0;
Console.WriteLine("NOTAS:  \n");
foreach (var nota in notas)
{
    if (nota >= 6)
    {
        Console.WriteLine("> Maior: " + nota);
        maiores++;
    }

    else
    {
        Console.WriteLine("< Menor: " + nota);
        menores++;
    }
}
Console.WriteLine("\nMAIORES: {0}\nMENORES: {1}",maiores, menores);
