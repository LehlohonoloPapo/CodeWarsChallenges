using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsSol
{
    internal class MexicanWave
    {

        public List<string> Wave(string str)
        {
            var list = new List<string> { };
            int i = 0;
            foreach (var item in str)
            {
                if(char.IsLetter(item)) list.Add(str.Remove(i,1).Insert(i, item.ToString().ToUpper()));
                i++;
            }
            return list;
        }
    }
}
