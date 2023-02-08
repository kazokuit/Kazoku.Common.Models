using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kazoku.Common.Models.Kazoku.Bookings
{
    public class Booking
    {
        public Guid Id { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string UserId { get; set; } = string.Empty;
    }
}
