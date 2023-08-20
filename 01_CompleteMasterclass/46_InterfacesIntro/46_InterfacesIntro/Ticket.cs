using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _46_InterfacesIntro
{
    class Ticket : IEquatable<Ticket>
    {
        // property to store the duration of the ticket in hours
        public int DurationInHours { get; set; }

        // simple construstor
        public Ticket(int durationInHours)
        {
            DurationInHours = durationInHours;
        }

        public bool Equals(Ticket other)
        {
            return this.DurationInHours == other.DurationInHours;
        }
    }
}
