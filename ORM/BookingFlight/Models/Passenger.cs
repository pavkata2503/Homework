using BookingFlight.Models.BaseModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingFlight.Models
{
    public class Passenger:BaseModel 
    {
        [MaxLength(150)]
        public string Name { get; set; }
        public int TicketId { get; set; }
    }
}
