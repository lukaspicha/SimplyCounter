using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplyCounter.Models
{
    interface ICounter
    {
        int Value { get; }
        void Increase();
    }
}
