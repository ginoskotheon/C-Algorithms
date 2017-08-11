using System;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ReverseString("Sam"));
        }

        static string ReverseString(string str)
        {
            string rvstr = "";

            for(var i = str.Length - 1; i >= 0 ; i--){
                rvstr += str[i];
            }
            
            return rvstr;
        }
    }
}
