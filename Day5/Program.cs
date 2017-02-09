using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a; //a is an array of int
            a = new int[3];// a has a elements
            a[0] = 1;
            a[1] = 10;
            a[2] = 100;
            //   a[-1] = 1000;//<====

            int[] b = new int[3];                                        //      fixed intax
            b[0] = 1;
            b[1]= 10;
            b[2] = 100;
            Console.WriteLine(b[0]);//1

            b = new int[10];//replace with a new array - old array will be thrown away with the older array
            Console.WriteLine(b[0]);//0

            int[] c = new int[] { 1, 10, 100 };//flexible / can adjust          special intax
            int[] d = new int[3] { 1, 10, 100 };//array must be 3

        }
    }
}
