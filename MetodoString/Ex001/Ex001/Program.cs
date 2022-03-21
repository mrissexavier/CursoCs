namespace Ex001
{
    class Program
    {
        static void Main(string[] args)
        {
            // ToUpper() = Retorna uma cópia dessa cadeia de caracteres convertida em maiúsculas.

            Console.WriteLine("Eai, como tu se chama?");
            string nome = Console.ReadLine();
            nome = nome.ToUpper();

            Console.WriteLine($"Chega mais, {nome} :)"); 
        }
    }
}
