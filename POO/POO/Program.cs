namespace POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa1 = new Pessoa();
            Pessoa pessoa2 = new Pessoa("Mark", "São Paulo", 22, "mark.dev@gmail.com");

            Console.WriteLine(pessoa1.ToString());
            Console.WriteLine("============================");
            Console.WriteLine(pessoa2.ToString());
        }
    }
}
