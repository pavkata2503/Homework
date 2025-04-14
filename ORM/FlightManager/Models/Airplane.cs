using FlightManager.BaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightManager.Models
{
    public class Airplane : BaseModel
    {
        public ushort SeatsCount { get; set; }
        public ICollection<Airport> Airports { get; set; } = new List<Airport>();
        public ICollection<Flight> Flights { get; set; } = new List<Flight>();


    }
}
