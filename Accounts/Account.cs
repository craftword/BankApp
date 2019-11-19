using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Accounts
{
    public class Account
    {
        //fields
       
        protected double balance;
        protected double deposit;
        protected double withdrawal;
        protected double minBalance;
        
        public double Withdrawal { get; set; }
       
        public double Deposit { get; set; }


        public double MinBalance { get; set; }



        public double Bal
        { get { return balance; } }

        //creates random Account Number
        public double Balance()
        {
            balance = balance + deposit - withdrawal;
            deposit = 0;
            withdrawal = 0;
            return balance;
        }
        //Computers Balance when withdrawal equals zero
        public double DepositBalance(double input)
        {
            //deposit = input;
            balance += input;
            return balance;
        }
        public double WithBalance(double input, string accountType)
        {
            if (accountType == "Saving")
            {
                minBalance = 1000;

            }
            if (input > (balance - minBalance))
            {
                Console.WriteLine("Insufficient Balance");
                return 0;
            }
            else
            {
                balance -= input;
                return balance;
            }


        }

        



    }
}

