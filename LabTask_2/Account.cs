using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTask_2
{
    class Account
    {
        public string AccName { get; set; }
        public string AccNo { get; }
        public double Balance { get; set; }

        public Account() { }
        public Account(string accName, string accNo, double balance)
        {
            AccName = accName;
            AccNo = accNo;
            Balance = balance;
        }
        public void Deposit(double amount)
        {
            Balance += amount;
        }
        public void ShowInfo()
        {
            Console.WriteLine("AccName: " + AccName);
            Console.WriteLine("AccNo: " + AccNo);
            Console.WriteLine("Balance: " + Balance);
        }
        virtual public void Withdraw(double amount)
        {

            if (amount <= Balance)
            {
                Balance = Balance - amount;
                Console.WriteLine("Your acc has been debited by {0} to self", amount);
            }
            else
            {
                Console.WriteLine("Insaficient Balance");
            }
        }
        virtual public void Transfer(Account acc, double amount)
        {
            if (amount <= Balance)
            {
                this.Balance -= amount;
                acc.Balance += amount;
                Console.WriteLine("Youracc has been debited {0} to {1}({2})", amount, acc.AccName, acc.AccNo);
            }

        }

    }
}
