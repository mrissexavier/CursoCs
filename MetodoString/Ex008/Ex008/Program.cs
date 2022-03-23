namespace Ex008
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Split(Char[])	
             * Divide uma cadeia de caracteres em substrings baseadas nos caracteres delimitadores especificados.
             */

            Console.WriteLine("Digite seu nome");
            string nome = Console.ReadLine();

            string[] nomes = nome.Split(" ");

            for (int i = 0; i < nomes.Length; i++)
            {
                Console.WriteLine(nomes[i]);
            }

        }
    }
}
