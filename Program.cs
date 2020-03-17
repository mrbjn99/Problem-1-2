using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Program
    {
        //Problem 1
        //Declare a Class
        public class BankAccount
        {
            private int id;
            private decimal balance;
            public int Id;
            public decimal Balance;
            public void Deposit(int depositAmount)
            {
                Balance = Balance + depositAmount;
            }
            public void WithDraw(int withdrawAmount)
            {
                Balance = Balance - withdrawAmount;
            }

        }


        static void Main(string[] args)
        {
            BankAccount acc = new BankAccount();

            acc.Id = 1;
            acc.Balance = 15;
            acc.Deposit(15);
            acc.WithDraw(10);
            Console.WriteLine($"Account {acc.Id}, balance { acc.Balance}");

            Console.WriteLine(acc);
        }

    }
}
