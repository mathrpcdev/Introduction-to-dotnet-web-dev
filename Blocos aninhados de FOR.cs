for (int row = 1; row < 11; row++)
{
    Console.WriteLine($"The row is: {row}");
}

for (char column = 'a'; column < 'k'; column++)
{
    Console.WriteLine($"The column is: {column}");
}

for (int fileira = 1; fileira < 11; fileira++)
{
    for (char coluna = 'a'; coluna < 'k'; coluna++)
    {
        Console.WriteLine($"The cell(pilha?) is: ({fileira}, {coluna})");
    }
}
