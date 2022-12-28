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
            int sum = 0;
            Console.WriteLine("Enter the Number :- ");
            int N1 = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < N1; i++)
            {
                if (N1 % i == 0)
                {

                    Console.Write(" " + i);
                    sum = sum + i;
                }
            }
            if (sum == N1)
            {
                Console.WriteLine("\n");
                Console.WriteLine(" {0} is Perfect Number", N1);
            }
            else
            {
                Console.WriteLine("\n");
                Console.WriteLine(" {0} is Not Perfect Number", N1);
            }
        }
        }
    }

