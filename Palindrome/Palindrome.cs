using System;
using System.Text.RegularExpressions;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose a word or phrase to see if it is a palindrome");
            string pali = Console.ReadLine();
            Console.WriteLine(IsPalindrome(pali));
        }
        static string ReverseString(string str)
        {
            string rvstr = "";

            for(var i = str.Length - 1; i >= 0 ; i--){
                rvstr += str[i];
            }
            
            return rvstr;
        }

        static bool IsPalindrome(string str)
        {
            var result = true;
            string replace =  @"[^\w]";
            string mini = Regex.Replace(str, replace, "").ToLower();
            string revd = ReverseString(mini);

            if(revd == mini)
            {
                result = true;
            }
            else
            {
                result = false;
            }
            // Console.WriteLine(str); 
            // Console.WriteLine(mini);
            // Console.WriteLine(revd);
            return result;
        }
    }
}
