namespace ExemploArray02
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             * Podemos escrever desta forma:
             
              string[] nomes = new string[] {"Emily", "Mark", "Ana", ...};

              Assim não precisamos perguntar ao utilizador quais os elementos/nomes com o laço for:

                 for (int i = 0; i < nomes.Length; i++)
            {
                Console.WriteLine($"Insira o {i + 1}º nome");
                nomes[i] = Console.ReadLine();
            }

             */

            string[] nomes = new string[10];

            for (int i = 0; i < nomes.Length; i++)
            {
                Console.WriteLine($"Insira o {i + 1}º nome");
                nomes[i] = Console.ReadLine();
            }

            Console.Clear();
            Console.WriteLine("Qual a posição que pretende verificar?");
            int posicao = int.Parse(Console.ReadLine())-1;  // -1 para selecionar a posição sem contar o index do Array

            Console.WriteLine(nomes[posicao]);
            Console.ReadKey();  
        }
    }
}
