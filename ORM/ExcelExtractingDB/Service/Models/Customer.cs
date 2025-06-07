using Service.BaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Models
{
    public class Customer:BaseModel
    {
        public string CustomerID { get; set; }
        public string CustomerName { get; set; }

        public string SegmentName { get; set; }
        public Segment Segment { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}
