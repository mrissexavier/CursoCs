double num, soma = 0, media;

for (int i = 1; i <= 5; i++)
{
    Console.WriteLine($"Insira o {i}º valor");
    num = double.Parse(Console.ReadLine());

    soma += num;
}

media = soma / 5;

if (media > 8)
    Console.WriteLine($"A média final é: 10");
else
    Console.WriteLine($"A média final é: {media}");