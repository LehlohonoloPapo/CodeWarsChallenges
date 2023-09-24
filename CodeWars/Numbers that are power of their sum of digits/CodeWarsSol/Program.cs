namespace CodeWarsSol
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var r = new IPValidation();




            Console.WriteLine(r.IsValidIP("12.34.56 .1"));
            Console.WriteLine(r.IsValidIP("12.255.56.1"));
            Console.WriteLine(r.IsValidIP("137.255.156.100"));
    
        }


        public static Dictionary<string, List<int>> GetPeaks(int[] arr)
        {
            // Your code here!
            return null;
        }
    }
}