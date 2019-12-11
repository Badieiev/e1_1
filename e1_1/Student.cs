using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e1_1
{
    class Student : IComparable<Student>
    {
        public string Name { get; set; }
        public int Mark { get; set; }
        public Student(string _name, int _mark)
        {
            this.Name = _name;
            this.Mark = _mark;
        }

        public int CompareTo(Student o)
        {
            int markComparison = o.Mark.CompareTo(this.Mark);
            if (markComparison == 0)
            {
                return this.Name.CompareTo(o.Name);
            }
            return o.Mark.CompareTo(this.Mark);
        }

        public override bool Equals(object obj)
        {
            Student student = obj as Student;
            if (student == null)
            {
                throw new Exception("Object is not student");
            }
            return this.Name == student.Name && this.Mark == student.Mark;
        }

        public override int GetHashCode()
        {
            int hash = 13;
            hash = (hash * 7) + Name.GetHashCode();
            hash = (hash * 7) + Mark.GetHashCode();
            return hash;
        }

        public override string ToString()
        {
            return this.Name + " " + this.Mark;
        }
    }
}
