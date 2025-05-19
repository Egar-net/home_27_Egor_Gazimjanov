namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UserMenu();
        }

        private static void UserMenu()
        {
            try
            {
                Console.WriteLine("Enter your name more 4:");
                string user = Console.ReadLine();
                while (true)
                {
                    if (user.Length >= 4 && !user.Any(char.IsDigit))
                    {
                        break; 
                    }
                    else
                    {
                        Console.WriteLine("Wrong! Try again:");
                        user = Console.ReadLine();
                    }
                }
                Console.WriteLine("Enter how much have money:");
                double sum = Convert.ToDouble(Console.ReadLine());
                while (true)
                {
                    if (sum > 0)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Wrong! try again");
                        sum = Convert.ToDouble(Console.ReadLine());
                    }
                }

                var account = new Account(user, sum);
                var bank = new Bank<Account>(account);
                account.ShowInfo();
                Console.WriteLine("How you wanna to get the money");
                Console.WriteLine("1:Deposit account\n2:Transit account\n3:Closed account");
                string choice = Console.ReadLine();
                while (true)
                {
                    switch (choice)
                    {
                        case "1":
                            DepositAccount deposit = new DepositAccount(user, sum);
                            deposit.ShowInfoDepositAccount();
                            return;
                        case "2":
                            TransitAccount transit = new TransitAccount(user, sum);
                            transit.ShowInfoTransitAccount();
                            return;
                        case "3":
                            ClosedAccount closed = new ClosedAccount(user, sum);
                            closed.ShowInfoClosedAccount();
                            return;
                        default:
                            Console.WriteLine("Wrong! try again");
                            choice = Console.ReadLine();
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


        }
    }
}
