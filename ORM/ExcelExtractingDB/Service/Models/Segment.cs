using Service.BaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Models
{
    public class Segment : BaseModel
    {
        public string SegmentName { get; set; }
        public ICollection<Customer> Customers { get; set; }
    }
}
