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
            //init
            TimeStampModel h = new TimeStampModel(15, 24, null);
            TimeStampModel m = new TimeStampModel(48, 60, h);
            TimeStampModel s = new TimeStampModel(47, 60, m);

            ///core
            while (!Console.KeyAvailable)
            {
                Console.WriteLine("Press any key to exit...");
                Console.WriteLine(s.NextTimeStamp.NextTimeStamp.Value + ":" + s.NextTimeStamp.Value + ":" + s.Value);
                Thread.Sleep(300);
                s.Increase();
                Console.Clear();
            }
        }
    }
}
