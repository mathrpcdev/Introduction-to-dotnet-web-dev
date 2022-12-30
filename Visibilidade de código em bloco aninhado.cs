int soma = 0;
for (int numero = 1; numero < 21; numero++)
{
    if (numero % 3 == 0)
    {
        soma = soma + numero;
    }
}
Console.WriteLine($"A soma dos números divisíveis por 3 é: {soma}");

