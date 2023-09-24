using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsSol
{
    public class PersistentBugger
    {
         int count = 0;
        public  int Persistence(long n)
        {
            long m = 1;
            if (n <= 9)
            {
                var holder = count;
                count = 0;
                return holder;
            }
            else
            {
                count += 1;
                string value = n.ToString();
                //foreach (char s in value)
                //{
                //    //Console.WriteLine("s " + s);
                //    m *= int.Parse(s.ToString());
                //    //Console.WriteLine("mul " + m);

                //}
                value.ToList().ForEach(i => m *= int.Parse(i.ToString()));
            }
            return Persistence(m);
        }
    }
}
