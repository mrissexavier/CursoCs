namespace ExercicioArray05
{
    class Program
    {
        static int[] numeros;
        static Random rnd;

        static void Main(string[] args)
        {
            numeros = new int[10];
            rnd = new Random();

            // Preenchendo o Array com numeros aleatórios 
            Preencher();

            // Sem ordenação
            Console.WriteLine(" =================== Ordem Inicial ===================== ");
            Imprimir();

            // Ordenação crescente
            Console.WriteLine(" =================== Ordem Crescente ===================== ");
                                         // Utilizando Bubble Sort para ordenar
            Crescente();
            Imprimir();

            //Ordenação decrescente
            Console.WriteLine(" =================== Ordem Decrescente ===================== ");
            Decrescente();
            Imprimir();
        }

        private static void Preencher()
        {
            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = rnd.Next(1, 100);
            }
        }

        private static void Decrescente()
        {
            for (int i = 0; i < numeros.Length - 1; i++)
            {
                for (int j = i + 1; j < numeros.Length; j++)
                {
                    if (numeros[i] < numeros[j])
                    {
                        int auxiliar = numeros[i];
                        numeros[i] = numeros[j];
                        numeros[j] = auxiliar;
                    }
                }
            }
        }

        private static void Crescente()
        {

            for (int i = 0;  i  < numeros.Length - 1;  i++)
            {
                for (int j = i + 1;  j < numeros.Length;  j++)
                {
                    if (numeros[i] > numeros[j])
                    {
                        int auxiliar = numeros[i];
                        numeros[i] = numeros[j];
                        numeros[j] = auxiliar;
                    }
                }
            }
        }

        private static void Imprimir()
        {
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine($"Posição: {i}\tValor: {numeros[i]}");
            }
            Console.WriteLine();
        }
    }
}
