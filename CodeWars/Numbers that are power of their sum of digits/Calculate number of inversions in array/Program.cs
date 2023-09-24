using NUnit.Framework.Internal;
using System.Security.Authentication;

namespace Calculate_number_of_inversions_in_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var test = new KataTests();
            test.BasicTests();
            Console.WriteLine(test);

        }
    }
}