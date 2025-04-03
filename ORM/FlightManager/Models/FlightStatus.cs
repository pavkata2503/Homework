using FlightManager.Models.BaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightManager.Models
{
    public class FlightStatus:BaseModel
    {
        public string Status { get; set; } = null!;
        public ICollection<FlightStatusChanges> FlightStatusChanges { get; set; }= new List<FlightStatusChanges>();
    }
}
