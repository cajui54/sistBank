using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankHeranca
{
    class BusinessAccount : Account
    {
        double loanLimit { get; set; }

        public BusinessAccount(int number, string holder, double balance, double loanLimit):base(number, holder, balance)
        {
            this.loanLimit = loanLimit;
        }
        public override string ToString()
        {
            return number +" - "+ holder +" - "+ loanLimit.ToString("F1", CultureInfo.InvariantCulture);
        }
        public override void withdraw(double amount)
        {
            balance -= amount -5;
        }
    }
}
