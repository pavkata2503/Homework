using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza_Service.Interfaces
{
    internal interface IPizza
    {
        public string Size { get; set; }
        public int Quantity { get; set; }
        public string OrderDate { get; set; }
        string GetName();
        void Prepare();
        decimal CalculatePrice();

        int GetAmount();
    }
}
