using System.Globalization;
using Interface.Entities;
using Interface.Services;
namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter rental data:");
            Console.Write("Car model: ");
            string carModel = Console.ReadLine();
            Console.Write("Pickup (DD/MM/YYYY hh : mm): ");
            DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.Write("Return (DD/MM/YYYY hh : mm): ");
            DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.Write("Enter price per hour: ");
            double hour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Enter price per day: ");
            double day = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            CarRental carRental = new CarRental(start, finish, new Vehicle(carModel));

            RentalService rentalService = new RentalService(hour, day, new BrazilTaxService());

            rentalService.ProcessInvoice(carRental);
            Console.WriteLine();
            Console.WriteLine("Invoice: ");
            Console.WriteLine(carRental.Invoice);


        }
    }
}
