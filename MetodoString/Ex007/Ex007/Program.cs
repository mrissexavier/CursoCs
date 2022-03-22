namespace Ex007
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
               Remove(Int32, Int32)	
                Retorna uma nova cadeia de caracteres em que um número especificado de caracteres 
                na instância atual que começa na posição especificada foi excluído.
             */

            Console.WriteLine("Digite seu nome completo:");
            string nome = Console.ReadLine();

            Console.WriteLine("A partir de qual caracter deseja apagar o nome?");
            int caracterEscolhido1 = int.Parse(Console.ReadLine());

            Console.WriteLine("A partir de qual quer retomar o nome?");
            int caracterEscolhido2 = int.Parse(Console.ReadLine());

            nome = nome.Remove(caracterEscolhido1, caracterEscolhido2).Trim();

            Console.WriteLine($"Bem vindo(a), {nome}!");

            Console.ReadKey();
        }
    }
}
