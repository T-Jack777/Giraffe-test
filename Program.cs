using Giraffe_test.dtos;
using System;
using System.Collections.Generic;

namespace Giraffe_test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ok let's do something different now

            //var dto = new DataTypeObject
            //{ 
            //    Name = "Travis",
            //    Value = 1

            //};
            //Console.WriteLine(dto.Name);
            //Console.WriteLine(dto.Value.ToString());

            var period = ".";
            int incrementalNumber;

            for (int i = 0; i < 10; i++)
            {
                incrementalNumber = i + 1;

                Console.WriteLine(incrementalNumber + period);
            }
        }
    }
}
