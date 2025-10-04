double NR1, n2, n3, media;
Console.WriteLine("Média Aritmética de 3 números");

Console.Write("Digite o primeiro número: ");
NR1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Digite o segundo número: ");
n2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Digite o terceiro número: ");
n3 = Convert.ToDouble(Console.ReadLine());
media = (NR1 + n2 + n3) / 3;
Console.Write("media: ");
Console.Write($"{media:N1}");