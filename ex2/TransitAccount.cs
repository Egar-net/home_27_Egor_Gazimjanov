namespace ConsoleApp1
{
    public class TransitAccount : Account
    {
        public TransitAccount(string user, double balance) : base(user, balance) {}

        public void ShowInfoTransitAccount()
        {
            Console.WriteLine("This is Transit Account");
            Console.WriteLine($"User : {Name}");
            Console.WriteLine($"Balance: {Balance}");
        }

    }
}
