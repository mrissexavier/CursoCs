namespace Ex011
{
    class Program
    {
        static void Main(string[] args)
        {
            int codigo;

            Console.WriteLine("Digite o código do produto");
            codigo = int.Parse(Console.ReadLine());

            if (codigo == 1)
                Console.WriteLine("001 - Paráfuso");
            else if (codigo == 2)
                Console.WriteLine("002 - Porca");
            else if (codigo == 3)
                Console.WriteLine("003 - Prego");
            else
                Console.WriteLine("Código não definido");
        }
    }
}