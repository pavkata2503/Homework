using Service.BaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Models
{
    public class ShipMode : BaseModel
    {
        public string ShipModeName { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
