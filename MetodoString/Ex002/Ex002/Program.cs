namespace Ex002
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu nome completo:");
            string nome = Console.ReadLine();
            nome = nome.ToLower();

            Console.WriteLine($"Bem vindo, {nome}!");
        }
    }
}
