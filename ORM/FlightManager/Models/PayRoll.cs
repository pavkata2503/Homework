using FlightManager.BaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace FlightManager.Models
{
    public class Payroll : BaseModel
    {

        public double Total { get; set; }

        // One payroll belongs to one passenger
        public int? PassengerId { get; set; }
        public Passenger? Passenger { get; set; } = null!;

        // One payroll belongs to one ticket
        public int? TicketId { get; set; }
        public Ticket? Ticket { get; set; } = null!;
    }
}
