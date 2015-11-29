using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplyCounter.Models
{
    /// <summary>
    /// Interface for TimeStampModel.
    /// </summary>
    interface ICounter
    {
        /// <summary>
        /// Actual value of TimeStamp.
        /// </summary>
        int Value { get; }
        /// <summary>
        /// Increase a value of TimeStamp.
        /// </summary>
        void Increase();
    }
}
