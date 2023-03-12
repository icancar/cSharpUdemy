using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerator
{
    class Ticket : IEquatable<Ticket>
    {
        public int DurationHours { get; set; }

        public Ticket(int durationHours)
        {
            DurationHours = durationHours;
        }

        public bool Equals(Ticket other)
        {
            bool isEqual = false;
            if(this.DurationHours == other.DurationHours) { 
                isEqual = true;
            }
            return isEqual;
        }
    }
}
