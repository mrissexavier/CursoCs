namespace Ex006
{
    class Program
    {
        static void Main(string[] args)
        {
            double kg, qntd, vPago;

            Console.WriteLine("Qual o preço do kg do produto");
            kg = double.Parse(Console.ReadLine());

            Console.WriteLine("Quantos kg comprou?");
            qntd = double.Parse(Console.ReadLine());

            vPago = kg * qntd;

            Console.WriteLine($"O valor a ser pago é {vPago}");
        }
    }
}
