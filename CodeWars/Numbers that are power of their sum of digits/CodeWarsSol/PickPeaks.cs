using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsSol
{
    public class PickPeaks
    {
        public static Dictionary<string, List<int>> GetPeaks(int[] arr)
        {
           var max = arr.Where(x=>x==arr.Max()).ToList();
            var pos = max.Where(x => x==Array.IndexOf(arr, x)).ToList();

            var dict = new Dictionary<string, List<int>>() { 

                { "pos",  pos},
                {"peaks", max }
            };
            return dict;
        }
    }
}
