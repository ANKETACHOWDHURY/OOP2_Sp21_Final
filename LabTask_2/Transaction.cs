using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTask_2
{
    class Transaction
    {
        public Account Sender { get; set; }
        public Account Receiver { get; set; }
        public int Amount { get; set; }
        public string AdditionalInfo { get; set; }

        public Transaction()
        {
            Console.WriteLine("Default Constructor");
        }

        public Transaction(Account sender, Account receiver, int amount, string additionalInfo)
        {
            Sender = sender;
            Receiver = receiver;
            Amount = amount;
            AdditionalInfo = additionalInfo;
            Console.WriteLine("4 Parameter Constructor ");
        }
        public void ShowInfo()
        {
            Console.WriteLine("Sender Name {0} : Account No {1} & Amount is {2}", Sender, Sender.AccNo, Amount);
            Console.WriteLine("Recever Name {0} : Account No {1} & Amount is {2}", Receiver, Receiver.AccNo, Amount);
            Console.WriteLine("Transferd Amount {0} : ", Amount);
            Console.WriteLine("Purpose of Transaction {0} : ", AdditionalInfo);
        }



    }
}
