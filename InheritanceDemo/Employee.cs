using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    class Employee
    {
        //properties
        protected string Name { get; set; }
        protected string FirstName { get; set; }
        protected double Salary { get; set; }

        //methods
        public virtual void Work()
        {
            Console.WriteLine("Ready to work! Work! Work!");
        }
        public void Pause()
        {
            Console.WriteLine("I need a breake, kit-kat pause =)");
        }

        public Employee() { }
        public Employee(string name, string firstname, double salary)
        {
            this.Name = name;
            this.FirstName = firstname;
            this.Salary = salary;

        }

    }
}
