using System;
using System.Collections.Generic;
using System.Linq;

namespace SubstringFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            //FindSub("I love chicken", "chicken");
            string str = "I love chicken";
            string strung = "chicken";
            // var matches = str.Split("\r\n".ToCharArray()).Where(s => s.StartsWith(strung));
            // foreach(string i in matches)
            // Console.WriteLine(i);
            string[] lines = str.Split("\r\n".ToCharArray());
            //Console.WriteLine(lines[0]);
            List<string> matches = new List<string>();
            foreach(string s in lines)
            if(s.StartsWith(strung))
                matches.Add(s);
          
            matches.ForEach(Console.WriteLine);
        }

        // public static List<string> FindSub(string str, string strung)
        // {
        //     List<string> matches = str.Split("\r\n".ToCharArray()).Where(s => s.StartsWith(strung));
        //     Console.Write(matches);
          
        //     // Regex r = new Regex("(?"+strung+"(inc\d+)?)");
        //     // foreach(Match m in r.Matches(str))
        //     // Console.WriteLine(m.Groups["f"].Value);

        //     // string[] lines = str.Split("\r\n".ToCharArray());
        //     // List<string> matches = new List<string>();
        //     // foreach(string s in lines)
        //     // if(s.StartsWith(strung))
        //     //     matches.Add(s);
            
        //     // return matches;
        // }
    }
}
