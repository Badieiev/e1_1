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
    class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Student(string _name, int _age)
        {
            this.Name = _name;
            this.Age = _age;
        }
    }

    class Rating
    {
        private Student[] students;

        public Rating()
        {
            students = new Student[0];
        }

        public void Add(Student student)
        {
            Student[] tmp = new Student[students.Length + 1];
            int i;
            for (int i = 0; i < students.Length; i++)
            {
                tmp[i] = students[i];
            }
            tmp[i] = student;
            students = tmp;
        }

        public Student[] Print()
        {
            return students;
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
