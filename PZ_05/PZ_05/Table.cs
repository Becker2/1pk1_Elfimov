using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableBookingSystem
{
    public class Table
    {
        public int Id { get; set; }
        public bool IsBooked { get; set; }
        public string BookingTime { get; set; }
    }
}
