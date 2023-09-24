using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using System;

namespace Calculate_number_of_inversions_in_array
{
   

    [TestFixture]
    public class KataTests
    {
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual(0, Kata.CountInversions(new int[] { 1, 2, 3 }), "Sorted array has 0 inversions");
            Assert.AreEqual(1, Kata.CountInversions(new int[] { 2, 1, 3 }), "Array [2,1,3] only has one inversion");
        }
    }
}
