using FlightManager.Models.BaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightManager.Models
{
    public class Passanger:BaseModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int TicketId { get; set; }
        public Ticket Ticket { get; set; } = null!;

    }
}
