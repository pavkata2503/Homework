using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16._03
{
    class Pair
    {
        public double exchangeRate {  get; set; }
        public string Name { get; set; }
        public const double Fee = 0.02;

        public Pair(double exchangeRate, string name)
        {
            this.exchangeRate = exchangeRate;
            Name = name;
        }
    }
}
