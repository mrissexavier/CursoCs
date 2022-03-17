namespace Ex012
{
    class Program
    {
        static void Main(string[] args)
        {
            int codigo;
            Console.WriteLine("Insira o código do produto");
            codigo = int.Parse(Console.ReadLine());

            switch (codigo)
            {
                case 1: Console.WriteLine("001 - Parafuso");      break;
                case 2: Console.WriteLine("002 - Martelo");       break;
                case 3: Console.WriteLine("003 - Prego");         break;
                default: Console.WriteLine("Códio não definido"); break;
            }
        }
    }
}
