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
            Console.WriteLine("Enter the Number :- ");
            int N1 = Convert.ToInt32(Console.ReadLine());
            int n1 = 0, n2 = 1;
            Console.Write(n1 + "\n" + n2 + "\n");
            for (int i = 0; i <= N1; i++)
            {
                int n3 = n1 + n2;
                Console.WriteLine(n3 + " ");
                n1 = n2;
                n2 = n3;
            }
        }
    }
}
