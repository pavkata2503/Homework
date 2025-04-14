using FlightManager.BaseModels;
using MathNet.Numerics;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightManager.Models
{
    public class Ticket : BaseModel
    {

        [Precision(9, 3)]
        public decimal TicketPrice { get; set; }
        [MaxLength(50)]
        public string Type { get; set; }
        public ushort SeatNumber { get; set; }
        //public DateTimeOffset FlightDate { get; set; }


        public int? FlightId { get; set; }
        public Flight? Flight { get; set; } = null!;

        // Many tickets belong to one passenger
        public int? PassengerId { get; set; }
        public Passenger? Passenger { get; set; } = null!;

        // One ticket has one payroll
        public Payroll? Payroll { get; set; }

    }
}
