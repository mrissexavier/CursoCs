namespace Ex006
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
               Remove(Int32)	
                Retorna uma nova cadeia de caracteres na qual todos os caracteres na instância atual, 
                começando na posição especificada e continuando até a última posição, foram excluídos.
             */

            Console.WriteLine("Digite seu nome completo:");
            string nome = Console.ReadLine();   

            Console.Clear();

            Console.WriteLine("A partir de qual caracter deseja apagar o nome?");
            int caracterEscolhido = int.Parse(Console.ReadLine());

            nome = nome.Remove(caracterEscolhido);

            Console.WriteLine($"Bem vindo(a), {nome}!");

            Console.ReadKey();
        }
    }
}
