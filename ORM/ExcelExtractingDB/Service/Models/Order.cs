using Service.BaseModels;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Models
{
    public class Order : BaseModel
    {
        public string OrderID { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime ShipDate { get; set; }

        public string CustomerID { get; set; }
        public Customer Customer { get; set; }

        public string ShipModeName { get; set; }
        public ShipMode ShipMode { get; set; }

        public string OrderPriorityName { get; set; }
        public OrderPriority OrderPriority { get; set; }

        public string RegionName { get; set; }
        public Region Region { get; set; }

        public ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
