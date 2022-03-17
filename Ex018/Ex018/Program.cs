double num, soma = 0, media, contador = 0, op = 1;

while (op != 0)
{
    Console.WriteLine("Insira um numero");
    num = double.Parse(Console.ReadLine());

    if (num > 4)
        soma += num;
        contador++;

    Console.WriteLine("Pretende inderir um novo numero?");
    Console.WriteLine("1-Sim");
    Console.WriteLine("0-Não");
    op = double.Parse(Console.ReadLine());
}

media = soma / contador;
if (contador > 0)
    Console.WriteLine($"A média é: {media}");
else
    Console.WriteLine("Não foram inseridos valores maiores que 4");


