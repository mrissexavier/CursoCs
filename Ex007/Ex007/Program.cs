namespace Ex007
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1, n2;
            Console.WriteLine("Insira o primeiro número");
            n1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Insira o segundo número");
            n2 = double.Parse(Console.ReadLine());

            if (n1 > n2)
                Console.WriteLine($"O maior valor é: {n1}");
            else if (n1 < n2)
                Console.WriteLine($"O maior valor é: {n2}");
            else
                Console.WriteLine($"São ambos iguas: {n1}");
        }
    }
}
