namespace ConsoleApp1
{
    public class DepositAccount : Account
    {
        public DepositAccount(string user, double balance) : base(user, balance) {}

        public void ShowInfoDepositAccount()
        {
            Console.WriteLine("This is Deposit Account");
            Console.WriteLine($"User : {Name}");
            Console.WriteLine($"Balance: {Balance}");
        }
    }
}
