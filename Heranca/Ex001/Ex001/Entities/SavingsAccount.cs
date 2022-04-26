namespace Ex001.Entities
{
    sealed class SavingsAccount : Account // classe selada -> não pode ser "herdada" 
    {
        public double InterestRate { get; set; }

        public SavingsAccount()
        {
        }

        public SavingsAccount(int number, string holder, double balance, double interestRate) : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }

        public sealed override void Withdraw(double amount)
        {
            base.Withdraw(amount); // palavra "base" reaproveita a operação da superclasse 
            Balance -= 2.0;
        }
    }
}
