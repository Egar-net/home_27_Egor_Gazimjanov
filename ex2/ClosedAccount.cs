namespace ConsoleApp1
{
    public class ClosedAccount : Account
    {
        public ClosedAccount(string user, double balance) : base(user, balance) { }

        public void ShowInfoClosedAccount() 
        {
            Console.WriteLine("This is Closed Account");
            Console.WriteLine($"User : {Name}");
            Console.WriteLine($"Balance: {Balance}");
        }
    }
}
