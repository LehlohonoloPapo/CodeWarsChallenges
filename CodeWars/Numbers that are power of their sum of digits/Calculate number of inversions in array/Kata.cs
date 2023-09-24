using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculate_number_of_inversions_in_array
{
    public class Kata
    {
        public static int CountInversions(int[] array)
        {
            int temp;
            int value=0;
            for (int j = 0; j <= array.Length - 2; j++)
            {
                for (int i = 0; i <= array.Length - 2; i++)
                {
                  
                    if (array[i] > array[i + 1])
                    {
                        temp = array[i + 1];
                        array[i + 1] = array[i];
                        array[i] = temp;
                        value++;
                    }
                }
            }
            Console.WriteLine(value);
            return value;
        }
    }
}
