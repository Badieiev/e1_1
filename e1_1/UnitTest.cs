using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e1_1
{
    class UnitTest
    {
        public static void RatingTest_AddOneStudent()
        {
            Rating rating = new Rating();
            rating.Add(new Student("Яковлев", 80));
            var students = rating.GetStudents();
            if (students[0].Name == "Яковлев")
            {
                Console.WriteLine("Test passed");
            }
            else
            {
                Console.WriteLine("Test failed");
            }
        }

    }
}
