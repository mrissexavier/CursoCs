namespace Menus
{
    class Program
    {
        static void Main(string[] args)
        {
            int op = 1;
            while (op != 0)
            {

                Console.Clear();
                Console.WriteLine("Bem vindo! Escolha uma das seguintes opções:");
                Console.WriteLine("1-Somar");
                Console.WriteLine("2-Subtrair");
                Console.WriteLine("3-Multiplicação");
                Console.WriteLine("4-Divisão");
                Console.WriteLine("0-Sair");
                op = int.Parse(Console.ReadLine());

                if (op == 0)
                {
                    break;
                }
                else if (op == 1)
                {
                    Soma();
                }

                else if (op == 2)
                {
                    Subtracao();
                }
                else if(op == 3)
                {
                    Multiplicacao();
                }
                else if(op == 4)
                {
                    Divisao();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Opção inválida");
                    Console.ReadKey();
                }

            }
        }

        private static void Divisao()
        {
            Console.Clear();
            Console.WriteLine("Insira o primeiro número");
            double num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Insira o segundo número");
            double num2 = double.Parse(Console.ReadLine());

            double div = num1 / num2;

            Console.WriteLine($"A divisão de {num1} por {num2} é: {div}");
            Console.ReadKey();
        }

        private static void Multiplicacao()
        {
            Console.Clear();
            Console.WriteLine("Insira o primeiro número");
            double num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Insira o segundo número");
            double num2 = double.Parse(Console.ReadLine());

            double mult = num1 * num2;

            Console.WriteLine($"A multiplicação de {num1} x {num2} é: {mult}");
            Console.ReadKey();
        }

        private static void Subtracao()
        {
            Console.Clear();
            Console.WriteLine("Insira o primeiro número");
            double num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Insira o segundo número");
            double num2 = double.Parse(Console.ReadLine());

            double sub = num1 - num2;

            Console.WriteLine($"A subtração de {num1} menos {num2} é: {sub}");
            Console.ReadKey();
        }

        private static void Soma()
        {
            Console.Clear();
            Console.WriteLine("Insira o primeiro número");
            double num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Insira o segundo número");
            double num2 = double.Parse(Console.ReadLine());

            double soma = num1 + num2;

            Console.WriteLine($"A soma de {num1} mais {num2} é: {soma}");
            Console.ReadKey();
        }
    }
}
