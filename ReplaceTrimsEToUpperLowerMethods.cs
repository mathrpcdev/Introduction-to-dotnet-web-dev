/*
O Código abaixo ensina os metodos: Replace, .ToUpper(), .ToLower(), .Trim(), .TrimStart(), .TrimEnd().
"The methods that manipulate strings return new string objects rather than making modifications in place."*
*/

string greeting = "       Hello World!      ";
Console.WriteLine($"[{greeting}]"); // A variável será impressa com todos os espaços existentes.

// Crio um novo objeto que irá receber manipulações na variável 'greeting'
string trimmedGreeting = greeting.TrimStart();
Console.WriteLine($"[{trimmedGreeting}]"); // O compilador irá ignorar os espaços antes da letra H.

trimmedGreeting = greeting.TrimEnd();
Console.WriteLine($"[{trimmedGreeting}]"); // O compilador irá apagar todos os espaços existentes após o ponto de exclamação !

trimmedGreeting = greeting.Trim();
Console.WriteLine($"[{trimmedGreeting}]"); // O compilador apaga todos os espaços.

string sayHello = "Hello World!";
Console.WriteLine(sayHello);

/*
O método .Replace recebe 2 parametros entre parênteses.
O Primeiro parâmetro passado será substituído pelo segundo parâmetro passado.
Os caracteres: H, e, l, l, o seráo substituídos por: G, r, e, e, t, i, n, g, s.
*/
sayHello = sayHello.Replace("Hello", "Greetings");
Console.WriteLine(sayHello + $"\n");

Console.WriteLine(sayHello.ToUpper());
Console.WriteLine(sayHello.ToLower());
