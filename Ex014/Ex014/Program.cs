namespace Ex015
{
    class Program
    {
        static void Main(string[] args)
        {
            double num, soma = 0, media;
            for (int i = 1; i <= 50; i++)
            {
                Console.WriteLine($"Insira o {i}º número");
                num = double.Parse(Console.ReadLine());

                soma += num;
            }
            media = soma / 50;

            Console.WriteLine($"A média dos numeros inseridos é: {media}");
        }
    }
}
