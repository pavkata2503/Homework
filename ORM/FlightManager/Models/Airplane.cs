using FlightManager.Models.BaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightManager.Models
{
    public class Airplane:BaseModel
    {
        public ICollection<Airport> Airports { get; set; } = new List<Airport>();
        public ushort SeatsCount { get; set; }
        public ICollection<Flight> Flights { get; set; } = new List<Flight>();
    }
}
