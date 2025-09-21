using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankomat
{
    public class Customer
    {
        public Person Person { get; }
        public BankAccount Account { get; }
        private readonly string pin;

        public Customer(Person person, BankAccount account, string pin)
        {
            Person = person;
            Account = account;
            this.pin = pin;
        }

        public bool Authenticate(string inputPin)
        {
            return inputPin == pin;
        }

    }
}
