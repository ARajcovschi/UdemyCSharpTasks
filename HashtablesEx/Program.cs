using System;
using System.Collections;

namespace HashtablesEx
{
    class Program
    {
        static void Main(string[] args)
        {
            Student[] students = new Student[5];
            students[0] = new Student(1, "Denis", 88);
            students[1] = new Student(2, "Olaf", 97);
            students[2] = new Student(6, "Ragner", 65);
            students[3] = new Student(1, "Luise", 73);
            students[4] = new Student(4, "Levi", 58);

            Hashtable myHash = new Hashtable();

            foreach (Student s in students)
            {
                if (!myHash.ContainsKey(s.Id))
                {
                    myHash.Add(s.Id, s);
                    Console.WriteLine("Strudent with ID: {0} was added!", s.Id);
                }
                else
                    Console.WriteLine("Sorry this ID: {0} already exists!", s.Id);
            }
        }
    }

    class Student
    {
        // property called Id
        public int Id { get; set; }
        // property called Name
        public string Name { get; set; }
        // property called GPA
        public float GPA { get; set; }
        // simple constructor
        public Student(int id, string name, float GPA)
        {
            this.Id = id;
            this.Name = name;
            this.GPA = GPA;
        }
    }
}
