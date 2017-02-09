using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    class Program3
    {
        public static bool isPrime(int num)
        {
            if (num<0)  return false;
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                    return false; //to stop
            }
            return true;
        }
        public static string ReadString(string prompt)
        {
            Console.Write(prompt);
            return Console.ReadLine();
        }

        public static int ReadInteger(string prompt)
        {
            String input = ReadString(prompt);
            return Convert.ToInt32(input);
        }

        public static void Main()
        {
            int num = ReadInteger("Please enter a number");
            if(isPrime(num))
            {
                Console.WriteLine("Prime");
            }
            else
            {
                Console.WriteLine("Not Prime");
            }
        }
    }
    }