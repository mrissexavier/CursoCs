namespace Ex010
{
    class Program
    {
        static void Main(string[] args)
        {
            int l1, l2, l3;

            Console.WriteLine("Qual o valor do lado 1?");
            l1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual o valor do lado 2?");
            l2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual o valor do lado 3?");
            l3 = int.Parse(Console.ReadLine());

            if (l1 == 0 || l2 == 0 || l3 == 0)
            {
                Console.WriteLine("O triangulo é impossível, pois um dos lados é igual a zero.");
            }
            else if (l1 > l2 + l3 || l2 > l1 + l3 || l3 > l1 + l2)
            {
                Console.WriteLine("O triangulo é impossível, pois um dos lados é maior que a soma dos outros dois.");
            }
            else
            {
                if (l1 == l2 && l1 == l3)
                {
                    Console.WriteLine("Triangulo Equilátero!");
                }
                else if (l1 != l2 && l1 != l3 && l2 != l3)
                {
                    Console.WriteLine("Triangulo Esacaleno!");
                }
                else if((l1== l2 && l1 != l3) || (l1 != l3 && l1 != l2) || (l2 == l3 && l2!= l1))
                {
                    Console.WriteLine("Triangulo Isósceles");
                }
            }
        }
    }
}
