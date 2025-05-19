namespace ConsoleApp1
{
    public class Account
    {
        public string Name { get; set; }
        public double Balance { get; set; }

        public Account(string name,  double balance)
        {
            Name = name;
            Balance = balance;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"User : {Name}");
            Console.WriteLine($"Balance: {Balance}");
        }
    }
}