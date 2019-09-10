using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectionTestWFACS.Model
{
    class IntervalInteger
    {
        public int Interval { get; set; }

        public override string ToString()
        {
            return Convert.ToString(Interval);
        }
    }
}
