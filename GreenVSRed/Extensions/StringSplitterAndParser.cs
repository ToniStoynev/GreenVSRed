namespace GreenVSRed.Extensions
{
    using System;
    using System.Linq;
    public static class StringSplitterAndParser
    {
        public static int[] SplitAndParse(this string str)
        {
           return  str.Split(new char[] { ',', ' ' } 
                            ,StringSplitOptions.RemoveEmptyEntries)
                               .Select(int.Parse)
                               .ToArray();
        }
    }
}
