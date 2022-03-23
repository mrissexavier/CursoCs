using System;

    namespace Condicoes
{
    class Program
    {
        static void Main(string [] args)
        {
            Console.WriteLine("Insira a sua idade");
            int idade = int.Parse(Console.ReadLine());

            if(idade < 2)
            {
                Console.WriteLine("É um bebê");
            }
            else if(idade < 10)
            {
                Console.WriteLine("É uma criança");

            }
            else if(idade < 18)
            {
                Console.WriteLine("É um adolescente");
            } 
            else if(idade < 60)
            {
                    Console.WriteLine("É um adulto");
            }
            else
            {
                Console.WriteLine("É um adulto");
            }
        }
    }
} 
