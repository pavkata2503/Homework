using Service.BaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Models
{
    public class ProductCategory : BaseModel
    {
        public string ProductCategoryName { get; set; }
        public string ProductSubCategoryName { get; set; }

        public ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
