Console.Clear();

string fala;

string falaErrada;

Console.Write("Digite uma frase: ");
fala = Console.ReadLine()!.ToLower();

falaErrada = fala.Replace("r", "l");

Console.WriteLine($"\nfrase original: {fala}");

Console.WriteLine($"\nfrase do cebolinha: {falaErrada}");