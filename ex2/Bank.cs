using System.Xml.Linq;

namespace ConsoleApp1
{
    public class Bank<T> where T : Account
    {
        private readonly T _account;

        public Bank(T account)
        {
            _account = account;
        }

        public void ShowMoney()
        {

        }
    }
}
