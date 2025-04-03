using FlightManager.Models.BaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightManager.Models
{
    public class Flight:BaseModel
    {
        public int FlightDuration { get; set; }
        public DateTimeOffset FlightDate { get; set; }
        public ushort PassengerCount { get; set; }
        public ICollection<Crew> Crews { get; set; }
        public ICollection<FlightStatusChanges> FlightStatusChanges { get; set; }
        public ICollection<Passanger> Passangers { get; set; }
        public int AirPlaneId { get; set; }
        public Airplane AirPlane { get; set; }=new Airplane();
    }
}
