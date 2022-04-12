using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARTPCodingChallenge
{
    class Multiples3and5
    {
        static void Main(string[] args)
        {
            int sum1 = 0;
            int i;

            for (i = 3; i <= 1000; i += 3)
            {
                sum1 += i;
            }
            Console.WriteLine("The sum of the multiples of 3 between 0 and 1000 is {0} ", sum1);

            int sum2 = 0;
            int y;

            for (y = 5; y <= 1000; y += 5)
            {
                sum2 += y;
            }

            Console.WriteLine("The sum of the multiples of 5 betwen 0 and 1000 is {0} ", sum1);

            int totalSum = sum1 + sum2;

            Console.WriteLine("The sum of the multiples of 3 and 5 between 0 and 1000 is {0}", totalSum);

        }


    }
}