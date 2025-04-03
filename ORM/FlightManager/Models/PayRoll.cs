using FlightManager.Models.BaseModels;
using MathNet.Numerics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace FlightManager.Models
{
    public class PayRoll:BaseModel
    {
        public int PassangerId { get; set; }
        public Passanger Passanger { get; set; } = null!;
        public int TicketId { get; set; }
        public Ticket Ticket { get; set; } = null!;
        public decimal Total { get; set; }
    }
}
