using System;

namespace C_Algorithms
{
    class FizzBuzz
    {
        static void Main(string[] args)
        {
            Fizzbuzz(15);   
        }

    

        static void Fizzbuzz(int num)
        {
            // string ans = "";
            for (int i = 0; i < num; i++)
            {
                if(i % 5 == 0 && i % 3 == 0){
                    Console.WriteLine("Fizzbuzz");
                }
                else if (i % 5 == 0)
                {
                     Console.WriteLine("Fizz");
                }
                else if (i % 3 == 0)
                {
                     Console.WriteLine("Buzz");
                }
                else
                {
                     Console.WriteLine(i.ToString());
                }
            }    
        }  
    }
}
