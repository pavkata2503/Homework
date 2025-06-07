using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class ModelClassMap:ClassMap<Model>
    {
        public ModelClassMap()
        {
            Map(m => m.RowID).Name("Row ID");
            Map(m => m.OrderPriority).Name("Order Priority");
            Map(m => m.Discount).Name("Discount");
            Map(m => m.UnitPrice).Name("Unit Price");
            Map(m => m.ShippingCost).Name("Shipping Cost");
            Map(m => m.CustomerID).Name("Customer ID");
            Map(m => m.CustomerName).Name("Customer Name");
            Map(m => m.ShipMode).Name("Ship Mode");
            Map(m => m.CustomerSegment).Name("Customer Segment");
            Map(m => m.ProductCategory).Name("Product Category");
            Map(m => m.ProductSub_Category).Name("Product Sub-Category");
            Map(m => m.ProductContainer).Name("Product Container");
            Map(m => m.ProductName).Name("Product Name");
            Map(m => m.ProductBaseMargin).Name("Product Base Margin");
            Map(m => m.Country).Name("Country");
            Map(m => m.Region).Name("Region");
            Map(m => m.StateorProvince).Name("State or Province");
            Map(m => m.City).Name("City");
            Map(m => m.PostalCode).Name("Postal Code");
            Map(m => m.OrderDate).Name("Order Date");
            Map(m => m.ShipDate).Name("Ship Date");
            Map(m => m.Profit).Name("Profit");
            Map(m => m.Quantityorderednew).Name("Quantity ordered new");
            Map(m => m.Sales).Name("Sales");
            Map(m => m.OrderID).Name("Order ID");
        }
    }
}
