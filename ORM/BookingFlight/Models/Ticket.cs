using BookingFlight.Models.BaseModels;
using MathNet.Numerics;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingFlight.Models
{
    public class Ticket:BaseModel
    {
        [Precision(9, 3)]
        public decimal TicketPrice { get; set; }
        [MaxLength(50)]
        public string Type { get; set; }
        public ushort SeatNumber { get; set; }
        //public DateTimeOffset FlightDate { get; set; }


        public int? PayrollId { get; set; }
        public Payroll? Payroll { get; set; }
        public int FlightId { get; set; }
        public Flight Flight { get; set; } = null!;
        public int PassengerId { get; set; }
        public Passenger Passenger { get; set; } = null!;
    }
}
