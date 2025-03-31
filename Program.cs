string letra, forca;
bool exite;

Console.Write("Qual a frase secreta: ");
forca = Console.ReadLine()!;
Console.WriteLine("Escreva a Letra: ");
letra = Console.ReadLine()!;

exite = forca.Contains(letra.ToLower());

Console.Write($"A letra é {exite}");

