namespace Ex005
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
             * Replace(String, String)	=
            * Retorna uma nova cadeia de caracteres na qual todas as ocorrências de um caractere 
            * Unicode especificado nessa instância são substituídas por outro caractere Unicode especificado.
             */

            Console.WriteLine("Digite seu nome completo:");
            string nome = Console.ReadLine();

            Console.Clear();

            while(nome.Length > 0)
            {
                Console.WriteLine("Qual letra deseja remover do nome?");
                string letraEscolhida = Console.ReadLine();

                nome = nome.Replace(letraEscolhida, "");
                nome = nome.Trim();

                Console.WriteLine($"Bem vindo(a), {nome}");
            }
            Console.ReadKey();
        }
    }
}