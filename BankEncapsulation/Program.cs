using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount();

            account.Deposit();
            Console.WriteLine($"Your ballance is ${account.GetBalance()}");               
            
        }
    }
}
