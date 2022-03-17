namespace Ex004
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y, a;

            Console.WriteLine("Qual o valor da base?");
            x = double.Parse(Console.ReadLine());

            Console.WriteLine("Qual o valor da altura?");
            y = double.Parse(Console.ReadLine());

            a = x * y / 2;

            Console.WriteLine("A área do triangulo é: " + a);
        }
    }
}
