namespace Ex003
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
             * Replace(Char, Char)	=
            * Retorna uma nova cadeia de caracteres na qual todas as ocorrências de um caractere 
            * Unicode especificado nessa instância são substituídas por outro caractere Unicode especificado.
             */

            Console.WriteLine("Digite seu nome completo:");
            string nome = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("Qual letra deseja remover do nome?");
            string letraEscolhida = Console.ReadLine();

            nome = nome.Replace(letraEscolhida, "");

            Console.WriteLine($"Bem vindo(a), {nome}");
            Console.ReadKey();
        }
    }
}
