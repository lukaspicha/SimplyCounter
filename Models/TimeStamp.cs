using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplyCounter.Models
{
    public class TimeStamp : ICounter
    {
        private int value;
        private int maxValue;
        private TimeStamp nextTimeStamp;

        public TimeStamp(int initValue, int maxValue, TimeStamp nextTimeStamp)
        {
            this.value = initValue;
            this.maxValue = maxValue;
            this.nextTimeStamp = nextTimeStamp;
        }

        public void Increase()
        {
            this.value++;
            if (this.value == this.maxValue)
            {
                this.value = 0;
                if(this.nextTimeStamp != null)
                    this.nextTimeStamp.Increase();
            }
        }
        public TimeStamp NextTimeStamp
        {
            get
            {
                return this.nextTimeStamp;
            }
        }
        public int Value
        {
            get
            {
                return this.value;
            }
        }
    }
}
