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
            Hour h = new Hour(15, 24, null);
            Minute m = new Minute(48, 60, h);
            Sec s = new Sec(47, 60, m);

            while (true)
            {
                Console.WriteLine(s.NextTimeStamp.NextTimeStamp.Value + ":" + s.NextTimeStamp.Value + ":" + s.Value);
                s.Increase();
                Thread.Sleep(500);
            }
        }
    }
}
