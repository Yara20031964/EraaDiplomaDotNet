namespace Week5Task1
{
    internal class TrustAccount : Account

    {
        private int withdrawalCount = 0;
        public int Interest { get; set; }

        public TrustAccount(string name = "Unnamed Account", int Interest = 500, double balance = 0.0) : base(name, balance)
        {
            this.Interest = Interest;
        }

        public override bool Deposit(double amount)
        {
            if (amount >= 5000)
            {
                return base.Deposit(amount + 50);
                
            }
            else
            {
                return base.Deposit(amount);
            }
        }
        public override bool Withdraw(double amount)
        {
            double twentyPercent = GetBalance() * 0.2;
            if (withdrawalCount >= 3)
            {
                Console.WriteLine("Withdrawal limit reached for this Trust Account.");
                return false;
            }

            if (amount > twentyPercent)
            {
                Console.WriteLine("Withdrawal failed: Amount exceeds 20% of balance.");
                return false;
            }
            bool result = base.Withdraw(amount);
            if (result)
            {
                withdrawalCount++;
            }
            return result;
        }
    }
}