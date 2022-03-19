namespace ExemploArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome = "Emily";
            string nome2 = "Ana";
            string nome3 = "Maik";

            int idade = 19;
            int idade1 = 25;
            int idade2 = 22;

            Console.WriteLine($"Nome 1: {nome}; Idade: {idade}");
            Console.WriteLine($"Nome 2: {nome2}; Idade: {idade1}");
            Console.WriteLine($"Nome 3: {nome3}; Idade: {idade2}");

            Console.WriteLine("=====================================================");

            // Utilizando Array podemos simplificar:
            string[] nomes = new string[] { "Emily", "Ana", "Maik" };

            // Para indiciar os elementos do Array manualmente
            int[] idades = new int[3];
            idades[0] = 19;
            idades[1] = 25;
            idades[2] = 22;

            for (int i = 0; i <  nomes.Length; i++) // Length sempre será a dimensão do Array e não a quantidade de elementos
            {
                Console.WriteLine($"Nome {i+1}: {nomes[i]}; Idade: {idades[i]}");
            }

            Console.WriteLine("=====================================================================================");

            // Utilizando numeros no Array

            Random rnd = new Random();
            
            int[] numeros = new int[10];

            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = rnd.Next(1, 100);
                Console.Write(numeros[i] + "\t");
            }


            // Outras aplicações com Array

            double[] decimais = new double[30];
            bool[] trueOrFalse = new bool[30];

            Console.WriteLine();
            Console.WriteLine("=====================================================================================");

            int[,] tabuada = new int[10,10]; // i = colunas j = linhas da tabela

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    tabuada[i, j] = (i + 1) * (j + 1);
                    Console.Write(tabuada[i, j] + "\t");
                }
                Console.WriteLine( );
            }


        }
    }
}
