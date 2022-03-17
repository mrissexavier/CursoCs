namespace Ex008
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, n3, n4;
            Console.WriteLine("Insira o 1º número");
            n1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Insira o 2º número");
            n2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Insira o 3º número");
            n3 = double.Parse(Console.ReadLine());

            Console.WriteLine("Insira o 4º número");
            n4 = double.Parse(Console.ReadLine());

            if (n1 < n2 && n1 < n3 && n1 < n4)
                Console.WriteLine($"O menor é o {n1}");
            else if(n2 < n1 && n2 < n3 && n2 < n4)
                Console.WriteLine($"O menor é o {n2}");
            else if(n3 < n1 && n3 < n2 && n3 < n4)
                Console.WriteLine($"O menor é o {n3}");
            else
                Console.WriteLine($"O menor é o {n4}");
        }
    }
}