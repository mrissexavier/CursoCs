namespace Ex003
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2;
            int dif;

            Console.WriteLine("Insira o primeiro número");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira o segundo número");
            n2 = int.Parse(Console.ReadLine());

            dif = n1 - n2;

            Console.WriteLine("A diferença entre " + n1 + " e " + n2 +" é de: " + dif);
        }
        
    }
}