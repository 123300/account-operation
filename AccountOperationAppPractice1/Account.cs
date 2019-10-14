using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountOperationAppPractice1
{
    public class Account
    {
        public string customerName;
        public string accountNumber;
        public double amount;

        public double Deposit(double amnt)
        {
            amount = amount + amnt;
            return amount;
        }

        public double Widthraw(double amnt)
        {
            amount = amount - amnt;
            return amount;
        }
    }
}
