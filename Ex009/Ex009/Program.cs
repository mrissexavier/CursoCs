namespace Ex009
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Insira um número");
            num = int.Parse(Console.ReadLine());

            if (num % 2 == 0)
                Console.WriteLine($"O numero {num} é par");
            else
                Console.WriteLine($"O numero {num} é impár");
        }
    }
}
