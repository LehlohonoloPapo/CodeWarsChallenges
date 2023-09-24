using System;
using System.Linq;
using System.Text.RegularExpressions;
using NUnit.Framework;

namespace Simple_Pig_Latin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var d = Kata.PigIt("Pig latin is cool !");
            //Console.WriteLine(d);
        }
    }

    public class Kata
    {
        public static string PigIt(string str)
        {

            return string.Join(" ", str.Split(' ').Select(i => IsLetter(i) ? i.Remove(0, 1) + i[0] + "ay" : i)); ;
        }
        public static bool IsLetter(string value) {
            return Regex.IsMatch(value, @"^[a-zA-Z]+$");
        }
    }

    [TestFixture]
    public class KataTest
    {

        [Test]
        public void KataTests()
        {
            Console.WriteLine("sdsad");
            Assert.AreEqual("igPay atinlay siay oolcay", Kata.PigIt("Pig latin is cool"));
            Assert.AreEqual("hisTay siay ymay tringsay", Kata.PigIt("This is my string"));
        }
        private static void testing(bool actual, bool expected)
        {
            Assert.AreEqual(expected, actual);
        }

    }
}