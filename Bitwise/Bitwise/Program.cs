namespace Bitwise
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 10, num1 = 20;
            /* 
                " << " dobra o valor 
                " >> " divide o valor
             */
            num = num << 1;
            num1 = num1 >> 1;

            Console.WriteLine(num);
            Console.WriteLine(num1);
        }
    }
}
