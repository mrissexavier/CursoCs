namespace Ex005
{
    class Program
    {
        static void Main(string[] args)
        {
            double vPago, preco, troco;

            Console.WriteLine("Qual o preço do produto?");
            preco = double.Parse(Console.ReadLine());

            Console.WriteLine("Qual o valor pago?");
            vPago = double.Parse(Console.ReadLine());

            troco = vPago - preco;

            if (troco > 0)
            
                Console.WriteLine($"O troco é: {troco}");
            
            else if(troco < 0)
            
                Console.WriteLine("Ainda falta pagar " + Math.Abs(troco));
            
            else
            
                Console.WriteLine("Não há troco");
            
        }
    }
}
