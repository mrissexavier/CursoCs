using System;

namespace SwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escolha uma das seguintes opções");
            Console.WriteLine("1-Criar arquivo");
            Console.WriteLine("2-Abrir arquivo");
            Console.WriteLine("3-Salvar arquivo");
            Console.WriteLine("0-Sair");
            int op = int.Parse(Console.ReadLine());

            switch (op)
            {
                case 1:
                    Console.WriteLine("Escolheu opcção 1 - Criar arquivo");
                    break;
                case 2:
                    Console.WriteLine("Escolheu opção 2 - Abrir arquivo");
                    break;
                case 3:
                    Console.WriteLine("Escolheu opção 3 - Salvar arquivo");
                    break;
                case 0:
                    break;
                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }
        }
    }
}