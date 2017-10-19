using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    static void Main(String[] args)
    {
        int q = Convert.ToInt32(Console.ReadLine());
        for (int a0 = 0; a0 < q; a0++)
        {
            string s = Console.ReadLine();
            char[] ss = s.ToCharArray();
            string hackerRank = "hackerrank";
            string x = IsItThere(s, hackerRank);
            Console.WriteLine(x);
        }
    }
    public static string IsItThere(string ss, string thisstring)
    {
        if (ss.Length < thisstring.Length)
            return "NO";

        string usable = thisstring;
        for (int ccc = 0; ccc < ss.Length; ccc++)
        {
            if (ss[ccc] == usable[0])
            {
                usable = usable.Remove(0, 1);
                if (string.IsNullOrEmpty(usable))
                    return "YES";
            }
        }
        return "NO";
    }
}