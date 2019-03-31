using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankHeranca
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account(1001,"Maria ", 500.05);
            Account businessAccount = new BusinessAccount(1002, "Ana Clara", 500.20, 5);

            Console.WriteLine(account);
            Console.WriteLine(businessAccount);
            account.withdraw(50);

            Console.WriteLine(account);

            Console.ReadLine();
        }
    }
}
