using System;

namespace ExemploCicloFor
{
    class Program
    {
        static void Main(string[] args)
        {
            int soma;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Insira um número");
                int num = int.Parse(Console.ReadLine());
                soma += num;
            }
            Console.WriteLine("A soma de todos os valores inseridos é: " +soma);
        }
    }
}
