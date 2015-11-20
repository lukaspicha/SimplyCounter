using SimplyCounter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SimplyCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeStamp h = new TimeStamp(15, 24, null);
            TimeStamp m = new TimeStamp(48, 60, h);
            TimeStamp s = new TimeStamp(47, 60, m);

            while (true)
            {
                Console.WriteLine(s.NextTimeStamp.NextTimeStamp.Value + ":" + s.NextTimeStamp.Value + ":" + s.Value);
                s.Increase();
                Thread.Sleep(00);
            }
        }
    }
}
