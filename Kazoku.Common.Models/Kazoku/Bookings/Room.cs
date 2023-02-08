using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kazoku.Common.Models.Kazoku.Bookings
{
    public class Room
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int MaxPeople { get; set; }
        public Dictionary<string, string> Equipment { get; set; } = new Dictionary<string, string>();
    }
}
