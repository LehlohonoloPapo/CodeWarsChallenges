namespace Scramblies
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var res = Scramble("rkqodlw", "world");
            Console.WriteLine(res);

            var res2 = Scramble("javscripts", "javascript");
            Console.WriteLine(res2);
        }
        public static bool Scramble(string str1, string str2)
        {
            
            //str2.Select(x=> !str1.Contains(x)?false: str1 = str1.Remove(str1.IndexOf(x), 1));


            foreach (char item in str2)
            {
                //Console.WriteLine(item);
                if (!str1.Contains(item)){
                    //Console.WriteLine(str1.Contains(item));
                    return false;
                }
                //var strArray = str2.Split('');


                str1 = str1.Remove(str1.IndexOf(item), 1 );

                //Console.WriteLine("str: "+str2+" array: "+str1);



            }
            return true;
        }
    }
}