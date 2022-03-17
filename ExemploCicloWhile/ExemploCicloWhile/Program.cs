using System;

namespace ExemploCicloWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 1, soma = 0;
            while (num!=0)
            {
                Console.WriteLine("Insira um numero para somar! Insira 0 para parar");
                num = int.Parse(Console.ReadLine());

                soma += num;
            }

            Console.WriteLine("A soma de todos numeroinsrtidos é: " + soma);
            
        }
    }
}