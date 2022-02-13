using System.Globalization;
using Exercise_Exceptions_DomainExceptions.Exceptions;

namespace Exercise_Exceptions_DomainExceptions.Entities
{
    class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithDrawLimit { get; set; }

        public Account()
        {
        }
        public Account(int number, string holder, double balance, double withDrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithDrawLimit = withDrawLimit;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void WithDraw(double amount)
        {
           if (amount > Balance) 
            {
                throw new DomainExceptions("Not enough balance");
            }
            
            if (amount > WithDrawLimit)
            {
                throw new DomainExceptions("The amount exceeds withdraw limit");
            }  
            
            Balance -= amount;
        }

        public override string ToString()
        {
            return "New balance: " + Balance.ToString("F2", CultureInfo.InvariantCulture); 
        }
    }
}
