using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16._03
{
    class Customer
    {
        public Customer(string name, double balance)
        {
            Name = name;
            Balance = balance;
        }

        public string Name { get; set; }
        public double Balance { get; set; }
        public override string ToString() 
        {
            return $"Име: {Name} Баланс: {Balance}";
        }
        public void ChangeValues(double value, double exchangeRate)
        {
            double fee= 0.02;
            double pricefee = value * fee;
            Balance = (value * exchangeRate)-pricefee;
        }

    }
}
