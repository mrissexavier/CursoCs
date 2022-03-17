using System;

namespace Ex002
{
    class Program
    {
        static void Main(string[] args)
        {
            int soma=0;
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Insira um numero");
                int num = int.Parse(Console.ReadLine());
                soma += num;
            }
            Console.WriteLine("A soma dos números digitados é: " +soma);
        }

    }
}
