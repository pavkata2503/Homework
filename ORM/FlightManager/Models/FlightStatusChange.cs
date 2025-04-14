using FlightManager.BaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightManager.Models
{
    public class FlightStatusChange : BaseModel
    {
        public int? FlightId { get; set; }
        public Flight? Flight { get; set; } = null!;
        public int? FlightStatusId { get; set; }
        public FlightStatus? FlightStatus { get; set; } = null!;
        public DateTime ChangeAt { get; set; }
    }
}
