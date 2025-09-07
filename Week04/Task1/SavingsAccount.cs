namespace Week5Task1
{
    internal class SavingsAccount : Account
    {
        public int Interest { get; set; }

        public SavingsAccount(string name = "Unnamed Account", int Interest = 500, double balance = 0.0):base(name, balance)
        {
            this.Interest = Interest;
        }
    }
}