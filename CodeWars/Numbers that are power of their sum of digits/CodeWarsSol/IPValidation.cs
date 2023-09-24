using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsSol
{
    public class IPValidation
    {
        public bool IsValidIP(string ipAdress)
        {
            if(String.IsNullOrEmpty(ipAdress)) return false;

            var ipList= ipAdress.Split('.').ToList();
            Console.WriteLine(ipList.Count);
            if(ipList.Count != 4) return false;

            ipList.ForEach(x => Console.Write("nn:"+x));

            //write a for loop  

            var a= ipList.FindAll(x=>int.TryParse(x, out int n) == true);
            Console.WriteLine("a: "+a.Count);

            if (a.Count != 4) return false;

            var b = ipList.FindAll(x => (int.Parse(x) > 0 & int.Parse(x) <= 255));
            Console.WriteLine("b: "+b.Count);
            if(b.Count != 4) return false;
            return true;

        }
    }
}
