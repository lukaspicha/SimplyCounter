using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplyCounter.Models
{
    /// <summary>
    /// TimeStampModel, implements ICounter.
    /// </summary>
    public class TimeStampModel : ICounter
    {
        private int value;
        private int maxValue;
        private TimeStampModel nextTimeStamp;
        /// <summary>
        /// Create a new TimeStamp with params.
        /// </summary>
        /// <param name="initValue">Init (start) value.</param>
        /// <param name="maxValue">Max value of TimeStamp.</param>
        /// <param name="nextTimeStamp">Next Timestamp of this TimeStamp.</param>
        public TimeStampModel(int initValue, int maxValue, TimeStampModel nextTimeStamp)
        {
            this.value = initValue;
            this.maxValue = maxValue;
            this.nextTimeStamp = nextTimeStamp;
        }
        /// <summary>
        /// Increase a this TimeStamp.
        /// If value is equal maxValue, this value set to zero and call Increase() of nextTimeStamp.
        /// </summary>
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

        public void Test() {
        	
        }
        /// <summary>
        /// Gets next TimeStamp.
        /// </summary>
        public TimeStampModel NextTimeStamp
        {
            get
            {
                return this.nextTimeStamp;
            }
        }
        /// <summary>
        /// Gets actual value of Timestamp.
        /// </summary>
        public int Value
        {
            get
            {
                return this.value;
            }
        }
    }
}
