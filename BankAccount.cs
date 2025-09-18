using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Bankomat
{
    internal class BankAccount
    {
        private decimal balance = 0; //känslig data
        public decimal Balance => balance;
        
        public void DepositMoney(decimal amount)
        {
            if (amount > 0) 
                balance += amount;
        }
        public void WithdrawMoney(decimal amount)
        {
            if (amount > 0 && amount <= balance)
                balance -= amount;
        }
    }
}
