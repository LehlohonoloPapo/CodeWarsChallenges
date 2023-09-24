

namespace CodeWarsSol
{
    internal static class CamelCase
    {
        public static string CamelCaseRun(this string str)
        {
            string word = "";

            str.Split().ToList()
                .ForEach(item =>  word += item.Length != 0 ? item.Remove(0, 1).Insert(0, item[0].ToString().ToUpper()):""
                .ToString());
            return word;
        }
    }
}
