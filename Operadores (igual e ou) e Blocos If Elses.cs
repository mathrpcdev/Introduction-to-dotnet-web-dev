int a = 5;
int b = 3;
if (a + b > 10)
{
    Console.WriteLine("O a resposta é maior que 10.");
}
else
{
    Console.WriteLine("The answer is smaller than 10.");
}

int c = 5;
int d = 3;
int e = 4;

if ((c + d + e > 10) && (c == d)) // False
{
    Console.WriteLine("The answer is grater than 10."); // True
    Console.WriteLine("And the first number is equal to the second"); // False
}
else // True
{
    Console.WriteLine("The answer is not greater than 10."); // False
    Console.WriteLine("Or the first number is not equal to the second."); // True
}

int f = 5;
int g = 3;
int h = 4;

if ((f + g + h > 10) || (f == g)) // True
{
    Console.WriteLine("A resposta é maior que 10."); // True
    Console.WriteLine("Ou o primeiro número é IGUAL o segundo."); // False
}
else
{
    Console.WriteLine("A resposta não é maior que 10."); // False
    Console.WriteLine("E o primeiro número NÃO é igual ao segundo."); // True
}
