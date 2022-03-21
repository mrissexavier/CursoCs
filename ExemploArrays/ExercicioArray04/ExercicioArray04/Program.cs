namespace ExercicioArray04
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            double[] numeros = new double[50];
            double soma = 0, media;

            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = rnd.Next(1, 100);
                soma += numeros[i];
            }

            media = soma / numeros.Length;
            Console.WriteLine($"A média é: {media}");

            for (int i = 0; i < numeros.Length; i++)
            {
                if(numeros[i] < media)
                    Console.WriteLine($"Posição: {i}\tValor: {numeros[i]}");
            }
        }
    }
}
