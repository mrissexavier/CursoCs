namespace ExercicioArray03
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[10];

            for (int i = 0; i < numeros.Length; i++)
            {
                Random rnd = new Random();

                numeros[i] = rnd.Next(1,10);
            }
            Console.WriteLine("Ordem de inserção: ");
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine($"Posição: {i} \tValor: {numeros[i]}");
            }
            Console.WriteLine("=============================================== \n");

            Console.WriteLine("Ordem inversa: ");
            for (int i = numeros.Length-1; i >= 0; i--)
            {
                Console.WriteLine($"Posição: {i} \tValor: {numeros[i]}");
            }
        }
    }
}
