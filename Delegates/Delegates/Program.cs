using Delegates.Services;

namespace Delegates
{

    delegate double BinaryNumericOperation(double n1, double n2);
    class Program
    {
        static void Main(string[] args)
        {
            double a = 10;
            double b = 20;

            BinaryNumericOperation op = CalculationService.Sum;
            double result = op(a, b);

            Console.WriteLine(result);
   
        }
    }
}
