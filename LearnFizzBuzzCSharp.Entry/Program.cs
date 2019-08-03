using System;

namespace LearnFizzBuzzCSharp.Entry
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach(var i in FizzBuzz.GetNum())
            {
                Console.WriteLine(i);
            }
        }
    }
}
