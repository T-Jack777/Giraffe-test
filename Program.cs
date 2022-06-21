using System;

namespace Giraffe_test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ok let's do something different now

            var period = ".";
            int incrementalNumber;

            for(int i = 0; i < 10; i++)
            {
                incrementalNumber = i + 1;
                Console.WriteLine(incrementalNumber + period);
            }
        }
    }
}
