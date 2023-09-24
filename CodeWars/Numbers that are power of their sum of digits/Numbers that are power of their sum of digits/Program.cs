

using System.Diagnostics;

namespace Numbers_that_are_power_of_their_sum_of_digits
{
     class Program
    {
        static void Main(string[] args)
        {
            //var timer = new Stopwatch();
            //timer.Start();
            //var k = PowerSumDig.PowerSumDigTerm(15);
            //Console.WriteLine(k);
            //timer.Stop();

            for (var i = 15; i < 17; i++)
            {
                var timer = new Stopwatch();
                timer.Start();

                var k = PowerSumDig.PowerSumDigTerm(15);
                TimeSpan timeTaken = timer.Elapsed;
                Console.WriteLine("input " + i + ", output " + k + " Time taken: " + timeTaken.ToString(@"m\:ss\.fff"));
                timer.Stop();
            }

            //TimeSpan timeTaken = timer.Elapsed;
            //string foo = "Time taken: " + timeTaken.ToString(@"m\:ss\.fff");
            //Console.WriteLine(foo);

            //double[] array = new double[] {  };
            //var r = FindAverage(array);
            // Console.WriteLine(r);
        }
        public static double FindAverage(double[] array)
        {
            double sum = 0;
            foreach (var item in array)
            { 
                sum+=item;
                
            }
            return sum/array.Length;
        }





    }
}