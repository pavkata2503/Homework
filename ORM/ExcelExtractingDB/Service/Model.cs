using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class Model
    {


        // Properties corresponding to the columns in the CSV file  
        // Ensure that the property names match the column names in the CSV file
        // or use the ClassMap to map them explicitly
        // If the column names in the CSV file are different, you can use CsvHelper's ClassMap to map them
        // to the properties in this class.
        public int RowID { get; set; }
        public string OrderPriority { get; set; }
        public string Discount { get; set; }
        public string UnitPrice { get; set; }
        public double ShippingCost { get; set; }
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string ShipMode { get; set; }
        public string CustomerSegment { get; set; }
        public string ProductCategory { get; set; }
        public string ProductSub_Category { get; set; }
        public string ProductContainer { get; set; }
        public string ProductName { get; set; }
        public double ProductBaseMargin { get; set; }
        public string Country { get; set; }
        public string Region { get; set; }
        public string StateorProvince { get; set; }
        public string City { get; set; }
        public int PostalCode { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime ShipDate { get; set; }
        public double Profit { get; set; }
        public int Quantityorderednew { get; set; }
        public double Sales { get; set; }
        public int OrderID { get; set; }
    }
}
