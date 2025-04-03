using FlightManager.Models.BaseModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightManager.Models
{
    public class Ticket:BaseModel
    {
        public int Id { get; set; }
        [Precision(9,2)]
        public decimal TicketPrice { get; set; }
        [MaxLength(50)]
        public string Type { get; set; }
        public ushort SeatNumber { get; set; }
        public int? PayrollId { get; set; }
        public PayRoll? Payroll { get; set; }
        public int FlightId { get; set; }
        public Flight Flight { get; set; }= null!;
        public int PassangerId { get; set; }
        public Passanger Passanger { get; set; } = null!;


    }
}
