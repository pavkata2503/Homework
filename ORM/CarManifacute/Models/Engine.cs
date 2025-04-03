using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManifacute.Models
{
    public class Engine
    {
        public int EngineId { get; set; }
        public string Name { get; set; }
        public double HoursePower { get; set; }
        public double Cylinders { get; set; }
        public double FuelConsumption { get; set; }
        public string FuelType { get; set; }

        public double Capacity { get; set; }
        
        public ICollection<Car> Cars { get; set; } = new List<Car>();
    }
}
