using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Problem
{
    public class Logical
    {
        public static void Problems()
        {
            int count = 0;
            Console.WriteLine("Enter the Number :- ");
            int N1 = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= N1; i++)
            {
                int C = (N1 % i);
                if (C == 0)
                {
                    count++;
                }
            }
            if (count == 2)
            {
                Console.WriteLine("Prime Number");
            }
            else
            {
                Console.WriteLine("Not a Prime Number");
            }
        }
    }
}

