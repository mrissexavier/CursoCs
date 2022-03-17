double num, soma = 0, media;

for (int i = 1; i <= 5; i++)
{
    Console.WriteLine($"Insira o {i}º valor");
    num = double.Parse(Console.ReadLine());

    soma += num;
}

media = soma / 5;
Console.WriteLine($"A média é: {media}");
