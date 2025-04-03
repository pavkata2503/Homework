using BookingFlight.Models.BaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingFlight.Models
{
    public class Flight: BaseModel
    {
        public int FlightDuration { get; set; }
        public DateTimeOffset FlightDate { get; set; }
        public ushort PassengerCount { get; set; }

        public ICollection<Crew> Crews { get; set; }
        public ICollection<FlightStatusChange> FlightStatusChanges { get; set; }
        public ICollection<Passenger> Passengers { get; set; }
        public int AirplaneId { get; set; }
        public Airplane Airplane { get; set; } = new Airplane();
    }
}
