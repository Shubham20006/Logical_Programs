using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Problem
{
    public class Logical
    {
        public static void Problems()
        {

            // Create new stopwatch
            Stopwatch stopwatch = new Stopwatch();

            // Begin timing
            Console.WriteLine("Press Enter for start");
            Console.ReadLine();
            stopwatch.Start();

            // Stop timing
            Console.WriteLine("Press Enter for stop");
            Console.ReadLine();
            stopwatch.Stop();
            Console.WriteLine("Time Elapsed : {0}", stopwatch.Elapsed);
        }
    }
}

