using Giraffe_test.dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe_test.PracticeScenarios
{
    public class WorkingWithDtos
    {
        public static void DtoPractice()
        {
            //Ok let's do something different now
            var dto = new DataTypeObject
            {
                Name = "Travis",
                Value = 1
            };


            Console.WriteLine(dto.Name);
            Console.WriteLine(dto.Value.ToString());

        }

    }
}
