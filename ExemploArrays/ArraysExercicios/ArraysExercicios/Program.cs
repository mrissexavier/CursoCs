namespace ArrayExercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] notas = new double[3]; // <--- O número 3 define a dimensão do Array

            for (int i = 0; i < notas.Length; i++)                                                     
            {
                Console.WriteLine($"Insira a {i+1}ª nota:");
                notas[i] = double.Parse(Console.ReadLine());
            }

            /* Utilizando "notas.Length" no lugar de "3" para ter a liberdade de alterar a dimensão  do Array
                      (Exemplo:  double[] notas = new double[4];)  sem ter que alterar todo o código */

            double soma = 0;

            for (int i = 0; i < notas.Length; i++)
            {
                soma += notas[i];
            }

            Console.WriteLine($"A média é: {soma/notas.Length}");
        }
    }
}
