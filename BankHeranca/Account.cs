using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankHeranca
{
    class Account
    {
        public int number { get; set; }
        public string holder { get; set; }
        public double balance { get; set; }

        public Account(int number, string holder, double balance)
        {
            this.number = number;
            this.holder = holder;
            this.balance = balance;
        }

        public override string ToString()
        {
            return number +" - "+ holder + " - "+balance.ToString("F2", CultureInfo.InvariantCulture) ;
        }

        public virtual void withdraw(double amount)
        {
            balance -= amount;
        }
        public void deposit(double amount)
        {
            balance += amount;
        }
    }
}
