using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    class Boss:Employee
    {
        protected string CompanyCar { get; set; }
        public void Lead()
        {
            Console.WriteLine("Who run the World? Me! Let's Rule!!!");
        }
        public Boss() { }
        public Boss(string name, string firstname, double salary, string companyCar)
        {
            this.Name = name;
            this.FirstName = firstname;
            this.Salary = salary;
            this.CompanyCar = companyCar;
        }
    }
}
