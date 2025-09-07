namespace Week5Task1
{
    internal class CheckingAccount : Account
    {
        private const double Fee = 1.50;
        public CheckingAccount(string name = "Unnamed Checking Account", double balance = 0.0)
      : base(name, balance)
        {
        }
        public override bool Withdraw(double amount)
        {
            double totalAmount = amount + Fee;

            if(GetBalance() - totalAmount >= 0)
            {
                return base.Withdraw(totalAmount);
                
            }
            return false;

        }
    }
}