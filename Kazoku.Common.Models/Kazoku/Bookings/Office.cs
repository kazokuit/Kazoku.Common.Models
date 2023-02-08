using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kazoku.Common.Models.Kazoku.Bookings
{
    public class Office
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public List<Room> Rooms { get; set; } = new List<Room>();
    }
}
