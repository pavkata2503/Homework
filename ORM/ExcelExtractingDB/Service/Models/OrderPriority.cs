using Service.BaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Models
{
    public class OrderPriority : BaseModel
    {
        public string OrderPriorityName { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
