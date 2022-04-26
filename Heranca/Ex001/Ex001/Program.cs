using Ex001.Entities;

namespace Ex001
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account(1001, "Emily", 0.0);
            BusinessAccount businessAccount = new BusinessAccount(1002, "Mark", 0.0, 500.0);

            //Upcasting

            Account account1 = businessAccount;
            Account account2 = new BusinessAccount(1003, "Bobby", 0.0, 2000.0);
            Account account3 = new SavingsAccount(1004, "Ana", 0.0, 0.01);

            //Downcasting

            BusinessAccount account4 = (BusinessAccount)account2;

            if(account3 is BusinessAccount)
            {
                //BusinessAccount account5 = (BusinessAccount)account3;
                BusinessAccount account5 = account3 as BusinessAccount;
                account5.Loan(200.0);
                Console.WriteLine("Loan!");
            }

            if(account3 is SavingsAccount)
            {
                //SavingsAccount account5 = (SavingsAccount)account3;
                SavingsAccount account5 = account3 as SavingsAccount;
                account5.UpdateBalance();
                Console.WriteLine("Update!");
            }


        }
    }
}
