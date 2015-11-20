using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplyCounter.Models
{
    public class Hour : TimeStamp
    {
        public Hour(int initValue, int maxValue, TimeStamp nextTimeStamp)
            : base(initValue, maxValue, nextTimeStamp)
        {

        }
    }
}
