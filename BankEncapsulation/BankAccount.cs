using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulation
{
    public class BankAccount
    {
        public BankAccount()
        {
        }

        private double balance = 0;

        public void Deposit()
        {
            double userDeposit;
            bool isParsable;

            do
            {
                Console.WriteLine("Please enter a deposit amount.");
                var userDepositResponce = Console.ReadLine();
                isParsable = double.TryParse(userDepositResponce, out userDeposit);
            } while (isParsable == false);

            balance += userDeposit;

            
        }

        public double GetBalance()
        {
            return balance;
        }
    }
}
