using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e1_1
{
    /*Разработать класс Student со свойствами Name (фамилия студента) и Mark (оценка студента)
      Разработать класс Rating (рейтинг студентов) с методом Add(Student student) (добавить студента в рейтинг) и Print()(вывести студента на экран)
      В рейтинге студенты располагаются в порядке убывания значений оценки. Студенты с одинаковыми оценками хранятся в рейтинге в алфавитном порядке.
      Двух студентов с одинаковыми фамилиями и оценками в рейтинге не должно быть.     
    */
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

    class Program
    { 
        static void Main(string[] args)
        {
            Rating rating = new Rating();
            rating.Add(new Student("Яковлев", 80));
            rating.Add(new Student("Петров", 85));
            rating.Add(new Student("Андреев", 85));
            rating.Add(new Student("Федоров", 75));
            rating.Add(new Student("Богданов", 94));
            rating.Add(new Student("Петров", 85));
            rating.Print();
            Console.ReadKey();
        }
    }
}
