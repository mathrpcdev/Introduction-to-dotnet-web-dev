/*
Quando o loop chegar até o número 10 e ao numero 85, ele irá parar a iteração.
O número que irá aparecer é um número abaixo do valor que estava sendo verificado -- verificado pelo while e for -- ou seja, 9 e 84.
 */

int counter1 = 0;
while (counter1 < 10) // Se o valor é 10, ele para e irá mostrar até onde a iteração chegou.
{
    Console.WriteLine($"Hello World! The counter is: {counter1}");
    counter1++;
}
Console.WriteLine();


int contagem1 = 0;
do // Aqui primeiro executa e depois verifica a expeção boleana while.
{
    Console.WriteLine($"Olá, mundo! A contagem atual é: {contagem1}");
    contagem1++;
} while (contagem1 < 10);



Console.WriteLine();


for (int counter2 = 5; counter2 < 85; counter2++)
{
    Console.WriteLine($"Olá! A contagem está em: {counter2}"); // Mostra até o número 84.
}
Console.WriteLine();
for (int contagem2 = 4; contagem2 < 85; contagem2++) // Mostra até o número 84.
{
    Console.WriteLine($"Numero: {contagem2}");
}
