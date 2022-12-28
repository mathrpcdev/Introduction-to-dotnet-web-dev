decimal minimo = decimal.MinValue;
decimal maximo = decimal.MinValue;
double min = double.MinValue;
double max = double.MaxValue;

// O tipo deciaml tem um range menor, porém tem uma precisão maior que o double.
Console.WriteLine($"O alcance do tipo decimal vai de: {minimo} até {maximo}");
Console.WriteLine($"O alcance de tipo double é de: {min} até {max}");

double a = 1.0;
double b = 3.0;
double resultDouble = a / b; // double = alcance e/ou armazenamento maior.
Console.WriteLine($"The range result of 'a / b' of double type is: {resultDouble}");

// O Alcance (range) do tupo double é menor que do tipo decimal.

decimal c = 1.0m;
decimal d = 3.0m;
decimal resultDecimal = c / d; // decimal = Precisão maior.
Console.WriteLine($"The range result of decimal types of 'c / d' is: {resultDecimal}");
