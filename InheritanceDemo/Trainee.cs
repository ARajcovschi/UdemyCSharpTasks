using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    //trainees with the properties WorkingHours and SchoolHours and a method Learn().
    class Trainee:Employee
    {
        protected int WorkingHours { get; set; }
        protected int SchoolHours { get; set; }

        public void Learn()
        {
            Console.WriteLine("Learning is Light!");
        }
        //Override the methods Work() of the trainee class so that it indicates the working hours of the trainee.
        override public void Work()
        {
            Console.WriteLine("Trainee {0} {1} are working for {2} hours", this.Name, this.FirstName, this.WorkingHours );
        }
        public Trainee() { }
        public Trainee(string name, string firstname, double salary, int workingHours, int schoolHours)
        {
            this.Name = name;
            this.FirstName = firstname;
            this.Salary = salary;
            this.WorkingHours = workingHours;
            this.SchoolHours = schoolHours;

        }

    }
}
