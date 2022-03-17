using System;

namespace LacoFor
{
    class Program
    {
        static void Main(string[] args)
        {
            int soma=0;
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Insira um numero");
                int num = int.Parse(Console.ReadLine());
                soma += num;
            }
            Console.WriteLine("A soma dos valores inseridos é: " +soma);
        }
    }
}
