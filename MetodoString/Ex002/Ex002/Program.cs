namespace Ex002
{
    class Program
    {
        static void Main(string[] args)
        {
            // ToLower()	= Retorna uma cópia dessa cadeia de caracteres (string) convertida em minúsculas.

            Console.WriteLine("Digite seu nome completo:");
            string nome = Console.ReadLine();
            nome = nome.ToLower();

            Console.WriteLine($"Bem vindo, {nome}!");
        }
    }
}
