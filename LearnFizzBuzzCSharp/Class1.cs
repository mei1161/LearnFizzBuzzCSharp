using System;
using System.Collections.Generic;

namespace LearnFizzBuzzCSharp
{
    public class FizzBuzz
    {
        public static IEnumerable<string> GetNum()
        {
            for(var i=1; i<=100;i++)
            {
                if(i%15==0)
                {
                    yield return "FizzBuzz";
                }
                else if(i%3==0)
                {
                    yield return "Fizz";
                }
                else if(i%5==0)
                {
                    yield return "Buzz";
                }
                else
                {
                    yield return i.ToString();
                }

            }
        }
    }
}
