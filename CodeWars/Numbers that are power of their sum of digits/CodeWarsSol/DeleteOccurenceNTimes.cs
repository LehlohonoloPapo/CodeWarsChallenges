using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsSol
{
    internal class DeleteOccurenceNTimes
    {
        public int[] DeleteNth(int[] arr, int x)
        {
            int count = 0;
            //var l=arr.Select(value=>;
            //Console.WriteLine(l);


            //for (int i = 0; i<l.Count; i++)
            //{
            //    Console.WriteLine(l[i]);
            //}


            var list = new List<int> { };
            foreach (int i in arr)
            {
                foreach (int j in arr)
                {
                    

                    count++;

                }
            }
                return list.ToArray();

            }
        }
}
