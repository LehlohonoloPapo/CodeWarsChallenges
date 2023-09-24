using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CodeWarsSol
{
    public static class StripComments
    {
        public static string StripComment(string text, string[] commentSymbols)
        {
            var pattern = string.Join("|", commentSymbols.Select(Regex.Escape));
            var regex = new Regex($"({pattern}).*");

            return string.Join("\n", text.Split('\n')
                .Select(line =>
                {
                    var strippedLine = regex.Replace(line, "");
                    return strippedLine.TrimEnd();
                })
            );
        }
    }
}
