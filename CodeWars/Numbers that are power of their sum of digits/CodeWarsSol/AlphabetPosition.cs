using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsSol
{
    public class AlphabetPosition
    {

        public string AlphabetPositionRun(string text)
        {
            char[] alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            string buildString="";

            text.ToList().ForEach(i => buildString += Char.IsLetter(i)? (new String(alpha).IndexOf(i.ToString().ToUpper()) + 1) + " ":"");
            Console.WriteLine(buildString);
            
            return text;
        }
    }
}
