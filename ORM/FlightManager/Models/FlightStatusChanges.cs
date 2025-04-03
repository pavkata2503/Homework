using FlightManager.Models.BaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightManager.Models
{
    public class FlightStatusChanges:BaseModel
    {
        public int FlightId { get; set; }
        public Flight Flight { get; set; }
        public int FlightStatusId { get; set; }
        public FlightStatus FlightStatus { get; set; }
        public DateTimeOffset ChangedAt { get; set; }
    }
}
