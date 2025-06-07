using Service.BaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Models
{
    public class OrderDetail : BaseModel
    {
        public int RowID { get; set; }

        public string OrderID { get; set; }
        public Order Order { get; set; }

        public string ProductName { get; set; }
        public string ProductCategoryName { get; set; }
        public string ProductSubCategoryName { get; set; }
        public ProductCategory ProductCategory { get; set; }

        public decimal Sales { get; set; }
        public int Quantity { get; set; }
        public double Discount { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal ShippingCost { get; set; }
        public decimal Profit { get; set; }
    }
}
