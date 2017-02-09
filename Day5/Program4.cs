using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    class Program4
    {
        public static void Main()
        {
            //print all prime number from 1-200
            for (int i = 1; i <= 200; i++)
            {
                if (Program3.isPrime(i))
                {
                    Console.WriteLine("{0} is a prime", i);
                }
            }
        }
    }
}
