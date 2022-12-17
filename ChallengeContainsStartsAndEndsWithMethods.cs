/*
.StartsWith(), .EndsWith() e .Contains() são Case-sensitive.
 */

string songLyrics = "You say goodbye, and I say Hello";

Console.WriteLine(songLyrics.Contains("say")); // Existe e retornará 'True'.
Console.WriteLine(songLyrics.Contains("greetings")); // Não contém, logo irá retornar 'False'.

bool containsTrue = songLyrics.StartsWith("You"); // Verifica se inicia com a string "You".
Console.WriteLine(containsTrue); // Outputs 'True'

bool containsFalse = songLyrics.EndsWith("goodbye"); // Verifica se termina com a palavra "goodbye"
Console.WriteLine(containsFalse); // Outputs 'False'

// -- Microsoft.NET Learn solution

string somDaMusica = "Você diz adeus, e eu digo olá";
Console.WriteLine(); // Essa linhA eu que criei.
Console.WriteLine(somDaMusica.StartsWith("Você"));
Console.WriteLine(somDaMusica.StartsWith("adeus"));
Console.WriteLine(); // Essa linhA eu que criei.
Console.WriteLine(somDaMusica.EndsWith("olá"));
Console.WriteLine(somDaMusica.EndsWith("adeus"));
