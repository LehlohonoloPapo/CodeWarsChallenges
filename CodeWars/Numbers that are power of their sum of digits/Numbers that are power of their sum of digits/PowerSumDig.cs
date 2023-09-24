using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers_that_are_power_of_their_sum_of_digits
{

    public class PowerSumDig
    {
        public static long PowerSumDigTerm(int n)
        {
            int trackNumber = 10;
            int count = 0;

            while (count <n)
            {
                trackNumber++;
                int sumValue = SumOfDigit(trackNumber.ToString().ToCharArray());
                
                if (PowerOfDigit(sumValue, trackNumber))
                    count++;
                
                    Console.WriteLine(count);

                if (count == n)
                    return trackNumber;
                
            }
            return 0;
        }

        public static int SumOfDigit(char[] list)
        {
            return list.Sum(x => int.Parse(x.ToString()));
        }

        public static bool PowerOfDigit(int digit, int termValue)
        {
           
            var x = Math.Round( Math.Log(termValue, digit),12);
       
            return (x % 1) == 0;

        }
    }
}
