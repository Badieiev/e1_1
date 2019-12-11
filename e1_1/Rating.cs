using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e1_1
{
    class Rating
    {
        SortedSet<Student> students = new SortedSet<Student>();

        public void Add(Student student)
        {
            students.Add(student);
        }

        public void Print()
        {
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
        }
    }
}
