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
            int rev = 0;
            Console.WriteLine("Enter the Starting Number :- ");
            int N1 = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i != N1;)
            {
                int C = (N1 % 10);

                rev = (rev * 10) + C;
                N1 = (N1 / 10);
            }
            Console.WriteLine(rev);
        }
    }
}

