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

            Console.WriteLine("================ Ordem Crescente ================");
            for (int i = 0; i < nomes.Length; i++)
            {
                Console.WriteLine(nomes[i]);
            }

            Console.WriteLine("================ Ordem Decrescente ================");
            /* for (int i = nomes.Length-1; i >= 0; i--)
            {
                Console.WriteLine(nomes[i]);
            } */

            Array.Reverse(nomes);
            for (int i = 0; i < nomes.Length; i++)
            {
                Console.WriteLine(nomes[i]);
            }

            Console.WriteLine("================ Ordem Alfabetica crescente ================");
            Array.Sort(nomes);
            for (int i = 0; i < nomes.Length; i++)
            {
                Console.WriteLine(nomes[i]);
            }

            Console.WriteLine("================ Ordem Alfabetica decrescente ================");
            Array.Reverse(nomes);
            for (int i = 0; i < nomes.Length; i++)
            {
                Console.WriteLine(nomes[i]);
            }

        }
    }
}
