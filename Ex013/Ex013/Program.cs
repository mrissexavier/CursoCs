namespace Ex013
{
    class Program
    {
        static void Main(string[] args)
        {
            double num, soma=0, media, i = 1;
            while (i <= 50)
            {
                Console.WriteLine($"Insira {i}º número");
                num = double.Parse(Console.ReadLine());

                soma += num;
                i++;
            }
            media = soma / 50;

            Console.WriteLine($"A média dos números é {media}");

        }
    }
}